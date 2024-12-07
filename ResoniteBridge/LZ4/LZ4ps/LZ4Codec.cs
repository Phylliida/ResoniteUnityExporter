#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LZ4ps
{

	public static class IntOperators
	{
        public static int UnsignedRightShift(this int signed, int places)
        {
            unchecked // just in case of unusual compiler switches; this is the default
            {
                var unsigned = (uint)signed;
                unsigned >>= places;
                return (int)unsigned;
            }
        }
        public static long UnsignedRightShift(this long signed, int places)
        {
            unchecked // just in case of unusual compiler switches; this is the default
            {
                var unsigned = (ulong)signed;
                unsigned >>= places;
                return (long)unsigned;
            }
        }
    }
	public static class LZ4Codec
	{
		private class LZ4HC_Data_Structure
		{
			public byte[] src;

			public int src_base;

			public int src_end;

			public int src_LASTLITERALS;

			public byte[] dst;

			public int dst_base;

			public int dst_len;

			public int dst_end;

			public int[] hashTable;

			public ushort[] chainTable;

			public int nextToUpdate;
		}

		private const int MEMORY_USAGE = 14;

		private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;

		private const int BLOCK_COPY_LIMIT = 16;

		private const int MINMATCH = 4;

		private const int SKIPSTRENGTH = 6;

		private const int COPYLENGTH = 8;

		private const int LASTLITERALS = 5;

		private const int MFLIMIT = 12;

		private const int MINLENGTH = 13;

		private const int MAXD_LOG = 16;

		private const int MAXD = 65536;

		private const int MAXD_MASK = 65535;

		private const int MAX_DISTANCE = 65535;

		private const int ML_BITS = 4;

		private const int ML_MASK = 15;

		private const int RUN_BITS = 4;

		private const int RUN_MASK = 15;

		private const int STEPSIZE_64 = 8;

		private const int STEPSIZE_32 = 4;

		private const int LZ4_64KLIMIT = 65547;

		private const int HASH_LOG = 12;

		private const int HASH_TABLESIZE = 4096;

		private const int HASH_ADJUST = 20;

		private const int HASH64K_LOG = 13;

		private const int HASH64K_TABLESIZE = 8192;

		private const int HASH64K_ADJUST = 19;

		private const int HASHHC_LOG = 15;

		private const int HASHHC_TABLESIZE = 32768;

		private const int HASHHC_ADJUST = 17;

		private static readonly int[] DECODER_TABLE_32 = new int[8] { 0, 3, 2, 3, 0, 0, 0, 0 };

		private static readonly int[] DECODER_TABLE_64 = new int[8] { 0, 0, 0, -1, 0, 1, 2, 3 };

		private static readonly int[] DEBRUIJN_TABLE_32 = new int[32]
		{
		0, 0, 3, 0, 3, 1, 3, 0, 3, 2,
		2, 1, 3, 2, 0, 1, 3, 3, 1, 2,
		2, 2, 2, 0, 3, 1, 2, 0, 1, 0,
		1, 1
		};

		private static readonly int[] DEBRUIJN_TABLE_64 = new int[64]
		{
		0, 0, 0, 0, 0, 1, 1, 2, 0, 3,
		1, 3, 1, 4, 2, 7, 0, 2, 3, 6,
		1, 5, 3, 5, 1, 3, 4, 4, 2, 5,
		6, 7, 7, 0, 1, 2, 3, 3, 4, 6,
		2, 6, 5, 5, 3, 4, 5, 6, 7, 1,
		2, 4, 6, 4, 4, 5, 7, 2, 6, 5,
		7, 6, 7, 7
		};

		private const int MAX_NB_ATTEMPTS = 256;

		private const int OPTIMAL_ML = 18;

		private static Stack<ushort[]> _ushortHashtables = new Stack<ushort[]>();

		private static Stack<int[]> _intHashtables = new Stack<int[]>();

		private static Stack<ushort[]> _HCushortHashtables = new Stack<ushort[]>();

		private static Stack<int[]> _HCintHashtables = new Stack<int[]>();

		public static int MaximumOutputLength(int inputLength)
		{
			return inputLength + inputLength / 255 + 16;
		}

		internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength)
		{
			if (inputLength < 0)
			{
				inputLength = input.Length - inputOffset;
			}
			if (inputLength == 0)
			{
				outputLength = 0;
				return;
			}
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (inputOffset < 0 || inputOffset + inputLength > input.Length)
			{
				throw new ArgumentException("inputOffset and inputLength are invalid for given input");
			}
			if (outputLength < 0)
			{
				outputLength = output.Length - outputOffset;
			}
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			if (outputOffset >= 0 && outputOffset + outputLength <= output.Length)
			{
				return;
			}
			throw new ArgumentException("outputOffset and outputLength are invalid for given output");
		}

		[Conditional("DEBUG")]
		private static void Assert(bool condition, string errorMessage)
		{
			if (!condition)
			{
				throw new ArgumentException(errorMessage);
			}
			Debug.Assert(condition, errorMessage);
		}

		internal static void Poke2(byte[] buffer, int offset, ushort value)
		{
			buffer[offset] = (byte)value;
			buffer[offset + 1] = (byte)(value >> 8);
		}

		internal static ushort Peek2(byte[] buffer, int offset)
		{
			return (ushort)(buffer[offset] | (buffer[offset + 1] << 8));
		}

		internal static uint Peek4(byte[] buffer, int offset)
		{
			return (uint)(buffer[offset] | (buffer[offset + 1] << 8) | (buffer[offset + 2] << 16) | (buffer[offset + 3] << 24));
		}

		private static uint Xor4(byte[] buffer, int offset1, int offset2)
		{
			uint num = (uint)(buffer[offset1] | (buffer[offset1 + 1] << 8) | (buffer[offset1 + 2] << 16) | (buffer[offset1 + 3] << 24));
			uint num2 = (uint)(buffer[offset2] | (buffer[offset2 + 1] << 8) | (buffer[offset2 + 2] << 16) | (buffer[offset2 + 3] << 24));
			return num ^ num2;
		}

		private static ulong Xor8(byte[] buffer, int offset1, int offset2)
		{
			ulong num = buffer[offset1] | ((ulong)buffer[offset1 + 1] << 8) | ((ulong)buffer[offset1 + 2] << 16) | ((ulong)buffer[offset1 + 3] << 24) | ((ulong)buffer[offset1 + 4] << 32) | ((ulong)buffer[offset1 + 5] << 40) | ((ulong)buffer[offset1 + 6] << 48) | ((ulong)buffer[offset1 + 7] << 56);
			ulong num2 = buffer[offset2] | ((ulong)buffer[offset2 + 1] << 8) | ((ulong)buffer[offset2 + 2] << 16) | ((ulong)buffer[offset2 + 3] << 24) | ((ulong)buffer[offset2 + 4] << 32) | ((ulong)buffer[offset2 + 5] << 40) | ((ulong)buffer[offset2 + 6] << 48) | ((ulong)buffer[offset2 + 7] << 56);
			return num ^ num2;
		}

		private static bool Equal2(byte[] buffer, int offset1, int offset2)
		{
			if (buffer[offset1] != buffer[offset2])
			{
				return false;
			}
			return buffer[offset1 + 1] == buffer[offset2 + 1];
		}

		private static bool Equal4(byte[] buffer, int offset1, int offset2)
		{
			if (buffer[offset1] != buffer[offset2])
			{
				return false;
			}
			if (buffer[offset1 + 1] != buffer[offset2 + 1])
			{
				return false;
			}
			if (buffer[offset1 + 2] != buffer[offset2 + 2])
			{
				return false;
			}
			return buffer[offset1 + 3] == buffer[offset2 + 3];
		}

		private static void Copy4(byte[] buf, int src, int dst)
		{
			if (dst > src)
			{
				buf[dst + 3] = buf[src + 3];
				buf[dst + 2] = buf[src + 2];
				buf[dst + 1] = buf[src + 1];
				buf[dst] = buf[src];
			}
			else
			{
				buf[dst] = buf[src];
				buf[dst + 1] = buf[src + 1];
				buf[dst + 2] = buf[src + 2];
				buf[dst + 3] = buf[src + 3];
			}
		}

		private static void Copy8(byte[] buf, int src, int dst)
		{
			if (dst > src)
			{
				buf[dst + 7] = buf[src + 7];
				buf[dst + 6] = buf[src + 6];
				buf[dst + 5] = buf[src + 5];
				buf[dst + 4] = buf[src + 4];
				buf[dst + 3] = buf[src + 3];
				buf[dst + 2] = buf[src + 2];
				buf[dst + 1] = buf[src + 1];
				buf[dst] = buf[src];
			}
			else
			{
				buf[dst] = buf[src];
				buf[dst + 1] = buf[src + 1];
				buf[dst + 2] = buf[src + 2];
				buf[dst + 3] = buf[src + 3];
				buf[dst + 4] = buf[src + 4];
				buf[dst + 5] = buf[src + 5];
				buf[dst + 6] = buf[src + 6];
				buf[dst + 7] = buf[src + 7];
			}
		}

		private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len)
		{
			Assert(src != dst, "BlockCopy does not handle copying to the same buffer");
			if (len >= 16)
			{
				Buffer.BlockCopy(src, src_0, dst, dst_0, len);
				return;
			}
			while (len >= 8)
			{
				dst[dst_0] = src[src_0];
				dst[dst_0 + 1] = src[src_0 + 1];
				dst[dst_0 + 2] = src[src_0 + 2];
				dst[dst_0 + 3] = src[src_0 + 3];
				dst[dst_0 + 4] = src[src_0 + 4];
				dst[dst_0 + 5] = src[src_0 + 5];
				dst[dst_0 + 6] = src[src_0 + 6];
				dst[dst_0 + 7] = src[src_0 + 7];
				len -= 8;
				src_0 += 8;
				dst_0 += 8;
			}
			while (len >= 4)
			{
				dst[dst_0] = src[src_0];
				dst[dst_0 + 1] = src[src_0 + 1];
				dst[dst_0 + 2] = src[src_0 + 2];
				dst[dst_0 + 3] = src[src_0 + 3];
				len -= 4;
				src_0 += 4;
				dst_0 += 4;
			}
			while (len-- > 0)
			{
				dst[dst_0++] = src[src_0++];
			}
		}

		private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end)
		{
			int num = dst_end - dst_0;
			Assert(src != dst, "BlockCopy does not handle copying to the same buffer");
			Assert(num > 0, "Length have to be greater than 0");
			if (num >= 16)
			{
				Buffer.BlockCopy(src, src_0, dst, dst_0, num);
			}
			else
			{
				while (num >= 4)
				{
					dst[dst_0] = src[src_0];
					dst[dst_0 + 1] = src[src_0 + 1];
					dst[dst_0 + 2] = src[src_0 + 2];
					dst[dst_0 + 3] = src[src_0 + 3];
					num -= 4;
					src_0 += 4;
					dst_0 += 4;
				}
				while (num-- > 0)
				{
					dst[dst_0++] = src[src_0++];
				}
			}
			return num;
		}

		private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end)
		{
			int num = dst - src;
			int num2 = dst_end - dst;
			int num3 = num2;
			Assert(num >= 4, "Target must be at least 4 bytes further than source");
			Assert(condition: true, "This method requires BLOCK_COPY_LIMIT > 4");
			Assert(num3 > 0, "Length have to be greater than 0");
			if (num >= 16)
			{
				if (num >= num2)
				{
					Buffer.BlockCopy(buffer, src, buffer, dst, num2);
					return num2;
				}
				do
				{
					Buffer.BlockCopy(buffer, src, buffer, dst, num);
					src += num;
					dst += num;
					num3 -= num;
				}
				while (num3 >= num);
			}
			while (num3 >= 4)
			{
				buffer[dst] = buffer[src];
				buffer[dst + 1] = buffer[src + 1];
				buffer[dst + 2] = buffer[src + 2];
				buffer[dst + 3] = buffer[src + 3];
				dst += 4;
				src += 4;
				num3 -= 4;
			}
			while (num3-- > 0)
			{
				buffer[dst++] = buffer[src++];
			}
			return num2;
		}

		private static ushort[] GetUshortHashtable()
		{
			lock (_ushortHashtables)
			{
				if (_ushortHashtables.Count > 0)
				{
					return _ushortHashtables.Pop();
				}
				return new ushort[8192];
			}
		}

		private static int[] GetIntHashtable()
		{
			lock (_intHashtables)
			{
				if (_intHashtables.Count > 0)
				{
					return _intHashtables.Pop();
				}
				return new int[4096];
			}
		}

		private static void ReturnHashtable(ushort[] hashtable)
		{
			for (int i = 0; i < hashtable.Length; i++)
			{
				hashtable[i] = 0;
			}
			lock (_ushortHashtables)
			{
				_ushortHashtables.Push(hashtable);
			}
		}

		private static void ReturnHashtable(int[] hashtable)
		{
			for (int i = 0; i < hashtable.Length; i++)
			{
				hashtable[i] = 0;
			}
			lock (_intHashtables)
			{
				_intHashtables.Push(hashtable);
			}
		}

		public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			if (outputLength == 0)
			{
				return 0;
			}
			if (inputLength < 65547)
			{
				ushort[] ushortHashtable = GetUshortHashtable();
				int result = LZ4_compress64kCtx_safe32(ushortHashtable, input, output, inputOffset, outputOffset, inputLength, outputLength);
				ReturnHashtable(ushortHashtable);
				return result;
			}
			int[] intHashtable = GetIntHashtable();
			int result2 = LZ4_compressCtx_safe32(intHashtable, input, output, inputOffset, outputOffset, inputLength, outputLength);
			ReturnHashtable(intHashtable);
			return result2;
		}

		public static byte[] Encode32(byte[] input, int inputOffset, int inputLength)
		{
			if (inputLength < 0)
			{
				inputLength = input.Length - inputOffset;
			}
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (inputOffset < 0 || inputOffset + inputLength > input.Length)
			{
				throw new ArgumentException("inputOffset and inputLength are invalid for given input");
			}
			byte[] array = new byte[MaximumOutputLength(inputLength)];
			int num = Encode32(input, inputOffset, inputLength, array, 0, array.Length);
			if (num != array.Length)
			{
				if (num < 0)
				{
					throw new InvalidOperationException("Compression has been corrupted");
				}
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			if (outputLength == 0)
			{
				return 0;
			}
			if (inputLength < 65547)
			{
				ushort[] hash_table = new ushort[8192];
				return LZ4_compress64kCtx_safe64(hash_table, input, output, inputOffset, outputOffset, inputLength, outputLength);
			}
			int[] hash_table2 = new int[4096];
			return LZ4_compressCtx_safe64(hash_table2, input, output, inputOffset, outputOffset, inputLength, outputLength);
		}

		public static byte[] Encode64(byte[] input, int inputOffset, int inputLength)
		{
			if (inputLength < 0)
			{
				inputLength = input.Length - inputOffset;
			}
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (inputOffset < 0 || inputOffset + inputLength > input.Length)
			{
				throw new ArgumentException("inputOffset and inputLength are invalid for given input");
			}
			byte[] array = new byte[MaximumOutputLength(inputLength)];
			int num = Encode64(input, inputOffset, inputLength, array, 0, array.Length);
			if (num != array.Length)
			{
				if (num < 0)
				{
					throw new InvalidOperationException("Compression has been corrupted");
				}
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
		{
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			if (outputLength == 0)
			{
				return 0;
			}
			if (knownOutputLength)
			{
				int num = LZ4_uncompress_safe32(input, output, inputOffset, outputOffset, outputLength);
				if (num != inputLength)
				{
					throw new ArgumentException("LZ4 block is corrupted, or invalid length has been given.");
				}
				return outputLength;
			}
			int num2 = LZ4_uncompress_unknownOutputSize_safe32(input, output, inputOffset, outputOffset, inputLength, outputLength);
			if (num2 < 0)
			{
				throw new ArgumentException("LZ4 block is corrupted, or invalid length has been given.");
			}
			return num2;
		}

		public static byte[] Decode32(byte[] input, int inputOffset, int inputLength, int outputLength)
		{
			if (inputLength < 0)
			{
				inputLength = input.Length - inputOffset;
			}
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (inputOffset < 0 || inputOffset + inputLength > input.Length)
			{
				throw new ArgumentException("inputOffset and inputLength are invalid for given input");
			}
			byte[] array = new byte[outputLength];
			int num = Decode32(input, inputOffset, inputLength, array, 0, outputLength, knownOutputLength: true);
			if (num != outputLength)
			{
				throw new ArgumentException("outputLength is not valid");
			}
			return array;
		}

		public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
		{
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			if (outputLength == 0)
			{
				return 0;
			}
			if (knownOutputLength)
			{
				int num = LZ4_uncompress_safe64(input, output, inputOffset, outputOffset, outputLength);
				if (num != inputLength)
				{
					throw new ArgumentException("LZ4 block is corrupted, or invalid length has been given.");
				}
				return outputLength;
			}
			int num2 = LZ4_uncompress_unknownOutputSize_safe64(input, output, inputOffset, outputOffset, inputLength, outputLength);
			if (num2 < 0)
			{
				throw new ArgumentException("LZ4 block is corrupted, or invalid length has been given.");
			}
			return num2;
		}

		public static byte[] Decode64(byte[] input, int inputOffset, int inputLength, int outputLength)
		{
			if (inputLength < 0)
			{
				inputLength = input.Length - inputOffset;
			}
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (inputOffset < 0 || inputOffset + inputLength > input.Length)
			{
				throw new ArgumentException("inputOffset and inputLength are invalid for given input");
			}
			byte[] array = new byte[outputLength];
			int num = Decode64(input, inputOffset, inputLength, array, 0, outputLength, knownOutputLength: true);
			if (num != outputLength)
			{
				throw new ArgumentException("outputLength is not valid");
			}
			return array;
		}

		private static ushort[] GetHCUshortHashtable()
		{
			lock (_HCushortHashtables)
			{
				if (_HCushortHashtables.Count > 0)
				{
					return _HCushortHashtables.Pop();
				}
				return new ushort[65536];
			}
		}

		private static int[] GetHCIntHashtable()
		{
			lock (_HCintHashtables)
			{
				if (_HCintHashtables.Count > 0)
				{
					return _HCintHashtables.Pop();
				}
				return new int[32768];
			}
		}

		private static void ReturnHCHashtable(ushort[] hashtable)
		{
			for (int i = 0; i < hashtable.Length; i++)
			{
				hashtable[i] = 0;
			}
			lock (_HCushortHashtables)
			{
				_HCushortHashtables.Push(hashtable);
			}
		}

		private static void ReturnHCHashtable(int[] hashtable)
		{
			for (int i = 0; i < hashtable.Length; i++)
			{
				hashtable[i] = 0;
			}
			lock (_HCintHashtables)
			{
				_HCintHashtables.Push(hashtable);
			}
		}

		private static LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len)
		{
			LZ4HC_Data_Structure lZ4HC_Data_Structure = new LZ4HC_Data_Structure
			{
				src = src,
				src_base = src_0,
				src_end = src_0 + src_len,
				src_LASTLITERALS = src_0 + src_len - 5,
				dst = dst,
				dst_base = dst_0,
				dst_len = dst_len,
				dst_end = dst_0 + dst_len,
				hashTable = GetHCIntHashtable(),
				chainTable = GetHCUshortHashtable(),
				nextToUpdate = src_0 + 1
			};
			ushort[] chainTable = lZ4HC_Data_Structure.chainTable;
			for (int num = chainTable.Length - 1; num >= 0; num--)
			{
				chainTable[num] = ushort.MaxValue;
			}
			return lZ4HC_Data_Structure;
		}

		private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			LZ4HC_Data_Structure lZ4HC_Data_Structure = LZ4HC_Create(input, inputOffset, inputLength, output, outputOffset, outputLength);
			int result = LZ4_compressHCCtx_32(lZ4HC_Data_Structure);
			ReturnHCHashtable(lZ4HC_Data_Structure.chainTable);
			ReturnHCHashtable(lZ4HC_Data_Structure.hashTable);
			return result;
		}

		public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			if (inputLength == 0)
			{
				return 0;
			}
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			int num = LZ4_compressHC_32(input, inputOffset, inputLength, output, outputOffset, outputLength);
			return (num <= 0) ? (-1) : num;
		}

		public static byte[] Encode32HC(byte[] input, int inputOffset, int inputLength)
		{
			if (inputLength == 0)
			{
				return new byte[0];
			}
			int num = MaximumOutputLength(inputLength);
			byte[] array = new byte[num];
			int num2 = Encode32HC(input, inputOffset, inputLength, array, 0, num);
			if (num2 < 0)
			{
				throw new ArgumentException("Provided data seems to be corrupted.");
			}
			if (num2 != num)
			{
				byte[] array2 = new byte[num2];
				Buffer.BlockCopy(array, 0, array2, 0, num2);
				array = array2;
			}
			return array;
		}

		private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return LZ4_compressHCCtx_64(LZ4HC_Create(input, inputOffset, inputLength, output, outputOffset, outputLength));
		}

		public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			if (inputLength == 0)
			{
				return 0;
			}
			CheckArguments(input, inputOffset, ref inputLength, output, outputOffset, ref outputLength);
			int num = LZ4_compressHC_64(input, inputOffset, inputLength, output, outputOffset, outputLength);
			return (num <= 0) ? (-1) : num;
		}

		public static byte[] Encode64HC(byte[] input, int inputOffset, int inputLength)
		{
			if (inputLength == 0)
			{
				return new byte[0];
			}
			int num = MaximumOutputLength(inputLength);
			byte[] array = new byte[num];
			int num2 = Encode64HC(input, inputOffset, inputLength, array, 0, num);
			if (num2 < 0)
			{
				throw new ArgumentException("Provided data seems to be corrupted.");
			}
			if (num2 != num)
			{
				byte[] array2 = new byte[num2];
				Buffer.BlockCopy(array, 0, array2, 0, num2);
				array = array2;
			}
			return array;
		}

		private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_32;
			int num = src_0;
			int num2 = num;
			int num3 = num + src_len;
			int num4 = num3 - 12;
			int num5 = dst_0;
			int num6 = num5 + dst_maxlen;
			int num7 = num3 - 5;
			int num8 = num7 - 1;
			int num9 = num7 - 3;
			int num10 = num6 - 6;
			int num11 = num6 - 8;
			if (src_len >= 13)
			{
				hash_table[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(20)] = num - src_0;
				num++;
				uint num12 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
				while (true)
				{
					int num13 = 67;
					int num14 = num;
					int num17;
					while (true)
					{
						uint num15 = num12;
						int num16 = num13++ >> 6;
						num = num14;
						num14 = num + num16;
						if (num14 > num4)
						{
							break;
						}
						num12 = (uint)((int)Peek4(src, num14) * -1640531535) >> 20;
						num17 = src_0 + hash_table[num15];
						hash_table[num15] = num - src_0;
						if (num17 < num - 65535 || !Equal4(src, num17, num))
						{
							continue;
						}
						goto IL_0108;
					}
					break;
				IL_03fe:
					num2 = num++;
					num12 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
					continue;
				IL_0108:
					while (num > num2 && num17 > src_0 && src[num - 1] == src[num17 - 1])
					{
						num--;
						num17--;
					}
					int num18 = num - num2;
					int num19 = num5++;
					if (num5 + num18 + (num18 >> 8) > num11)
					{
						return 0;
					}
					if (num18 >= 15)
					{
						int num20 = num18 - 15;
						dst[num19] = 240;
						if (num20 > 254)
						{
							do
							{
								dst[num5++] = byte.MaxValue;
								num20 -= 255;
							}
							while (num20 > 254);
							dst[num5++] = (byte)num20;
							BlockCopy(src, num2, dst, num5, num18);
							num5 += num18;
							goto IL_020c;
						}
						dst[num5++] = (byte)num20;
					}
					else
					{
						dst[num19] = (byte)(num18 << 4);
					}
					if (num18 > 0)
					{
						int num21 = num5 + num18;
						WildCopy(src, num2, dst, num5, num21);
						num5 = num21;
					}
					goto IL_020c;
				IL_020c:
					while (true)
					{
						Poke2(dst, num5, (ushort)(num - num17));
						num5 += 2;
						num += 4;
						num17 += 4;
						num2 = num;
						while (true)
						{
							if (num < num9)
							{
								int num22 = (int)Xor4(src, num17, num);
								if (num22 == 0)
								{
									num += 4;
									num17 += 4;
									continue;
								}
								num += dEBRUIJN_TABLE_[((num22 & -num22) * 125613361).UnsignedRightShift(27)];
								break;
							}
							if (num < num8 && Equal2(src, num17, num))
							{
								num += 2;
								num17 += 2;
							}
							if (num < num7 && src[num17] == src[num])
							{
								num++;
							}
							break;
						}
						num18 = num - num2;
						if (num5 + (num18 >> 8) > num10)
						{
							return 0;
						}
						if (num18 >= 15)
						{
							dst[num19] += 15;
							for (num18 -= 15; num18 > 509; num18 -= 510)
							{
								dst[num5++] = byte.MaxValue;
								dst[num5++] = byte.MaxValue;
							}
							if (num18 > 254)
							{
								num18 -= 255;
								dst[num5++] = byte.MaxValue;
							}
							dst[num5++] = (byte)num18;
						}
						else
						{
							dst[num19] += (byte)num18;
						}
						if (num > num4)
						{
							break;
						}
						hash_table[((int)Peek4(src, num - 2) * -1640531535).UnsignedRightShift(20)] = num - 2 - src_0;
						uint num15 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
						num17 = src_0 + hash_table[num15];
						hash_table[num15] = num - src_0;
						if (num17 > num - 65536 && Equal4(src, num17, num))
						{
							num19 = num5++;
							dst[num19] = 0;
							continue;
						}
						goto IL_03fe;
					}
					num2 = num;
					break;
				}
			}
			int num23 = num3 - num2;
			if (num5 + num23 + 1 + (num23 + 255 - 15) / 255 > num6)
			{
				return 0;
			}
			if (num23 >= 15)
			{
				dst[num5++] = 240;
				for (num23 -= 15; num23 > 254; num23 -= 255)
				{
					dst[num5++] = byte.MaxValue;
				}
				dst[num5++] = (byte)num23;
			}
			else
			{
				dst[num5++] = (byte)(num23 << 4);
			}
			BlockCopy(src, num2, dst, num5, num3 - num2);
			num5 += num3 - num2;
			return num5 - dst_0;
		}

		private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_32;
			int num = src_0;
			int num2 = num;
			int num3 = num;
			int num4 = num + src_len;
			int num5 = num4 - 12;
			int num6 = dst_0;
			int num7 = num6 + dst_maxlen;
			int num8 = num4 - 5;
			int num9 = num8 - 1;
			int num10 = num8 - 3;
			int num11 = num7 - 6;
			int num12 = num7 - 8;
			if (src_len >= 13)
			{
				num++;
				uint num13 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
				while (true)
				{
					int num14 = 67;
					int num15 = num;
					int num18;
					while (true)
					{
						uint num16 = num13;
						int num17 = num14++ >> 6;
						num = num15;
						num15 = num + num17;
						if (num15 > num5)
						{
							break;
						}
						num13 = (uint)((int)Peek4(src, num15) * -1640531535) >> 19;
						num18 = num3 + hash_table[num16];
						hash_table[num16] = (ushort)(num - num3);
						if (!Equal4(src, num18, num))
						{
							continue;
						}
						goto IL_00e8;
					}
					break;
				IL_03d0:
					num2 = num++;
					num13 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
					continue;
				IL_00e8:
					while (num > num2 && num18 > src_0 && src[num - 1] == src[num18 - 1])
					{
						num--;
						num18--;
					}
					int num19 = num - num2;
					int num20 = num6++;
					if (num6 + num19 + (num19 >> 8) > num12)
					{
						return 0;
					}
					if (num19 >= 15)
					{
						int num21 = num19 - 15;
						dst[num20] = 240;
						if (num21 > 254)
						{
							do
							{
								dst[num6++] = byte.MaxValue;
								num21 -= 255;
							}
							while (num21 > 254);
							dst[num6++] = (byte)num21;
							BlockCopy(src, num2, dst, num6, num19);
							num6 += num19;
							goto IL_01ea;
						}
						dst[num6++] = (byte)num21;
					}
					else
					{
						dst[num20] = (byte)(num19 << 4);
					}
					if (num19 > 0)
					{
						int num22 = num6 + num19;
						WildCopy(src, num2, dst, num6, num22);
						num6 = num22;
					}
					goto IL_01ea;
				IL_01ea:
					while (true)
					{
						Poke2(dst, num6, (ushort)(num - num18));
						num6 += 2;
						num += 4;
						num18 += 4;
						num2 = num;
						while (true)
						{
							if (num < num10)
							{
								int num23 = (int)Xor4(src, num18, num);
								if (num23 == 0)
								{
									num += 4;
									num18 += 4;
									continue;
								}
								num += dEBRUIJN_TABLE_[((num23 & -num23) * 125613361).UnsignedRightShift(27)];
								break;
							}
							if (num < num9 && Equal2(src, num18, num))
							{
								num += 2;
								num18 += 2;
							}
							if (num < num8 && src[num18] == src[num])
							{
								num++;
							}
							break;
						}
						int num21 = num - num2;
						if (num6 + (num21 >> 8) > num11)
						{
							return 0;
						}
						if (num21 >= 15)
						{
							dst[num20] += 15;
							for (num21 -= 15; num21 > 509; num21 -= 510)
							{
								dst[num6++] = byte.MaxValue;
								dst[num6++] = byte.MaxValue;
							}
							if (num21 > 254)
							{
								num21 -= 255;
								dst[num6++] = byte.MaxValue;
							}
							dst[num6++] = (byte)num21;
						}
						else
						{
							dst[num20] += (byte)num21;
						}
						if (num > num5)
						{
							break;
						}
						hash_table[((int)Peek4(src, num - 2) * -1640531535).UnsignedRightShift(19)] = (ushort)(num - 2 - num3);
						uint num16 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
						num18 = num3 + hash_table[num16];
						hash_table[num16] = (ushort)(num - num3);
						if (Equal4(src, num18, num))
						{
							num20 = num6++;
							dst[num20] = 0;
							continue;
						}
						goto IL_03d0;
					}
					num2 = num;
					break;
				}
			}
			int num24 = num4 - num2;
			if (num6 + num24 + 1 + (num24 - 15 + 255) / 255 > num7)
			{
				return 0;
			}
			if (num24 >= 15)
			{
				dst[num6++] = 240;
				for (num24 -= 15; num24 > 254; num24 -= 255)
				{
					dst[num6++] = byte.MaxValue;
				}
				dst[num6++] = (byte)num24;
			}
			else
			{
				dst[num6++] = (byte)(num24 << 4);
			}
			BlockCopy(src, num2, dst, num6, num4 - num2);
			num6 += num4 - num2;
			return num6 - dst_0;
		}

		private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			int[] dECODER_TABLE_ = DECODER_TABLE_32;
			int num = src_0;
			int num2 = dst_0;
			int num3 = num2 + dst_len;
			int num4 = num3 - 5;
			int num5 = num3 - 8;
			int num6 = num3 - 8;
			while (true)
			{
				byte b = src[num++];
				int num7;
				if ((num7 = b >> 4) == 15)
				{
					int num8;
					while ((num8 = src[num++]) == 255)
					{
						num7 += 255;
					}
					num7 += num8;
				}
				int num9 = num2 + num7;
				if (num9 > num5)
				{
					if (num9 != num3)
					{
						break;
					}
					BlockCopy(src, num, dst, num2, num7);
					num += num7;
					return num - src_0;
				}
				if (num2 < num9)
				{
					int num10 = WildCopy(src, num, dst, num2, num9);
					num += num10;
					num2 += num10;
				}
				num -= num2 - num9;
				num2 = num9;
				int num11 = num9 - Peek2(src, num);
				num += 2;
				if (num11 < dst_0)
				{
					break;
				}
				if ((num7 = b & 0xF) == 15)
				{
					while (src[num] == byte.MaxValue)
					{
						num++;
						num7 += 255;
					}
					num7 += src[num++];
				}
				if (num2 - num11 < 4)
				{
					dst[num2] = dst[num11];
					dst[num2 + 1] = dst[num11 + 1];
					dst[num2 + 2] = dst[num11 + 2];
					dst[num2 + 3] = dst[num11 + 3];
					num2 += 4;
					num11 += 4;
					num11 -= dECODER_TABLE_[num2 - num11];
					Copy4(dst, num11, num2);
					num2 = num2;
					num11 = num11;
				}
				else
				{
					Copy4(dst, num11, num2);
					num2 += 4;
					num11 += 4;
				}
				num9 = num2 + num7;
				if (num9 > num6)
				{
					if (num9 > num4)
					{
						break;
					}
					if (num2 < num5)
					{
						int num10 = SecureCopy(dst, num11, num2, num5);
						num11 += num10;
						num2 += num10;
					}
					while (num2 < num9)
					{
						dst[num2++] = dst[num11++];
					}
					num2 = num9;
				}
				else
				{
					if (num2 < num9)
					{
						SecureCopy(dst, num11, num2, num9);
					}
					num2 = num9;
				}
			}
			return -(num - src_0);
		}

		private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dECODER_TABLE_ = DECODER_TABLE_32;
			int num = src_0;
			int num2 = num + src_len;
			int num3 = dst_0;
			int num4 = num3 + dst_maxlen;
			int num5 = num2 - 8;
			int num6 = num2 - 6;
			int num7 = num4 - 8;
			int num8 = num4 - 8;
			int num9 = num4 - 5;
			int num10 = num4 - 12;
			if (num != num2)
			{
				while (true)
				{
					byte b = src[num++];
					int num11;
					if ((num11 = b >> 4) == 15)
					{
						int num12 = 255;
						while (num < num2 && num12 == 255)
						{
							num11 += (num12 = src[num++]);
						}
					}
					int num13 = num3 + num11;
					if (num13 > num10 || num + num11 > num5)
					{
						if (num13 > num4 || num + num11 != num2)
						{
							break;
						}
						BlockCopy(src, num, dst, num3, num11);
						num3 += num11;
						return num3 - dst_0;
					}
					if (num3 < num13)
					{
						int num14 = WildCopy(src, num, dst, num3, num13);
						num += num14;
						num3 += num14;
					}
					num -= num3 - num13;
					num3 = num13;
					int num15 = num13 - Peek2(src, num);
					num += 2;
					if (num15 < dst_0)
					{
						break;
					}
					if ((num11 = b & 0xF) == 15)
					{
						while (num < num6)
						{
							int num16 = src[num++];
							num11 += num16;
							if (num16 == 255)
							{
								continue;
							}
							break;
						}
					}
					if (num3 - num15 < 4)
					{
						dst[num3] = dst[num15];
						dst[num3 + 1] = dst[num15 + 1];
						dst[num3 + 2] = dst[num15 + 2];
						dst[num3 + 3] = dst[num15 + 3];
						num3 += 4;
						num15 += 4;
						num15 -= dECODER_TABLE_[num3 - num15];
						Copy4(dst, num15, num3);
						num3 = num3;
						num15 = num15;
					}
					else
					{
						Copy4(dst, num15, num3);
						num3 += 4;
						num15 += 4;
					}
					num13 = num3 + num11;
					if (num13 > num8)
					{
						if (num13 > num9)
						{
							break;
						}
						if (num3 < num7)
						{
							int num14 = SecureCopy(dst, num15, num3, num7);
							num15 += num14;
							num3 += num14;
						}
						while (num3 < num13)
						{
							dst[num3++] = dst[num15++];
						}
						num3 = num13;
					}
					else
					{
						if (num3 < num13)
						{
							SecureCopy(dst, num15, num3, num13);
						}
						num3 = num13;
					}
				}
			}
			return -(num - src_0);
		}

		private static void LZ4HC_Insert_32(LZ4HC_Data_Structure ctx, int src_p)
		{
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			int i = ctx.nextToUpdate;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			for (; i < src_p; i++)
			{
				int num = i;
				int num2 = num - (hashTable[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(17)] + src_base);
				if (num2 > 65535)
				{
					num2 = 65535;
				}
				chainTable[num & 0xFFFF] = (ushort)num2;
				hashTable[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(17)] = num - src_base;
			}
			ctx.nextToUpdate = i;
		}

		private static int LZ4HC_CommonLength_32(LZ4HC_Data_Structure ctx, int p1, int p2)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_32;
			byte[] src = ctx.src;
			int src_LASTLITERALS = ctx.src_LASTLITERALS;
			int num = p1;
			while (num < src_LASTLITERALS - 3)
			{
				int num2 = (int)Xor4(src, p2, num);
				if (num2 == 0)
				{
					num += 4;
					p2 += 4;
					continue;
				}
				num += dEBRUIJN_TABLE_[((num2 & -num2) * 125613361).UnsignedRightShift(27)];
				return num - p1;
			}
			if (num < src_LASTLITERALS - 1 && Equal2(src, p2, num))
			{
				num += 2;
				p2 += 2;
			}
			if (num < src_LASTLITERALS && src[p2] == src[num])
			{
				num++;
			}
			return num - p1;
		}

		private static int LZ4HC_InsertAndFindBestMatch_32(LZ4HC_Data_Structure ctx, int src_p, ref int src_match)
		{
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int num = 256;
			int num2 = 0;
			int num3 = 0;
			ushort num4 = 0;
			LZ4HC_Insert_32(ctx, src_p);
			int num5 = hashTable[((int)Peek4(src, src_p) * -1640531535).UnsignedRightShift(17)] + src_base;
			if (num5 >= src_p - 4)
			{
				if (Equal4(src, num5, src_p))
				{
					num4 = (ushort)(src_p - num5);
					num2 = (num3 = LZ4HC_CommonLength_32(ctx, src_p + 4, num5 + 4) + 4);
					src_match = num5;
				}
				num5 -= chainTable[num5 & 0xFFFF];
			}
			while (num5 >= src_p - 65535 && num != 0)
			{
				num--;
				if (src[num5 + num3] == src[src_p + num3] && Equal4(src, num5, src_p))
				{
					int num6 = LZ4HC_CommonLength_32(ctx, src_p + 4, num5 + 4) + 4;
					if (num6 > num3)
					{
						num3 = num6;
						src_match = num5;
					}
				}
				num5 -= chainTable[num5 & 0xFFFF];
			}
			if (num2 != 0)
			{
				int i = src_p;
				int num7;
				for (num7 = src_p + num2 - 3; i < num7 - num4; i++)
				{
					chainTable[i & 0xFFFF] = num4;
				}
				do
				{
					chainTable[i & 0xFFFF] = num4;
					hashTable[((int)Peek4(src, i) * -1640531535).UnsignedRightShift(17)] = i - src_base;
					i++;
				}
				while (i < num7);
				ctx.nextToUpdate = num7;
			}
			return num3;
		}

		private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
		{
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int src_LASTLITERALS = ctx.src_LASTLITERALS;
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_32;
			int num = 256;
			int num2 = src_p - startLimit;
			LZ4HC_Insert_32(ctx, src_p);
			int num3 = hashTable[((int)Peek4(src, src_p) * -1640531535).UnsignedRightShift(17)] + src_base;
			while (num3 >= src_p - 65535 && num != 0)
			{
				num--;
				if (src[startLimit + longest] == src[num3 - num2 + longest] && Equal4(src, num3, src_p))
				{
					int num4 = num3 + 4;
					int num5 = src_p + 4;
					int num6 = src_p;
					while (true)
					{
						if (num5 < src_LASTLITERALS - 3)
						{
							int num7 = (int)Xor4(src, num4, num5);
							if (num7 == 0)
							{
								num5 += 4;
								num4 += 4;
								continue;
							}
							num5 += dEBRUIJN_TABLE_[((num7 & -num7) * 125613361).UnsignedRightShift(27)];
							break;
						}
						if (num5 < src_LASTLITERALS - 1 && Equal2(src, num4, num5))
						{
							num5 += 2;
							num4 += 2;
						}
						if (num5 < src_LASTLITERALS && src[num4] == src[num5])
						{
							num5++;
						}
						break;
					}
					num4 = num3;
					while (num6 > startLimit && num4 > src_base && src[num6 - 1] == src[num4 - 1])
					{
						num6--;
						num4--;
					}
					if (num5 - num6 > longest)
					{
						longest = num5 - num6;
						matchpos = num4;
						startpos = num6;
					}
				}
				num3 -= chainTable[num3 & 0xFFFF];
			}
			return longest;
		}

		private static int LZ4_encodeSequence_32(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end)
		{
			byte[] src = ctx.src;
			byte[] dst = ctx.dst;
			int num = src_p - src_anchor;
			int num2 = dst_p++;
			if (dst_p + num + 8 + (num >> 8) > dst_end)
			{
				return 1;
			}
			int num3;
			if (num >= 15)
			{
				dst[num2] = 240;
				for (num3 = num - 15; num3 > 254; num3 -= 255)
				{
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num3;
			}
			else
			{
				dst[num2] = (byte)(num << 4);
			}
			if (num > 0)
			{
				int num4 = dst_p + num;
				src_anchor += WildCopy(src, src_anchor, dst, dst_p, num4);
				dst_p = num4;
			}
			Poke2(dst, dst_p, (ushort)(src_p - src_ref));
			dst_p += 2;
			num3 = matchLength - 4;
			if (dst_p + 6 + (num >> 8) > dst_end)
			{
				return 1;
			}
			if (num3 >= 15)
			{
				dst[num2] += 15;
				for (num3 -= 15; num3 > 509; num3 -= 510)
				{
					dst[dst_p++] = byte.MaxValue;
					dst[dst_p++] = byte.MaxValue;
				}
				if (num3 > 254)
				{
					num3 -= 255;
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num3;
			}
			else
			{
				dst[num2] += (byte)num3;
			}
			src_p += matchLength;
			src_anchor = src_p;
			return 0;
		}

		private static int LZ4_compressHCCtx_32(LZ4HC_Data_Structure ctx)
		{
			byte[] src = ctx.src;
			byte[] dst = ctx.dst;
			int src_base = ctx.src_base;
			int src_end = ctx.src_end;
			int dst_base = ctx.dst_base;
			int dst_len = ctx.dst_len;
			int dst_end = ctx.dst_end;
			int num = src_base;
			int src_anchor = num;
			int num2 = src_end - 12;
			int dst_p = dst_base;
			int src_match = 0;
			int startpos = 0;
			int matchpos = 0;
			int startpos2 = 0;
			int matchpos2 = 0;
			num++;
			while (num < num2)
			{
				int num3 = LZ4HC_InsertAndFindBestMatch_32(ctx, num, ref src_match);
				if (num3 == 0)
				{
					num++;
					continue;
				}
				int num4 = num;
				int num5 = src_match;
				int num6 = num3;
				while (true)
				{
					int num7 = ((num + num3 < num2) ? LZ4HC_InsertAndGetWiderMatch_32(ctx, num + num3 - 2, num + 1, num3, ref matchpos, ref startpos) : num3);
					if (num7 == num3)
					{
						if (LZ4_encodeSequence_32(ctx, ref num, ref dst_p, ref src_anchor, num3, src_match, dst_end) != 0)
						{
							return 0;
						}
						break;
					}
					if (num4 < num && startpos < num + num6)
					{
						num = num4;
						src_match = num5;
						num3 = num6;
					}
					if (startpos - num < 3)
					{
						num3 = num7;
						num = startpos;
						src_match = matchpos;
						continue;
					}
					int num10;
					while (true)
					{
						if (startpos - num < 18)
						{
							int num8 = num3;
							if (num8 > 18)
							{
								num8 = 18;
							}
							if (num + num8 > startpos + num7 - 4)
							{
								num8 = startpos - num + num7 - 4;
							}
							int num9 = num8 - (startpos - num);
							if (num9 > 0)
							{
								startpos += num9;
								matchpos += num9;
								num7 -= num9;
							}
						}
						num10 = ((startpos + num7 < num2) ? LZ4HC_InsertAndGetWiderMatch_32(ctx, startpos + num7 - 3, startpos, num7, ref matchpos2, ref startpos2) : num7);
						if (num10 == num7)
						{
							break;
						}
						if (startpos2 < num + num3 + 3)
						{
							if (startpos2 < num + num3)
							{
								startpos = startpos2;
								matchpos = matchpos2;
								num7 = num10;
								continue;
							}
							goto IL_0269;
						}
						if (startpos < num + num3)
						{
							if (startpos - num < 15)
							{
								if (num3 > 18)
								{
									num3 = 18;
								}
								if (num + num3 > startpos + num7 - 4)
								{
									num3 = startpos - num + num7 - 4;
								}
								int num11 = num3 - (startpos - num);
								if (num11 > 0)
								{
									startpos += num11;
									matchpos += num11;
									num7 -= num11;
								}
							}
							else
							{
								num3 = startpos - num;
							}
						}
						if (LZ4_encodeSequence_32(ctx, ref num, ref dst_p, ref src_anchor, num3, src_match, dst_end) != 0)
						{
							return 0;
						}
						num = startpos;
						src_match = matchpos;
						num3 = num7;
						startpos = startpos2;
						matchpos = matchpos2;
						num7 = num10;
					}
					if (startpos < num + num3)
					{
						num3 = startpos - num;
					}
					if (LZ4_encodeSequence_32(ctx, ref num, ref dst_p, ref src_anchor, num3, src_match, dst_end) != 0)
					{
						return 0;
					}
					num = startpos;
					if (LZ4_encodeSequence_32(ctx, ref num, ref dst_p, ref src_anchor, num7, matchpos, dst_end) != 0)
					{
						return 0;
					}
					break;
				IL_0269:
					if (startpos < num + num3)
					{
						int num12 = num + num3 - startpos;
						startpos += num12;
						matchpos += num12;
						num7 -= num12;
						if (num7 < 4)
						{
							startpos = startpos2;
							matchpos = matchpos2;
							num7 = num10;
						}
					}
					if (LZ4_encodeSequence_32(ctx, ref num, ref dst_p, ref src_anchor, num3, src_match, dst_end) != 0)
					{
						return 0;
					}
					num = startpos2;
					src_match = matchpos2;
					num3 = num10;
					num4 = startpos;
					num5 = matchpos;
					num6 = num7;
				}
			}
			int num13 = src_end - src_anchor;
			if (dst_p - dst_base + num13 + 1 + (num13 + 255 - 15) / 255 > (uint)dst_len)
			{
				return 0;
			}
			if (num13 >= 15)
			{
				dst[dst_p++] = 240;
				for (num13 -= 15; num13 > 254; num13 -= 255)
				{
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num13;
			}
			else
			{
				dst[dst_p++] = (byte)(num13 << 4);
			}
			BlockCopy(src, src_anchor, dst, dst_p, src_end - src_anchor);
			dst_p += src_end - src_anchor;
			return dst_p - dst_base;
		}

		private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_64;
			int num = src_0;
			int num2 = num;
			int num3 = num + src_len;
			int num4 = num3 - 12;
			int num5 = dst_0;
			int num6 = num5 + dst_maxlen;
			int num7 = num3 - 5;
			int num8 = num7 - 1;
			int num9 = num7 - 3;
			int num10 = num7 - 7;
			int num11 = num6 - 6;
			int num12 = num6 - 8;
			if (src_len >= 13)
			{
				hash_table[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(20)] = num - src_0;
				num++;
				uint num13 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
				while (true)
				{
					int num14 = 67;
					int num15 = num;
					int num18;
					while (true)
					{
						uint num16 = num13;
						int num17 = num14++ >> 6;
						num = num15;
						num15 = num + num17;
						if (num15 > num4)
						{
							break;
						}
						num13 = (uint)((int)Peek4(src, num15) * -1640531535) >> 20;
						num18 = src_0 + hash_table[num16];
						hash_table[num16] = num - src_0;
						if (num18 < num - 65535 || !Equal4(src, num18, num))
						{
							continue;
						}
						goto IL_010e;
					}
					break;
				IL_042d:
					num2 = num++;
					num13 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
					continue;
				IL_010e:
					while (num > num2 && num18 > src_0 && src[num - 1] == src[num18 - 1])
					{
						num--;
						num18--;
					}
					int num19 = num - num2;
					int num20 = num5++;
					if (num5 + num19 + (num19 >> 8) > num12)
					{
						return 0;
					}
					if (num19 >= 15)
					{
						int num21 = num19 - 15;
						dst[num20] = 240;
						if (num21 > 254)
						{
							do
							{
								dst[num5++] = byte.MaxValue;
								num21 -= 255;
							}
							while (num21 > 254);
							dst[num5++] = (byte)num21;
							BlockCopy(src, num2, dst, num5, num19);
							num5 += num19;
							goto IL_0212;
						}
						dst[num5++] = (byte)num21;
					}
					else
					{
						dst[num20] = (byte)(num19 << 4);
					}
					if (num19 > 0)
					{
						int num22 = num5 + num19;
						WildCopy(src, num2, dst, num5, num22);
						num5 = num22;
					}
					goto IL_0212;
				IL_0212:
					while (true)
					{
						Poke2(dst, num5, (ushort)(num - num18));
						num5 += 2;
						num += 4;
						num18 += 4;
						num2 = num;
						while (true)
						{
							if (num < num10)
							{
								long num23 = (long)Xor8(src, num18, num);
								if (num23 == 0)
								{
									num += 8;
									num18 += 8;
									continue;
								}
								num += dEBRUIJN_TABLE_[((num23 & -num23) * 151050438428048703L).UnsignedRightShift(58)];
								break;
							}
							if (num < num9 && Equal4(src, num18, num))
							{
								num += 4;
								num18 += 4;
							}
							if (num < num8 && Equal2(src, num18, num))
							{
								num += 2;
								num18 += 2;
							}
							if (num < num7 && src[num18] == src[num])
							{
								num++;
							}
							break;
						}
						num19 = num - num2;
						if (num5 + (num19 >> 8) > num11)
						{
							return 0;
						}
						if (num19 >= 15)
						{
							dst[num20] += 15;
							for (num19 -= 15; num19 > 509; num19 -= 510)
							{
								dst[num5++] = byte.MaxValue;
								dst[num5++] = byte.MaxValue;
							}
							if (num19 > 254)
							{
								num19 -= 255;
								dst[num5++] = byte.MaxValue;
							}
							dst[num5++] = (byte)num19;
						}
						else
						{
							dst[num20] += (byte)num19;
						}
						if (num > num4)
						{
							break;
						}
						hash_table[((int)Peek4(src, num - 2) * -1640531535).UnsignedRightShift(20)] = num - 2 - src_0;
						uint num16 = (uint)((int)Peek4(src, num) * -1640531535) >> 20;
						num18 = src_0 + hash_table[num16];
						hash_table[num16] = num - src_0;
						if (num18 > num - 65536 && Equal4(src, num18, num))
						{
							num20 = num5++;
							dst[num20] = 0;
							continue;
						}
						goto IL_042d;
					}
					num2 = num;
					break;
				}
			}
			int num24 = num3 - num2;
			if (num5 + num24 + 1 + (num24 + 255 - 15) / 255 > num6)
			{
				return 0;
			}
			if (num24 >= 15)
			{
				dst[num5++] = 240;
				for (num24 -= 15; num24 > 254; num24 -= 255)
				{
					dst[num5++] = byte.MaxValue;
				}
				dst[num5++] = (byte)num24;
			}
			else
			{
				dst[num5++] = (byte)(num24 << 4);
			}
			BlockCopy(src, num2, dst, num5, num3 - num2);
			num5 += num3 - num2;
			return num5 - dst_0;
		}

		private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_64;
			int num = src_0;
			int num2 = num;
			int num3 = num;
			int num4 = num + src_len;
			int num5 = num4 - 12;
			int num6 = dst_0;
			int num7 = num6 + dst_maxlen;
			int num8 = num4 - 5;
			int num9 = num8 - 1;
			int num10 = num8 - 3;
			int num11 = num8 - 7;
			int num12 = num7 - 6;
			int num13 = num7 - 8;
			if (src_len >= 13)
			{
				num++;
				uint num14 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
				while (true)
				{
					int num15 = 67;
					int num16 = num;
					int num19;
					while (true)
					{
						uint num17 = num14;
						int num18 = num15++ >> 6;
						num = num16;
						num16 = num + num18;
						if (num16 > num5)
						{
							break;
						}
						num14 = (uint)((int)Peek4(src, num16) * -1640531535) >> 19;
						num19 = num3 + hash_table[num17];
						hash_table[num17] = (ushort)(num - num3);
						if (!Equal4(src, num19, num))
						{
							continue;
						}
						goto IL_00ee;
					}
					break;
				IL_03fd:
					num2 = num++;
					num14 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
					continue;
				IL_00ee:
					while (num > num2 && num19 > src_0 && src[num - 1] == src[num19 - 1])
					{
						num--;
						num19--;
					}
					int num20 = num - num2;
					int num21 = num6++;
					if (num6 + num20 + (num20 >> 8) > num13)
					{
						return 0;
					}
					if (num20 >= 15)
					{
						int num22 = num20 - 15;
						dst[num21] = 240;
						if (num22 > 254)
						{
							do
							{
								dst[num6++] = byte.MaxValue;
								num22 -= 255;
							}
							while (num22 > 254);
							dst[num6++] = (byte)num22;
							BlockCopy(src, num2, dst, num6, num20);
							num6 += num20;
							goto IL_01ee;
						}
						dst[num6++] = (byte)num22;
					}
					else
					{
						dst[num21] = (byte)(num20 << 4);
					}
					if (num20 > 0)
					{
						int num23 = num6 + num20;
						WildCopy(src, num2, dst, num6, num23);
						num6 = num23;
					}
					goto IL_01ee;
				IL_01ee:
					while (true)
					{
						Poke2(dst, num6, (ushort)(num - num19));
						num6 += 2;
						num += 4;
						num19 += 4;
						num2 = num;
						while (true)
						{
							if (num < num11)
							{
								long num24 = (long)Xor8(src, num19, num);
								if (num24 == 0)
								{
									num += 8;
									num19 += 8;
									continue;
								}
								num += dEBRUIJN_TABLE_[((num24 & -num24) * 151050438428048703L).UnsignedRightShift(58)];
								break;
							}
							if (num < num10 && Equal4(src, num19, num))
							{
								num += 4;
								num19 += 4;
							}
							if (num < num9 && Equal2(src, num19, num))
							{
								num += 2;
								num19 += 2;
							}
							if (num < num8 && src[num19] == src[num])
							{
								num++;
							}
							break;
						}
						int num22 = num - num2;
						if (num6 + (num22 >> 8) > num12)
						{
							return 0;
						}
						if (num22 >= 15)
						{
							dst[num21] += 15;
							for (num22 -= 15; num22 > 509; num22 -= 510)
							{
								dst[num6++] = byte.MaxValue;
								dst[num6++] = byte.MaxValue;
							}
							if (num22 > 254)
							{
								num22 -= 255;
								dst[num6++] = byte.MaxValue;
							}
							dst[num6++] = (byte)num22;
						}
						else
						{
							dst[num21] += (byte)num22;
						}
						if (num > num5)
						{
							break;
						}
						hash_table[((int)Peek4(src, num - 2) * -1640531535).UnsignedRightShift(19)] = (ushort)(num - 2 - num3);
						uint num17 = (uint)((int)Peek4(src, num) * -1640531535) >> 19;
						num19 = num3 + hash_table[num17];
						hash_table[num17] = (ushort)(num - num3);
						if (Equal4(src, num19, num))
						{
							num21 = num6++;
							dst[num21] = 0;
							continue;
						}
						goto IL_03fd;
					}
					num2 = num;
					break;
				}
			}
			int num25 = num4 - num2;
			if (num6 + num25 + 1 + (num25 - 15 + 255) / 255 > num7)
			{
				return 0;
			}
			if (num25 >= 15)
			{
				dst[num6++] = 240;
				for (num25 -= 15; num25 > 254; num25 -= 255)
				{
					dst[num6++] = byte.MaxValue;
				}
				dst[num6++] = (byte)num25;
			}
			else
			{
				dst[num6++] = (byte)(num25 << 4);
			}
			BlockCopy(src, num2, dst, num6, num4 - num2);
			num6 += num4 - num2;
			return num6 - dst_0;
		}

		private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			int[] dECODER_TABLE_ = DECODER_TABLE_32;
			int[] dECODER_TABLE_2 = DECODER_TABLE_64;
			int num = src_0;
			int num2 = dst_0;
			int num3 = num2 + dst_len;
			int num4 = num3 - 5;
			int num5 = num3 - 8;
			int num6 = num3 - 8 - 4;
			while (true)
			{
				uint num7 = src[num++];
				int num8;
				if ((num8 = (byte)(num7 >> 4)) == 15)
				{
					int num9;
					while ((num9 = src[num++]) == 255)
					{
						num8 += 255;
					}
					num8 += num9;
				}
				int num10 = num2 + num8;
				if (num10 > num5)
				{
					if (num10 != num3)
					{
						break;
					}
					BlockCopy(src, num, dst, num2, num8);
					num += num8;
					return num - src_0;
				}
				if (num2 < num10)
				{
					int num11 = WildCopy(src, num, dst, num2, num10);
					num += num11;
					num2 += num11;
				}
				num -= num2 - num10;
				num2 = num10;
				int num12 = num10 - Peek2(src, num);
				num += 2;
				if (num12 < dst_0)
				{
					break;
				}
				if ((num8 = (byte)(num7 & 0xF)) == 15)
				{
					while (src[num] == byte.MaxValue)
					{
						num++;
						num8 += 255;
					}
					num8 += src[num++];
				}
				if (num2 - num12 < 8)
				{
					int num13 = dECODER_TABLE_2[num2 - num12];
					dst[num2] = dst[num12];
					dst[num2 + 1] = dst[num12 + 1];
					dst[num2 + 2] = dst[num12 + 2];
					dst[num2 + 3] = dst[num12 + 3];
					num2 += 4;
					num12 += 4;
					num12 -= dECODER_TABLE_[num2 - num12];
					Copy4(dst, num12, num2);
					num2 += 4;
					num12 -= num13;
				}
				else
				{
					Copy8(dst, num12, num2);
					num2 += 8;
					num12 += 8;
				}
				num10 = num2 + num8 - 4;
				if (num10 > num6)
				{
					if (num10 > num4)
					{
						break;
					}
					if (num2 < num5)
					{
						int num11 = SecureCopy(dst, num12, num2, num5);
						num12 += num11;
						num2 += num11;
					}
					while (num2 < num10)
					{
						dst[num2++] = dst[num12++];
					}
					num2 = num10;
				}
				else
				{
					if (num2 < num10)
					{
						SecureCopy(dst, num12, num2, num10);
					}
					num2 = num10;
				}
			}
			return -(num - src_0);
		}

		private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			int[] dECODER_TABLE_ = DECODER_TABLE_32;
			int[] dECODER_TABLE_2 = DECODER_TABLE_64;
			int num = src_0;
			int num2 = num + src_len;
			int num3 = dst_0;
			int num4 = num3 + dst_maxlen;
			int num5 = num2 - 8;
			int num6 = num2 - 6;
			int num7 = num4 - 8;
			int num8 = num4 - 12;
			int num9 = num4 - 5;
			int num10 = num4 - 12;
			if (num != num2)
			{
				while (true)
				{
					byte b = src[num++];
					int num11;
					if ((num11 = b >> 4) == 15)
					{
						int num12 = 255;
						while (num < num2 && num12 == 255)
						{
							num11 += (num12 = src[num++]);
						}
					}
					int num13 = num3 + num11;
					if (num13 > num10 || num + num11 > num5)
					{
						if (num13 > num4 || num + num11 != num2)
						{
							break;
						}
						BlockCopy(src, num, dst, num3, num11);
						num3 += num11;
						return num3 - dst_0;
					}
					if (num3 < num13)
					{
						int num14 = WildCopy(src, num, dst, num3, num13);
						num += num14;
						num3 += num14;
					}
					num -= num3 - num13;
					num3 = num13;
					int num15 = num13 - Peek2(src, num);
					num += 2;
					if (num15 < dst_0)
					{
						break;
					}
					if ((num11 = b & 0xF) == 15)
					{
						while (num < num6)
						{
							int num16 = src[num++];
							num11 += num16;
							if (num16 == 255)
							{
								continue;
							}
							break;
						}
					}
					if (num3 - num15 < 8)
					{
						int num17 = dECODER_TABLE_2[num3 - num15];
						dst[num3] = dst[num15];
						dst[num3 + 1] = dst[num15 + 1];
						dst[num3 + 2] = dst[num15 + 2];
						dst[num3 + 3] = dst[num15 + 3];
						num3 += 4;
						num15 += 4;
						num15 -= dECODER_TABLE_[num3 - num15];
						Copy4(dst, num15, num3);
						num3 += 4;
						num15 -= num17;
					}
					else
					{
						Copy8(dst, num15, num3);
						num3 += 8;
						num15 += 8;
					}
					num13 = num3 + num11 - 4;
					if (num13 > num8)
					{
						if (num13 > num9)
						{
							break;
						}
						if (num3 < num7)
						{
							int num14 = SecureCopy(dst, num15, num3, num7);
							num15 += num14;
							num3 += num14;
						}
						while (num3 < num13)
						{
							dst[num3++] = dst[num15++];
						}
						num3 = num13;
					}
					else
					{
						if (num3 < num13)
						{
							SecureCopy(dst, num15, num3, num13);
						}
						num3 = num13;
					}
				}
			}
			return -(num - src_0);
		}

		private static void LZ4HC_Insert_64(LZ4HC_Data_Structure ctx, int src_p)
		{
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int i;
			for (i = ctx.nextToUpdate; i < src_p; i++)
			{
				int num = i;
				int num2 = num - (hashTable[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(17)] + src_base);
				if (num2 > 65535)
				{
					num2 = 65535;
				}
				chainTable[num & 0xFFFF] = (ushort)num2;
				hashTable[((int)Peek4(src, num) * -1640531535).UnsignedRightShift(17)] = num - src_base;
			}
			ctx.nextToUpdate = i;
		}

		private static int LZ4HC_CommonLength_64(LZ4HC_Data_Structure ctx, int p1, int p2)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_64;
			byte[] src = ctx.src;
			int src_LASTLITERALS = ctx.src_LASTLITERALS;
			int num = p1;
			while (num < src_LASTLITERALS - 7)
			{
				long num2 = (long)Xor8(src, p2, num);
				if (num2 == 0)
				{
					num += 8;
					p2 += 8;
					continue;
				}
				num += dEBRUIJN_TABLE_[((num2 & -num2) * 151050438428048703L).UnsignedRightShift(58)];
				return num - p1;
			}
			if (num < src_LASTLITERALS - 3 && Equal4(src, p2, num))
			{
				num += 4;
				p2 += 4;
			}
			if (num < src_LASTLITERALS - 1 && Equal2(src, p2, num))
			{
				num += 2;
				p2 += 2;
			}
			if (num < src_LASTLITERALS && src[p2] == src[num])
			{
				num++;
			}
			return num - p1;
		}

		private static int LZ4HC_InsertAndFindBestMatch_64(LZ4HC_Data_Structure ctx, int src_p, ref int matchpos)
		{
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int num = 256;
			int num2 = 0;
			int num3 = 0;
			ushort num4 = 0;
			LZ4HC_Insert_64(ctx, src_p);
			int num5 = hashTable[((int)Peek4(src, src_p) * -1640531535).UnsignedRightShift(17)] + src_base;
			if (num5 >= src_p - 4)
			{
				if (Equal4(src, num5, src_p))
				{
					num4 = (ushort)(src_p - num5);
					num2 = (num3 = LZ4HC_CommonLength_64(ctx, src_p + 4, num5 + 4) + 4);
					matchpos = num5;
				}
				num5 -= chainTable[num5 & 0xFFFF];
			}
			while (num5 >= src_p - 65535 && num != 0)
			{
				num--;
				if (src[num5 + num3] == src[src_p + num3] && Equal4(src, num5, src_p))
				{
					int num6 = LZ4HC_CommonLength_64(ctx, src_p + 4, num5 + 4) + 4;
					if (num6 > num3)
					{
						num3 = num6;
						matchpos = num5;
					}
				}
				num5 -= chainTable[num5 & 0xFFFF];
			}
			if (num2 != 0)
			{
				int i = src_p;
				int num7;
				for (num7 = src_p + num2 - 3; i < num7 - num4; i++)
				{
					chainTable[i & 0xFFFF] = num4;
				}
				do
				{
					chainTable[i & 0xFFFF] = num4;
					hashTable[((int)Peek4(src, i) * -1640531535).UnsignedRightShift(17)] = i - src_base;
					i++;
				}
				while (i < num7);
				ctx.nextToUpdate = num7;
			}
			return num3;
		}

		private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
		{
			int[] dEBRUIJN_TABLE_ = DEBRUIJN_TABLE_64;
			ushort[] chainTable = ctx.chainTable;
			int[] hashTable = ctx.hashTable;
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int src_LASTLITERALS = ctx.src_LASTLITERALS;
			int num = 256;
			int num2 = src_p - startLimit;
			LZ4HC_Insert_64(ctx, src_p);
			int num3 = hashTable[((int)Peek4(src, src_p) * -1640531535).UnsignedRightShift(17)] + src_base;
			while (num3 >= src_p - 65535 && num != 0)
			{
				num--;
				if (src[startLimit + longest] == src[num3 - num2 + longest] && Equal4(src, num3, src_p))
				{
					int num4 = num3 + 4;
					int num5 = src_p + 4;
					int num6 = src_p;
					while (true)
					{
						if (num5 < src_LASTLITERALS - 7)
						{
							long num7 = (long)Xor8(src, num4, num5);
							if (num7 == 0)
							{
								num5 += 8;
								num4 += 8;
								continue;
							}
							num5 += dEBRUIJN_TABLE_[((num7 & -num7) * 151050438428048703L).UnsignedRightShift(58)];
							break;
						}
						if (num5 < src_LASTLITERALS - 3 && Equal4(src, num4, num5))
						{
							num5 += 4;
							num4 += 4;
						}
						if (num5 < src_LASTLITERALS - 1 && Equal2(src, num4, num5))
						{
							num5 += 2;
							num4 += 2;
						}
						if (num5 < src_LASTLITERALS && src[num4] == src[num5])
						{
							num5++;
						}
						break;
					}
					num4 = num3;
					while (num6 > startLimit && num4 > src_base && src[num6 - 1] == src[num4 - 1])
					{
						num6--;
						num4--;
					}
					if (num5 - num6 > longest)
					{
						longest = num5 - num6;
						matchpos = num4;
						startpos = num6;
					}
				}
				num3 -= chainTable[num3 & 0xFFFF];
			}
			return longest;
		}

		private static int LZ4_encodeSequence_64(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref)
		{
			byte[] src = ctx.src;
			byte[] dst = ctx.dst;
			int dst_end = ctx.dst_end;
			int num = src_p - src_anchor;
			int num2 = dst_p++;
			if (dst_p + num + 8 + (num >> 8) > dst_end)
			{
				return 1;
			}
			int num3;
			if (num >= 15)
			{
				dst[num2] = 240;
				for (num3 = num - 15; num3 > 254; num3 -= 255)
				{
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num3;
			}
			else
			{
				dst[num2] = (byte)(num << 4);
			}
			if (num > 0)
			{
				int num4 = dst_p + num;
				src_anchor += WildCopy(src, src_anchor, dst, dst_p, num4);
				dst_p = num4;
			}
			Poke2(dst, dst_p, (ushort)(src_p - src_ref));
			dst_p += 2;
			num3 = matchLength - 4;
			if (dst_p + 6 + (num >> 8) > dst_end)
			{
				return 1;
			}
			if (num3 >= 15)
			{
				dst[num2] += 15;
				for (num3 -= 15; num3 > 509; num3 -= 510)
				{
					dst[dst_p++] = byte.MaxValue;
					dst[dst_p++] = byte.MaxValue;
				}
				if (num3 > 254)
				{
					num3 -= 255;
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num3;
			}
			else
			{
				dst[num2] += (byte)num3;
			}
			src_p += matchLength;
			src_anchor = src_p;
			return 0;
		}

		private static int LZ4_compressHCCtx_64(LZ4HC_Data_Structure ctx)
		{
			byte[] src = ctx.src;
			int src_base = ctx.src_base;
			int src_end = ctx.src_end;
			int dst_base = ctx.dst_base;
			int src_anchor = src_base;
			int num = src_end - 12;
			byte[] dst = ctx.dst;
			int dst_len = ctx.dst_len;
			int dst_p = ctx.dst_base;
			int matchpos = 0;
			int startpos = 0;
			int matchpos2 = 0;
			int startpos2 = 0;
			int matchpos3 = 0;
			src_base++;
			while (src_base < num)
			{
				int num2 = LZ4HC_InsertAndFindBestMatch_64(ctx, src_base, ref matchpos);
				if (num2 == 0)
				{
					src_base++;
					continue;
				}
				int num3 = src_base;
				int num4 = matchpos;
				int num5 = num2;
				while (true)
				{
					int num6 = ((src_base + num2 < num) ? LZ4HC_InsertAndGetWiderMatch_64(ctx, src_base + num2 - 2, src_base + 1, num2, ref matchpos2, ref startpos) : num2);
					if (num6 == num2)
					{
						if (LZ4_encodeSequence_64(ctx, ref src_base, ref dst_p, ref src_anchor, num2, matchpos) != 0)
						{
							return 0;
						}
						break;
					}
					if (num3 < src_base && startpos < src_base + num5)
					{
						src_base = num3;
						matchpos = num4;
						num2 = num5;
					}
					if (startpos - src_base < 3)
					{
						num2 = num6;
						src_base = startpos;
						matchpos = matchpos2;
						continue;
					}
					int num9;
					while (true)
					{
						if (startpos - src_base < 18)
						{
							int num7 = num2;
							if (num7 > 18)
							{
								num7 = 18;
							}
							if (src_base + num7 > startpos + num6 - 4)
							{
								num7 = startpos - src_base + num6 - 4;
							}
							int num8 = num7 - (startpos - src_base);
							if (num8 > 0)
							{
								startpos += num8;
								matchpos2 += num8;
								num6 -= num8;
							}
						}
						num9 = ((startpos + num6 < num) ? LZ4HC_InsertAndGetWiderMatch_64(ctx, startpos + num6 - 3, startpos, num6, ref matchpos3, ref startpos2) : num6);
						if (num9 == num6)
						{
							break;
						}
						if (startpos2 < src_base + num2 + 3)
						{
							if (startpos2 < src_base + num2)
							{
								startpos = startpos2;
								matchpos2 = matchpos3;
								num6 = num9;
								continue;
							}
							goto IL_0244;
						}
						if (startpos < src_base + num2)
						{
							if (startpos - src_base < 15)
							{
								if (num2 > 18)
								{
									num2 = 18;
								}
								if (src_base + num2 > startpos + num6 - 4)
								{
									num2 = startpos - src_base + num6 - 4;
								}
								int num10 = num2 - (startpos - src_base);
								if (num10 > 0)
								{
									startpos += num10;
									matchpos2 += num10;
									num6 -= num10;
								}
							}
							else
							{
								num2 = startpos - src_base;
							}
						}
						if (LZ4_encodeSequence_64(ctx, ref src_base, ref dst_p, ref src_anchor, num2, matchpos) != 0)
						{
							return 0;
						}
						src_base = startpos;
						matchpos = matchpos2;
						num2 = num6;
						startpos = startpos2;
						matchpos2 = matchpos3;
						num6 = num9;
					}
					if (startpos < src_base + num2)
					{
						num2 = startpos - src_base;
					}
					if (LZ4_encodeSequence_64(ctx, ref src_base, ref dst_p, ref src_anchor, num2, matchpos) != 0)
					{
						return 0;
					}
					src_base = startpos;
					if (LZ4_encodeSequence_64(ctx, ref src_base, ref dst_p, ref src_anchor, num6, matchpos2) != 0)
					{
						return 0;
					}
					break;
				IL_0244:
					if (startpos < src_base + num2)
					{
						int num11 = src_base + num2 - startpos;
						startpos += num11;
						matchpos2 += num11;
						num6 -= num11;
						if (num6 < 4)
						{
							startpos = startpos2;
							matchpos2 = matchpos3;
							num6 = num9;
						}
					}
					if (LZ4_encodeSequence_64(ctx, ref src_base, ref dst_p, ref src_anchor, num2, matchpos) != 0)
					{
						return 0;
					}
					src_base = startpos2;
					matchpos = matchpos3;
					num2 = num9;
					num3 = startpos;
					num4 = matchpos2;
					num5 = num6;
				}
			}
			int num12 = src_end - src_anchor;
			if (dst_p - dst_base + num12 + 1 + (num12 + 255 - 15) / 255 > (uint)dst_len)
			{
				return 0;
			}
			if (num12 >= 15)
			{
				dst[dst_p++] = 240;
				for (num12 -= 15; num12 > 254; num12 -= 255)
				{
					dst[dst_p++] = byte.MaxValue;
				}
				dst[dst_p++] = (byte)num12;
			}
			else
			{
				dst[dst_p++] = (byte)(num12 << 4);
			}
			BlockCopy(src, src_anchor, dst, dst_p, src_end - src_anchor);
			dst_p += src_end - src_anchor;
			return dst_p - dst_base;
		}
	}
}