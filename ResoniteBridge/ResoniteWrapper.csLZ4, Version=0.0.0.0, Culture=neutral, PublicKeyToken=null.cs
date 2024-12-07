using ResoniteBridge;
#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using LZ4.Services;
using LZ4ps;

namespace LZ4
{
	public interface ILZ4Service : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.String CodecName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CodecName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.Int32 Encode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength);

		System.Int32 EncodeHC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength);

		System.Int32 Decode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength, System.Boolean knownOutputLength);
	}
	public static class LZ4Codec
	{
		public delegate void Action();

		public delegate T Func<T>();

		public static ILZ4Service Encoder
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encoder"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encoder", value);
			}
		}

		public static ILZ4Service EncoderHC
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "EncoderHC"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "EncoderHC", value);
			}
		}

		public static ILZ4Service Decoder
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decoder"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decoder", value);
			}
		}

		public static ILZ4Service _service_MM32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_MM32"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_MM32", value);
			}
		}

		public static ILZ4Service _service_MM64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_MM64"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_MM64", value);
			}
		}

		public static ILZ4Service _service_CC32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_CC32"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_CC32", value);
			}
		}

		public static ILZ4Service _service_CC64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_CC64"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_CC64", value);
			}
		}

		public static ILZ4Service _service_N32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_N32"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_N32", value);
			}
		}

		public static ILZ4Service _service_N64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_N64"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_N64", value);
			}
		}

		public static ILZ4Service _service_S32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_S32"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_S32", value);
			}
		}

		public static ILZ4Service _service_S64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_S64"), typeof(ILZ4Service)) is ILZ4Service __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILZ4Service");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_service_S64", value);
			}
		}

		public static System.Int32 WRAP_OFFSET_0
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_0"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_0", value);
			}
		}

		public static System.Int32 WRAP_OFFSET_4
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_4"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_4", value);
			}
		}

		public static System.Int32 WRAP_OFFSET_8
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_8"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_OFFSET_8", value);
			}
		}

		public static System.Int32 WRAP_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WRAP_LENGTH", value);
			}
		}

		public static System.String CodecName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "CodecName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		static LZ4Codec()
		{
		}

		public static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "SelectCodec", out ResoniteBridge.ResoniteBridgeValue[] __outVars);
		}

		public static ILZ4Service AutoTest(ILZ4Service service)
		{
			return (ILZ4Service)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "AutoTest", service), typeof(ILZ4Service));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static public void Try(Action method)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Try", method);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static public T Try<T>(Func<T> method, T defaultValue)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Try", method, defaultValue), typeof(T));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static public ILZ4Service TryService<T>() where T : ILZ4Service, new()
		{
			return (ILZ4Service)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "TryService"), typeof(ILZ4Service));
		}

		public static System.Int32 MaximumOutputLength(System.Int32 inputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MaximumOutputLength", inputLength), typeof(System.Int32));
		}

		public static System.Int32 Encode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] Encode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 EncodeHC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeHC", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] EncodeHC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeHC", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 Decode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength = 0, System.Boolean knownOutputLength = false)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength), typeof(System.Int32));
		}

		public static byte[] Decode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, System.Int32 outputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", input, inputOffset, inputLength, outputLength), typeof(byte[]));
		}

		public static void Poke4(byte[] buffer, System.Int32 offset, System.UInt32 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Poke4", buffer, offset, value);
		}

		public static System.UInt32 Peek4(byte[] buffer, System.Int32 offset)
		{
			return (System.UInt32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Peek4", buffer, offset), typeof(System.UInt32));
		}

		public static byte[] Wrap(byte[] inputBuffer, System.Int32 inputOffset, System.Int32 inputLength, System.Boolean highCompression)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Wrap", inputBuffer, inputOffset, inputLength, highCompression), typeof(byte[]));
		}

		public static byte[] Wrap(byte[] inputBuffer, System.Int32 inputOffset = 0, System.Int32 inputLength = int.MaxValue)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Wrap", inputBuffer, inputOffset, inputLength), typeof(byte[]));
		}

		public static byte[] WrapHC(byte[] inputBuffer, System.Int32 inputOffset = 0, System.Int32 inputLength = int.MaxValue)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WrapHC", inputBuffer, inputOffset, inputLength), typeof(byte[]));
		}

		public static byte[] Unwrap(byte[] inputBuffer, System.Int32 inputOffset = 0)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Unwrap", inputBuffer, inputOffset), typeof(byte[]));
		}

		public static System.Boolean Has2015Runtime()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Has2015Runtime"), typeof(System.Boolean));
		}

		public static void InitializeLZ4mm()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "InitializeLZ4mm");
		}

		public static void InitializeLZ4cc()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "InitializeLZ4cc");
		}

		public static void InitializeLZ4n()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "InitializeLZ4n");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static public void InitializeLZ4s()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "InitializeLZ4s");
		}
	}
	public interface IBufferAllocator : ResoniteBridge.ResoniteBridgeValueHolder
	{
		byte[] GetBuffer(System.Int32 minSize);

		void ReturnBuffer(byte[] buffer);
	}
	public class LZ4Stream : Stream, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Flags]
		public enum ChunkFlags
		{
			None = 0,
			Compressed = 1,
			HighCompression = 2,
			Passes = 0x1C
		}

		public IBufferAllocator _bufferAllocator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_bufferAllocator"), typeof(IBufferAllocator)) is IBufferAllocator __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IBufferAllocator");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_bufferAllocator", value);
			}
		}

		public Stream _innerStream
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_innerStream"), typeof(Stream)) is Stream __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stream");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_innerStream", value);
			}
		}

		public LZ4StreamMode _compressionMode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_compressionMode"), typeof(LZ4StreamMode)) is LZ4StreamMode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LZ4StreamMode");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_compressionMode", value);
			}
		}

		public System.Boolean _highCompression
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_highCompression"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_highCompression", value);
			}
		}

		public System.Boolean _interactiveRead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_interactiveRead"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_interactiveRead", value);
			}
		}

		public System.Boolean _isolateInnerStream
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isolateInnerStream"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_isolateInnerStream", value);
			}
		}

		public System.Int32 _blockSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_blockSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_blockSize", value);
			}
		}

		public byte[] _buffer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_buffer"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_buffer", value);
			}
		}

		public System.Int32 _bufferLength
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_bufferLength"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_bufferLength", value);
			}
		}

		public System.Int32 _bufferOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_bufferOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_bufferOffset", value);
			}
		}

		public System.Int64 _uncompressedPosition
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_uncompressedPosition"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_uncompressedPosition", value);
			}
		}

		public override System.Boolean CanRead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanRead"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override System.Boolean CanSeek
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanSeek"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override System.Boolean CanWrite
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanWrite"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override System.Int64 Length
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Length"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		public override System.Int64 Position
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Position"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Position", value);
			}
		}

		[Obsolete("This constructor is obsolete")]
		public LZ4Stream(Stream innerStream, LZ4StreamMode compressionMode, System.Boolean highCompression, System.Int32 blockSize = 1048576, System.Boolean interactiveRead = false, IBufferAllocator bufferAllocator = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), innerStream, compressionMode, highCompression, blockSize, interactiveRead, bufferAllocator);
		}

		public LZ4Stream(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = LZ4StreamFlags.None, System.Int32 blockSize = 1048576, IBufferAllocator bufferAllocator = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), innerStream, compressionMode, compressionFlags, blockSize, bufferAllocator);
		}

		public byte[] AllocateBuffer(System.Int32 size)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateBuffer", size), typeof(byte[]));
		}

		public void ReturnBuffer(byte[] buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReturnBuffer", buffer);
		}

		public static NotSupportedException NotSupported(System.String operationName)
		{
			return (NotSupportedException)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), "NotSupported", operationName), typeof(NotSupportedException));
		}

		public static EndOfStreamException EndOfStream()
		{
			return (EndOfStreamException)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), "EndOfStream"), typeof(EndOfStreamException));
		}

		public System.Boolean TryReadVarInt(out System.UInt64 result)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryReadVarInt", out ResoniteBridge.ResoniteBridgeValue[] __outVars), typeof(System.Boolean));
			result = (System.UInt64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.UInt64));
			return __finalResult;
		}

		public System.UInt64 ReadVarInt()
		{
			return (System.UInt64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVarInt"), typeof(System.UInt64));
		}

		public System.Int32 ReadBlock(byte[] buffer, System.Int32 offset, System.Int32 length)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadBlock", buffer, offset, length), typeof(System.Int32));
		}

		public void WriteVarInt(System.UInt64 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVarInt", value);
		}

		public void FlushCurrentChunk()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FlushCurrentChunk");
		}

		public System.Boolean AcquireNextChunk()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AcquireNextChunk"), typeof(System.Boolean));
		}

		public override void Flush()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Flush");
		}

		public override System.Int32 ReadByte()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadByte"), typeof(System.Int32));
		}

		public override System.Int32 Read(byte[] buffer, System.Int32 offset, System.Int32 count)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", buffer, offset, count), typeof(System.Int32));
		}

		public override System.Int64 Seek(System.Int64 offset, SeekOrigin origin)
		{
			return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Seek", offset, origin), typeof(System.Int64));
		}

		public override void SetLength(System.Int64 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLength", value);
		}

		public override void WriteByte(System.Byte value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteByte", value);
		}

		public override void Write(byte[] buffer, System.Int32 offset, System.Int32 count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", buffer, offset, count);
		}

		protected override void Dispose(System.Boolean disposing)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose", disposing);
		}

		[Obsolete("This constructor is obsolete")]
		public LZ4Stream(Stream innerStream, ResoniteBridge.ResoniteBridgeValue compressionMode, System.Boolean highCompression, System.Int32 blockSize = 1048576, System.Boolean interactiveRead = false)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), innerStream, compressionMode, highCompression, blockSize, interactiveRead);
		}

		public LZ4Stream(Stream innerStream, ResoniteBridge.ResoniteBridgeValue compressionMode, LZ4StreamFlags compressionFlags = LZ4StreamFlags.None, System.Int32 blockSize = 1048576)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), innerStream, compressionMode, compressionFlags, blockSize);
		}

		public static LZ4StreamMode ToLZ4StreamMode(ResoniteBridge.ResoniteBridgeValue compressionMode)
		{
			return (LZ4StreamMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), "ToLZ4StreamMode", compressionMode), typeof(LZ4StreamMode));
		}

		public static LZ4StreamFlags CombineLZ4Flags(System.Boolean highCompression, System.Boolean interactiveRead)
		{
			return (LZ4StreamFlags)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Stream", ResoniteBridge.ResoniteBridgeValueType.Type), "CombineLZ4Flags", highCompression, interactiveRead), typeof(LZ4StreamFlags));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LZ4Stream(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LZ4Stream()
		{
		}
	}
	[Flags]
	public enum LZ4StreamFlags
	{
		None = 0,
		InteractiveRead = 1,
		HighCompression = 2,
		IsolateInnerStream = 4,
		Default = 0
	}
	public enum LZ4StreamMode
	{
		Compress,
		Decompress
	}
}
namespace LZ4.Services
{
	public class Safe32LZ4Service : ILZ4Service, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String CodecName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CodecName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Int32 Encode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Encode", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public System.Int32 Decode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength, System.Boolean knownOutputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Decode", input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength), typeof(System.Int32));
		}

		public System.Int32 EncodeHC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EncodeHC", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Safe32LZ4Service(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Safe32LZ4Service()
		{
		}
	}
	public class Safe64LZ4Service : ILZ4Service, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String CodecName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CodecName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Int32 Encode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Encode", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public System.Int32 Decode(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength, System.Boolean knownOutputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Decode", input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength), typeof(System.Int32));
		}

		public System.Int32 EncodeHC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EncodeHC", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Safe64LZ4Service(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Safe64LZ4Service()
		{
		}
	}
}
namespace LZ4ps
{
	public static class LZ4Codec
	{
		public class LZ4HC_Data_Structure : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public byte[] src
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "src"), typeof(byte[])) is byte[] __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to byte[]");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "src", value);
				}
			}

			public System.Int32 src_base
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "src_base"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "src_base", value);
				}
			}

			public System.Int32 src_end
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "src_end"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "src_end", value);
				}
			}

			public System.Int32 src_LASTLITERALS
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "src_LASTLITERALS"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "src_LASTLITERALS", value);
				}
			}

			public byte[] dst
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dst"), typeof(byte[])) is byte[] __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to byte[]");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dst", value);
				}
			}

			public System.Int32 dst_base
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dst_base"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dst_base", value);
				}
			}

			public System.Int32 dst_len
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dst_len"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dst_len", value);
				}
			}

			public System.Int32 dst_end
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dst_end"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dst_end", value);
				}
			}

			public int[] hashTable
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "hashTable"), typeof(int[])) is int[] __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int[]");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "hashTable", value);
				}
			}

			public ushort[] chainTable
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "chainTable"), typeof(ushort[])) is ushort[] __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ushort[]");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "chainTable", value);
				}
			}

			public System.Int32 nextToUpdate
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nextToUpdate"), typeof(System.Int32)) is System.Int32 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to int");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nextToUpdate", value);
				}
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public LZ4HC_Data_Structure(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public LZ4HC_Data_Structure()
			{
			}
		}

		public static System.Int32 MEMORY_USAGE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MEMORY_USAGE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MEMORY_USAGE", value);
			}
		}

		public static System.Int32 NOTCOMPRESSIBLE_DETECTIONLEVEL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "NOTCOMPRESSIBLE_DETECTIONLEVEL"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "NOTCOMPRESSIBLE_DETECTIONLEVEL", value);
			}
		}

		public static System.Int32 BLOCK_COPY_LIMIT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "BLOCK_COPY_LIMIT"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "BLOCK_COPY_LIMIT", value);
			}
		}

		public static System.Int32 MINMATCH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MINMATCH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MINMATCH", value);
			}
		}

		public static System.Int32 SKIPSTRENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "SKIPSTRENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "SKIPSTRENGTH", value);
			}
		}

		public static System.Int32 COPYLENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "COPYLENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "COPYLENGTH", value);
			}
		}

		public static System.Int32 LASTLITERALS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LASTLITERALS"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LASTLITERALS", value);
			}
		}

		public static System.Int32 MFLIMIT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MFLIMIT"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MFLIMIT", value);
			}
		}

		public static System.Int32 MINLENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MINLENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MINLENGTH", value);
			}
		}

		public static System.Int32 MAXD_LOG
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD_LOG"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD_LOG", value);
			}
		}

		public static System.Int32 MAXD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD", value);
			}
		}

		public static System.Int32 MAXD_MASK
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD_MASK"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAXD_MASK", value);
			}
		}

		public static System.Int32 MAX_DISTANCE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DISTANCE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DISTANCE", value);
			}
		}

		public static System.Int32 ML_BITS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ML_BITS"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ML_BITS", value);
			}
		}

		public static System.Int32 ML_MASK
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ML_MASK"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ML_MASK", value);
			}
		}

		public static System.Int32 RUN_BITS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "RUN_BITS"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "RUN_BITS", value);
			}
		}

		public static System.Int32 RUN_MASK
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "RUN_MASK"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "RUN_MASK", value);
			}
		}

		public static System.Int32 STEPSIZE_64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "STEPSIZE_64"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "STEPSIZE_64", value);
			}
		}

		public static System.Int32 STEPSIZE_32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "STEPSIZE_32"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "STEPSIZE_32", value);
			}
		}

		public static System.Int32 LZ4_64KLIMIT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_64KLIMIT"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_64KLIMIT", value);
			}
		}

		public static System.Int32 HASH_LOG
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_LOG"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_LOG", value);
			}
		}

		public static System.Int32 HASH_TABLESIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_TABLESIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_TABLESIZE", value);
			}
		}

		public static System.Int32 HASH_ADJUST
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_ADJUST"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH_ADJUST", value);
			}
		}

		public static System.Int32 HASH64K_LOG
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_LOG"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_LOG", value);
			}
		}

		public static System.Int32 HASH64K_TABLESIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_TABLESIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_TABLESIZE", value);
			}
		}

		public static System.Int32 HASH64K_ADJUST
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_ADJUST"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASH64K_ADJUST", value);
			}
		}

		public static System.Int32 HASHHC_LOG
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_LOG"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_LOG", value);
			}
		}

		public static System.Int32 HASHHC_TABLESIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_TABLESIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_TABLESIZE", value);
			}
		}

		public static System.Int32 HASHHC_ADJUST
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_ADJUST"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "HASHHC_ADJUST", value);
			}
		}

		public static int[] DECODER_TABLE_32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DECODER_TABLE_32"), typeof(int[])) is int[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DECODER_TABLE_32", value);
			}
		}

		public static int[] DECODER_TABLE_64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DECODER_TABLE_64"), typeof(int[])) is int[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DECODER_TABLE_64", value);
			}
		}

		public static int[] DEBRUIJN_TABLE_32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBRUIJN_TABLE_32"), typeof(int[])) is int[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBRUIJN_TABLE_32", value);
			}
		}

		public static int[] DEBRUIJN_TABLE_64
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBRUIJN_TABLE_64"), typeof(int[])) is int[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBRUIJN_TABLE_64", value);
			}
		}

		public static System.Int32 MAX_NB_ATTEMPTS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_NB_ATTEMPTS"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_NB_ATTEMPTS", value);
			}
		}

		public static System.Int32 OPTIMAL_ML
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "OPTIMAL_ML"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "OPTIMAL_ML", value);
			}
		}

		public static Stack<ushort[]> _ushortHashtables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_ushortHashtables"), typeof(Stack<ushort[]>)) is Stack<ushort[]> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<ushort[]>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_ushortHashtables", value);
			}
		}

		public static Stack<int[]> _intHashtables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_intHashtables"), typeof(Stack<int[]>)) is Stack<int[]> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<int[]>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_intHashtables", value);
			}
		}

		public static Stack<ushort[]> _HCushortHashtables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_HCushortHashtables"), typeof(Stack<ushort[]>)) is Stack<ushort[]> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<ushort[]>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_HCushortHashtables", value);
			}
		}

		public static Stack<int[]> _HCintHashtables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_HCintHashtables"), typeof(Stack<int[]>)) is Stack<int[]> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<int[]>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "_HCintHashtables", value);
			}
		}

		public static System.Int32 MaximumOutputLength(System.Int32 inputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "MaximumOutputLength", inputLength), typeof(System.Int32));
		}

		public static void CheckArguments(byte[] input, System.Int32 inputOffset, ref System.Int32 inputLength, byte[] output, System.Int32 outputOffset, ref System.Int32 outputLength)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "CheckArguments", out ResoniteBridge.ResoniteBridgeValue[] __outVars, input, inputOffset, inputLength, output, outputOffset, outputLength);
		}

		[Conditional("DEBUG")]
		static public void Assert(System.Boolean condition, System.String errorMessage)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Assert", condition, errorMessage);
		}

		public static void Poke2(byte[] buffer, System.Int32 offset, System.UInt16 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Poke2", buffer, offset, value);
		}

		public static System.UInt16 Peek2(byte[] buffer, System.Int32 offset)
		{
			return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Peek2", buffer, offset), typeof(System.UInt16));
		}

		public static System.UInt32 Peek4(byte[] buffer, System.Int32 offset)
		{
			return (System.UInt32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Peek4", buffer, offset), typeof(System.UInt32));
		}

		public static System.UInt32 Xor4(byte[] buffer, System.Int32 offset1, System.Int32 offset2)
		{
			return (System.UInt32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Xor4", buffer, offset1, offset2), typeof(System.UInt32));
		}

		public static System.UInt64 Xor8(byte[] buffer, System.Int32 offset1, System.Int32 offset2)
		{
			return (System.UInt64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Xor8", buffer, offset1, offset2), typeof(System.UInt64));
		}

		public static System.Boolean Equal2(byte[] buffer, System.Int32 offset1, System.Int32 offset2)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Equal2", buffer, offset1, offset2), typeof(System.Boolean));
		}

		public static System.Boolean Equal4(byte[] buffer, System.Int32 offset1, System.Int32 offset2)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Equal4", buffer, offset1, offset2), typeof(System.Boolean));
		}

		public static void Copy4(byte[] buf, System.Int32 src, System.Int32 dst)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Copy4", buf, src, dst);
		}

		public static void Copy8(byte[] buf, System.Int32 src, System.Int32 dst)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Copy8", buf, src, dst);
		}

		public static void BlockCopy(byte[] src, System.Int32 src_0, byte[] dst, System.Int32 dst_0, System.Int32 len)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "BlockCopy", src, src_0, dst, dst_0, len);
		}

		public static System.Int32 WildCopy(byte[] src, System.Int32 src_0, byte[] dst, System.Int32 dst_0, System.Int32 dst_end)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "WildCopy", src, src_0, dst, dst_0, dst_end), typeof(System.Int32));
		}

		public static System.Int32 SecureCopy(byte[] buffer, System.Int32 src, System.Int32 dst, System.Int32 dst_end)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "SecureCopy", buffer, src, dst, dst_end), typeof(System.Int32));
		}

		public static ushort[] GetUshortHashtable()
		{
			return (ushort[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUshortHashtable"), typeof(ushort[]));
		}

		public static int[] GetIntHashtable()
		{
			return (int[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "GetIntHashtable"), typeof(int[]));
		}

		public static void ReturnHashtable(ushort[] hashtable)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ReturnHashtable", hashtable);
		}

		public static void ReturnHashtable(int[] hashtable)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ReturnHashtable", hashtable);
		}

		public static System.Int32 Encode32(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode32", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] Encode32(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode32", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 Encode64(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode64", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] Encode64(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode64", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 Decode32(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength, System.Boolean knownOutputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode32", input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength), typeof(System.Int32));
		}

		public static byte[] Decode32(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, System.Int32 outputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode32", input, inputOffset, inputLength, outputLength), typeof(byte[]));
		}

		public static System.Int32 Decode64(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength, System.Boolean knownOutputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode64", input, inputOffset, inputLength, output, outputOffset, outputLength, knownOutputLength), typeof(System.Int32));
		}

		public static byte[] Decode64(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, System.Int32 outputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode64", input, inputOffset, inputLength, outputLength), typeof(byte[]));
		}

		public static ushort[] GetHCUshortHashtable()
		{
			return (ushort[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "GetHCUshortHashtable"), typeof(ushort[]));
		}

		public static int[] GetHCIntHashtable()
		{
			return (int[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "GetHCIntHashtable"), typeof(int[]));
		}

		public static void ReturnHCHashtable(ushort[] hashtable)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ReturnHCHashtable", hashtable);
		}

		public static void ReturnHCHashtable(int[] hashtable)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "ReturnHCHashtable", hashtable);
		}

		public static LZ4HC_Data_Structure LZ4HC_Create(byte[] src, System.Int32 src_0, System.Int32 src_len, byte[] dst, System.Int32 dst_0, System.Int32 dst_len)
		{
			return (LZ4HC_Data_Structure)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_Create", src, src_0, src_len, dst, dst_0, dst_len), typeof(LZ4HC_Data_Structure));
		}

		public static System.Int32 LZ4_compressHC_32(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressHC_32", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static System.Int32 Encode32HC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode32HC", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] Encode32HC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode32HC", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 LZ4_compressHC_64(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressHC_64", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static System.Int32 Encode64HC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength, byte[] output, System.Int32 outputOffset, System.Int32 outputLength)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode64HC", input, inputOffset, inputLength, output, outputOffset, outputLength), typeof(System.Int32));
		}

		public static byte[] Encode64HC(byte[] input, System.Int32 inputOffset, System.Int32 inputLength)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode64HC", input, inputOffset, inputLength), typeof(byte[]));
		}

		public static System.Int32 LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressCtx_safe32", hash_table, src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static System.Int32 LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compress64kCtx_safe32", hash_table, src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static System.Int32 LZ4_uncompress_safe32(byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 dst_len)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_uncompress_safe32", src, dst, src_0, dst_0, dst_len), typeof(System.Int32));
		}

		public static System.Int32 LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_uncompress_unknownOutputSize_safe32", src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static void LZ4HC_Insert_32(LZ4HC_Data_Structure ctx, System.Int32 src_p)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_Insert_32", ctx, src_p);
		}

		public static System.Int32 LZ4HC_CommonLength_32(LZ4HC_Data_Structure ctx, System.Int32 p1, System.Int32 p2)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_CommonLength_32", ctx, p1, p2), typeof(System.Int32));
		}

		public static System.Int32 LZ4HC_InsertAndFindBestMatch_32(LZ4HC_Data_Structure ctx, System.Int32 src_p, ref System.Int32 src_match)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_InsertAndFindBestMatch_32", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, src_match), typeof(System.Int32));
			src_match = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4HC_InsertAndGetWiderMatch_32(LZ4HC_Data_Structure ctx, System.Int32 src_p, System.Int32 startLimit, System.Int32 longest, ref System.Int32 matchpos, ref System.Int32 startpos)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_InsertAndGetWiderMatch_32", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, startLimit, longest, matchpos, startpos), typeof(System.Int32));
			matchpos = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			startpos = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4_encodeSequence_32(LZ4HC_Data_Structure ctx, ref System.Int32 src_p, ref System.Int32 dst_p, ref System.Int32 src_anchor, System.Int32 matchLength, System.Int32 src_ref, System.Int32 dst_end)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_encodeSequence_32", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, dst_p, src_anchor, matchLength, src_ref, dst_end), typeof(System.Int32));
			src_p = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			dst_p = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.Int32));
			src_anchor = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[2], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4_compressHCCtx_32(LZ4HC_Data_Structure ctx)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressHCCtx_32", ctx), typeof(System.Int32));
		}

		public static System.Int32 LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressCtx_safe64", hash_table, src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static System.Int32 LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compress64kCtx_safe64", hash_table, src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static System.Int32 LZ4_uncompress_safe64(byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 dst_len)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_uncompress_safe64", src, dst, src_0, dst_0, dst_len), typeof(System.Int32));
		}

		public static System.Int32 LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, System.Int32 src_0, System.Int32 dst_0, System.Int32 src_len, System.Int32 dst_maxlen)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_uncompress_unknownOutputSize_safe64", src, dst, src_0, dst_0, src_len, dst_maxlen), typeof(System.Int32));
		}

		public static void LZ4HC_Insert_64(LZ4HC_Data_Structure ctx, System.Int32 src_p)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_Insert_64", ctx, src_p);
		}

		public static System.Int32 LZ4HC_CommonLength_64(LZ4HC_Data_Structure ctx, System.Int32 p1, System.Int32 p2)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_CommonLength_64", ctx, p1, p2), typeof(System.Int32));
		}

		public static System.Int32 LZ4HC_InsertAndFindBestMatch_64(LZ4HC_Data_Structure ctx, System.Int32 src_p, ref System.Int32 matchpos)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_InsertAndFindBestMatch_64", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, matchpos), typeof(System.Int32));
			matchpos = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4HC_InsertAndGetWiderMatch_64(LZ4HC_Data_Structure ctx, System.Int32 src_p, System.Int32 startLimit, System.Int32 longest, ref System.Int32 matchpos, ref System.Int32 startpos)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4HC_InsertAndGetWiderMatch_64", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, startLimit, longest, matchpos, startpos), typeof(System.Int32));
			matchpos = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			startpos = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4_encodeSequence_64(LZ4HC_Data_Structure ctx, ref System.Int32 src_p, ref System.Int32 dst_p, ref System.Int32 src_anchor, System.Int32 matchLength, System.Int32 src_ref)
		{
			int __finalResult = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_encodeSequence_64", out ResoniteBridge.ResoniteBridgeValue[] __outVars, ctx, src_p, dst_p, src_anchor, matchLength, src_ref), typeof(System.Int32));
			src_p = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			dst_p = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.Int32));
			src_anchor = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[2], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 LZ4_compressHCCtx_64(LZ4HC_Data_Structure ctx)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "LZ4", "LZ4Codec", ResoniteBridge.ResoniteBridgeValueType.Type), "LZ4_compressHCCtx_64", ctx), typeof(System.Int32));
		}
	}
}
