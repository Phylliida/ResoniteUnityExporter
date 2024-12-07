using System;
using System.Runtime.CompilerServices;
using System.Text;
using LZ4.Services;

namespace LZ4
{

	public static class LZ4Codec
	{
		public delegate void Action();

		public delegate T Func<T>();

		private static readonly ILZ4Service Encoder;

		private static readonly ILZ4Service EncoderHC;

		private static readonly ILZ4Service Decoder;

		private static ILZ4Service _service_MM32;

		private static ILZ4Service _service_MM64;

		private static ILZ4Service _service_CC32;

		private static ILZ4Service _service_CC64;

		private static ILZ4Service _service_N32;

		private static ILZ4Service _service_N64;

		private static ILZ4Service _service_S32;

		private static ILZ4Service _service_S64;

		private const int WRAP_OFFSET_0 = 0;

		private const int WRAP_OFFSET_4 = 4;

		private const int WRAP_OFFSET_8 = 8;

		private const int WRAP_LENGTH = 8;

		public static string CodecName => string.Format("{0}/{1}/{2}HC", (Encoder == null) ? "<none>" : Encoder.CodecName, (Decoder == null) ? "<none>" : Decoder.CodecName, (EncoderHC == null) ? "<none>" : EncoderHC.CodecName);

		static LZ4Codec()
		{
			if (Try(Has2015Runtime, defaultValue: false))
			{
				Try(InitializeLZ4mm);
				Try(InitializeLZ4cc);
			}
			Try(InitializeLZ4n);
			Try(InitializeLZ4s);
			SelectCodec(out var encoder, out var decoder, out var encoderHC);
			Encoder = encoder;
			Decoder = decoder;
			EncoderHC = encoderHC;
			if (Encoder == null || Decoder == null)
			{
				throw new NotSupportedException("No LZ4 compression service found");
			}
		}

		private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC)
		{
			if (IntPtr.Size == 4)
			{
				encoder = _service_MM32 ?? _service_MM64 ?? _service_N32 ?? _service_CC32 ?? _service_N64 ?? _service_CC64 ?? _service_S32 ?? _service_S64;
				decoder = _service_MM32 ?? _service_MM64 ?? _service_CC64 ?? _service_CC32 ?? _service_N64 ?? _service_N32 ?? _service_S64 ?? _service_S32;
				encoderHC = _service_MM32 ?? _service_MM64 ?? _service_N32 ?? _service_CC32 ?? _service_N64 ?? _service_CC64 ?? _service_S32 ?? _service_S64;
			}
			else
			{
				encoder = _service_MM64 ?? _service_MM32 ?? _service_N64 ?? _service_N32 ?? _service_CC64 ?? _service_CC32 ?? _service_S32 ?? _service_S64;
				decoder = _service_MM64 ?? _service_N64 ?? _service_N32 ?? _service_CC64 ?? _service_MM32 ?? _service_CC32 ?? _service_S64 ?? _service_S32;
				encoderHC = _service_MM64 ?? _service_MM32 ?? _service_CC32 ?? _service_CC64 ?? _service_N32 ?? _service_N64 ?? _service_S32 ?? _service_S64;
			}
		}

		private static ILZ4Service AutoTest(ILZ4Service service)
		{
			byte[] bytes = Encoding.UTF8.GetBytes("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
			byte[] array = new byte[MaximumOutputLength(bytes.Length)];
			int num = service.Encode(bytes, 0, bytes.Length, array, 0, array.Length);
			if (num < 0)
			{
				return null;
			}
			byte[] array2 = new byte[bytes.Length];
			int num2 = service.Decode(array, 0, num, array2, 0, array2.Length, knownOutputLength: true);
			if (num2 != bytes.Length)
			{
				return null;
			}
			string @string = Encoding.UTF8.GetString(array2, 0, array2.Length);
			if (@string != "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
			{
				return null;
			}
			int num3 = service.Decode(array, 0, num, array2, 0, array2.Length, knownOutputLength: false);
			if (num3 != bytes.Length)
			{
				return null;
			}
			string string2 = Encoding.UTF8.GetString(array2, 0, array2.Length);
			if (string2 != "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
			{
				return null;
			}
			byte[] array3 = new byte[MaximumOutputLength(bytes.Length)];
			int num4 = service.EncodeHC(bytes, 0, bytes.Length, array3, 0, array3.Length);
			if (num4 < 0)
			{
				return null;
			}
			byte[] array4 = new byte[bytes.Length];
			int num5 = service.Decode(array3, 0, num4, array4, 0, array4.Length, knownOutputLength: true);
			if (num5 != bytes.Length)
			{
				return null;
			}
			string string3 = Encoding.UTF8.GetString(array4, 0, array4.Length);
			if (string3 != "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
			{
				return null;
			}
			int num6 = service.Decode(array3, 0, num4, array4, 0, array4.Length, knownOutputLength: false);
			if (num6 != bytes.Length)
			{
				return null;
			}
			string string4 = Encoding.UTF8.GetString(array4, 0, array4.Length);
			if (string4 != "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
			{
				return null;
			}
			return service;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Try(Action method)
		{
			try
			{
				method();
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T Try<T>(Func<T> method, T defaultValue)
		{
			try
			{
				return method();
			}
			catch
			{
				return defaultValue;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ILZ4Service TryService<T>() where T : ILZ4Service, new()
		{
			try
			{
				return AutoTest(new T());
			}
			catch (Exception)
			{
				return null;
			}
		}

		public static int MaximumOutputLength(int inputLength)
		{
			return inputLength + inputLength / 255 + 16;
		}

		public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return Encoder.Encode(input, inputOffset, inputLength, output, outputOffset, outputLength);
		}

		public static byte[] Encode(byte[] input, int inputOffset, int inputLength)
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
			int num = Encode(input, inputOffset, inputLength, array, 0, array.Length);
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

		public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return (EncoderHC ?? Encoder).EncodeHC(input, inputOffset, inputLength, output, outputOffset, outputLength);
		}

		public static byte[] EncodeHC(byte[] input, int inputOffset, int inputLength)
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
			int num = EncodeHC(input, inputOffset, inputLength, array, 0, array.Length);
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

		public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = false)
		{
			return Decoder.Decode(input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength);
		}

		public static byte[] Decode(byte[] input, int inputOffset, int inputLength, int outputLength)
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
			int num = Decode(input, inputOffset, inputLength, array, 0, outputLength, knownOutputLength: true);
			if (num != outputLength)
			{
				throw new ArgumentException("outputLength is not valid");
			}
			return array;
		}

		private static void Poke4(byte[] buffer, int offset, uint value)
		{
			buffer[offset] = (byte)value;
			buffer[offset + 1] = (byte)(value >> 8);
			buffer[offset + 2] = (byte)(value >> 16);
			buffer[offset + 3] = (byte)(value >> 24);
		}

		private static uint Peek4(byte[] buffer, int offset)
		{
			return (uint)(buffer[offset] | (buffer[offset + 1] << 8) | (buffer[offset + 2] << 16) | (buffer[offset + 3] << 24));
		}

		private static byte[] Wrap(byte[] inputBuffer, int inputOffset, int inputLength, bool highCompression)
		{
			inputLength = Math.Min(inputBuffer.Length - inputOffset, inputLength);
			if (inputLength < 0)
			{
				throw new ArgumentException("inputBuffer size of inputLength is invalid");
			}
			if (inputLength == 0)
			{
				return new byte[8];
			}
			int num = inputLength;
			byte[] array = new byte[num];
			num = (highCompression ? EncodeHC(inputBuffer, inputOffset, inputLength, array, 0, num) : Encode(inputBuffer, inputOffset, inputLength, array, 0, num));
			byte[] array2;
			if (num >= inputLength || num <= 0)
			{
				array2 = new byte[inputLength + 8];
				Poke4(array2, 0, (uint)inputLength);
				Poke4(array2, 4, (uint)inputLength);
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, 8, inputLength);
			}
			else
			{
				array2 = new byte[num + 8];
				Poke4(array2, 0, (uint)inputLength);
				Poke4(array2, 4, (uint)num);
				Buffer.BlockCopy(array, 0, array2, 8, num);
			}
			return array2;
		}

		public static byte[] Wrap(byte[] inputBuffer, int inputOffset = 0, int inputLength = int.MaxValue)
		{
			return Wrap(inputBuffer, inputOffset, inputLength, highCompression: false);
		}

		public static byte[] WrapHC(byte[] inputBuffer, int inputOffset = 0, int inputLength = int.MaxValue)
		{
			return Wrap(inputBuffer, inputOffset, inputLength, highCompression: true);
		}

		public static byte[] Unwrap(byte[] inputBuffer, int inputOffset = 0)
		{
			int num = inputBuffer.Length - inputOffset;
			if (num < 8)
			{
				throw new ArgumentException("inputBuffer size is invalid");
			}
			int num2 = (int)Peek4(inputBuffer, inputOffset);
			num = (int)Peek4(inputBuffer, inputOffset + 4);
			if (num > inputBuffer.Length - inputOffset - 8)
			{
				throw new ArgumentException("inputBuffer size is invalid or has been corrupted");
			}
			byte[] array;
			if (num >= num2)
			{
				array = new byte[num];
				Buffer.BlockCopy(inputBuffer, inputOffset + 8, array, 0, num);
			}
			else
			{
				array = new byte[num2];
				Decode(inputBuffer, inputOffset + 8, num, array, 0, num2, knownOutputLength: true);
			}
			return array;
		}

		private static bool Has2015Runtime()
		{
			return false;
		}

		private static void InitializeLZ4mm()
		{
			_service_MM32 = (_service_MM64 = null);
		}

		private static void InitializeLZ4cc()
		{
			_service_CC32 = (_service_CC64 = null);
		}

		private static void InitializeLZ4n()
		{
			_service_N32 = (_service_N64 = null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void InitializeLZ4s()
		{
			_service_S32 = TryService<Safe32LZ4Service>();
			_service_S64 = TryService<Safe64LZ4Service>();
		}
	}

}