using ResoniteBridge;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using ProtoFlux.Core;
using ProtoFlux.Runtimes.Execution;
using ProtoFlux.Runtimes.Execution.Nodes;
using ProtoFlux.Runtimes.Execution.Nodes.Casts;

namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace ProtoFlux.Runtimes.Execution
{
	public class ExecutionContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct StackFrame : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.Int32 valueBottom
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "valueBottom"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "valueBottom", value);
				}
			}

			public System.Int32 objectBottom
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "objectBottom"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "objectBottom", value);
				}
			}

			public System.UInt16 pinCount
			{
				get
				{
					return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "pinCount"), typeof(System.UInt16));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "pinCount", value);
				}
			}

			public System.UInt16 sourceFrame
			{
				get
				{
					return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "sourceFrame"), typeof(System.UInt16));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "sourceFrame", value);
				}
			}

			public System.Int32 valueStoreOffset
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "valueStoreOffset"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "valueStoreOffset", value);
				}
			}

			public System.Int32 objectStoreOffset
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "objectStoreOffset"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "objectStoreOffset", value);
				}
			}

			public IExecutionRuntime runtime
			{
				get
				{
					return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "runtime"), typeof(IExecutionRuntime));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "runtime", value);
				}
			}

			public IExecutionNestedNode nestedNode
			{
				get
				{
					return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "nestedNode"), typeof(IExecutionNestedNode));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "nestedNode", value);
				}
			}

			public ScopePoint sharedScope
			{
				get
				{
					return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "sharedScope"), typeof(ScopePoint));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "sharedScope", value);
				}
			}

			public override System.String ToString()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public StackFrame(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		public struct StackLayout : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public short[] layout
			{
				get
				{
					return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "layout"), typeof(short[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "layout", value);
				}
			}

			public System.Int16 valueSize
			{
				get
				{
					return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "valueSize"), typeof(System.Int16));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "valueSize", value);
				}
			}

			public System.Int16 objectSize
			{
				get
				{
					return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "objectSize"), typeof(System.Int16));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "objectSize", value);
				}
			}

			public override System.String ToString()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public StackLayout(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public StackLayout()
			{
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _impulseExportHandlers
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulseExportHandlers"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulseExportHandlers", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _asyncImpulseExportHandlers
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_asyncImpulseExportHandlers"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_asyncImpulseExportHandlers", value);
			}
		}

		private StackFrame[] _frames
		{
			get
			{
				return (StackFrame[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_frames"), typeof(StackFrame[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_frames", value);
			}
		}

		private System.UInt16 _allocatedFrames
		{
			get
			{
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedFrames"), typeof(System.UInt16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedFrames", value);
			}
		}

		private System.UInt16 _currentFrameIndex
		{
			get
			{
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentFrameIndex"), typeof(System.UInt16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentFrameIndex", value);
			}
		}

		internal StackLayout stackLayout
		{
			get
			{
				return (StackLayout)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackLayout"), typeof(StackLayout));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackLayout", value);
			}
		}

		private HashSet<IExecutionRuntime> onceEnteredRuntimes
		{
			get
			{
				return (HashSet<IExecutionRuntime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "onceEnteredRuntimes"), typeof(HashSet<IExecutionRuntime>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "onceEnteredRuntimes", value);
			}
		}

		public ValueStack Values
		{
			get
			{
				return (ValueStack)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Values"), typeof(ValueStack));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Values", value);
			}
		}

		public ObjectStack Objects
		{
			get
			{
				return (ObjectStack)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Objects"), typeof(ObjectStack));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Objects", value);
			}
		}

		public System.Int32 ImpulseExport
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseExport"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ImpulseExport", value);
			}
		}

		public System.Int32 CurrentFramePins
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFramePins"), typeof(System.Int32));
			}
		}

		public System.Int32 CurrentValueStoreOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentValueStoreOffset"), typeof(System.Int32));
			}
		}

		public System.Int32 CurrentObjectStoreOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentObjectStoreOffset"), typeof(System.Int32));
			}
		}

		public SharedExecutionScope SharedScope
		{
			get
			{
				return (SharedExecutionScope)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SharedScope"), typeof(SharedExecutionScope));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SharedScope", value);
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean));
			}
		}

		public System.UInt16 CurrentFrameIndex
		{
			get
			{
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFrameIndex"), typeof(System.UInt16));
			}
		}

		public System.Boolean CurrentFrameIsTop
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFrameIsTop"), typeof(System.Boolean));
			}
		}

		public System.Int32 MaxDepth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxDepth"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxDepth", value);
			}
		}

		public System.Int32 AutoYieldSafetyDepth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoYieldSafetyDepth"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoYieldSafetyDepth", value);
			}
		}

		public System.Int32 CurrentDepth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentDepth"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentDepth", value);
			}
		}

		public System.Int32 InheritedDepth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InheritedDepth"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InheritedDepth", value);
			}
		}

		public System.Boolean AbortExecution
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AbortExecution"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AbortExecution", value);
			}
		}

		public IExecutionRuntime CurrentRuntime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentRuntime"), typeof(IExecutionRuntime));
			}
		}

		public IExecutionNestedNode CurrentNestedNode
		{
			get
			{
				return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentNestedNode"), typeof(IExecutionNestedNode));
			}
		}

		public ScopePoint CurrentScope
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentScope"), typeof(ScopePoint));
			}
		}

		public IExecutionRuntime GetFrameRuntime(System.Int32 frameIndex)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameRuntime", frameIndex), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
			}
		}

		public IExecutionNestedNode GetFrameNestedNode(System.Int32 frameIndex)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameNestedNode", frameIndex), typeof(IExecutionNestedNode)) is IExecutionNestedNode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IExecutionNestedNode");
			}
		}

		public System.Int32 GetFrameSource(System.Int32 frameIndex)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameSource", frameIndex), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.String StackLayoutDebug()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StackLayoutDebug"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopInputs()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopInputs");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(System.Int32 index) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue", index), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObject", index), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(System.Int32 index, System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue", index, offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(System.Int32 index, System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObject", index, offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValueDirect<T>(System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValueDirect", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObjectDirect<T>(System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObjectDirect", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredValue<T>(System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadStoredValue", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteStoredValue<T>(System.Int32 offset, T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteStoredValue", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T AccessStoredValue<T>(System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AccessStoredValue", offset), typeof(ref T)) is ref T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ref T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredObject<T>(System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadStoredObject", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteStoredObject<T>(System.Int32 offset, T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteStoredObject", offset, value);
		}

		public void AllocateFrame(IExecutionRuntime runtime, IExecutionNestedNode nestedNode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateFrame", runtime, nestedNode);
		}

		private ref StackFrame CreateStackFrame(IExecutionRuntime runtime, IExecutionNestedNode nestedNode)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateStackFrame", runtime, nestedNode), typeof(ref StackFrame)) is ref StackFrame __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ref StackFrame");
			}
		}

		public void DeallocateFrame()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeallocateFrame");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PinFrame()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PinFrame");
		}

		public System.UInt16 ReturnToPreviousFrame()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReturnToPreviousFrame"), typeof(System.UInt16)) is System.UInt16 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ushort");
			}
		}

		public void StepIntoFrame(System.UInt16 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StepIntoFrame", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Boolean UnpinFrame()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnpinFrame"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Span<StackFrame> GetRawStackFrame()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRawStackFrame"), typeof(Span<StackFrame>)) is Span<StackFrame> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Span<StackFrame>");
			}
		}

		internal void PopToLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopToLocal", mapping);
		}

		internal void PushFromLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushFromLocal", mapping);
		}

		internal void PushImpulseExportHandler(ExecutionImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushImpulseExportHandler", handler);
		}

		internal void PushAsyncImpulseExportHandler(ExecutionAsyncImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushAsyncImpulseExportHandler", handler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PopImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PopAsyncImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopAsyncImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void InvokeImpulseExport(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeImpulseExport", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Task InvokeAsyncImpulseExport(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeAsyncImpulseExport", index), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void CaptureContextFrom(ExecutionContext source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureContextFrom", source);
		}

		public NodeContextPath CaptureContextPath()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureContextPath"), typeof(NodeContextPath)) is NodeContextPath __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeContextPath");
			}
		}

		public System.Boolean IsCurrentPath(IExecutionRuntime rootRuntime, NodeContextPath path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsCurrentPath", rootRuntime, path), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 ComputeStackDepth()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeStackDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		internal void EnterExecution()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterExecution");
		}

		internal Task TryEnterAsyncExecution()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterAsyncExecution"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		internal void ExitExecution()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitExecution");
		}

		public void InheritExecutionDepthFrom(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InheritExecutionDepthFrom", context);
		}

		public void SubtractInheritedDepth()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SubtractInheritedDepth");
		}

		public void ClearExecutionDepth()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearExecutionDepth");
		}

		private void WalkStackAndCopyTo(System.UInt16 frameIndex, ExecutionContext target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WalkStackAndCopyTo", frameIndex, target);
		}

		public System.Boolean TryEnterRuntimeOnce(IExecutionRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterRuntimeOnce", runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void ExitRuntimeOnce(IExecutionRuntime runtime)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitRuntimeOnce", runtime);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class ExecutionContextExtensions
	{
		private static NotImplementedException Exception()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Exception"), typeof(NotImplementedException)) is NotImplementedException __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NotImplementedException");
			}
		}

		public static T ReadValue<T>(this ValueArgument<T> input, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", input, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T ReadObject<T>(this ObjectArgument<T> input, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", input, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T ReadValue<T>(this IInputList list, System.Int32 index, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T ReadObject<T>(this IInputList list, System.Int32 index, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T ReadValue<T>(this ValueArgumentList<T> list, System.Int32 index, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T ReadObject<T>(this ObjectArgumentList<T> list, System.Int32 index, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this System.Int32 index, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this System.Int32 index, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", index, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValueDirect<T>(this System.Int32 offset, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValueDirect", offset, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObjectDirect<T>(this System.Int32 offset, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObjectDirect", offset, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this IInputList list, System.Int32 index, ExecutionContext context, System.Int32 listOffset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this IInputList list, System.Int32 index, ExecutionContext context, System.Int32 listOffset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context, listOffset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this ValueArgumentList<T> list, System.Int32 index, ExecutionContext context, System.Int32 listOffset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this ObjectArgumentList<T> list, System.Int32 index, ExecutionContext context, System.Int32 listOffset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context, listOffset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ValueInput<T> input, ExecutionContext context, T defaultValue = default(T)) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, context, defaultValue), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ObjectInput<T> input, ExecutionContext context, T defaultValue = default(T))
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, context, defaultValue), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ValueInputList<T> input, System.Int32 index, ExecutionContext context, T defaultValue = default(T)) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, index, context, defaultValue), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ObjectInputList<T> input, System.Int32 index, ExecutionContext context, T defaultValue = default(T))
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, index, context, defaultValue), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write<T>(this ValueOutput<T> output, T value, ExecutionContext context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", output, value, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write<T>(this ObjectOutput<T> output, T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", output, value, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Execute(this IImpulse impulse, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Execute", impulse, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Task ExecuteAsync(this IImpulse impulse, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ExecuteAsync", impulse, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Execute(this ICall call, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Execute", call, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Execute(this Call call, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Execute", call, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Task ExecuteAsync(this AsyncCall call, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ExecuteAsync", call, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public static void MoveToContext<C>(this C context, NodeContextPath previousPath, NodeContextPath nextPath) where C : ExecutionContext
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "MoveToContext", context, previousPath, nextPath);
		}
	}
	public abstract class ExtendedExecutionContext<C> : ExecutionContext, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		private ExecutionEventDispatcher<C> _eventDispatcher
		{
			get
			{
				return (ExecutionEventDispatcher<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_eventDispatcher"), typeof(ExecutionEventDispatcher<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_eventDispatcher", value);
			}
		}

		public ExecutionUpdateDispatcher<C> Updates
		{
			get
			{
				return (ExecutionUpdateDispatcher<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Updates"), typeof(ExecutionUpdateDispatcher<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Updates", value);
			}
		}

		public ExecutionChangesDispatcher<C> Changes
		{
			get
			{
				return (ExecutionChangesDispatcher<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Changes"), typeof(ExecutionChangesDispatcher<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Changes", value);
			}
		}

		public System.Int32 ScheduledEventCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledEventCount"), typeof(System.Int32));
			}
		}

		public void DispatchEvents(ExecutionRuntime<C> runtime)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchEvents", runtime);
		}

		public void SetEventDispatcher(ExecutionEventDispatcher<C> eventDispatcher)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetEventDispatcher", eventDispatcher);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class ExtendedExecutionContext : ExtendedExecutionContext<ExtendedExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExtendedExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IGlobalValue : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean IsWriteable
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsWriteable"), typeof(System.Boolean));
			}
		}

		Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
		}

		System.Object BoxedValue
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BoxedValue"), typeof(System.Object));
			}
		}
	}
	public interface IGlobalValue<T> : IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T));
			}
		}

		System.Boolean SetValue(T newValue);
	}
	public class ObjectStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private object[] stack
		{
			get
			{
				return (object[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stack"), typeof(object[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stack", value);
			}
		}

		public System.Int32 Top
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Top"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Top", value);
			}
		}

		public System.Int32 Bottom
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bottom"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bottom", value);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private System.Int32 GetBottomPosition(System.Int32 bottom, System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBottomPosition", bottom, offset), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private System.Int32 GetPosition(System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPosition", offset), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Push<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Push", obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Pop<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop"), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write<T>(System.Int32 offset, T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", offset, obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Pop(System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop", size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Store(System.Int32 size, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Store", size, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Load(System.Int32 size, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Load", size, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Allocate(System.Int32 count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Allocate", count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear(System.Int32 position, System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear", position, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void DeAllocate(System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeAllocate", size);
		}

		public void CopyBottomTo(System.Int32 sourceBottom, System.Int32 targetBottom, System.Int32 count, ObjectStack target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyBottomTo", sourceBottom, targetBottom, count, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ScopeKey : IEquatable<ScopeKey>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IExecutionRuntime runtime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtime"), typeof(IExecutionRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "runtime", value);
			}
		}

		public IExecutionNestedNode nestedNode
		{
			get
			{
				return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nestedNode"), typeof(IExecutionNestedNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nestedNode", value);
			}
		}

		public System.Boolean Equals(ScopeKey other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static bool operator ==(ScopeKey left, ScopeKey right)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeKey", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean));
		}

		public static bool operator !=(ScopeKey left, ScopeKey right)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeKey", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ScopeKey(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ScopeKey()
		{
		}
	}
	public struct NodeStoreOffsets : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 valuesOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valuesOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valuesOffset", value);
			}
		}

		public System.Int32 objectsOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectsOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectsOffset", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeStoreOffsets(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeStoreOffsets()
		{
		}
	}
	public class ScopePoint : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IGlobalValue[] _mappedGlobals
		{
			get
			{
				return (IGlobalValue[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_mappedGlobals"), typeof(IGlobalValue[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_mappedGlobals", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue nestedScopes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nestedScopes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nestedScopes", value);
			}
		}

		private Dictionary<IExecutionNode, NodeStoreOffsets> explicitNodeMap
		{
			get
			{
				return (Dictionary<IExecutionNode, NodeStoreOffsets>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "explicitNodeMap"), typeof(Dictionary<IExecutionNode, NodeStoreOffsets>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "explicitNodeMap", value);
			}
		}

		public ScopePoint Parent
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Parent"), typeof(ScopePoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Parent", value);
			}
		}

		public ScopeKey Key
		{
			get
			{
				return (ScopeKey)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Key"), typeof(ScopeKey));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Key", value);
			}
		}

		public IExecutionRuntime Runtime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(IExecutionRuntime));
			}
		}

		public IExecutionNestedNode NestedNode
		{
			get
			{
				return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedNode"), typeof(IExecutionNestedNode));
			}
		}

		public System.Boolean IsRoot
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsRoot"), typeof(System.Boolean));
			}
		}

		public System.Int32 Depth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Depth"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Depth", value);
			}
		}

		public System.Int32 NestedScopeCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedScopeCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ValuesStoreOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesStoreOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValuesStoreOffset", value);
			}
		}

		public System.Int32 ObjectsStoreOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectsStoreOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectsStoreOffset", value);
			}
		}

		public System.Boolean AreGlobalsMapped
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AreGlobalsMapped"), typeof(System.Boolean));
			}
		}

		public ScopePoint GetNestedScope(in ScopeKey key)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedScope", key), typeof(ScopePoint)) is ScopePoint __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ScopePoint");
			}
		}

		public ScopePoint AllocateScope(ScopeKey key, System.Int32 valuesStoreOffset, System.Int32 objectsStoreOffset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateScope", key, valuesStoreOffset, objectsStoreOffset), typeof(ScopePoint)) is ScopePoint __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ScopePoint");
			}
		}

		internal void MapGlobals(IGlobalValue[] globals)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobals", globals);
		}

		public T ReadGlobal<T>(GlobalRef<T> globalRef)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", globalRef), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T ReadGlobal<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", index), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean WriteGlobal<T>(GlobalRef<T> globalRef, T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteGlobal", globalRef, value), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean WriteGlobal<T>(System.Int32 index, T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteGlobal", index, value), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean HasAnyStoreDataInHierarchy()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasAnyStoreDataInHierarchy"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal void CaptureExplicitNodeMap()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureExplicitNodeMap");
		}

		internal ResoniteBridge.ResoniteBridgeValue GetStoredOffset(IExecutionNode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoredOffset", node), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeStoreOffsets?");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ScopePoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SharedExecutionScope : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.Object _lock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lock", value);
			}
		}

		private System.Int32 _allocatedValueStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedValueStoreSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedValueStoreSize", value);
			}
		}

		private System.Int32 _allocatedObjectStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedObjectStoreSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedObjectStoreSize", value);
			}
		}

		public ScopePoint RootScope
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RootScope"), typeof(ScopePoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RootScope", value);
			}
		}

		public byte[] ValuesStore
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesStore"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValuesStore", value);
			}
		}

		public object[] ObjectsStore
		{
			get
			{
				return (object[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectsStore"), typeof(object[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectsStore", value);
			}
		}

		public ScopePoint GetNestedScopeOrAllocate(ScopePoint sourcePoint, IExecutionRuntime runtime, IExecutionNestedNode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedScopeOrAllocate", sourcePoint, runtime, node), typeof(ScopePoint)) is ScopePoint __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ScopePoint");
			}
		}

		public System.Boolean HasAnyStoreDataInHierarchy()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasAnyStoreDataInHierarchy"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public SharedExecutionScope(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SharedExecutionScope()
		{
		}
	}
	public class SimpleGlobalValue<T> : IGlobalValue<T>, IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

		public System.Object BoxedValue
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BoxedValue"), typeof(System.Object));
			}
		}

		public System.Boolean IsWriteable
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsWriteable"), typeof(System.Boolean));
			}
		}

		public Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
		}

		public System.Boolean SetValue(T newValue)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", newValue), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public SimpleGlobalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private byte[] stack
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stack"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stack", value);
			}
		}

		public System.Int32 Top
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Top"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Top", value);
			}
		}

		public System.Int32 Bottom
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bottom"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bottom", value);
			}
		}

		public System.Int32 Size
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Size"), typeof(System.Int32));
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private System.Int32 GetBottomPosition(System.Int32 bottom, System.Int32 offset)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBottomPosition", bottom, offset), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Push<T>(T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Push", value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private System.Int32 GetPosition<T>(System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPosition", offset), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public unsafe T Pop<T>() where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop"), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", offset), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write<T>(System.Int32 offset, T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T Access<T>(System.Int32 offset) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", offset), typeof(ref T)) is ref T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ref T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Pop(System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop", size);
		}

		public void Store(System.Int32 size, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Store", size, offset);
		}

		public void Load(System.Int32 size, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Load", size, offset);
		}

		public void Allocate(System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Allocate", size);
		}

		public void Clear(System.Int32 position, System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear", position, size);
		}

		public void DeAllocate(System.Int32 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeAllocate", size);
		}

		public void CopyBottomTo(System.Int32 sourceBottom, System.Int32 targetBottom, System.Int32 size, ValueStack target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyBottomTo", sourceBottom, targetBottom, size, target);
		}

		public Span<byte> GetRawStack()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRawStack"), typeof(Span<byte>)) is Span<byte> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Span<byte>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IVariable<C, T> : INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		T Read(C context);

		System.Boolean Write(T value, C context);
	}
	public struct ObjectLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal System.Int32 offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ValueLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		internal System.Int32 offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		public ref T Access(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", context), typeof(ref T)) is ref T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ref T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ExecutionChangesDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private NodeGroup group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "group", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue changedNodes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "changedNodes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "changedNodes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue backBuffer
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "backBuffer"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "backBuffer", value);
			}
		}

		public System.Int32 CurrentChangedCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentChangedCount"), typeof(System.Int32));
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean));
			}
		}

		public IEnumerable<ElementPath<INode>> CurrentChangedNodes
		{
			get
			{
				return (IEnumerable<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentChangedNodes"), typeof(IEnumerable<ElementPath<INode>>));
			}
		}

		public event Action FirstChangeRegistered;

		public void AllTrackedChanged()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllTrackedChanged");
		}

		public void MarkChanged(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkChanged", node);
		}

		public void MarkChanged(INode node, NodeContextPath path)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkChanged", node, path);
		}

		public void OutputChanged(ElementPath<IOutput> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OutputChanged", node);
		}

		public void ClearChanges()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearChanges");
		}

		public System.Int32 DispatchChangeToAllListeners(ExecutionRuntime<C> runtime, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChangeToAllListeners", runtime, context), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private System.Int32 DispatchChangeToAllRecursively(ExecutionRuntime<C> runtime, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChangeToAllRecursively", runtime, context), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.Int32 DispatchChanges(ExecutionRuntime<C> runtime, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChanges", runtime, context), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionChangesDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionChangesDispatcher()
		{
		}
	}
	public delegate void NodeEventHandler<in C>(C context, System.Object eventData) where C : ExecutionContext;
	public class ExecutionEventDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private struct Event : IEquatable<Event>, IComparable<Event>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public NodeContextPath path
			{
				get
				{
					return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "path"), typeof(NodeContextPath));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "path", value);
				}
			}

			public NodeEventHandler<C> handler
			{
				get
				{
					return (NodeEventHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "handler"), typeof(NodeEventHandler<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "handler", value);
				}
			}

			public System.Object eventData
			{
				get
				{
					return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "eventData"), typeof(System.Object));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "eventData", value);
				}
			}

			public System.Int32 CompareTo(Event other)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}

			public System.Boolean Equals(Event other)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public Event(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Event()
			{
			}
		}

		private List<Event> orderedEvents
		{
			get
			{
				return (List<Event>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "orderedEvents"), typeof(List<Event>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "orderedEvents", value);
			}
		}

		private List<Event> unorderedEvents
		{
			get
			{
				return (List<Event>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "unorderedEvents"), typeof(List<Event>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "unorderedEvents", value);
			}
		}

		public System.Int32 ScheduledEventCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledEventCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ScheduledOrderedEventCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledOrderedEventCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ScheduledUnorderedEventCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledUnorderedEventCount"), typeof(System.Int32));
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean));
			}
		}

		public event Action FirstEventRegistered;

		public void ScheduleEvent(NodeContextPath path, NodeEventHandler<C> handler, System.Object eventData, System.Boolean ordered = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleEvent", path, handler, eventData, ordered);
		}

		public void ScheduleEvent(NodeContextPath path, Action<C> handler, System.Boolean ordered = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleEvent", path, handler, ordered);
		}

		public void DispatchEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchEvents", runtime, context);
		}

		public void ClearEvents()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearEvents");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionEventDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionEventDispatcher()
		{
		}
	}
	public class ExecutionUpdateDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private struct UpdateNode : IComparable<UpdateNode>, IEquatable<UpdateNode>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public NodeContextPath path
			{
				get
				{
					return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "path"), typeof(NodeContextPath));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "path", value);
				}
			}

			public IExecutionUpdateReceiver<C> receiver
			{
				get
				{
					return (IExecutionUpdateReceiver<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "receiver"), typeof(IExecutionUpdateReceiver<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "receiver", value);
				}
			}

			public System.Boolean Equals(UpdateNode other)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}

			public System.Int32 CompareTo(UpdateNode other)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}

			public override System.Int32 GetHashCode()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public UpdateNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public UpdateNode()
			{
			}
		}

		private ResoniteBridge.ResoniteBridgeValue updateBuckets
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "updateBuckets"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "updateBuckets", value);
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean));
			}
		}

		public System.Int32 UpdateBucketCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UpdateBucketCount"), typeof(System.Int32));
			}
		}

		public System.Int32 TotalUpdateNodes
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalUpdateNodes"), typeof(System.Int32));
			}
		}

		public event Action FirstNodeRegistered;

		public event Action BecameEmpty;

		public void RegisterNode(NodeContextPath path, IExecutionUpdateReceiver<C> node, System.Int32 bucket)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterNode", path, node, bucket);
		}

		public void UnregisterNode(NodeContextPath path, IExecutionUpdateReceiver<C> node, System.Int32 bucket)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterNode", path, node, bucket);
		}

		public System.Int32 UpdateAllBuckets(ExecutionRuntime<C> runtime, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateAllBuckets", runtime, context), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public void UpdateBucket(System.Int32 bucket, ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBucket", bucket, runtime, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionUpdateDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionUpdateDispatcher()
		{
		}
	}
	public interface IExecutionChangeListener<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		void Changed(C context);
	}
	public interface IExecutionUpdateReceiver<C> : INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		void Update(C context);
	}
	public interface IScopeEventListener<in C> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		void AddedToScope(C context);

		void RemovedFromScope(C context);
	}
	public class ScopeAddRemoveDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private class ScopeNode : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IScopeEventListener<C> Node
			{
				get
				{
					return (IScopeEventListener<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Node"), typeof(IScopeEventListener<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Node", value);
				}
			}

			public System.Boolean NewlyAdded
			{
				get
				{
					return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NewlyAdded"), typeof(System.Boolean));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NewlyAdded", value);
				}
			}

			public System.Boolean Exists
			{
				get
				{
					return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Exists"), typeof(System.Boolean));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Exists", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public ScopeNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ScopeNode()
			{
			}
		}

		private Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>> registeredNodes
		{
			get
			{
				return (Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "registeredNodes"), typeof(Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "registeredNodes", value);
			}
		}

		private System.Boolean _hasNewNodes
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hasNewNodes"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hasNewNodes", value);
			}
		}

		public void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateScopesAndSendRemoved", runtime, context);
		}

		private void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context, System.Boolean scanForNewNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateScopesAndSendRemoved", runtime, context, scanForNewNodes);
		}

		public void SendAllRemovedEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendAllRemovedEvents", runtime, context);
		}

		public void SendAddedEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendAddedEvents", runtime, context);
		}

		private void ProcessScope(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessScope", runtime, context);
		}

		private Dictionary<IScopeEventListener<C>, ScopeNode> EnsureScopeDictionary(NodeContextPath path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureScopeDictionary", path), typeof(Dictionary<IScopeEventListener<C>, ScopeNode>)) is Dictionary<IScopeEventListener<C>, ScopeNode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Dictionary<IScopeEventListener<C>, ScopeNode>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ScopeAddRemoveDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ScopeAddRemoveDispatcher()
		{
		}
	}
	public class ExecutionAbortedException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IExecutionRuntime Runtime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(IExecutionRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public IOperation InitialOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InitialOperation", value);
			}
		}

		public IOperation NextOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NextOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NextOperation", value);
			}
		}

		public System.Boolean IsAsyncContext
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsyncContext"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAsyncContext", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionAbortedException(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionAbortedException()
		{
		}
	}
	internal class EvaluateSequence<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public EvaluationSequence<C> Sequence
		{
			get
			{
				return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Sequence"), typeof(EvaluationSequence<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Sequence", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public EvaluateSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluateSequence()
		{
		}
	}
	internal abstract class ExecutionControlNode<C> : IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 FixedValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32));
			}
		}

		public System.Int32 InputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 OutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32));
			}
		}

		public System.Int32 OperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32));
			}
		}

		public System.String Overload
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String));
			}
		}

		public System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		public NodeMetadata Metadata
		{
			get
			{
				return (NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata));
			}
		}

		public System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public System.Int32 FixedLocalsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedValueLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedObjectLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedReferenceCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32));
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
		}

		public System.Boolean ListensToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean));
			}
		}

		public System.Int32 FixedStoresCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedValueStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedObjectStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32));
			}
		}

		public System.Boolean HasSingleContinuation
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSingleContinuation"), typeof(System.Boolean));
			}
		}

		public System.Boolean HasSyncAsyncTransition
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSyncAsyncTransition"), typeof(System.Boolean));
			}
		}

		public System.Int32 IndexInGroup
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		public System.Int32 FixedGlobalRefCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ArgumentCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32));
			}
		}

		public System.Int32 AllocationIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32));
			}
		}

		public System.Int32 ValueStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		public System.Int32 ObjectStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectStoreStartOffset", value);
			}
		}

		public abstract void Evaluate(C context);

		public IOperation GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public ExecutionOperationHandler<T> GetOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationHandler", index), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public short[] GetDefaultStackLayout()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStackLayout"), typeof(short[])) is short[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to short[]");
			}
		}

		public ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicOperationHandler", listIndex, index), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public IInputList GetInputList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputList", index), typeof(IInputList)) is IInputList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IInputList");
			}
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public System.Object GetInputDefaultValue(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputDefaultValue", index), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		public System.String GetInputName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public System.Int32 GetInputStackOffset(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputStackOffset", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public Type GetInputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public DataClass GetInputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public IOutput GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public System.String GetOutputName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public DataClass GetOutputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public System.Int32 GetValueInputSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueInputSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.Int32 GetValueOutputSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutputSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.Boolean IsImpulseImplicit(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsImpulseImplicit", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean IsInputConditional(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean IsOutputImplicit(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOutputImplicit", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public IOutputList GetOutputList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputList", index), typeof(IOutputList)) is IOutputList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutputList");
			}
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		public IImpulseList GetImpulseList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseList", index), typeof(IImpulseList)) is IImpulseList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulseList");
			}
		}

		public SyncOperationList GetOperationList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationList", index), typeof(SyncOperationList)) is SyncOperationList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SyncOperationList");
			}
		}

		public System.String GetInputListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public Type GetInputListTypeConstraint(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListTypeConstraint", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public System.String GetOutputListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String GetOperationListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public void CopyDynamicOutputLayout(INode source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyDynamicOutputLayout", source);
		}

		public void CopyDynamicOperationLayout(INode source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyDynamicOperationLayout", source);
		}

		public DataClass GetLocalDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public Type GetLocalType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public System.Int32 GetValueLocalSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueLocalSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public void SetLocalOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalOffset", index, offset);
		}

		public System.String GetImpulseListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String GetReferenceName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public Type GetReferenceType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public INode GetReferenceTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceTarget", index), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public void SetReferenceTarget(System.Int32 index, INode target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReferenceTarget", index, target);
		}

		public System.Boolean TrySetReferenceTarget(System.Int32 index, INode target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetReferenceTarget", index, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void SetInputSource(ElementRef input, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", input, source);
		}

		public void Initialize(NodeRuntime runtime, System.Int32 allocationIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", runtime, allocationIndex);
		}

		public System.Boolean IsInputListeningToChanges(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputListeningToChanges", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public CrossRuntimeInputAttribute GetInputCrossRuntime(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputCrossRuntime", index), typeof(CrossRuntimeInputAttribute)) is CrossRuntimeInputAttribute __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CrossRuntimeInputAttribute");
			}
		}

		public OutputChangeSource GetOutputChangeType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputChangeType", index), typeof(OutputChangeSource)) is OutputChangeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OutputChangeSource");
			}
		}

		public DataClass GetStoreDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public Type GetStoreType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public System.Int32 GetValueStoreSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueStoreSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public void SetStoreOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStoreOffset", index, offset);
		}

		public System.String GetImpulseName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType)) is ImpulseType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseType");
			}
		}

		public System.Boolean IsOperationAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean IsOperationListAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationListAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncOperationHandler", index), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		public AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicAsyncOperationHandler", listIndex, index), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		IOperationList INode.GetOperationList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationList", index), typeof(IOperationList)) is IOperationList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperationList");
			}
		}

		public System.String GetGlobalRefName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public Type GetGlobalRefValueType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefValueType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public Global GetGlobalRefBinding(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefBinding", index), typeof(Global)) is Global __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Global");
			}
		}

		public void SetGlobalRefBinding(System.Int32 index, Global binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public System.Boolean TrySetGlobalRefBinding(System.Int32 index, Global binding)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetGlobalRefBinding", index, binding), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public void GlobalChanged<T>(System.Int32 index, T newValue, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GlobalChanged", index, newValue, context);
		}

		public void ListGlobalChanged<T>(System.Int32 listIndex, System.Int32 index, T newValue, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListGlobalChanged", listIndex, index, newValue, context);
		}

		public System.Boolean CanOperationContinueTo(System.Int32 index, System.String impulseName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationContinueTo", index, impulseName), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean CanOperationListContinueTo(System.Int32 index, System.String impulseName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationListContinueTo", index, impulseName), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean OperationHasSingleContinuation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSingleContinuation", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean OperationHasSyncAsyncTransition(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSyncAsyncTransition", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.String GetOperationName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionControlNode()
		{
		}
	}
	internal class LoadValueFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Size
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Size"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Size", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LoadValueFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LoadValueFromLocal()
		{
		}
	}
	internal class LoadObjectFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Size
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Size"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Size", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LoadObjectFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LoadObjectFromLocal()
		{
		}
	}
	internal class PopToLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public LocalNodeData Mapping
		{
			get
			{
				return (LocalNodeData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Mapping"), typeof(LocalNodeData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Mapping", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public PopToLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PopToLocal()
		{
		}
	}
	internal class PushObject<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public T Object
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Object"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Object", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public PushObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PushObject()
		{
		}
	}
	internal class PushValue<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public PushValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PushValue()
		{
		}
	}
	public static class ExecutionHelper
	{
		private static ResoniteBridge.ResoniteBridgeValue _sizeCache
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache", value);
			}
		}

		public static System.Int32 SizeOf(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOf", type), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private unsafe static System.Int32 SizeOfGeneric<T>() where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOfGeneric"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}
	}
	[AttributeUsage(AttributeTargets.Field)]
	public class ExecutionInputAttribute : CrossRuntimeInputAttribute, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean IsValidTargetRuntime(NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidTargetRuntime", runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionInputAttribute(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class ExecutionNode<C> : Node, IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		private BindingFlags OPERATION_BIND_FLAGS
		{
			get
			{
				return (BindingFlags)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OPERATION_BIND_FLAGS"), typeof(BindingFlags));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OPERATION_BIND_FLAGS", value);
			}
		}

		private BindingFlags LOCALS_BIND_FLAGS
		{
			get
			{
				return (BindingFlags)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LOCALS_BIND_FLAGS"), typeof(BindingFlags));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LOCALS_BIND_FLAGS", value);
			}
		}

		private BindingFlags STORES_BIND_FLAGS
		{
			get
			{
				return (BindingFlags)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "STORES_BIND_FLAGS"), typeof(BindingFlags));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "STORES_BIND_FLAGS", value);
			}
		}

		private BindingFlags GLOBAL_BIND_FLAGS
		{
			get
			{
				return (BindingFlags)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "GLOBAL_BIND_FLAGS"), typeof(BindingFlags));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "GLOBAL_BIND_FLAGS", value);
			}
		}

		public abstract System.Boolean CanBeEvaluated { get; }

		public virtual System.Int32 FixedValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedLocalsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedValueLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedObjectLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedStoresCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedValueStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedObjectStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32));
			}
		}

		public System.Int32 ValueStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		public System.Int32 ObjectStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectStoreStartOffset", value);
			}
		}

		public virtual ExecutionNodeMetadata ExecutionMetadata
		{
			get
			{
				return (ExecutionNodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionMetadata"), typeof(ExecutionNodeMetadata));
			}
		}

		public abstract void Evaluate(C context);

		public virtual System.Int32 GetValueInputSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueInputSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual System.Int32 GetInputStackOffset(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputStackOffset", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual short[] GetDefaultStackLayout()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStackLayout"), typeof(short[])) is short[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to short[]");
			}
		}

		public virtual System.Int32 GetValueOutputSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutputSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual ExecutionOperationHandler<T> GetOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationHandler", index), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncOperationHandler", index), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		public virtual void GlobalChanged<T>(System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GlobalChanged", index, value, context);
		}

		public virtual void ListGlobalChanged<T>(System.Int32 listIndex, System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListGlobalChanged", listIndex, index, value, context);
		}

		private MethodInfo GetHandlerMethod(System.Int32 index, System.Boolean async)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandlerMethod", index, async), typeof(MethodInfo)) is MethodInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to MethodInfo");
			}
		}

		public virtual ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicOperationHandler", listIndex, index), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public virtual AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicAsyncOperationHandler", listIndex, index), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		public virtual DataClass GetLocalDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public virtual Type GetLocalType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual System.Int32 GetValueLocalSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueLocalSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual void SetLocalOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalOffset", index, offset);
		}

		public virtual DataClass GetStoreDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public virtual Type GetStoreType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual System.Int32 GetValueStoreSize(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueStoreSize", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual void SetStoreOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStoreOffset", index, offset);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionNode()
		{
		}
	}
	public abstract class ValueFunctionNode<C, T> : ExecutionNode<C>, IValueOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public override System.Int32 OutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32));
			}
		}

		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}

		public DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override IOutput GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public override Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public override DataClass GetOutputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public sealed override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		protected abstract T Compute(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueFunctionNode()
		{
		}
	}
	public abstract class ObjectFunctionNode<C, T> : ExecutionNode<C>, IObjectOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public override System.Int32 OutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32));
			}
		}

		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}

		public DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override IOutput GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public override Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public override DataClass GetOutputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public sealed override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		protected abstract T Compute(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectFunctionNode()
		{
		}
	}
	public abstract class VoidNode<C> : ExecutionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		protected virtual void ComputeOutputs(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public VoidNode()
		{
		}
	}
	public interface IExecutionOperationNode : ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		ExecutionOperationHandler<C> GetHandler<C>() where C : ExecutionContext;
	}
	public interface IExecutionAsyncOperationNode : IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		AsyncExecutionOperationHandler<C> GetAsyncHandler<C>() where C : ExecutionContext;
	}
	public abstract class ActionNode<C> : ExecutionNode<C>, IExecutionOperationNode, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public ExecutionOperationHandler<C> Handler
		{
			get
			{
				return (ExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(ExecutionOperationHandler<C>));
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public virtual ExecutionOperationHandler<T> GetHandler<T>() where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		protected abstract IOperation Run(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ActionNode()
		{
		}
	}
	public abstract class ActionFlowNode<C> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		protected sealed override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		protected abstract void Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ActionFlowNode()
		{
		}
	}
	public abstract class ActionBreakableFlowNode<C> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		protected sealed override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		protected abstract System.Boolean Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ActionBreakableFlowNode()
		{
		}
	}
	public abstract class AsyncActionNode<C> : ExecutionNode<C>, IExecutionAsyncOperationNode, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncHandler<T>() where T : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncHandler"), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		protected abstract Task<IOperation> RunAsync(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncActionNode()
		{
		}
	}
	public abstract class AsyncActionFlowNode<C> : AsyncActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		protected sealed override Task<IOperation> RunAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		protected abstract Task Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncActionFlowNode()
		{
		}
	}
	public abstract class AsyncActionBreakableFlowNode<C> : AsyncActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		protected sealed override Task<IOperation> RunAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		protected abstract Task<bool> Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncActionBreakableFlowNode()
		{
		}
	}
	public interface IExecutionNode : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		System.Int32 FixedValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32));
			}
		}

		System.Int32 FixedObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32));
			}
		}

		System.Int32 FixedLocalsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedValueLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32));
			}
		}

		System.Int32 FixedObjectLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32));
			}
		}

		System.Int32 FixedStoresCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedValueStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32));
			}
		}

		System.Int32 FixedObjectStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32));
			}
		}

		System.Int32 ValueStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		System.Int32 ObjectStoreStartOffset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectStoreStartOffset", value);
			}
		}

		System.Int32 GetValueInputSize(System.Int32 index);

		System.Int32 GetInputStackOffset(System.Int32 index);

		short[] GetDefaultStackLayout();

		System.Int32 GetValueOutputSize(System.Int32 index);

		System.Boolean IsOperationPassthrough(System.Int32 index);

		ExecutionOperationHandler<T> GetOperationHandler<T>(System.Int32 index) where T : ExecutionContext;

		ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext;

		AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(System.Int32 index) where T : ExecutionContext;

		AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext;

		DataClass GetLocalDataClass(System.Int32 index);

		Type GetLocalType(System.Int32 index);

		System.Int32 GetValueLocalSize(System.Int32 index);

		void SetLocalOffset(System.Int32 index, System.Int32 offset);

		DataClass GetStoreDataClass(System.Int32 index);

		Type GetStoreType(System.Int32 index);

		System.Int32 GetValueStoreSize(System.Int32 index);

		void SetStoreOffset(System.Int32 index, System.Int32 offset);
	}
	public interface IExecutionNode<in C> : IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		void Evaluate(C context);

		void GlobalChanged<T>(System.Int32 index, T value, C context);

		void ListGlobalChanged<T>(System.Int32 listIndex, System.Int32 index, T value, C context);
	}
	public interface IExecutionRuntimeInterop : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean InputNodesMustBeLocal
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputNodesMustBeLocal"), typeof(System.Boolean));
			}
		}
	}
	public struct OperationExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OperationExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OperationExecutionMetadata()
		{
		}
	}
	public struct OperationListExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo SyncMethod
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SyncMethod"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SyncMethod", value);
			}
		}

		public MethodInfo AsyncMethod
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AsyncMethod"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AsyncMethod", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OperationListExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OperationListExecutionMetadata()
		{
		}
	}
	public class ExecutionNodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 FixedInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedActionCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedActionCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedLocalsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedStoresCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicActionCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicActionCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueStackSize", value);
			}
		}

		public System.Int32 FixedObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectStackSize", value);
			}
		}

		public System.Int32 FixedValueLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueLocalsSize", value);
			}
		}

		public System.Int32 FixedObjectLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectLocalsSize", value);
			}
		}

		public System.Int32 FixedValueStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueStoresSize", value);
			}
		}

		public System.Int32 FixedObjectStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectStoresSize", value);
			}
		}

		public short[] DefaultFixedStackLayout
		{
			get
			{
				return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultFixedStackLayout"), typeof(short[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefaultFixedStackLayout", value);
			}
		}

		public List<InputExecutionMetadata> FixedInputs
		{
			get
			{
				return (List<InputExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputs"), typeof(List<InputExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedInputs", value);
			}
		}

		public List<OutputExecutionMetadata> FixedOutputs
		{
			get
			{
				return (List<OutputExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputs"), typeof(List<OutputExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedOutputs", value);
			}
		}

		public List<OperationExecutionMetadata> FixedOperations
		{
			get
			{
				return (List<OperationExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperations"), typeof(List<OperationExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedOperations", value);
			}
		}

		public List<LocalExecutionMetadata> FixedLocals
		{
			get
			{
				return (List<LocalExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocals"), typeof(List<LocalExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedLocals", value);
			}
		}

		public List<StoreExecutionMetadata> FixedStores
		{
			get
			{
				return (List<StoreExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStores"), typeof(List<StoreExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedStores", value);
			}
		}

		public List<GlobalRefExecutionMetadata> FixedGlobalRefs
		{
			get
			{
				return (List<GlobalRefExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedGlobalRefs", value);
			}
		}

		public List<OperationListExecutionMetadata> DynamicOperations
		{
			get
			{
				return (List<OperationListExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperations"), typeof(List<OperationListExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicOperations", value);
			}
		}

		public List<GlobalRefListExecutionMetadata> DynamicGlobalRefs
		{
			get
			{
				return (List<GlobalRefListExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicGlobalRefs", value);
			}
		}

		internal void GenerateDefaultStackLayout()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateDefaultStackLayout");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionNodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct GlobalRefExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRefExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRefExecutionMetadata()
		{
		}
	}
	public struct GlobalRefListExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRefListExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRefListExecutionMetadata()
		{
		}
	}
	public struct InputExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int16 size
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "size"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "size", value);
			}
		}

		public System.Int16 stackOffset
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackOffset"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackOffset", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputExecutionMetadata()
		{
		}
	}
	public struct LocalExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public FieldInfo field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "field", value);
			}
		}

		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "type", value);
			}
		}

		public DataClass dataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataClass", value);
			}
		}

		public System.Int16 valueSize
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LocalExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalExecutionMetadata()
		{
		}
	}
	public struct OutputExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int16 size
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "size"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "size", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OutputExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OutputExecutionMetadata()
		{
		}
	}
	public struct StoreExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public FieldInfo field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "field", value);
			}
		}

		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "type", value);
			}
		}

		public DataClass dataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataClass", value);
			}
		}

		public System.Int16 valueSize
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public StoreExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public StoreExecutionMetadata()
		{
		}
	}
	public delegate void ExecutionNodeOperation<T, C>(T node, C context) where T : INode where C : ExecutionContext;
	public class AsyncCallExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Task<IOperation> ExecuteAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncCallExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCallExportWrapper()
		{
		}
	}
	internal class AsyncExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public AsyncExecutionListOperationHandler<C> Handler
		{
			get
			{
				return (AsyncExecutionListOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(AsyncExecutionListOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Handler", value);
			}
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncExecutionListOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncExecutionListOperationWrapper()
		{
		}
	}
	internal class AsyncOperationSequence<C> : OperationSequence<C, IAsyncOperation, AsyncExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override System.Boolean IsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
			}
		}

		protected override AsyncExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler", operation), typeof(AsyncExecutionOperationHandler<C>)) is AsyncExecutionOperationHandler<C> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<C>");
			}
		}

		public override Task<IOperation> ExecuteAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncOperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncOperationSequence()
		{
		}
	}
	internal class EvaluationAnalysisContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private HashSet<EvaluationSequence<C>> processedSequences
		{
			get
			{
				return (HashSet<EvaluationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "processedSequences"), typeof(HashSet<EvaluationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "processedSequences", value);
			}
		}

		private HashSet<IExecutionNode<C>> globalEvaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globalEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "globalEvaluatedNodes", value);
			}
		}

		private HashSet<IExecutionNode<C>> sequenceEvaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sequenceEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sequenceEvaluatedNodes", value);
			}
		}

		private HashSet<IExecutionNode<C>> localNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localNodes", value);
			}
		}

		public ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public IEnumerable<IExecutionNode<C>> LocalNodes
		{
			get
			{
				return (IEnumerable<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalNodes"), typeof(IEnumerable<IExecutionNode<C>>));
			}
		}

		public System.Boolean BeginSequence(EvaluationSequence<C> sequence)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginSequence", sequence), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean MarkNodeEvaluated(IExecutionNode<C> node, EvaluationSequence<C> sequence, System.Boolean external)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkNodeEvaluated", node, sequence, external), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void MarkLocal(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkLocal", node);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public EvaluationAnalysisContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluationAnalysisContext()
		{
		}
	}
	internal class EvaluationBuildContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private HashSet<IExecutionNode<C>> evaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluatedNodes", value);
			}
		}

		public System.Boolean MarkEvaluated(IExecutionNode<C> node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkEvaluated", node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void ClearEvaluated()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearEvaluated");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public EvaluationBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CallExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public IOperation Execute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public CallExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CallExportWrapper()
		{
		}
	}
	public class ContinuationExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public IOperation Execute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuationExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuationExportWrapper()
		{
		}
	}
	internal struct EvaluationAction<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public IExecutionNode<C> node
		{
			get
			{
				return (IExecutionNode<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "node"), typeof(IExecutionNode<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "node", value);
			}
		}

		public ExecutionContext.StackLayout stackLayout
		{
			get
			{
				return (ExecutionContext.StackLayout)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackLayout"), typeof(ExecutionContext.StackLayout));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackLayout", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public EvaluationAction(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	internal class EvaluationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private System.Boolean isRoot
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isRoot"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isRoot", value);
			}
		}

		private HashSet<IExecutionNode<C>> rootNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "rootNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "rootNodes", value);
			}
		}

		private IExecutionNode<C> firstNode
		{
			get
			{
				return (IExecutionNode<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "firstNode"), typeof(IExecutionNode<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "firstNode", value);
			}
		}

		private List<IOutput> outputs
		{
			get
			{
				return (List<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputs"), typeof(List<IOutput>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputs", value);
			}
		}

		private List<EvaluationAction<C>> evaluationSequence
		{
			get
			{
				return (List<EvaluationAction<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluationSequence"), typeof(List<EvaluationAction<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluationSequence", value);
			}
		}

		public ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Boolean IsLocal
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLocal"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLocal", value);
			}
		}

		internal void MarkLocal()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkLocal");
		}

		internal void Analyze(EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Analyze", context);
		}

		private void AnalyzeRecursive(IExecutionNode<C> node, EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AnalyzeRecursive", node, context);
		}

		internal void Build(EvaluationBuildContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Build", context);
		}

		private System.Boolean BuildRecursive(IExecutionNode<C> node, EvaluationBuildContext<C> context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BuildRecursive", node, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal T EvaluateValue<T>(IOutput output, C context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValue", output, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		internal T EvaluateObject<T>(IOutput output, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObject", output, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		internal void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValueToStack", output, context);
		}

		internal void EvaluateObjectToStack<T>(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObjectToStack", output, context);
		}

		internal void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public System.String ToDebugString(System.String prefix = "")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToDebugString", prefix), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public EvaluationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public delegate void ExecutionGlobalRefHandler<in C, T>(T value, C context) where C : ExecutionContext;
	public delegate void ExecutionGlobalRefListHandler<in C, T>(System.Int32 index, T value, C context) where C : ExecutionContext;
	internal class ExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public ExecutionListOperationHandler<C> Handler
		{
			get
			{
				return (ExecutionListOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(ExecutionListOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Handler", value);
			}
		}

		public IOperation Execute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionListOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionListOperationWrapper()
		{
		}
	}
	public delegate IOperation ExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate IOperation ExecutionListOperationHandler<in C>(C context, System.Int32 index) where C : ExecutionContext;
	public delegate Task<IOperation> AsyncExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate Task<IOperation> AsyncExecutionListOperationHandler<in C>(C context, System.Int32 index) where C : ExecutionContext;
	public delegate void ExecutionImpulseExportHandler(ExecutionContext context, System.Int32 index);
	public delegate Task ExecutionAsyncImpulseExportHandler(ExecutionContext context, System.Int32 index);
	public delegate void VoidExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate Task AsyncVoidExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public class VoidExecutionOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public VoidExecutionOperationHandler<C> handler
		{
			get
			{
				return (VoidExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "handler"), typeof(VoidExecutionOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "handler", value);
			}
		}

		public IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public VoidExecutionOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public VoidExecutionOperationWrapper()
		{
		}
	}
	public class AsyncVoidExecutionOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public AsyncVoidExecutionOperationHandler<C> handler
		{
			get
			{
				return (AsyncVoidExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "handler"), typeof(AsyncVoidExecutionOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "handler", value);
			}
		}

		public Task<IOperation> RunAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncVoidExecutionOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncVoidExecutionOperationWrapper()
		{
		}
	}
	public interface IExecutionRuntime : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean RequiresScopeData
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresScopeData"), typeof(System.Boolean));
			}
		}

		System.Int32 ValueStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreSize"), typeof(System.Int32));
			}
		}

		System.Int32 ObjectStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreSize"), typeof(System.Int32));
			}
		}

		System.Int32 TotalValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalValueStackSize"), typeof(System.Int32));
			}
		}

		System.Int32 TotalObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalObjectStackSize"), typeof(System.Int32));
			}
		}

		IEnumerable<IExecutionNode> Nodes
		{
			get
			{
				return (IEnumerable<IExecutionNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<IExecutionNode>));
			}
		}

		T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : unmanaged;

		T EvaluateObject<T>(IOutput output, ExecutionContext context);

		void SetValue<T>(IOutput output, T value, ExecutionContext context) where T : unmanaged;

		void SetObject<T>(IOutput output, T value, ExecutionContext context);

		void Execute(ISyncOperation action, ExecutionContext context);

		Task ExecuteAsync(IOperation action, ExecutionContext context);

		System.String GetEvaluationSequenceDebug(IOutput output);
	}
	public class ExecutionRuntime<C> : NodeRuntime<IExecutionNode<C>>, IExecutionRuntime, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private EvaluationSequence<C> _exportsEvaluationSequence
		{
			get
			{
				return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_exportsEvaluationSequence"), typeof(EvaluationSequence<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_exportsEvaluationSequence", value);
			}
		}

		private Dictionary<IExecutionNode<C>, EvaluationSequence<C>> evaluationSequences
		{
			get
			{
				return (Dictionary<IExecutionNode<C>, EvaluationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluationSequences"), typeof(Dictionary<IExecutionNode<C>, EvaluationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluationSequences", value);
			}
		}

		private List<int> importsMapping
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "importsMapping"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "importsMapping", value);
			}
		}

		private Dictionary<IOutput, int> localValueMapping
		{
			get
			{
				return (Dictionary<IOutput, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localValueMapping"), typeof(Dictionary<IOutput, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localValueMapping", value);
			}
		}

		private Dictionary<IExecutionNode<C>, LocalNodeData> localNodes
		{
			get
			{
				return (Dictionary<IExecutionNode<C>, LocalNodeData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localNodes"), typeof(Dictionary<IExecutionNode<C>, LocalNodeData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localNodes", value);
			}
		}

		private Dictionary<IOperation, IOperationSequence<C>> operationSequences
		{
			get
			{
				return (Dictionary<IOperation, IOperationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "operationSequences"), typeof(Dictionary<IOperation, IOperationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "operationSequences", value);
			}
		}

		private System.Int32 _evaluationFlagsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_evaluationFlagsSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_evaluationFlagsSize", value);
			}
		}

		private System.Int32 _localValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localValueStackSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localValueStackSize", value);
			}
		}

		private System.Int32 _localObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localObjectStackSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localObjectStackSize", value);
			}
		}

		private System.Int32 _valueLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_valueLocalsSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_valueLocalsSize", value);
			}
		}

		private System.Int32 _objectLocalsSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_objectLocalsSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_objectLocalsSize", value);
			}
		}

		private System.Boolean _requiresScopeData
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_requiresScopeData"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_requiresScopeData", value);
			}
		}

		private System.Int32 _valueStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_valueStoresSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_valueStoresSize", value);
			}
		}

		private System.Int32 _objectStoresSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_objectStoresSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_objectStoresSize", value);
			}
		}

		public System.Boolean RequiresScopeData
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresScopeData"), typeof(System.Boolean));
			}
		}

		public System.Int32 ValueStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreSize"), typeof(System.Int32));
			}
		}

		public System.Int32 ObjectStoreSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreSize"), typeof(System.Int32));
			}
		}

		public System.Int32 TotalValueStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalValueStackSize"), typeof(System.Int32));
			}
		}

		public System.Int32 TotalObjectStackSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalObjectStackSize"), typeof(System.Int32));
			}
		}

		IEnumerable<IExecutionNode> IExecutionRuntime.Nodes
		{
			get
			{
				return (IEnumerable<IExecutionNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<IExecutionNode>));
			}
		}

		public override Type GetCompatibleNodeType(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValue", output, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T EvaluateObject<T>(IOutput output, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObject", output, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		internal void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValueToStack", output, context);
		}

		internal void EvaluateObjectToStack<T>(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObjectToStack", output, context);
		}

		public void SetValue<T>(IOutput output, T value, ExecutionContext context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", output, value, context);
		}

		public void SetObject<T>(IOutput output, T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetObject", output, value, context);
		}

		public void Execute(ISyncOperation action, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", action, context);
		}

		public Task ExecuteAsync(IOperation operation, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", operation, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void Rebuild()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Rebuild");
		}

		private void MapLocalNode(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapLocalNode", node);
		}

		internal EvaluationSequence<C> EnsureSequence(IExecutionNode<C> node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureSequence", node), typeof(EvaluationSequence<C>)) is EvaluationSequence<C> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to EvaluationSequence<C>");
			}
		}

		internal EvaluationSequence<C> GetSequence(IExecutionNode<C> node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSequence", node), typeof(EvaluationSequence<C>)) is EvaluationSequence<C> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to EvaluationSequence<C>");
			}
		}

		internal System.Boolean IsLocalNode(IExecutionNode<C> node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsLocalNode", node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal System.Int32 GetLocalValueMapping(IOutput output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalValueMapping", output), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		internal LocalNodeData GetStaticNodeMapping(IExecutionNode<C> node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStaticNodeMapping", node), typeof(LocalNodeData)) is LocalNodeData __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to LocalNodeData");
			}
		}

		internal void MapSequence(IOperation alias, IOperation existing)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapSequence", alias, existing);
		}

		internal void SetNullSequence(IOperation alias)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetNullSequence", alias);
		}

		public System.Boolean IsEvaluationDirty(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsEvaluationDirty", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void MarkEvaluationDirty(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkEvaluationDirty", context);
		}

		public System.Boolean IsEvaluated(IExecutionNode<C> node, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsEvaluated", node, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void MarkEvaluated(IExecutionNode<C> node, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkEvaluated", node, context);
		}

		public void EnsureEvaluated(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureEvaluated", output, context);
		}

		public void ExecuteImpulseImport(System.Int32 index, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteImpulseImport", index, context);
		}

		public Task ExecuteAsyncImpulseImport(System.Int32 index, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncImpulseImport", index, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void ExecuteSequence(ISyncOperation operation, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSequence", operation, context);
		}

		public Task ExecuteAsyncSequence(IOperation operation, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncSequence", operation, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void ExecuteResumption(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteResumption", resumption, context);
		}

		public Task ExecuteAsyncResumption(AsyncResumption resumption, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncResumption", resumption, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		internal void ResumeExecution(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeExecution", resumption, context);
		}

		internal Task ResumeAsyncExecution(AsyncResumption resumption, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void SetValueImport<T>(System.Int32 index, T value, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValueImport", index, value, context);
		}

		public void SetObjectImport<T>(System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetObjectImport", index, value, context);
		}

		public void SetValueImport<T>(IOutput output, T value, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValueImport", output, value, context);
		}

		public void SetObjectImport<T>(IOutput output, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetObjectImport", output, value, context);
		}

		public void BeginStackFrame(C context, IExecutionNestedNode nestedNode = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginStackFrame", context, nestedNode);
		}

		public void PinStackFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PinStackFrame", context);
		}

		public System.Boolean ExitStackFrame(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitStackFrame", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal void ClearValueLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearValueLocals", context);
		}

		internal void ClearObjectLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearObjectLocals", context);
		}

		internal void ClearEvaluatedFlags(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearEvaluatedFlags", context);
		}

		public void RunEvaluation(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunEvaluation", context);
		}

		public void EndStackFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EndStackFrame", context);
		}

		internal void InvokeImpulseExport(C context, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeImpulseExport", context, index);
		}

		public System.Int32 GetOperationSequenceSteps(IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationSequenceSteps", operation), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.String GetEvaluationSequenceDebug(IOutput output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEvaluationSequenceDebug", output), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Int32 DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, System.Boolean cache = true, HashSet<NodeRuntime> walkedRuntimes = null) where T : INode
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public void MapGlobals(IGlobalValue[] globals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobals", globals, context);
		}

		public void UpdateGlobal<T>(Global<T> global, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGlobal", global, value, context);
		}

		public void UpdateGlobalsToInitialValue(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGlobalsToInitialValue", context);
		}

		public void ResetGlobalsToDefault(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetGlobalsToDefault", context);
		}

		internal void MapGlobalsInternal(IGlobalValue[] globals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobalsInternal", globals, context);
		}

		public System.Int32 RestoreSharedScope(ScopePoint rootScope, C context, byte[] values, object[] objects)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RestoreSharedScope", rootScope, context, values, objects), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private System.Int32 RestoreSharedScopeInternal(ScopePoint point, C context, byte[] values, object[] objects)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RestoreSharedScopeInternal", point, context, values, objects), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExecutionRuntime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class ImpulseExportWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Boolean IsLast
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLast"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLast", value);
			}
		}

		protected System.Boolean ShouldBeContinuation(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldBeContinuation", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	internal struct LocalNodeData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "index", value);
			}
		}

		public System.Boolean isImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isImplicit"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isImplicit", value);
			}
		}

		public System.Int32 valueStart
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueStart"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueStart", value);
			}
		}

		public System.Int32 valueSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		public System.Int32 objectStart
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectStart"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectStart", value);
			}
		}

		public System.Int32 objectSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectSize", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LocalNodeData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalNodeData()
		{
		}
	}
	internal interface IOperationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
		}

		System.Boolean IsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
			}
		}

		System.Int32 SequenceSteps
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SequenceSteps"), typeof(System.Int32));
			}
		}

		void Build();

		IOperation ExecuteSync(C context);

		Task<IOperation> ExecuteAsync(C context);
	}
	internal abstract class OperationSequence<C, O, H> : IOperationSequence<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where O : class, IOperation where H : Delegate
	{
		private O origin
		{
			get
			{
				return (O)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "origin"), typeof(O));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "origin", value);
			}
		}

		public ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Int32 SequenceSteps
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SequenceSteps"), typeof(System.Int32));
			}
		}

		protected List<H> operationSequence
		{
			get
			{
				return (List<H>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "operationSequence"), typeof(List<H>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "operationSequence", value);
			}
		}

		public abstract System.Boolean IsAsync { get; }

		void IOperationSequence<C>.Build()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Build");
		}

		internal void StitchSequence(Node node, IOperation initialOperationSkip)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StitchSequence", node, initialOperationSkip);
		}

		protected virtual System.Boolean IsSupported(IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsSupported", operation), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		protected abstract H GetHandler(IOperation operation);

		public virtual IOperation ExecuteSync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSync", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public virtual Task<IOperation> ExecuteAsync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	internal class SyncOperationSequence<C> : OperationSequence<C, ISyncOperation, ExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override System.Boolean IsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
			}
		}

		protected override ExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler", operation), typeof(ExecutionOperationHandler<C>)) is ExecutionOperationHandler<C> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<C>");
			}
		}

		public override IOperation ExecuteSync(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSync", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public SyncOperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SyncOperationSequence()
		{
		}
	}
	public interface IExecutionNestedNode : INestedNode, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IExecutionRuntime TargetRuntime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(IExecutionRuntime));
			}
		}

		IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context);

		Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context);
	}
	[NodeOverload("Core.Nest")]
	public class NestedNode<C> : VoidNode<C>, IExecutionNestedNode, INestedNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private abstract class InputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(ArgumentList inputList, IOutput output);

			public abstract void SetImport(System.Int32 index, ExecutionRuntime<C> group, C context, System.Int32 valueOffset, System.Int32 objectOffset);

			public abstract void EvaluateInput(ExecutionRuntime<C> group, C context);

			public abstract void SetFromStack(System.Int32 index, ExecutionRuntime<C> group, C context);

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public InputMapping()
			{
			}
		}

		private abstract class OutputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(OutputList outputList, IOutput output);

			public abstract void ExtractExport(System.Int32 index, ExecutionRuntime<C> runtime, C context);

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public OutputMapping()
			{
			}
		}

		private abstract class InputMapping<T> : InputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public InputMapping()
			{
			}
		}

		private abstract class OutputMapping<T> : OutputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public OutputMapping()
			{
			}
		}

		private class ValueInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			private IInput<T> input
			{
				get
				{
					return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "input"), typeof(IInput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "input", value);
				}
			}

			private ValueOutput<T> import
			{
				get
				{
					return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "import"), typeof(ValueOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "import", value);
				}
			}

			public override void Map(ArgumentList inputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Map", inputList, output);
			}

			public override void SetImport(System.Int32 index, ExecutionRuntime<C> group, C context, System.Int32 valueOffset, System.Int32 objectOffset)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImport", index, group, context, valueOffset, objectOffset);
			}

			public override void EvaluateInput(ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateInput", group, context);
			}

			public override void SetFromStack(System.Int32 index, ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetFromStack", index, group, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public ValueInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private class ObjectInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private IInput<T> input
			{
				get
				{
					return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "input"), typeof(IInput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "input", value);
				}
			}

			private ObjectOutput<T> import
			{
				get
				{
					return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "import"), typeof(ObjectOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "import", value);
				}
			}

			public override void Map(ArgumentList inputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Map", inputList, output);
			}

			public override void SetImport(System.Int32 index, ExecutionRuntime<C> group, C context, System.Int32 valueOffset, System.Int32 objectOffset)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImport", index, group, context, valueOffset, objectOffset);
			}

			public override void EvaluateInput(ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateInput", group, context);
			}

			public override void SetFromStack(System.Int32 index, ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetFromStack", index, group, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public ObjectInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private class ValueOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			private ValueOutput<T> output
			{
				get
				{
					return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "output"), typeof(ValueOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "output", value);
				}
			}

			private IOutput export
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "export"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "export", value);
				}
			}

			public override void Map(OutputList outputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Map", outputList, output);
			}

			public override void ExtractExport(System.Int32 index, ExecutionRuntime<C> runtime, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractExport", index, runtime, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public ValueOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private class ObjectOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ObjectOutput<T> output
			{
				get
				{
					return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "output"), typeof(ObjectOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "output", value);
				}
			}

			private IOutput export
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "export"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "export", value);
				}
			}

			public override void Map(OutputList outputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Map", outputList, output);
			}

			public override void ExtractExport(System.Int32 index, ExecutionRuntime<C> runtime, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractExport", index, runtime, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public ObjectOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private static Type _valueInputMapping
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueInputMapping"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueInputMapping", value);
			}
		}

		private static Type _objectInputMapping
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectInputMapping"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectInputMapping", value);
			}
		}

		private static Type _valueOutputMapping
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueOutputMapping"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueOutputMapping", value);
			}
		}

		private static Type _objectOutputMapping
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectOutputMapping"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectOutputMapping", value);
			}
		}

		public ExecutionRuntime<C> Target
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		public ArgumentList Inputs
		{
			get
			{
				return (ArgumentList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ArgumentList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Inputs", value);
			}
		}

		public OutputList Outputs
		{
			get
			{
				return (OutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Outputs"), typeof(OutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Outputs", value);
			}
		}

		public MixedOperationList Operations
		{
			get
			{
				return (MixedOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operations"), typeof(MixedOperationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Operations", value);
			}
		}

		public CallList Impulses
		{
			get
			{
				return (CallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Impulses"), typeof(CallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Impulses", value);
			}
		}

		public GlobalRefList GlobalRefs
		{
			get
			{
				return (GlobalRefList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "GlobalRefs"), typeof(GlobalRefList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "GlobalRefs", value);
			}
		}

		private List<InputMapping> _inputMappings
		{
			get
			{
				return (List<InputMapping>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputMappings"), typeof(List<InputMapping>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputMappings", value);
			}
		}

		private List<OutputMapping> _outputMappings
		{
			get
			{
				return (List<OutputMapping>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputMappings"), typeof(List<OutputMapping>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputMappings", value);
			}
		}

		NodeGroup INestedNode.TargetGroup
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetGroup"), typeof(NodeGroup));
			}
		}

		NodeRuntime INestedNode.TargetRuntime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(NodeRuntime));
			}
		}

		IExecutionRuntime IExecutionNestedNode.TargetRuntime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(IExecutionRuntime));
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public override System.Boolean IsInputConditional(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public IOutput GetTargetExport(IOutput output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetTargetExport", output), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public IOutput GetImportSource(IOutput import)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportSource", import), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public void MapTarget()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapTarget");
		}

		internal void EnterTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterTargetFrame", context);
		}

		internal void ExitTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitTargetFrame", context);
		}

		protected IOperation DoOperations(C context, System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperations", context, index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		protected Task<IOperation> DoOperationsAsync(C context, System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperationsAsync", context, index), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private void OnGlobalRefsChanged<T>(System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalRefsChanged", index, value, context);
		}

		internal void MapGlobals(IGlobalValue[] scopeGlobals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobals", scopeGlobals, context);
		}

		private IOperation FinishOperations(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishOperations", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeExecution", resumption, context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		internal System.Int32 DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, System.Boolean cache, HashSet<NodeRuntime> walkedRuntimes) where T : INode
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private void OnImpulseExport(ExecutionContext context, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnImpulseExport", context, index);
		}

		protected override void ComputeOutputs(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private void EnterNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterNestedFrame", context);
		}

		private void FinishNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishNestedFrame", context);
		}

		private void ExtractExports(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractExports", context);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NestedNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NestedNode()
		{
		}
	}
	public static class NestedNodeHelper
	{
		public static NestedNode<C> AddNestedNode<C>(this ExecutionRuntime<C> runtime, ExecutionRuntime<C> target) where C : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddNestedNode", runtime, target), typeof(NestedNode<C>)) is NestedNode<C> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NestedNode<C>");
			}
		}
	}
}
namespace ProtoFlux.Runtimes.Execution.Nodes
{
	[NodeCategory("Flow")]
	[NodeName("Time Delay", false)]
	[NodeOverload("Core.Delay")]
	public abstract class DelayTime : AsyncActionFlowNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AsyncCall OnTriggered
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		protected virtual void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		protected abstract TimeSpan GetDuration(ExecutionContext context);

		protected override Task Do(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Do", context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayTime()
		{
		}
	}
	[NodeName("Delay", false)]
	public class DelayTimeSpan : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsInt : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelaySecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsFloat : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelaySecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsDouble : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelaySecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeName("Time Delay with Data", false)]
	[NodeOverload("Core.DelayWithData")]
	public abstract class DelayTimeWithValue<T> : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ValueOutput<T> DelayedValue
		{
			get
			{
				return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DelayedValue"), typeof(ValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DelayedValue", value);
			}
		}

		protected override void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class DelayWithValueTimeSpan<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithValueTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithValueSecondsInt<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithValueSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithValueSecondsFloat<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithValueSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithValueSecondsDouble<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithValueSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeName("Time Delay with Data", false)]
	[NodeOverload("Core.DelayWithData")]
	public abstract class DelayTimeWithObject<T> : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ObjectOutput<T> DelayedValue
		{
			get
			{
				return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DelayedValue"), typeof(ObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DelayedValue", value);
			}
		}

		protected override void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class DelayWithObjectTimeSpan<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithObjectTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithObjectSecondsInt<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithObjectSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithObjectSecondsFloat<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithObjectSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithObjectSecondsDouble<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan)) is TimeSpan __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DelayWithObjectSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Box")]
	public class Box<T> : ObjectFunctionNode<ExecutionContext, object>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> Input
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		protected override System.Object Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Box(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Constant")]
	public class ValueConstant<T> : ValueFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Constant")]
	public class ObjectConstant<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class ConstantHelper
	{
		public static ValueConstant<T> AddValueConstant<T>(this ExecutionRuntime<ExecutionContext> runtime, T value) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddValueConstant", runtime, value), typeof(ValueConstant<T>)) is ValueConstant<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueConstant<T>");
			}
		}

		public static ObjectConstant<T> AddObjectConstant<T>(this ExecutionRuntime<ExecutionContext> runtime, T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddObjectConstant", runtime, value), typeof(ObjectConstant<T>)) is ObjectConstant<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ObjectConstant<T>");
			}
		}

		public static ValueConstant<T> AddValueConstant<C, T>(this ExecutionRuntime<C> runtime, T value) where C : ExecutionContext where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddValueConstant", runtime, value), typeof(ValueConstant<T>)) is ValueConstant<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueConstant<T>");
			}
		}

		public static ObjectConstant<T> AddObjectConstant<C, T>(this ExecutionRuntime<C> runtime, T value) where C : ExecutionContext
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddObjectConstant", runtime, value), typeof(ObjectConstant<T>)) is ObjectConstant<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ObjectConstant<T>");
			}
		}
	}
	[NodeCategory("Utility")]
	[NodeName("Continuous Relay", false)]
	[ContinuouslyChanging]
	[NodeOverload("Core.ContinuouslyChangingRelay")]
	[OldNodeName("ContinouslyChangingValueRelay")]
	public class ContinuouslyChangingValueRelay<T> : ValueFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> Input
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuouslyChangingValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Utility")]
	[NodeName("Continuous Relay", false)]
	[ContinuouslyChanging]
	[NodeOverload("Core.ContinuouslyChangingRelay")]
	[OldNodeName("ContinouslyChangingObjectRelay")]
	public class ContinuouslyChangingObjectRelay<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<T> Input
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuouslyChangingObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Utility")]
	[NodeOverload("Core.Demultiplex")]
	public class ValueDemultiplex<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> Value
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ValueArgument<T> DefaultValue
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public ValueOutputList<T> ValueOutputs
		{
			get
			{
				return (ValueOutputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ValueOutputs"), typeof(ValueOutputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ValueOutputs", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueDemultiplex()
		{
		}
	}
	[NodeCategory("Utility")]
	[NodeOverload("Core.Demultiplex")]
	public class ObjectDemultiplex<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<T> Value
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ObjectArgument<T> DefaultValue
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public ObjectOutputList<T> ValueOutputs
		{
			get
			{
				return (ObjectOutputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ValueOutputs"), typeof(ObjectOutputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ValueOutputs", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectDemultiplex()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Eval Point", false)]
	[NodeOverload("Core.EvaluationPoint")]
	public class ValueEvaluationPoint<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<T> Input
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Eval Point", false)]
	[NodeOverload("Core.EvaluationPoint")]
	public class ObjectEvaluationPoint<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectInput<T> Input
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public delegate void DisplayHandler<C, T>(T value, C context);
	public delegate void ImpulseDisplayHandler<C>(C context);
	[NodeCategory("Core")]
	[NodeName("Display", false)]
	[NodeOverload("Core.Display")]
	public class ExternalValueDisplay<C, T> : VoidNode<C>, IExecutionChangeListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C> where T : struct
	{
		public ValueInput<T> Input
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public DisplayHandler<C, T> OnDisplay
		{
			get
			{
				return (DisplayHandler<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnDisplay", value);
			}
		}

		public System.Boolean InputListensToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputListensToChanges"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Changed", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalValueDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Display", false)]
	[NodeOverload("Core.Display")]
	public class ExternalObjectDisplay<C, T> : VoidNode<C>, IExecutionChangeListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		public ObjectInput<T> Input
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public DisplayHandler<C, T> OnDisplay
		{
			get
			{
				return (DisplayHandler<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnDisplay", value);
			}
		}

		public System.Boolean InputListensToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputListensToChanges"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Changed", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalObjectDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Pulse Display", false)]
	public class ExternalImpulseDisplay<C> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public ImpulseDisplayHandler<C> OnPulsed
		{
			get
			{
				return (ImpulseDisplayHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnPulsed"), typeof(ImpulseDisplayHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnPulsed", value);
			}
		}

		protected override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ExternalImpulseDisplay : ExternalImpulseDisplay<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Input", false)]
	[ChangeSource]
	[NodeOverload("Core.Input")]
	public class ExternalValueInput<C, T> : ValueFunctionNode<C, T>, IScopeEventListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C> where T : struct
	{
		private Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> _changeListeners
		{
			get
			{
				return (Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_changeListeners", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

		public void AddedToScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddedToScope", context);
		}

		public void RemovedFromScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemovedFromScope", context);
		}

		public void SetValue(T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value);
		}

		protected override T Compute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Input", false)]
	[ChangeSource]
	[NodeOverload("Core.Input")]
	public class ExternalObjectInput<C, T> : ObjectFunctionNode<C, T>, IScopeEventListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		private Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> _changeListeners
		{
			get
			{
				return (Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_changeListeners", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

		public void AddedToScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddedToScope", context);
		}

		public void RemovedFromScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemovedFromScope", context);
		}

		public void SetValue(T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value);
		}

		protected override T Compute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("FilterInput", false)]
	[ChangeSource]
	[NodeOverload("Core.FilterInput")]
	public class ExternalValueInputWithFilter<C, T> : ExternalValueInput<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C> where T : struct
	{
		public Func<T, T> Filter
		{
			get
			{
				return (Func<T, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Filter"), typeof(Func<T, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Filter", value);
			}
		}

		protected override T Compute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalValueInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("FilterInput", false)]
	[ChangeSource]
	[NodeOverload("Core.FilterInput")]
	public class ExternalObjectInputWithFilter<C, T> : ExternalObjectInput<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		public Func<T, T> Filter
		{
			get
			{
				return (Func<T, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Filter"), typeof(Func<T, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Filter", value);
			}
		}

		protected override T Compute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalObjectInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Call", false)]
	public class ExternalCall<C> : VoidNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Call Target
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		public void Execute(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Async Call", false)]
	public class ExternalAsyncCall<C> : VoidNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public AsyncCall Target
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		public Task Execute(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ExternalAsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Flow/Async")]
	[NodeName("Async For", false)]
	public class AsyncFor : AsyncActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Count
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Count"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Count", value);
			}
		}

		public ValueInput<bool> Reverse
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reverse"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reverse", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Iteration
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Iteration"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Iteration", value);
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncFor(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncFor()
		{
		}
	}
	[NodeCategory("Flow/Async")]
	[NodeName("Async Range Loop", false)]
	[NodeOverload("Core.AsyncRangeLoop")]
	public class AsyncRangeLoopInt : AsyncActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Start
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Start"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Start", value);
			}
		}

		public ValueInput<int> End
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "End"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "End", value);
			}
		}

		public ValueInput<int> StepSize
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "StepSize"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "StepSize", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Current
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Current"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Current", value);
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncRangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncRangeLoopInt()
		{
		}
	}
	[NodeCategory("Flow/Async")]
	[NodeName("Async Sequence", false)]
	public class AsyncSequence : AsyncActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AsyncCallList Calls
		{
			get
			{
				return (AsyncCallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Calls"), typeof(AsyncCallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Calls", value);
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncSequence()
		{
		}
	}
	[NodeCategory("Flow/Async")]
	[NodeName("Async While", false)]
	public class AsyncWhile : AsyncActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncWhile(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Flow")]
	[NodeName("For", false)]
	public class For : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Count
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Count"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Count", value);
			}
		}

		public ValueInput<bool> Reverse
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reverse"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reverse", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Iteration
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Iteration"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Iteration", value);
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public For(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public For()
		{
		}
	}
	[NodeCategory("Flow")]
	[NodeName("If", false)]
	public class If : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Continuation OnTrue
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTrue", value);
			}
		}

		public Continuation OnFalse
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFalse", value);
			}
		}

		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public If(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Flow")]
	public class ImpulseDemultiplexer : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SyncOperationList Operations
		{
			get
			{
				return (SyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operations"), typeof(SyncOperationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Operations", value);
			}
		}

		public Continuation OnTriggered
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		public ValueOutput<int> Index
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		public IOperation DoOperations(ExecutionContext context, System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperations", context, index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseDemultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseDemultiplexer()
		{
		}
	}
	[NodeCategory("Flow")]
	[NodeName("Multiplex", false)]
	public class ImpulseMultiplexer : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Index
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public ContinuationList Impulses
		{
			get
			{
				return (ContinuationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Impulses"), typeof(ContinuationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Impulses", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseMultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseMultiplexer()
		{
		}
	}
	[NodeCategory("Flow")]
	[NodeName("Range Loop", false)]
	[NodeOverload("Core.RangeLoop")]
	public class RangeLoopInt : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Start
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Start"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Start", value);
			}
		}

		public ValueInput<int> End
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "End"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "End", value);
			}
		}

		public ValueInput<int> StepSize
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "StepSize"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "StepSize", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Current
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Current"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Current", value);
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean));
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public RangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RangeLoopInt()
		{
		}
	}
	[NodeCategory("Flow")]
	[NodeName("Sequence", false)]
	public class Sequence : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public CallList Calls
		{
			get
			{
				return (CallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Calls"), typeof(CallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Calls", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Sequence()
		{
		}
	}
	[NodeCategory("Flow")]
	[NodeName("While", false)]
	public class While : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public While(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Utility")]
	[NodeName("Get Type", false)]
	public class GetType : ObjectFunctionNode<ExecutionContext, Type>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<object> Object
		{
			get
			{
				return (ObjectArgument<object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Object"), typeof(ObjectArgument<object>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Object", value);
			}
		}

		protected override Type Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GetType(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Global To Output", false)]
	[NodeOverload("Core.GlobalToOutput")]
	public class GlobalToValueOutput<T> : ValueFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public GlobalRef<T> Global
		{
			get
			{
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalToValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalToValueOutput()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Global To Output", false)]
	[NodeOverload("Core.GlobalToOutput")]
	public class GlobalToObjectOutput<T> : ObjectFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlobalRef<T> Global
		{
			get
			{
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalToObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalToObjectOutput()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Link", false)]
	public class Link : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Reference<INode> A
		{
			get
			{
				return (Reference<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(Reference<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public Reference<INode> B
		{
			get
			{
				return (Reference<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(Reference<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Link(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Local")]
	public class LocalValue<T> : ValueFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ValueLocal<T> _data
		{
			get
			{
				return (ValueLocal<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ValueLocal<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LocalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Local")]
	public class LocalObject<T> : ObjectFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ObjectLocal<T> _data
		{
			get
			{
				return (ObjectLocal<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ObjectLocal<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public LocalObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Utility")]
	[NodeOverload("Core.Multiplex")]
	public class ValueMultiplex<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInputList<T> Inputs
		{
			get
			{
				return (ValueInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ValueInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Inputs", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public ValueOutput<T> Output
		{
			get
			{
				return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public new ValueOutput<int> InputCount
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InputCount"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "InputCount", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueMultiplex()
		{
		}
	}
	[NodeCategory("Utility")]
	[NodeOverload("Core.Multiplex")]
	public class ObjectMultiplex<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectInputList<T> Inputs
		{
			get
			{
				return (ObjectInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ObjectInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Inputs", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Index", value);
			}
		}

		public ObjectOutput<T> Output
		{
			get
			{
				return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public new ValueOutput<int> InputCount
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InputCount"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "InputCount", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectMultiplex()
		{
		}
	}
	[NodeCategory("Operators/Packing")]
	[NodeName("Pack Nullable", false)]
	[NodeOverload("Core.PackNullable")]
	public class PackNullable<T> : ObjectFunctionNode<ExecutionContext, T?>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> Value
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ValueArgument<bool> HasValue
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "HasValue"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "HasValue", value);
			}
		}

		protected override ResoniteBridge.ResoniteBridgeValue Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T?");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public PackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators/Packing")]
	[NodeName("Unpack Nullable", false)]
	[NodeOverload("Core.UnpackNullable")]
	public class UnpackNullable<T> : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ObjectArgument<T?> Nullable
		{
			get
			{
				return (ObjectArgument<T?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Nullable"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Nullable", value);
			}
		}

		public ValueOutput<T> Value
		{
			get
			{
				return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public ValueOutput<bool> HasValue
		{
			get
			{
				return (ValueOutput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "HasValue"), typeof(ValueOutput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "HasValue", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public UnpackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnpackNullable()
		{
		}
	}
	[NodeCategory("Operators")]
	[NodeName("?:", false)]
	[NodeOverload("Core.Conditional")]
	public class ValueConditional<T> : ValueFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<T> OnTrue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTrue", value);
			}
		}

		public ValueInput<T> OnFalse
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFalse", value);
			}
		}

		public ValueArgument<bool> Condition
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("?:", false)]
	[NodeOverload("Core.Conditional")]
	public class ObjectConditional<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectInput<T> OnTrue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTrue", value);
			}
		}

		public ObjectInput<T> OnFalse
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFalse", value);
			}
		}

		public ValueArgument<bool> Condition
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("==", true)]
	[NodeOverload("Core.Equals")]
	public class ValueEquals<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> A
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ValueArgument<T> B
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("==", true)]
	[NodeOverload("Core.Equals")]
	public class ObjectEquals<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<T> A
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ObjectArgument<T> B
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("Is Null", true)]
	[NodeOverload("Core.IsNull")]
	public class IsNull<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder where T : class
	{
		public ObjectArgument<T> Instance
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Instance"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Instance", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public IsNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("NOT Null", true)]
	[NodeOverload("Core.NotNull")]
	public class NotNull<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder where T : class
	{
		public ObjectArgument<T> Instance
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Instance"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Instance", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NotNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("!=", true)]
	[NodeOverload("Core.NotEquals")]
	public class ValueNotEquals<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> A
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ValueArgument<T> B
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("!=", true)]
	[NodeOverload("Core.NotEquals")]
	public class ObjectNotEquals<T> : ValueFunctionNode<ExecutionContext, bool>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<T> A
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ObjectArgument<T> B
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		protected override System.Boolean Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("??", true)]
	[NodeOverload("Core.NullCoalesce")]
	public class NullCoalesce<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : class
	{
		public ObjectArgument<T> A
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ObjectInput<T> B
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Operators")]
	[NodeName("??", false)]
	[NodeOverload("Core.MultiNullCoalesce")]
	public class MultiNullCoalesce<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : class
	{
		public ObjectInputList<T> Operands
		{
			get
			{
				return (ObjectInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operands"), typeof(ObjectInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Operands", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public MultiNullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public MultiNullCoalesce()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Ref To Output", false)]
	[NodeOverload("Core.RefToOutput")]
	public class ReferenceToOutput<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : INode
	{
		public Reference<T> Reference
		{
			get
			{
				return (Reference<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reference"), typeof(Reference<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reference", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ReferenceToOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Relay")]
	public class ValueRelay<T> : ValueFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueArgument<T> Input
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Relay")]
	public class ObjectRelay<T> : ObjectFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectArgument<T> Input
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Continuation Relay", false)]
	[NodeOverload("Core.ContinuationRelay")]
	public class ContinuationRelay : ActionFlowNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		protected override void Do(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Do", context);
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuationRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Call Relay", false)]
	[NodeOverload("Core.CallRelay")]
	public class CallRelay : ActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Call OnTriggered
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>)) is ExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<T>");
			}
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public CallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Async Relay", false)]
	[NodeOverload("Core.CallRelay")]
	public class AsyncCallRelay : AsyncActionNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AsyncCall OnTriggered
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>)) is Task<IOperation> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<IOperation>");
			}
		}

		public override AsyncExecutionOperationHandler<T> GetAsyncHandler<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncHandler"), typeof(AsyncExecutionOperationHandler<T>)) is AsyncExecutionOperationHandler<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncExecutionOperationHandler<T>");
			}
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncCallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Store")]
	public class StoredValue<T> : ValueFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ValueStore<T> _data
		{
			get
			{
				return (ValueStore<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ValueStore<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public StoredValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Store")]
	public class StoredObject<T> : ObjectFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ObjectStore<T> _data
		{
			get
			{
				return (ObjectStore<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ObjectStore<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public T Read(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public StoredObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeOverload("Core.Unbox")]
	public class Unbox<T> : ValueFunctionNode<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ObjectArgument<object> Input
		{
			get
			{
				return (ObjectArgument<object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<object>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Unbox(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class WriteBase<C, T> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnWritten
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnWritten", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		protected abstract IVariable<C, T> GetVariable(C context);

		protected abstract T GetValue(IVariable<C, T> variable, C context);

		protected override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public WriteBase()
		{
		}
	}
	[NodeCategory("Actions")]
	[NodeName("Write", false)]
	[NodeOverload("Core.Write")]
	public class ValueWrite<C, T> : WriteBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public Reference<IVariable<C, T>> Variable
		{
			get
			{
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions")]
	[NodeName("Write", false)]
	[NodeOverload("Core.Write")]
	public class ObjectWrite<C, T> : WriteBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Reference<IVariable<C, T>> Variable
		{
			get
			{
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions/Indirect")]
	[NodeName("Indirect Write", false)]
	[NodeOverload("Core.IndirectWrite")]
	public class ValueIndirectWrite<C, T> : WriteBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public ObjectInput<IVariable<C, T>> Variable
		{
			get
			{
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions/Indirect")]
	[NodeName("Indirect Write", false)]
	[NodeOverload("Core.IndirectWrite")]
	public class ObjectIndirectWrite<C, T> : WriteBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public ObjectInput<IVariable<C, T>> Variable
		{
			get
			{
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueWrite<T> : ValueWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectWrite<T> : ObjectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueIndirectWrite<T> : ValueIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectIndirectWrite<T> : ObjectIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Write Global", false)]
	[NodeOverload("Core.WriteGlobal")]
	public class WriteValueToGlobal<C, T> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public GlobalRef<T> Global
		{
			get
			{
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public Continuation OnWritten
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnWritten", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		protected override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public WriteValueToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public WriteValueToGlobal()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Write Global", false)]
	[NodeOverload("Core.WriteGlobal")]
	public class WriteObjectToGlobal<C, T> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public GlobalRef<T> Global
		{
			get
			{
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public Continuation OnWritten
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnWritten", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		protected override IOperation Run(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public WriteObjectToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public WriteObjectToGlobal()
		{
		}
	}
	public abstract class WriteLatchBase<C, T> : VoidNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnSet
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnSet"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnSet", value);
			}
		}

		public Continuation OnReset
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnReset"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnReset", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		public Operation Set
		{
			get
			{
				return (Operation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Set"), typeof(Operation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Set", value);
			}
		}

		public Operation Reset
		{
			get
			{
				return (Operation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reset"), typeof(Operation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reset", value);
			}
		}

		public IOperation DoSet(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoSet", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public IOperation DoReset(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoReset", context), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		protected abstract IVariable<C, T> GetVariable(C context);

		protected abstract T GetSetValue(IVariable<C, T> variable, C context);

		protected abstract T GetResetValue(IVariable<C, T> variable, C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	[NodeCategory("Actions")]
	[NodeName("Write Latch", false)]
	[NodeOverload("Core.WriteLatch")]
	public class ValueWriteLatch<C, T> : WriteLatchBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public Reference<IVariable<C, T>> Variable
		{
			get
			{
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ValueInput<T> SetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SetValue", value);
			}
		}

		public ValueInput<T> ResetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions")]
	[NodeName("Write Latch", false)]
	[NodeOverload("Core.WriteLatch")]
	public class ObjectWriteLatch<C, T> : WriteLatchBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Reference<IVariable<C, T>> Variable
		{
			get
			{
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> SetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SetValue", value);
			}
		}

		public ObjectInput<T> ResetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions/Indirect")]
	[NodeName("Indirect Write Latch", false)]
	[NodeOverload("Core.IndirectWriteLatch")]
	public class ValueIndirectWriteLatch<C, T> : WriteLatchBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public ObjectInput<IVariable<C, T>> Variable
		{
			get
			{
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ValueInput<T> SetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SetValue", value);
			}
		}

		public ValueInput<T> ResetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Actions/Indirect")]
	[NodeName("Indirect Write Latch", false)]
	[NodeOverload("Core.IndirectWriteLatch")]
	public class ObjectIndirectWriteLatch<C, T> : WriteLatchBase<C, T>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public ObjectInput<IVariable<C, T>> Variable
		{
			get
			{
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> SetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SetValue", value);
			}
		}

		public ObjectInput<T> ResetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>)) is IVariable<C, T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IVariable<C, T>");
			}
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueWriteLatch<T> : ValueWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectWriteLatch<T> : ObjectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueIndirectWriteLatch<T> : ValueIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectIndirectWriteLatch<T> : ObjectIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.Execution.Nodes.Casts
{
	[NodeCategory("Core/Casts")]
	[NodeOverload("Core.ValueCast")]
	public abstract class ValueCast<I, O> : ValueFunctionNode<ExecutionContext, O>, ICast, INode, ResoniteBridge.ResoniteBridgeValueHolder where I : struct where O : struct
	{
		public ValueArgument<I> Input
		{
			get
			{
				return (ValueArgument<I>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<I>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueCast()
		{
		}
	}
	[NodeCategory("Core/Casts")]
	[ObjectCast]
	[NodeOverload("Core.ObjectCast")]
	public class ObjectCast<I, O> : ObjectFunctionNode<ExecutionContext, O>, ICast, INode, ResoniteBridge.ResoniteBridgeValueHolder where I : class where O : class
	{
		public ObjectArgument<I> Input
		{
			get
			{
				return (ObjectArgument<I>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<I>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
		}

		protected override O Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(O)) is O __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to O");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Casts")]
	[NodeOverload("Core.ValueCast")]
	public class NullableToObjectCast<I> : ObjectFunctionNode<ExecutionContext, object>, ICast, INode, ResoniteBridge.ResoniteBridgeValueHolder where I : struct
	{
		public ObjectArgument<I?> Input
		{
			get
			{
				return (ObjectArgument<I?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		protected override System.Object Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NullableToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeCategory("Casts")]
	[NodeOverload("Core.ValueCast")]
	public class ValueToObjectCast<I> : ObjectFunctionNode<ExecutionContext, object>, ICast, INode, ResoniteBridge.ResoniteBridgeValueHolder where I : struct
	{
		public ValueArgument<I> Input
		{
			get
			{
				return (ValueArgument<I>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<I>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		protected override System.Object Compute(ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.DSP
{
	public abstract class DSP_Action<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private List<DSP_Dependency<TSequence>> _dependencies
		{
			get
			{
				return (List<DSP_Dependency<TSequence>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_dependencies"), typeof(List<DSP_Dependency<TSequence>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_dependencies", value);
			}
		}

		public TNode Node
		{
			get
			{
				return (TNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Node"), typeof(TNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Node", value);
			}
		}

		public System.Int32 InputIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputIndex", value);
			}
		}

		public System.Int32 OutputIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OutputIndex", value);
			}
		}

		public void MapInputOutput(System.Int32 inputIndex, System.Int32 outputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapInputOutput", inputIndex, outputIndex);
		}

		public void Execute(TContext context, TAction next)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context, next);
		}

		public void RequestResultDependency(System.Int32 outputIndex, System.Int32 resultIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestResultDependency", outputIndex, resultIndex);
		}

		public void RequestDepedency(TSequence sequence, System.Int32 inputIndex, System.Int32 outputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestDepedency", sequence, inputIndex, outputIndex);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public abstract class DSP_Buffer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract Type BufferType { get; }

		public abstract void Recycle();

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Buffer()
		{
		}
	}
	public abstract class DSP_BuildContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ProtoFlux.Runtimes.Execution.ExecutionContext ExecutionContext
		{
			get
			{
				return (ProtoFlux.Runtimes.Execution.ExecutionContext)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionContext"), typeof(ProtoFlux.Runtimes.Execution.ExecutionContext));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExecutionContext", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_BuildContext()
		{
		}
	}
	public abstract class DSP_BuildContext<TNode, TSequence, TContext, TBuffer, TAction> : DSP_BuildContext, ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction>, new() where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private Dictionary<TNode, TSequence> nodes
		{
			get
			{
				return (Dictionary<TNode, TSequence>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodes"), typeof(Dictionary<TNode, TSequence>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nodes", value);
			}
		}

		private List<TSequence> rootSequences
		{
			get
			{
				return (List<TSequence>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "rootSequences"), typeof(List<TSequence>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "rootSequences", value);
			}
		}

		private TaskCompletionSource<bool> completion
		{
			get
			{
				return (TaskCompletionSource<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "completion"), typeof(TaskCompletionSource<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "completion", value);
			}
		}

		private DSP_ResultHandler<TBuffer> resultHandler
		{
			get
			{
				return (DSP_ResultHandler<TBuffer>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "resultHandler"), typeof(DSP_ResultHandler<TBuffer>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "resultHandler", value);
			}
		}

		private System.Int32 outputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputCount", value);
			}
		}

		private System.Int32 remainingOutputs
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "remainingOutputs"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "remainingOutputs", value);
			}
		}

		public Dictionary<TNode, TSequence>.KeyCollection CollectedNodes
		{
			get
			{
				return (Dictionary<TNode, TSequence>.KeyCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CollectedNodes"), typeof(Dictionary<TNode, TSequence>.KeyCollection));
			}
		}

		public void Collect(List<IOutput> outputs, ProtoFlux.Runtimes.Execution.ExecutionContext executionContext)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", outputs, executionContext);
		}

		private TSequence Collect(TNode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", node), typeof(TSequence)) is TSequence __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TSequence");
			}
		}

		public Task Execute(TContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private void HandleResult(System.Int32 index, TBuffer buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleResult", index, buffer);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_BuildContext()
		{
		}
	}
	public static class DSP_BuildContextHelper
	{
		public static void Collect<T>(this ValueInput<T> input, Span<bool> mask) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}

		public static void Collect<T>(this ObjectInput<T> input, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}

		public static void Collect<T>(this System.Int32 input, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}
	}
	public delegate void DSP_ResultHandler<B>(System.Int32 resultIndex, B buffer) where B : DSP_Buffer;
	public abstract class DSP_Context<B, C> : ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		private List<B> inputBuffers
		{
			get
			{
				return (List<B>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputBuffers"), typeof(List<B>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputBuffers", value);
			}
		}

		private List<B> outputBuffers
		{
			get
			{
				return (List<B>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputBuffers"), typeof(List<B>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputBuffers", value);
			}
		}

		private List<int> sharedOutputBuffers
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sharedOutputBuffers"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sharedOutputBuffers", value);
			}
		}

		public ProtoFlux.Runtimes.Execution.ExecutionContext ExecutionContext
		{
			get
			{
				return (ProtoFlux.Runtimes.Execution.ExecutionContext)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionContext"), typeof(ProtoFlux.Runtimes.Execution.ExecutionContext));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExecutionContext", value);
			}
		}

		public DSP_ResultHandler<B> ResultHandler
		{
			get
			{
				return (DSP_ResultHandler<B>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResultHandler"), typeof(DSP_ResultHandler<B>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ResultHandler", value);
			}
		}

		internal void SetResult(System.Int32 resultIndex, B buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetResult", resultIndex, buffer);
		}

		public B GetInputBuffer(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputBuffer", index), typeof(B)) is B __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to B");
			}
		}

		public B GetOutputBuffer(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputBuffer", index), typeof(B)) is B __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to B");
			}
		}

		public B TryGetInputBuffer(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetInputBuffer", index), typeof(B)) is B __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to B");
			}
		}

		public B TryGetOutputBuffer(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetOutputBuffer", index), typeof(B)) is B __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to B");
			}
		}

		public B TryGetOutputBufferOrReuseInput(System.Int32 index, Predicate<B> filter)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetOutputBufferOrReuseInput", index, filter), typeof(B)) is B __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to B");
			}
		}

		public void SetOutputBuffer(System.Int32 index, B buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetOutputBuffer", index, buffer);
		}

		public void MapInputBuffers(List<B> buffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapInputBuffers", buffers);
		}

		public void RemapBuffersAndRecycle(System.Int32 outputIndex, System.Int32 inputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemapBuffersAndRecycle", outputIndex, inputIndex);
		}

		public void RecycleBuffers()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleBuffers");
		}

		public void ClearOutputBuffer(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearOutputBuffer", index);
		}

		public abstract void EnqueueTask(Action<C> task);

		public C CloneContext()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneContext"), typeof(C)) is C __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to C");
			}
		}

		public virtual void RecycleContext()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleContext");
		}

		public abstract B CloneBuffer(B buffer);

		protected abstract void RecycleBuffer(B buffer);

		protected abstract C CloneSelf();

		private void EnsureInputBufferCountForIndex(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureInputBufferCountForIndex", index);
		}

		private void EnsureOutputBufferCountForIndex(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureOutputBufferCountForIndex", index);
		}

		private void EnsureBufferCountForIndex(List<B> list, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureBufferCountForIndex", list, index);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Context()
		{
		}
	}
	internal struct DSP_Dependency<TSequence> : ResoniteBridge.ResoniteBridgeValueHolder where TSequence : class
	{
		public TSequence sequence
		{
			get
			{
				return (TSequence)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sequence"), typeof(TSequence));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sequence", value);
			}
		}

		public System.Int32 inputIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputIndex", value);
			}
		}

		public System.Int32 outputIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputIndex", value);
			}
		}

		public System.Boolean IsResultDependency
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsResultDependency"), typeof(System.Boolean));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Dependency(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Dependency()
		{
		}
	}
	public static class DSP_MetadataHelper
	{
		private static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		public static DSP_NodeMetadata GetMetadata(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadata", type), typeof(DSP_NodeMetadata)) is DSP_NodeMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_NodeMetadata");
			}
		}

		public static System.Boolean IsDSP(InputMetadataBase input)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", input), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean IsDSP(OutputMetadataBase output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", output), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}
	}
	public abstract class DSP_Node<B, C> : Node, IDSP_Node<B, C>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		public virtual DSP_NodeMetadata DSP_Metadata
		{
			get
			{
				return (DSP_NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DSP_Metadata"), typeof(DSP_NodeMetadata));
			}
		}

		public System.Boolean HasExecutionEntryPoints
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean));
			}
		}

		public System.Int32 InputBufferCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputBufferCount"), typeof(System.Int32));
			}
		}

		public System.Int32 OutputBufferCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputBufferCount"), typeof(System.Int32));
			}
		}

		private System.Int32 BaseInputIndex(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseInputIndex", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private System.Int32 BaseOutputIndex(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseOutputIndex", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private System.Int32 BaseInputListIndex(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseInputListIndex", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private System.Int32 BaseOutputListIndex(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseOutputListIndex", index), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public abstract void Collect(DSP_BuildContext context, Span<bool> mask);

		public IOutput GetInputBufferSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputBufferSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public System.Boolean IsInputBufferConditional(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputBufferConditional", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public abstract void Process(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Node()
		{
		}
	}
	public abstract class DSP_Runtime<TNode, TContext, TBuffer, TBuildContext, TSequence, TAction, TExecutionContext> : NodeRuntime<TNode>, IExecutionRuntimeInterop, ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TBuildContext : DSP_BuildContext<TNode, TSequence, TContext, TBuffer, TAction>, new() where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction>, new() where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction> where TExecutionContext : ProtoFlux.Runtimes.Execution.ExecutionContext
	{
		public ExecutionRuntime<TExecutionContext> ExecutionRuntime
		{
			get
			{
				return (ExecutionRuntime<TExecutionContext>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionRuntime"), typeof(ExecutionRuntime<TExecutionContext>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExecutionRuntime", value);
			}
		}

		public System.Boolean InputNodesMustBeLocal
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputNodesMustBeLocal"), typeof(System.Boolean));
			}
		}

		public Task<TBuffer> Process(IOutput output, TContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", output, context), typeof(Task<TBuffer>)) is Task<TBuffer> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<TBuffer>");
			}
		}

		public Task Process(List<IOutput> outputs, TContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", outputs, context), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Runtime()
		{
		}
	}
	public abstract class DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private List<TAction> _actions
		{
			get
			{
				return (List<TAction>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actions"), typeof(List<TAction>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actions", value);
			}
		}

		private List<TBuffer> _dependencyBuffers
		{
			get
			{
				return (List<TBuffer>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_dependencyBuffers"), typeof(List<TBuffer>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_dependencyBuffers", value);
			}
		}

		private System.Int32 _missingDependencies
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_missingDependencies"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_missingDependencies", value);
			}
		}

		public TNode LastNode
		{
			get
			{
				return (TNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastNode"), typeof(TNode));
			}
		}

		internal void AllocateDependency(System.Int32 inputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateDependency", inputIndex);
		}

		internal System.Boolean SetDependency(System.Int32 inputIndex, TBuffer buffer)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetDependency", inputIndex, buffer), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal void AddStep(TNode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddStep", node);
		}

		internal void AddStep(IDSP_Node node, System.Int32 inputIndex, System.Int32 outputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddStep", node, inputIndex, outputIndex);
		}

		protected abstract TAction CreateAction(IDSP_Node node);

		internal void RegisterDependency(IOutput output, System.Int32 inputIndex, TSequence targetSequence)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterDependency", output, inputIndex, targetSequence);
		}

		internal void RegisterResultDependency(IOutput output, System.Int32 resultIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterResultDependency", output, resultIndex);
		}

		internal TAction FindAction(IOutput output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindAction", output), typeof(TAction)) is TAction __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TAction");
			}
		}

		internal void ScheduleRun(TContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleRun", context);
		}

		internal void RunSequence(TContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunSequence", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Sequence()
		{
		}
	}
	public interface IDSP_Node : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		DSP_NodeMetadata DSP_Metadata
		{
			get
			{
				return (DSP_NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DSP_Metadata"), typeof(DSP_NodeMetadata));
			}
		}

		System.Boolean HasExecutionEntryPoints
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean));
			}
		}

		System.Int32 InputBufferCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputBufferCount"), typeof(System.Int32));
			}
		}

		System.Int32 OutputBufferCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputBufferCount"), typeof(System.Int32));
			}
		}

		IOutput GetInputBufferSource(System.Int32 index);

		System.Boolean IsInputBufferConditional(System.Int32 index);

		void Collect(DSP_BuildContext context, Span<bool> mask);
	}
	public interface IDSP_Node<B, C> : IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		void Process(C context);
	}
	public class DSP_NodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 FixedBufferInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedBufferOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicBufferInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicBufferOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferOutputCount"), typeof(System.Int32));
			}
		}

		public System.Boolean HasExecutionEntryPoints
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasExecutionEntryPoints", value);
			}
		}

		public List<InputMetadata> FixedBufferInputs
		{
			get
			{
				return (List<InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferInputs"), typeof(List<InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedBufferInputs", value);
			}
		}

		public List<OutputMetadata> FixedBufferOutputs
		{
			get
			{
				return (List<OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferOutputs"), typeof(List<OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedBufferOutputs", value);
			}
		}

		public List<InputListMetadata> DynamicBufferInputs
		{
			get
			{
				return (List<InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferInputs"), typeof(List<InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicBufferInputs", value);
			}
		}

		public List<OutputListMetadata> DynamicBufferOutputs
		{
			get
			{
				return (List<OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferOutputs"), typeof(List<OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicBufferOutputs", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.DSP.Array
{
	public class DSP_Array_Action : DSP_Action<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Action(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Action()
		{
		}
	}
	public abstract class DSP_Array_Buffer : DSP_Buffer, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract DSP_Array_Buffer Clone(DSP_Array_Context context, DSP_Array_Buffer source);

		public abstract void Copy(DSP_Array_Buffer source);

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Buffer()
		{
		}
	}
	public class DSP_Array_Buffer<T> : DSP_Array_Buffer, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override Type BufferType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BufferType"), typeof(Type));
			}
		}

		public T[] Buffer
		{
			get
			{
				return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Buffer"), typeof(T[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Buffer", value);
			}
		}

		public override void Copy(DSP_Array_Buffer source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Copy", source);
		}

		public override DSP_Array_Buffer Clone(DSP_Array_Context context, DSP_Array_Buffer source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone", context, source), typeof(DSP_Array_Buffer)) is DSP_Array_Buffer __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_Array_Buffer");
			}
		}

		public override void Recycle()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Recycle");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Buffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Buffer()
		{
		}
	}
	public class DSP_Array_BuildContext : DSP_BuildContext<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_BuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DSP_Array_Context : DSP_Context<DSP_Array_Buffer, DSP_Array_Context>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DSP_Array_Buffer<T> AllocateBuffer<T>() where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateBuffer"), typeof(DSP_Array_Buffer<T>)) is DSP_Array_Buffer<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_Array_Buffer<T>");
			}
		}

		public override DSP_Array_Buffer CloneBuffer(DSP_Array_Buffer buffer)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneBuffer", buffer), typeof(DSP_Array_Buffer)) is DSP_Array_Buffer __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_Array_Buffer");
			}
		}

		protected override DSP_Array_Context CloneSelf()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneSelf"), typeof(DSP_Array_Context)) is DSP_Array_Context __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_Array_Context");
			}
		}

		public override void EnqueueTask(Action<DSP_Array_Context> task)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnqueueTask", task);
		}

		public override void RecycleContext()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleContext");
		}

		protected override void RecycleBuffer(DSP_Array_Buffer buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleBuffer", buffer);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Context(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class DSP_Array_BufferExtensions
	{
		public static T[] GetInputBuffer<T>(this ValueInput<T> input, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetInputBuffer", input, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		public static T[] GetOutputBuffer<T>(this ValueOutput<T> input, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", input, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		public static T[] GetOutputBufferOrReuse<T>(this ValueOutput<T> input, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBufferOrReuse", input, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		public static T[] GetInputBuffer<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetInputBuffer", index, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		public static T[] GetOutputBuffer<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		public static T[] GetOutputBufferOrReuse<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBufferOrReuse", index, context), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}

		private static T[] GetOutputBuffer<T>(System.Int32 index, DSP_Array_Context context, System.Boolean allowReuse) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context, allowReuse), typeof(T[])) is T[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T[]");
			}
		}
	}
	public abstract class DSP_Array_Node : DSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Array_Node, IDSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Node()
		{
		}
	}
	public class DSP_Array_Runtime<C> : DSP_Runtime<IDSP_Array_Node, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_BuildContext, DSP_Array_Sequence, DSP_Array_Action, C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ProtoFlux.Runtimes.Execution.ExecutionContext
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Runtime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DSP_Array_Sequence : DSP_Sequence<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		protected override DSP_Array_Action CreateAction(IDSP_Node node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateAction", node), typeof(DSP_Array_Action)) is DSP_Array_Action __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DSP_Array_Action");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DSP_Array_Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IDSP_Array_Node : IDSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	[NodeOverload("Core.Add")]
	public class TestAddArraysNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> A
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ValueInput<float> B
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestAddArraysNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestAddArraysNode()
		{
		}
	}
	[NodeOverload("Core.Add")]
	public class TestAddArraysNodeExecution : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> A
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "A", value);
			}
		}

		public ValueInput<float> B
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestAddArraysNodeExecution(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestAddArraysNodeExecution()
		{
		}
	}
	public class TestAmplifyArray : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public ValueInput<float> Multiplier
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Multiplier"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Multiplier", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestAmplifyArray(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestAmplifyArray()
		{
		}
	}
	public class TestConditionalCollectArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> OnTrue
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTrue", value);
			}
		}

		public ValueInput<float> OnFalse
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFalse", value);
			}
		}

		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestConditionalCollectArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestConditionalCollectArrayNode()
		{
		}
	}
	public class TestNegateArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestNegateArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestNegateArrayNode()
		{
		}
	}
	public class TestRandomArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestRandomArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestRandomArrayNode()
		{
		}
	}
	public class TestSequenceArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public TestSequenceArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public TestSequenceArrayNode()
		{
		}
	}
}
namespace ProtoFlux.Core
{
	public static class CastHelper
	{
		private static Dictionary<Type, Dictionary<Type, List<Type>>> valueCasts
		{
			get
			{
				return (Dictionary<Type, Dictionary<Type, List<Type>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "valueCasts"), typeof(Dictionary<Type, Dictionary<Type, List<Type>>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "valueCasts", value);
			}
		}

		private static List<Type> objectCasts
		{
			get
			{
				return (List<Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "objectCasts"), typeof(List<Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "objectCasts", value);
			}
		}

		public static void SearchCasts()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SearchCasts");
		}

		public static IReadOnlyList<Type> GetValueCastNodes(Type from, Type to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetValueCastNodes", from, to), typeof(IReadOnlyList<Type>)) is IReadOnlyList<Type> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IReadOnlyList<Type>");
			}
		}

		public static Type GetCastNode(Type from, Type to, NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCastNode", from, to, runtime), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}
	}
	public class ChangeListenerAttribute : Attribute
	{
		public ChangeListenerAttribute()
		{
		}
	}
	public class ChangeSourceAttribute : Attribute
	{
		public ChangeSourceAttribute()
		{
		}
	}
	internal struct ChangeSourceInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean continuous
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuous"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "continuous", value);
			}
		}

		public List<ElementPath<IOutput>> outputs
		{
			get
			{
				return (List<ElementPath<IOutput>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputs"), typeof(List<ElementPath<IOutput>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputs", value);
			}
		}

		public System.Boolean ProducesChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProducesChanges"), typeof(System.Boolean));
			}
		}

		public void SetContinuous()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetContinuous");
		}

		public void Add(IOutput output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", output);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ChangeSourceInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	internal class ChangeTrackingBuildContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<NodeGroup> _currentlyProcessing
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentlyProcessing"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentlyProcessing", value);
			}
		}

		private HashSet<NodeGroup> _currentConflicts
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentConflicts"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentConflicts", value);
			}
		}

		public System.Boolean HasConflicts
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasConflicts"), typeof(System.Boolean));
			}
		}

		public System.Boolean ContainsCurrentlyProcessing(NodeGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContainsCurrentlyProcessing", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean TryNestInto(NodeGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryNestInto", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void NestOut(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NestOut", group);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ChangeTrackingBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	internal class ChangeTrackingData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public HashSet<NodeGroup> NestedGroups
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NestedGroups"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "NestedGroups", value);
			}
		}

		public List<ElementPath<INode>> ContinuousChanges
		{
			get
			{
				return (List<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContinuousChanges"), typeof(List<ElementPath<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ContinuousChanges", value);
			}
		}

		public Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>> ChangeListeners
		{
			get
			{
				return (Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ChangeListeners"), typeof(Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ChangeListeners", value);
			}
		}

		public Dictionary<IOutput, ChangeSourceInfo> ExportsInfo
		{
			get
			{
				return (Dictionary<IOutput, ChangeSourceInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ExportsInfo"), typeof(Dictionary<IOutput, ChangeSourceInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ExportsInfo", value);
			}
		}

		public void Sort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Sort");
		}

		public void RegisterListener(ElementPath<IOutput> output, ElementPath<INode> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", output, node);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ChangeTrackingData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ContinuouslyChangingAttribute : Attribute
	{
		public ContinuouslyChangingAttribute()
		{
		}
	}
	public class NodeGroup : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ChangeTrackingData changeTrackingData
		{
			get
			{
				return (ChangeTrackingData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "changeTrackingData"), typeof(ChangeTrackingData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "changeTrackingData", value);
			}
		}

		private List<NodeRuntime> runtimes
		{
			get
			{
				return (List<NodeRuntime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtimes"), typeof(List<NodeRuntime>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "runtimes", value);
			}
		}

		private System.Int32 _nodeAllocationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_nodeAllocationCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_nodeAllocationCount", value);
			}
		}

		public System.Boolean ChangeTrackingBuilt
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTrackingBuilt"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeTrackingBuilt", value);
			}
		}

		public System.Boolean ChangeTrackingDirty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTrackingDirty"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeTrackingDirty", value);
			}
		}

		public System.Boolean RequiresRebuild
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresRebuild"), typeof(System.Boolean));
			}
		}

		public System.Boolean IgnoreChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IgnoreChanges"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IgnoreChanges", value);
			}
		}

		public IReadOnlyList<ElementPath<INode>> ContinuousChanges
		{
			get
			{
				return (IReadOnlyList<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContinuousChanges"), typeof(IReadOnlyList<ElementPath<INode>>));
			}
		}

		public Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection ActiveChangeSources
		{
			get
			{
				return (Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveChangeSources"), typeof(Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection));
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public System.Int32 RuntimeCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RuntimeCount"), typeof(System.Int32));
			}
		}

		public IEnumerable<NodeRuntime> Runtimes
		{
			get
			{
				return (IEnumerable<NodeRuntime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtimes"), typeof(IEnumerable<NodeRuntime>));
			}
		}

		public System.Int32 TotalNodeCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalNodeCount"), typeof(System.Int32));
			}
		}

		public event Action<NodeGroup> ChangeTrackingInvalidated;

		public void MarkChangeTrackingDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkChangeTrackingDirty");
		}

		public System.Boolean ContainsNestedGroup(NodeGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContainsNestedGroup", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean CheckChangeTracking()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckChangeTracking"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void OutputChanged(ElementPath<IOutput> output, HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OutputChanged", output, changedNodes);
		}

		public void OutputChanged(ElementPath<IOutput> output, ResoniteBridge.ResoniteBridgeValue changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OutputChanged", output, changedNodes);
		}

		public void AllChanged(HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllChanged", changedNodes);
		}

		public void AllChanged(ResoniteBridge.ResoniteBridgeValue changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllChanged", changedNodes);
		}

		public void RebuildChangeTrackingData()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RebuildChangeTrackingData");
		}

		private ChangeTrackingData BuildChangeTrackingData(ChangeTrackingBuildContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BuildChangeTrackingData", context), typeof(ChangeTrackingData)) is ChangeTrackingData __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ChangeTrackingData");
			}
		}

		private ChangeSourceInfo GetChangeInfo(IOutput output, Dictionary<IOutput, ChangeSourceInfo> infos, Dictionary<INestedNode, ChangeTrackingData> nestedData)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetChangeInfo", output, infos, nestedData), typeof(ChangeSourceInfo)) is ChangeSourceInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ChangeSourceInfo");
			}
		}

		public System.String DebugChangeTrackingData()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DebugChangeTrackingData"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String PrintDebugStructure()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintDebugStructure"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private void PrintRuntime(StringBuilder str, NodeRuntime runtime, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintRuntime", str, runtime, indent);
		}

		private void PrintNode(StringBuilder str, INode node, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintNode", str, node, indent);
		}

		private System.String PrintInputSource(IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintInputSource", source), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String PrintImpulseTarget(IOperation target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintImpulseTarget", target), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private void Indent(StringBuilder str, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Indent", str, indent);
		}

		public NodeRuntime GetRuntime(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRuntime", index), typeof(NodeRuntime)) is NodeRuntime __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeRuntime");
			}
		}

		internal System.Int32 GetNodeAllocationIndex()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodeAllocationIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public R AddRuntime<R>() where R : NodeRuntime, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddRuntime"), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to R");
			}
		}

		public R GetRuntime<R>() where R : NodeRuntime
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRuntime"), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to R");
			}
		}

		public void ForeachNode<T>(NodeEnumerationAction<T> action, System.Boolean cache) where T : INode
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachNode", action, cache);
		}

		public void ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, System.Boolean cache) where T : INode
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachNode", action, context, cache);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeGroup(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeGroup()
		{
		}
	}
	public enum DataClass
	{
		Value,
		Object
	}
	[AttributeUsage(AttributeTargets.Field)]
	public class DefaultValueAttribute : Attribute
	{
		public System.Object Value
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}
	}
	public class AsyncCallList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private class InternalCall : IAsyncCall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOperation Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType
			{
				get
				{
					return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
				}
			}

			IOperation IImpulse.Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private List<InternalCall> calls
		{
			get
			{
				return (List<InternalCall>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "calls"), typeof(List<InternalCall>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "calls", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public IImpulse GetImpulse(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType)) is ImpulseType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseType");
			}
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncCallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AsyncOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class Operation : IAsyncOperation, IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.Int32 Index
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public AsyncOperationList List
			{
				get
				{
					return (AsyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(AsyncOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
				}
			}

			public Node OwnerNode
			{
				get
				{
					return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
				}
			}

			IOperationList IListOperation.List
			{
				get
				{
					return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList));
				}
			}

			public override System.String ToString()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Operation()
			{
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IAsyncOperation AddOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(IAsyncOperation)) is IAsyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncOperation");
			}
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public IAsyncOperation GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IAsyncOperation)) is IAsyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncOperation");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		IOperation IOperationList.AddOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		IOperation IOperationList.GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		System.Boolean IOperationList.IsOperationAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CallList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private class InternalCall : ICall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public ISyncOperation Target
			{
				get
				{
					return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType
			{
				get
				{
					return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
				}
			}

			IOperation IImpulse.Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private List<InternalCall> calls
		{
			get
			{
				return (List<InternalCall>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "calls"), typeof(List<InternalCall>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "calls", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public IImpulse GetImpulse(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType)) is ImpulseType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseType");
			}
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public CallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ContinuationList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private class InternalContinuation : IContinuation, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOperation Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType
			{
				get
				{
					return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public InternalContinuation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private List<InternalContinuation> continuations
		{
			get
			{
				return (List<InternalContinuation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuations"), typeof(List<InternalContinuation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "continuations", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public IImpulse GetImpulse(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse)) is IImpulse __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulse");
			}
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType)) is ImpulseType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseType");
			}
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ListGlobalRef<T> : GlobalRef<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlobalRefList List
		{
			get
			{
				return (GlobalRefList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(GlobalRefList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ListGlobalRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ListGlobalRef()
		{
		}
	}
	public class GlobalRefList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IGlobalRef> globalRefs
		{
			get
			{
				return (List<IGlobalRef>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globalRefs"), typeof(List<IGlobalRef>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "globalRefs", value);
			}
		}

		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerNode", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IGlobalRef<T> AddGlobalRef<T>(Global<T> binding = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGlobalRef", binding), typeof(IGlobalRef<T>)) is IGlobalRef<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IGlobalRef<T>");
			}
		}

		public void SetGlobalRefBinding<T>(System.Int32 index, Global<T> binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public IGlobalRef GetUntypedGlobalRef(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUntypedGlobalRef", index), typeof(IGlobalRef)) is IGlobalRef __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IGlobalRef");
			}
		}

		public IGlobalRef<T> GetGlobalRef<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRef", index), typeof(IGlobalRef<T>)) is IGlobalRef<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IGlobalRef<T>");
			}
		}

		public void RemoveGlobalRef()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveGlobalRef");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRefList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRefList()
		{
		}
	}
	public interface IImpulseList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		IImpulse AddImpulse(IOperation target = null);

		void RemoveImpulse();

		void Clear();

		ImpulseType GetImpulseType(System.Int32 index);

		IImpulse GetImpulse(System.Int32 index);

		IOperation GetImpulseTarget(System.Int32 index);

		void SetImpulseTarget(System.Int32 index, IOperation target);
	}
	public interface IInputList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		IOutput GetInputSource(System.Int32 index);

		void AddInput(IOutput source);

		void SetInputSource(System.Int32 index, IOutput source);

		void RemoveInput();

		void Clear();

		Type GetInputType(System.Int32 index);

		DataClass GetDataClass(System.Int32 index);

		System.Object GetDefaultValue(System.Int32 index);
	}
	public interface IListOperation : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
		}

		IOperationList List
		{
			get
			{
				return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList));
			}
		}
	}
	public abstract class InputListBase : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private abstract class Input : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract IOutput GenericSource { get; set; }

			public abstract Type InputType { get; }

			public abstract DataClass DataClass { get; }

			public abstract System.Object DefaultValue { get; }

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public Input()
			{
			}
		}

		private class Input<T> : Input, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOutput<T> Source
			{
				get
				{
					return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
				}
			}

			public override Type InputType
			{
				get
				{
					return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
				}
			}

			public override IOutput GenericSource
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GenericSource"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GenericSource", value);
				}
			}

			public override DataClass DataClass
			{
				get
				{
					return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass));
				}
			}

			public override System.Object DefaultValue
			{
				get
				{
					return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.Object));
				}
			}

			IOutput IInput.Source
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public Input(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private List<Input> _inputs
		{
			get
			{
				return (List<Input>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputs"), typeof(List<Input>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputs", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IInput<T> GetInput<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInput", index), typeof(IInput<T>)) is IInput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IInput<T>");
			}
		}

		public IInput<T> AddInput<T>(IOutput<T> source = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source), typeof(IInput<T>)) is IInput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IInput<T>");
			}
		}

		public void RemoveInput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveInput");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public void SetInputSource(System.Int32 index, IOutput source, System.Boolean changeType)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source, changeType);
		}

		public Type GetInputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		public void AddInput(IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputListBase()
		{
		}
	}
	public class InputList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ArgumentList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IOperationList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		IOperation AddOperation();

		void RemoveOperation();

		IOperation GetOperation(System.Int32 index);

		System.Boolean IsOperationAsync(System.Int32 index);

		void Clear();
	}
	public interface IOutputList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
		}

		System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		IOutput GetOutput(System.Int32 index);

		Type GetOutputType(System.Int32 index);

		DataClass GetOutputClass(System.Int32 index);

		IListOutput AddOutput();

		void RemoveOutput();

		void Clear();
	}
	public class MixedOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract class Operation : IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.Int32 Index
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public MixedOperationList List
			{
				get
				{
					return (MixedOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(MixedOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
				}
			}

			public Node OwnerNode
			{
				get
				{
					return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
				}
			}

			public abstract System.Boolean IsAsync { get; }

			IOperationList IListOperation.List
			{
				get
				{
					return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList));
				}
			}

			public override System.String ToString()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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
		}

		public class SyncOperation : Operation, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public override System.Boolean IsAsync
			{
				get
				{
					return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public SyncOperation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public SyncOperation()
			{
			}
		}

		public class AsyncOperation : Operation, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public override System.Boolean IsAsync
			{
				get
				{
					return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public AsyncOperation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public AsyncOperation()
			{
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public ISyncOperation AddSyncOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddSyncOperation"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ISyncOperation");
			}
		}

		public IAsyncOperation AddAsyncOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddAsyncOperation"), typeof(IAsyncOperation)) is IAsyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncOperation");
			}
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public IOperation GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public System.Boolean IsOperationAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		IOperation IOperationList.AddOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public MixedOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class ObjectInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IObjectOutput<T>> inputs
		{
			get
			{
				return (List<IObjectOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputs"), typeof(List<IObjectOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputs", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		public Type GetInputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public void AddInput(IObjectOutput<T> source = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
		}

		public void AddInput(IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
		}

		public void RemoveInput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveInput");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectInputListBase()
		{
		}
	}
	public class ObjectInputList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectArgumentList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<ListObjectOutput<T>> _outputs
		{
			get
			{
				return (List<ListObjectOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<ListObjectOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public ListObjectOutput<T> AddOutput()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(ListObjectOutput<T>)) is ListObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListObjectOutput<T>");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public ListObjectOutput<T> GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(ListObjectOutput<T>)) is ListObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListObjectOutput<T>");
			}
		}

		IOutput IOutputList.GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		IListOutput IOutputList.AddOutput()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(IListOutput)) is IListOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IListOutput");
			}
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOutput");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectOutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectOutputList()
		{
		}
	}
	public interface IListOutput : IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
		}

		IOutputList List
		{
			get
			{
				return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList));
			}
		}
	}
	public class ListValueOutput<T> : ValueOutput<T>, IListOutput, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IOutputList List
		{
			get
			{
				return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ListValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ListValueOutput()
		{
		}
	}
	public class ListObjectOutput<T> : ObjectOutput<T>, IListOutput, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOutputList List
		{
			get
			{
				return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ListObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ListObjectOutput()
		{
		}
	}
	public class OutputList : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IOutput> _outputs
		{
			get
			{
				return (List<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<IOutput>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IOutput GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public IListOutput AddOutputAuto(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutputAuto", type), typeof(IListOutput)) is IListOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IListOutput");
			}
		}

		public ListValueOutput<T> AddValueOutput<T>() where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddValueOutput"), typeof(ListValueOutput<T>)) is ListValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListValueOutput<T>");
			}
		}

		public ListObjectOutput<T> AddObjectOutput<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddObjectOutput"), typeof(ListObjectOutput<T>)) is ListObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListObjectOutput<T>");
			}
		}

		public ListValueOutput<T> GetValueOutput<T>(System.Int32 index) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutput", index), typeof(ListValueOutput<T>)) is ListValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListValueOutput<T>");
			}
		}

		public ListObjectOutput<T> GetObjectOutput<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetObjectOutput", index), typeof(ListObjectOutput<T>)) is ListObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListObjectOutput<T>");
			}
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOutput");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public IListOutput AddOutput()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(IListOutput)) is IListOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IListOutput");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OutputList()
		{
		}
	}
	public class SyncOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class Operation : ISyncOperation, IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.Int32 Index
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public SyncOperationList List
			{
				get
				{
					return (SyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(SyncOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
				}
			}

			public Node OwnerNode
			{
				get
				{
					return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
				}
			}

			IOperationList IListOperation.List
			{
				get
				{
					return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList));
				}
			}

			public override System.String ToString()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Operation()
			{
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public ISyncOperation AddOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ISyncOperation");
			}
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public ISyncOperation GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(ISyncOperation)) is ISyncOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ISyncOperation");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		IOperation IOperationList.AddOperation()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		IOperation IOperationList.GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		System.Boolean IOperationList.IsOperationAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public SyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class ValueInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private List<IValueOutput<T>> inputs
		{
			get
			{
				return (List<IValueOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputs"), typeof(List<IValueOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputs", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		public Type GetInputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public void AddInput(IValueOutput<T> source = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
		}

		public void AddInput(IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
		}

		public void RemoveInput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveInput");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueInputListBase()
		{
		}
	}
	public class ValueInputList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueArgumentList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private List<ListValueOutput<T>> _outputs
		{
			get
			{
				return (List<ListValueOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<ListValueOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Owner", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public ListValueOutput<T> AddOutput()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(ListValueOutput<T>)) is ListValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListValueOutput<T>");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public ListValueOutput<T> GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(ListValueOutput<T>)) is ListValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ListValueOutput<T>");
			}
		}

		IOutput IOutputList.GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		IListOutput IOutputList.AddOutput()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(IListOutput)) is IListOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IListOutput");
			}
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOutput");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueOutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueOutputList()
		{
		}
	}
	public struct AsyncCall : IAsyncCall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AsyncOperation : IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerNode", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncOperation(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncOperation()
		{
		}
	}
	public struct AsyncResumption : IAsyncResumption, IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct Call : ICall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Call(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct Continuation : IContinuation, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Continuation(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class GlobalRef : IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerNode", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public abstract Global UntypedGlobal { get; }

		public abstract void ClearReference();

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class GlobalRef<T> : GlobalRef, IGlobalRef<T>, IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Global<T> _global
		{
			get
			{
				return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_global"), typeof(Global<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_global", value);
			}
		}

		public override Global UntypedGlobal
		{
			get
			{
				return (Global)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UntypedGlobal"), typeof(Global));
			}
		}

		public Global<T> Global
		{
			get
			{
				return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Global"), typeof(Global<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Global", value);
			}
		}

		public override void ClearReference()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearReference");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRef()
		{
		}
	}
	public static class GlobalRefHelper
	{
		public static T Read<T>(this GlobalRef<T> global, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Read", global, context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static System.Boolean Write<T>(this GlobalRef<T> global, T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", global, value, context), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}
	}
	public struct ObjectArgument<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				return (IObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		IOutput IInput.Source
		{
			get
			{
				return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ObjectInput<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				return (IObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		IOutput IInput.Source
		{
			get
			{
				return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ObjectOutput<T> : Output<T>, IObjectOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectOutput()
		{
		}
	}
	public class Operation : ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerNode", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Operation(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Operation()
		{
		}
	}
	public struct Reference<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : INode
	{
		public T Target
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Reference(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct SyncResumption : ISyncResumption, IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public SyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ValueArgument<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				return (IValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		IOutput IInput.Source
		{
			get
			{
				return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ValueInput<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				return (IValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		IOutput IInput.Source
		{
			get
			{
				return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ValueOutput<T> : Output<T>, IValueOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueOutput()
		{
		}
	}
	public interface IAsyncOperation : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IGlobalRef : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Global UntypedGlobal
		{
			get
			{
				return (Global)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UntypedGlobal"), typeof(Global));
			}
		}

		void ClearReference();
	}
	public interface IGlobalRef<T> : IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		Global<T> Global
		{
			get
			{
				return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Global"), typeof(Global<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Global", value);
			}
		}
	}
	public enum ImpulseType
	{
		Continuation,
		Call,
		AsyncCall,
		SyncResumption,
		AsyncResumption
	}
	public interface IImpulse : ResoniteBridge.ResoniteBridgeValueHolder
	{
		IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}

		ImpulseType ImpulseType
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType));
			}
		}
	}
	public interface ICall : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}
	}
	public interface IAsyncCall : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IContinuation : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IResumption : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface ISyncResumption : IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
			}
		}
	}
	public interface IAsyncResumption : IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IInput : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		IOutput Source
		{
			get
			{
				return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput));
			}
		}
	}
	public interface IInput<T> : IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IOutput<T> Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}
	}
	public interface IValueInput<T> : IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		new IValueOutput<T> Source
		{
			get
			{
				return (IValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}
	}
	public interface IObjectInput<T> : IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IObjectOutput<T> Source
		{
			get
			{
				return (IObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
			}
		}
	}
	public interface IOperation : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}
	}
	public interface IOutput : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}

		DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}
	}
	public interface IOutput<T> : IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IObjectOutput<T> : IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IValueOutput<T> : IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
	}
	public interface ISyncOperation : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public struct UnmanagedNullable<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private T _value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_value", value);
			}
		}

		private System.Boolean _hasValue
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hasValue"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hasValue", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T));
			}
		}

		public System.Boolean HasValue
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasValue"), typeof(System.Boolean));
			}
		}

		public static implicit operator T?(UnmanagedNullable<T> unmanagedNullable)
		{
			return (T?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", unmanagedNullable), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static implicit operator UnmanagedNullable<T>(T? nullable)
		{
			return (UnmanagedNullable<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", nullable), typeof(UnmanagedNullable<T>));
		}

		public static implicit operator UnmanagedNullable<T>(T value)
		{
			return (UnmanagedNullable<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", value), typeof(UnmanagedNullable<T>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public UnmanagedNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnmanagedNullable()
		{
		}
	}
	public interface IStore : ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IStore<T> : IStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context);

		void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context);
	}
	public static class StoreHelpers
	{
		public static void Clear<T>(this IStore<T> store, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "StoreHelpers", ResoniteBridge.ResoniteBridgeValueType.Type), "Clear", store, context);
		}
	}
	public struct ObjectStore<T> : IStore<T>, IStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal System.Int32 offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32));
			}
		}

		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ObjectStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ValueStore<T> : IStore<T>, IStore, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		internal System.Int32 offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32));
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T Access(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", context), typeof(ref T)) is ref T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ref T");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class CrossRuntimeInputAttribute : Attribute
	{
		public abstract System.Boolean IsValidTargetRuntime(NodeRuntime runtime);

		public CrossRuntimeInputAttribute()
		{
		}
	}
	public interface INestedNode : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		NodeGroup TargetGroup
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetGroup"), typeof(NodeGroup));
			}
		}

		NodeRuntime TargetRuntime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(NodeRuntime));
			}
		}

		IOutput GetTargetExport(IOutput output);

		IOutput GetImportSource(IOutput import);
	}
	public struct ElementRef : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int16 index
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "index"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "index", value);
			}
		}

		public System.Int16 listIndex
		{
			get
			{
				return (System.Int16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "listIndex"), typeof(System.Int16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "listIndex", value);
			}
		}

		public System.Boolean IsDynamic
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDynamic"), typeof(System.Boolean));
			}
		}

		public System.Boolean AddToList
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AddToList"), typeof(System.Boolean));
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ElementRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AsyncCallExport : ImpulseExport, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public AsyncCallExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCallExport()
		{
		}
	}
	public class CallExport : ImpulseExport, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public CallExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CallExport()
		{
		}
	}
	public class ContinuationExport : ImpulseExport, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ContinuationExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuationExport()
		{
		}
	}
	public abstract class ImpulseExport : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerNode", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class ImpulseExportNode : Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseExportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DataImportNode : Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public DataImportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class Global : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public abstract Type ValueType { get; }

		public abstract System.Int32 ListenerCount { get; }

		internal abstract void AddMatchingTypeToList(GlobalRefList list);

		internal abstract void UpdateToInitialValue<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		internal abstract void ResetValueToDefault<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class Global<T> : Global, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<GlobalRef<T>> _listeners
		{
			get
			{
				return (List<GlobalRef<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_listeners"), typeof(List<GlobalRef<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_listeners", value);
			}
		}

		public override Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
		}

		public override System.Int32 ListenerCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListenerCount"), typeof(System.Int32));
			}
		}

		internal void ValueChanged<C>(T value, C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ValueChanged", value, context);
		}

		internal override void UpdateToInitialValue<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateToInitialValue", context);
		}

		internal override void ResetValueToDefault<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetValueToDefault", context);
		}

		internal void RegisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", listener);
		}

		internal void UnregisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterListener", listener);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		internal override void AddMatchingTypeToList(GlobalRefList list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMatchingTypeToList", list);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Global(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Global()
		{
		}
	}
	public struct ImpulseImport : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "target", value);
			}
		}

		public System.Boolean isAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isAsync", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseImport(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseImport()
		{
		}
	}
	public class ImpulseMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public ImpulseType Type
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(ImpulseType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseMetadata()
		{
		}
	}
	public class GlobalRefListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRefListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRefListMetadata()
		{
		}
	}
	public class GlobalRefMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueType", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public GlobalRefMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRefMetadata()
		{
		}
	}
	public interface IElementMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
		}

		System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
		}
	}
	public class ImpulseListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public ImpulseType? Type
		{
			get
			{
				return (ImpulseType?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseListMetadata()
		{
		}
	}
	public class InputListMetadata : InputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type TypeConstraint
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TypeConstraint"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TypeConstraint", value);
			}
		}

		public DataClass? DataClassConstraint
		{
			get
			{
				return (DataClass?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClassConstraint"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClassConstraint", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputListMetadata()
		{
		}
	}
	public class InputMetadata : InputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DataClass DataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClass", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputType", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputMetadata()
		{
		}
	}
	public abstract class InputMetadataBase : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public System.Object DefaultValue
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefaultValue", value);
			}
		}

		public System.Boolean IsConditional
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsConditional"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsConditional", value);
			}
		}

		public bool? IsListeningToChanges
		{
			get
			{
				return (bool?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListeningToChanges"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListeningToChanges", value);
			}
		}

		public PropertyInfo IsListeningToChangesEval
		{
			get
			{
				return (PropertyInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListeningToChangesEval"), typeof(PropertyInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListeningToChangesEval", value);
			}
		}

		public CrossRuntimeInputAttribute CrossRuntime
		{
			get
			{
				return (CrossRuntimeInputAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CrossRuntime"), typeof(CrossRuntimeInputAttribute));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CrossRuntime", value);
			}
		}

		public System.Boolean IsPotentiallyListeningToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPotentiallyListeningToChanges"), typeof(System.Boolean));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class NodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<string, InputMetadata> _inputsByName
		{
			get
			{
				return (Dictionary<string, InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputsByName"), typeof(Dictionary<string, InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputsByName", value);
			}
		}

		private Dictionary<string, OutputMetadata> _outputsByName
		{
			get
			{
				return (Dictionary<string, OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputsByName"), typeof(Dictionary<string, OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputsByName", value);
			}
		}

		private Dictionary<string, InputListMetadata> _inputListsByName
		{
			get
			{
				return (Dictionary<string, InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputListsByName"), typeof(Dictionary<string, InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputListsByName", value);
			}
		}

		private Dictionary<string, OutputListMetadata> _outputListsByName
		{
			get
			{
				return (Dictionary<string, OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputListsByName"), typeof(Dictionary<string, OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputListsByName", value);
			}
		}

		private Dictionary<string, ImpulseMetadata> _impulsesByName
		{
			get
			{
				return (Dictionary<string, ImpulseMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulsesByName"), typeof(Dictionary<string, ImpulseMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulsesByName", value);
			}
		}

		private Dictionary<string, OperationMetadata> _actionsByName
		{
			get
			{
				return (Dictionary<string, OperationMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actionsByName"), typeof(Dictionary<string, OperationMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actionsByName", value);
			}
		}

		private Dictionary<string, ImpulseListMetadata> _impulseListsByName
		{
			get
			{
				return (Dictionary<string, ImpulseListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulseListsByName"), typeof(Dictionary<string, ImpulseListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulseListsByName", value);
			}
		}

		private Dictionary<string, OperationListMetadata> _actionListsByName
		{
			get
			{
				return (Dictionary<string, OperationListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actionListsByName"), typeof(Dictionary<string, OperationListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actionListsByName", value);
			}
		}

		private Dictionary<string, ReferenceMetadata> _referencesByName
		{
			get
			{
				return (Dictionary<string, ReferenceMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_referencesByName"), typeof(Dictionary<string, ReferenceMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_referencesByName", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public System.String Overload
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Overload", value);
			}
		}

		public System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPassthrough", value);
			}
		}

		public System.Boolean IsPotentiallyListeningToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPotentiallyListeningToChanges"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPotentiallyListeningToChanges", value);
			}
		}

		public System.Int32 FixedInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedReferenceCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32));
			}
		}

		public System.Int32 FixedGlobalRefCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DynamicGlobalRefCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefCount"), typeof(System.Int32));
			}
		}

		public List<InputMetadata> FixedInputs
		{
			get
			{
				return (List<InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputs"), typeof(List<InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedInputs", value);
			}
		}

		public List<OutputMetadata> FixedOutputs
		{
			get
			{
				return (List<OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputs"), typeof(List<OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedOutputs", value);
			}
		}

		public List<ImpulseMetadata> FixedImpulses
		{
			get
			{
				return (List<ImpulseMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulses"), typeof(List<ImpulseMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedImpulses", value);
			}
		}

		public List<OperationMetadata> FixedOperations
		{
			get
			{
				return (List<OperationMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperations"), typeof(List<OperationMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedOperations", value);
			}
		}

		public List<ReferenceMetadata> FixedReferences
		{
			get
			{
				return (List<ReferenceMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferences"), typeof(List<ReferenceMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedReferences", value);
			}
		}

		public List<GlobalRefMetadata> FixedGlobalRefs
		{
			get
			{
				return (List<GlobalRefMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedGlobalRefs", value);
			}
		}

		public List<InputListMetadata> DynamicInputs
		{
			get
			{
				return (List<InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputs"), typeof(List<InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicInputs", value);
			}
		}

		public List<OutputListMetadata> DynamicOutputs
		{
			get
			{
				return (List<OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputs"), typeof(List<OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicOutputs", value);
			}
		}

		public List<ImpulseListMetadata> DynamicImpulses
		{
			get
			{
				return (List<ImpulseListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulses"), typeof(List<ImpulseListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicImpulses", value);
			}
		}

		public List<OperationListMetadata> DynamicOperations
		{
			get
			{
				return (List<OperationListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperations"), typeof(List<OperationListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicOperations", value);
			}
		}

		public List<GlobalRefListMetadata> DynamicGlobalRefs
		{
			get
			{
				return (List<GlobalRefListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicGlobalRefs", value);
			}
		}

		public System.Boolean HasDynamicInputs
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicInputs"), typeof(System.Boolean));
			}
		}

		public System.Boolean HasDynamicOutputs
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicOutputs"), typeof(System.Boolean));
			}
		}

		public System.Boolean HasDynamicImpulses
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicImpulses"), typeof(System.Boolean));
			}
		}

		public System.Boolean HasDynamicActions
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicActions"), typeof(System.Boolean));
			}
		}

		public System.Boolean HasDynamicGlobalRefs
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicGlobalRefs"), typeof(System.Boolean));
			}
		}

		public System.Int32 FixedArgumentCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedArgumentCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedArgumentCount", value);
			}
		}

		public System.Int32 FixedContinuationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedContinuationCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedContinuationCount", value);
			}
		}

		public System.Int32 FixedCallCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedCallCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedCallCount", value);
			}
		}

		public System.Int32 FixedAsyncCallCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedAsyncCallCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedAsyncCallCount", value);
			}
		}

		public System.Int32 FixedSyncOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedSyncOperationCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedSyncOperationCount", value);
			}
		}

		public System.Int32 FixedAsyncOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedAsyncOperationCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedAsyncOperationCount", value);
			}
		}

		public void ComputeMetadata()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeMetadata");
		}

		public InputMetadata GetInputByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputByName", name), typeof(InputMetadata)) is InputMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to InputMetadata");
			}
		}

		public OutputMetadata GetOutputByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputByName", name), typeof(OutputMetadata)) is OutputMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OutputMetadata");
			}
		}

		public ImpulseMetadata GetImpulseByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseByName", name), typeof(ImpulseMetadata)) is ImpulseMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseMetadata");
			}
		}

		public OperationMetadata GetOperationByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationByName", name), typeof(OperationMetadata)) is OperationMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationMetadata");
			}
		}

		public InputListMetadata GetInputListByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListByName", name), typeof(InputListMetadata)) is InputListMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to InputListMetadata");
			}
		}

		public OutputListMetadata GetOutputListByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListByName", name), typeof(OutputListMetadata)) is OutputListMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OutputListMetadata");
			}
		}

		public ImpulseListMetadata GetImpulseListByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListByName", name), typeof(ImpulseListMetadata)) is ImpulseListMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseListMetadata");
			}
		}

		public OperationListMetadata GetOperationListByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListByName", name), typeof(OperationListMetadata)) is OperationListMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationListMetadata");
			}
		}

		public ReferenceMetadata GetReferenceByName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceByName", name), typeof(ReferenceMetadata)) is ReferenceMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ReferenceMetadata");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class NodeMetadataHelper
	{
		private static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		public static NodeMetadata GetMetadata(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadata", type), typeof(NodeMetadata)) is NodeMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeMetadata");
			}
		}
	}
	public class OperationListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public System.Boolean SupportsSync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportsSync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportsSync", value);
			}
		}

		public System.Boolean SupportsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportsAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				return (PossibleContinuationsAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PossibleContinuations", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OperationListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OperationListMetadata()
		{
		}
	}
	public class OperationMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public System.Boolean IsSelf
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelf"), typeof(System.Boolean));
			}
		}

		public System.Boolean IsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				return (PossibleContinuationsAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PossibleContinuations", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OperationMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class OutputListMetadata : OutputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type TypeConstraint
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TypeConstraint"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TypeConstraint", value);
			}
		}

		public DataClass? DataClassConstraint
		{
			get
			{
				return (DataClass?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClassConstraint"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClassConstraint", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OutputListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OutputListMetadata()
		{
		}
	}
	public class OutputMetadata : OutputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OutputType", value);
			}
		}

		public DataClass DataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClass", value);
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsImplicit", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OutputMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum OutputChangeSource
	{
		Passthrough,
		Individual,
		Continuous,
		Dynamic
	}
	public abstract class OutputMetadataBase : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public PropertyInfo ChangeTypeEval
		{
			get
			{
				return (PropertyInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTypeEval"), typeof(PropertyInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeTypeEval", value);
			}
		}

		public OutputChangeSource ChangeType
		{
			get
			{
				return (OutputChangeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeType"), typeof(OutputChangeSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeType", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class ReferenceMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public Type ReferenceType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferenceType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReferenceType", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ReferenceMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ReferenceMetadata()
		{
		}
	}
	public interface INode : ResoniteBridge.ResoniteBridgeValueHolder
	{
		NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
		}

		NodeMetadata Metadata
		{
			get
			{
				return (NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata));
			}
		}

		System.Int32 IndexInGroup
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		System.Int32 AllocationIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32));
			}
		}

		System.String Overload
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String));
			}
		}

		System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		System.Boolean ListensToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean));
			}
		}

		System.Int32 InputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32));
			}
		}

		System.Int32 OutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32));
			}
		}

		System.Int32 ArgumentCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32));
			}
		}

		System.Int32 ImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32));
			}
		}

		System.Int32 OperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedReferenceCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32));
			}
		}

		System.Int32 FixedGlobalRefCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32));
			}
		}

		System.Int32 DynamicInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32));
			}
		}

		System.Int32 DynamicOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32));
			}
		}

		System.Int32 DynamicImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32));
			}
		}

		System.Int32 DynamicOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32));
			}
		}

		void Initialize(NodeRuntime runtime, System.Int32 allocationIndex);

		void Dispose();

		void SetInputSource(ElementRef input, IOutput source);

		IOutput GetInputSource(System.Int32 index);

		void SetInputSource(System.Int32 index, IOutput source);

		System.String GetInputName(System.Int32 index);

		Type GetInputType(System.Int32 index);

		DataClass GetInputTypeClass(System.Int32 index);

		System.Object GetInputDefaultValue(System.Int32 index);

		System.Boolean IsInputConditional(System.Int32 index);

		System.Boolean IsInputListeningToChanges(System.Int32 index);

		CrossRuntimeInputAttribute GetInputCrossRuntime(System.Int32 index);

		IInputList GetInputList(System.Int32 index);

		System.String GetInputListName(System.Int32 index);

		Type GetInputListTypeConstraint(System.Int32 index);

		IOutput GetOutput(System.Int32 index);

		System.String GetOutputName(System.Int32 index);

		Type GetOutputType(System.Int32 index);

		DataClass GetOutputTypeClass(System.Int32 index);

		System.Boolean IsOutputImplicit(System.Int32 index);

		OutputChangeSource GetOutputChangeType(System.Int32 index);

		IOutputList GetOutputList(System.Int32 index);

		System.String GetOutputListName(System.Int32 index);

		System.String GetImpulseName(System.Int32 index);

		IOperation GetImpulseTarget(System.Int32 index);

		void SetImpulseTarget(System.Int32 index, IOperation target);

		IOperation GetOperation(System.Int32 index);

		System.String GetOperationName(System.Int32 index);

		System.Boolean IsOperationAsync(System.Int32 index);

		System.Boolean CanOperationContinueTo(System.Int32 index, System.String impulseName);

		IImpulseList GetImpulseList(System.Int32 index);

		System.String GetImpulseListName(System.Int32 index);

		System.Boolean CanOperationListContinueTo(System.Int32 index, System.String impulseName);

		IOperationList GetOperationList(System.Int32 index);

		System.String GetOperationListName(System.Int32 index);

		ImpulseType GetImpulseType(System.Int32 index);

		System.Boolean OperationHasSingleContinuation(System.Int32 index);

		System.Boolean OperationHasSyncAsyncTransition(System.Int32 index);

		System.String GetReferenceName(System.Int32 index);

		Type GetReferenceType(System.Int32 index);

		INode GetReferenceTarget(System.Int32 index);

		void SetReferenceTarget(System.Int32 index, INode target);

		System.Boolean TrySetReferenceTarget(System.Int32 index, INode target);

		System.String GetGlobalRefName(System.Int32 index);

		Type GetGlobalRefValueType(System.Int32 index);

		Global GetGlobalRefBinding(System.Int32 index);

		void SetGlobalRefBinding(System.Int32 index, Global binding);

		System.Boolean TrySetGlobalRefBinding(System.Int32 index, Global binding);

		void CopyDynamicOutputLayout(INode source);

		void CopyDynamicOperationLayout(INode source);
	}
	public abstract class Node : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Int32 IndexInGroup
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		public System.Int32 AllocationIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllocationIndex", value);
			}
		}

		public virtual NodeMetadata Metadata
		{
			get
			{
				return (NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata));
			}
		}

		public virtual System.String Overload
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String));
			}
		}

		public virtual System.Boolean IsPassthrough
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean));
			}
		}

		public virtual System.Boolean ListensToChanges
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean));
			}
		}

		public virtual System.Int32 InputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 OutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 ImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 ArgumentCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 OperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedReferenceCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 FixedGlobalRefCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 DynamicInputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 DynamicOutputCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 DynamicImpulseCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32));
			}
		}

		public virtual System.Int32 DynamicOperationCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32));
			}
		}

		public void Initialize(NodeRuntime runtime, System.Int32 allocationIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", runtime, allocationIndex);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public virtual IOutput GetInputSource(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public virtual void SetInputSource(ElementRef input, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", input, source);
		}

		public virtual void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public virtual IInputList GetInputList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputList", index), typeof(IInputList)) is IInputList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IInputList");
			}
		}

		public virtual System.String GetInputListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual Type GetInputListTypeConstraint(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListTypeConstraint", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual IOutput GetOutput(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public virtual System.String GetOutputName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual IOutputList GetOutputList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputList", index), typeof(IOutputList)) is IOutputList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutputList");
			}
		}

		public virtual System.String GetOutputListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual System.String GetInputName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual Type GetInputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual DataClass GetInputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public virtual System.Object GetInputDefaultValue(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputDefaultValue", index), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to object");
			}
		}

		public virtual System.Boolean IsInputConditional(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.Boolean IsInputListeningToChanges(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputListeningToChanges", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual CrossRuntimeInputAttribute GetInputCrossRuntime(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputCrossRuntime", index), typeof(CrossRuntimeInputAttribute)) is CrossRuntimeInputAttribute __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CrossRuntimeInputAttribute");
			}
		}

		public virtual Type GetOutputType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual DataClass GetOutputTypeClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public virtual System.Boolean IsOutputImplicit(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOutputImplicit", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual OutputChangeSource GetOutputChangeType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputChangeType", index), typeof(OutputChangeSource)) is OutputChangeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OutputChangeSource");
			}
		}

		public virtual IOperation GetImpulseTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public virtual System.String GetImpulseName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		public virtual IImpulseList GetImpulseList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseList", index), typeof(IImpulseList)) is IImpulseList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IImpulseList");
			}
		}

		public virtual System.String GetImpulseListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual IOperation GetOperation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public virtual System.String GetOperationName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual System.Boolean IsOperationAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.Boolean CanOperationContinueTo(System.Int32 index, System.String impulseName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationContinueTo", index, impulseName), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.Boolean CanOperationListContinueTo(System.Int32 index, System.String impulseName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationListContinueTo", index, impulseName), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual IOperationList GetOperationList(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationList", index), typeof(IOperationList)) is IOperationList __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperationList");
			}
		}

		public virtual System.String GetOperationListName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual ImpulseType GetImpulseType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType)) is ImpulseType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseType");
			}
		}

		public virtual System.Boolean OperationHasSingleContinuation(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSingleContinuation", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.Boolean OperationHasSyncAsyncTransition(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSyncAsyncTransition", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.String GetReferenceName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual Type GetReferenceType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual INode GetReferenceTarget(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceTarget", index), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public virtual void SetReferenceTarget(System.Int32 index, INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReferenceTarget", index, node);
		}

		public virtual System.Boolean TrySetReferenceTarget(System.Int32 index, INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetReferenceTarget", index, node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public virtual System.String GetGlobalRefName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public virtual Type GetGlobalRefValueType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefValueType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public virtual Global GetGlobalRefBinding(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefBinding", index), typeof(Global)) is Global __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Global");
			}
		}

		public virtual void SetGlobalRefBinding(System.Int32 index, Global binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public virtual System.Boolean TrySetGlobalRefBinding(System.Int32 index, Global binding)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetGlobalRefBinding", index, binding), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void CopyDynamicOutputLayout(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyDynamicOutputLayout", node);
		}

		public void CopyDynamicOperationLayout(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyDynamicOperationLayout", node);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public Node()
		{
		}
	}
	public abstract class NodeRuntime : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private DataImportNode importNode
		{
			get
			{
				return (DataImportNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "importNode"), typeof(DataImportNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "importNode", value);
			}
		}

		private ImpulseExportNode exportNode
		{
			get
			{
				return (ImpulseExportNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "exportNode"), typeof(ImpulseExportNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "exportNode", value);
			}
		}

		private List<IOutput> dataExports
		{
			get
			{
				return (List<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataExports"), typeof(List<IOutput>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataExports", value);
			}
		}

		private OutputList dataImports
		{
			get
			{
				return (OutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataImports"), typeof(OutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataImports", value);
			}
		}

		private List<ImpulseImport> impulseImports
		{
			get
			{
				return (List<ImpulseImport>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseImports"), typeof(List<ImpulseImport>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseImports", value);
			}
		}

		private List<ImpulseExport> impulseExports
		{
			get
			{
				return (List<ImpulseExport>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseExports"), typeof(List<ImpulseExport>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseExports", value);
			}
		}

		private List<Global> globals
		{
			get
			{
				return (List<Global>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globals"), typeof(List<Global>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "globals", value);
			}
		}

		public NodeGroup Group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		public abstract System.Int32 NodeCount { get; }

		public System.Int32 DataImportsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataImportsCount"), typeof(System.Int32));
			}
		}

		public System.Int32 DataExportsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataExportsCount"), typeof(System.Int32));
			}
		}

		public IEnumerable<IOutput> DataExports
		{
			get
			{
				return (IEnumerable<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataExports"), typeof(IEnumerable<IOutput>));
			}
		}

		public System.Int32 ImpulseImportsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseImportsCount"), typeof(System.Int32));
			}
		}

		public System.Int32 ImpulseExportCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseExportCount"), typeof(System.Int32));
			}
		}

		public System.Int32 GlobalsCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalsCount"), typeof(System.Int32));
			}
		}

		public abstract INode AddNode(Type type);

		public abstract System.Boolean RemoveNode(INode node);

		public abstract System.Int32 RemoveNodes(Predicate<INode> predicate);

		public abstract INode GetNodeGeneric(System.Int32 index);

		public abstract void TranslateInputs(INode target, INode source, Dictionary<INode, INode> nodeReplacements = null, List<InsertedConversion> insertedConversions = null);

		public abstract void TranslateImpulses(INode target, INode source, Dictionary<INode, INode> nodeReplcements = null);

		public abstract void TranslateReferences(INode target, INode source, Dictionary<INode, INode> nodeReplacements = null);

		public abstract void SortNodesByIndex();

		internal abstract System.Int32 ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, System.Boolean cache) where T : INode;

		internal void Init(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Init", group);
		}

		public abstract Type GetCompatibleNodeType(Type type);

		public ValueOutput<T> AddValueImport<T>() where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddValueImport"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
			}
		}

		public ObjectOutput<T> AddObjectImport<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddObjectImport"), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
			}
		}

		public ValueOutput<T> GetValueImport<T>(System.Int32 index) where T : struct
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueImport", index), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
			}
		}

		public ObjectOutput<T> GetObjectImport<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetObjectImport", index), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
			}
		}

		public IOutput GetImport(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImport", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public Type GetImportType(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportType", index), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public DataClass GetImportDataClass(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportDataClass", index), typeof(DataClass)) is DataClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to DataClass");
			}
		}

		public IOutput GetValueExport(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueExport", index), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public void SetValueExport(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValueExport", index, source);
		}

		public void AddExport(IOutput output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddExport", output);
		}

		public void RemoveExport(IOutput output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveExport", output);
		}

		public void ClearValueExports()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearValueExports");
		}

		public void AddImpulseImport(IOperation operation, System.Boolean isAsync = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulseImport", operation, isAsync);
		}

		public void AddSyncImpulseImport(ISyncOperation operation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddSyncImpulseImport", operation);
		}

		public void AddAsyncImpulseImport(IOperation operation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddAsyncImpulseImport", operation);
		}

		public System.Boolean IsImpulseImportAsync(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsImpulseImportAsync", index), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void RemoveImpulseImport(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveImpulseImport", index);
		}

		public void SetImpulseImport(System.Int32 index, IOperation operation, System.Boolean isAsync)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseImport", index, operation, isAsync);
		}

		public void ClearImpulseImports()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearImpulseImports");
		}

		public IOperation GetImpulseImport(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseImport", index), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}

		public ContinuationExport AddContinuationExport()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContinuationExport"), typeof(ContinuationExport)) is ContinuationExport __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ContinuationExport");
			}
		}

		public CallExport AddCallExport()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddCallExport"), typeof(CallExport)) is CallExport __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CallExport");
			}
		}

		public AsyncCallExport AddAsyncCallExport()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddAsyncCallExport"), typeof(AsyncCallExport)) is AsyncCallExport __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AsyncCallExport");
			}
		}

		public void ClearImpulseExports()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearImpulseExports");
		}

		public Global<T> AddGlobal<T>(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGlobal", name), typeof(Global<T>)) is Global<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Global<T>");
			}
		}

		public Global GetGlobal(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobal", index), typeof(Global)) is Global __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Global");
			}
		}

		public Global<T> GetGlobal<T>(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobal", index), typeof(Global<T>)) is Global<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Global<T>");
			}
		}

		public void ClearGlobals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearGlobals");
		}

		public void RemapImportsAndExports(Dictionary<INode, INode> remappedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemapImportsAndExports", remappedNodes);
		}

		public static System.Boolean CanTargetRuntime(NodeRuntime ownerRuntime, CrossRuntimeInputAttribute inputCrossRuntime, IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "CanTargetRuntime", ownerRuntime, inputCrossRuntime, source), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean CanTargetRuntime(NodeRuntime ownerRuntime, CrossRuntimeInputAttribute inputCrossRuntime, NodeRuntime targetRuntime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "CanTargetRuntime", ownerRuntime, inputCrossRuntime, targetRuntime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean AreSameRuntimeTypes(NodeRuntime ownerRuntime, IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "AreSameRuntimeTypes", ownerRuntime, source), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean AreSameRuntimeTypes(NodeRuntime ownerRuntime, NodeRuntime targetRuntime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "AreSameRuntimeTypes", ownerRuntime, targetRuntime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeRuntime()
		{
		}
	}
	public abstract class NodeRuntime<N> : NodeRuntime, ResoniteBridge.ResoniteBridgeValueHolder where N : class, INode
	{
		private List<N> nodes
		{
			get
			{
				return (List<N>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodes"), typeof(List<N>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nodes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue cachedNodeTypes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedNodeTypes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cachedNodeTypes", value);
			}
		}

		private List<IExecutionNestedNode> cachedNestedNodes
		{
			get
			{
				return (List<IExecutionNestedNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedNestedNodes"), typeof(List<IExecutionNestedNode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cachedNestedNodes", value);
			}
		}

		public override System.Int32 NodeCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeCount"), typeof(System.Int32));
			}
		}

		public IEnumerable<N> Nodes
		{
			get
			{
				return (IEnumerable<N>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<N>));
			}
		}

		public static System.Boolean IsCompatibleNodeType(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "IsCompatibleNodeType", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public N GetNode(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNode", index), typeof(N)) is N __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to N");
			}
		}

		public override INode GetNodeGeneric(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodeGeneric", index), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public void AddNode(N node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode", node);
		}

		public T AddNode<T>() where T : N, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode"), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public override INode AddNode(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode", type), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public override System.Boolean RemoveNode(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveNode", node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 RemoveNodes(Predicate<INode> predicate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveNodes", predicate), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public override void SortNodesByIndex()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SortNodesByIndex");
		}

		public override Type GetCompatibleNodeType(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public ConnectionResult ConnectInput(INode node, System.String inputName, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectInput", node, inputName, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult ConnectListInput(INode node, System.String listName, System.Int32 inputIndex, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectListInput", node, listName, inputIndex, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult ConnectListInput(INode node, System.String listName, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectListInput", node, listName, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult ConnectInput(INode node, ElementRef input, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectInput", node, input, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult SetReference(INode node, System.String referenceName, INode target, System.Boolean overload = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", node, referenceName, target, overload), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult SetReference(INode node, System.Int32 referenceIndex, INode target, System.Boolean overload = true, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", node, referenceIndex, target, overload, allowMergingGroups), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public override void TranslateInputs(INode target, INode source, Dictionary<INode, INode> remappedNodes = null, List<InsertedConversion> insertedCasts = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TranslateInputs", target, source, remappedNodes, insertedCasts);
		}

		public override void TranslateImpulses(INode target, INode source, Dictionary<INode, INode> remappedNodes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TranslateImpulses", target, source, remappedNodes);
		}

		public override void TranslateReferences(INode target, INode source, Dictionary<INode, INode> remappedNodes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TranslateReferences", target, source, remappedNodes);
		}

		public IEnumerable<IExecutionNestedNode> GetNestedNodes(System.Boolean cache)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedNodes", cache), typeof(IEnumerable<IExecutionNestedNode>)) is IEnumerable<IExecutionNestedNode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<IExecutionNestedNode>");
			}
		}

		public IEnumerable<T> GetNodesOfType<T>(System.Boolean cache) where T : INode
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodesOfType", cache), typeof(IEnumerable<T>)) is IEnumerable<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<T>");
			}
		}

		internal override System.Int32 ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, System.Boolean cache)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachNode", action, context, cache), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		protected void ClearQueryCaches()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearQueryCaches");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeRuntime()
		{
		}
	}
	public struct ElementPath<E> : IEquatable<ElementPath<E>>, IComparable<ElementPath<E>>, ResoniteBridge.ResoniteBridgeValueHolder where E : class
	{
		public NodeContextPath path
		{
			get
			{
				return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(NodeContextPath));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
			}
		}

		public E element
		{
			get
			{
				return (E)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "element"), typeof(E));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "element", value);
			}
		}

		public ElementPath<E> Nest(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Nest", node), typeof(ElementPath<E>)) is ElementPath<E> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ElementPath<E>");
			}
		}

		public System.Boolean Equals(ElementPath<E> other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Int32 CompareTo(ElementPath<E> other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ElementPath(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct NodeContextPath : IEquatable<NodeContextPath>, IComparable<NodeContextPath>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private INode[] path
		{
			get
			{
				return (INode[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(INode[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
			}
		}

		public System.Int32 PathLength
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PathLength"), typeof(System.Int32));
			}
		}

		public INode this[System.Int32 index] => GetNode(index);

		public INode GetNode(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNode", index), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public NodeContextPath Nest(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Nest", node), typeof(NodeContextPath)) is NodeContextPath __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeContextPath");
			}
		}

		public System.Boolean Equals(NodeContextPath other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Int32 CompareTo(NodeContextPath other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.Int32 FindSharedRootLength(NodeContextPath other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindSharedRootLength", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeContextPath(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeContextPath()
		{
		}
	}
	public delegate void NodeEnumerationAction<T>(T node, NodeEnumerationContext context) where T : INode;
	public class NodeEnumerationContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<NodeGroup> enteredGroups
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "enteredGroups"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "enteredGroups", value);
			}
		}

		private List<INestedNode> nodePath
		{
			get
			{
				return (List<INestedNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodePath"), typeof(List<INestedNode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nodePath", value);
			}
		}

		public System.Int32 CurrentDepth
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentDepth"), typeof(System.Int32));
			}
		}

		public INestedNode GetNodePath(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodePath", index), typeof(INestedNode)) is INestedNode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INestedNode");
			}
		}

		public void Begin(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Begin", group);
		}

		public void End()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "End");
		}

		public System.Boolean TryEnterNestedNode(INestedNode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterNestedNode", node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void ExitNestedNode(INestedNode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitNestedNode", node);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeEnumerationContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class NodeQueryAcceleration : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<INode, HashSet<INode>> evaluatingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluatingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluatingNodes", value);
			}
		}

		private Dictionary<INode, HashSet<INode>> impulsingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulsingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulsingNodes", value);
			}
		}

		private Dictionary<INode, HashSet<INode>> referencingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "referencingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "referencingNodes", value);
			}
		}

		public NodeGroup Group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		private void Build()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Build");
		}

		public IEnumerable<INode> GetEvaluatingNodes(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEvaluatingNodes", node), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
			}
		}

		public IEnumerable<INode> GetImpulsingNodes(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulsingNodes", node), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
			}
		}

		public IEnumerable<INode> GetReferencingNodes(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferencingNodes", node), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeQueryAcceleration(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeQueryAcceleration()
		{
		}
	}
	public enum SourceElement
	{
		NONE,
		Input,
		Output,
		Impulse,
		Action,
		Reference,
		ReferencingNode
	}
	public class NodeQueryContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean WalkEvaluationInputs
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkEvaluationInputs"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkEvaluationInputs", value);
			}
		}

		public System.Boolean WalkImpulseTargets
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkImpulseTargets"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkImpulseTargets", value);
			}
		}

		public System.Boolean WalkReferences
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkReferences"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkReferences", value);
			}
		}

		public System.Boolean WalkEvaluatingNodes
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkEvaluatingNodes"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkEvaluatingNodes", value);
			}
		}

		public System.Boolean WalkImpulsingNodes
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkImpulsingNodes"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkImpulsingNodes", value);
			}
		}

		public System.Boolean WalkReferencingNodes
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkReferencingNodes"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkReferencingNodes", value);
			}
		}

		public System.Boolean SkipWalkingBack
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SkipWalkingBack"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SkipWalkingBack", value);
			}
		}

		public NodeRuntime OnlyRuntime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnlyRuntime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnlyRuntime", value);
			}
		}

		public Predicate<INode> NodeFilter
		{
			get
			{
				return (Predicate<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NodeFilter"), typeof(Predicate<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "NodeFilter", value);
			}
		}

		public Dictionary<INode, bool> WalkedNodes
		{
			get
			{
				return (Dictionary<INode, bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkedNodes"), typeof(Dictionary<INode, bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkedNodes", value);
			}
		}

		public HashSet<INode> LoopNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopNodes", value);
			}
		}

		public NodeQueryAcceleration Acceleration
		{
			get
			{
				return (NodeQueryAcceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Acceleration"), typeof(NodeQueryAcceleration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Acceleration", value);
			}
		}

		public System.Boolean RequiresAcceleration
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresAcceleration"), typeof(System.Boolean));
			}
		}

		public System.Boolean DetectedAnyLoops
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DetectedAnyLoops"), typeof(System.Boolean));
			}
		}

		public void EnsureAllocatedStructures(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureAllocatedStructures", node);
		}

		public System.Boolean BeginWalkingNode(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginWalkingNode", node), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void FinishWalkingNode(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishWalkingNode", node);
		}

		public void SetWalkAll()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetWalkAll");
		}

		public void SetWalkAllEvaluation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetWalkAllEvaluation");
		}

		public void SetWalkAllImpulses()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetWalkAllImpulses");
		}

		public void SetWalkAllReferences()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetWalkAllReferences");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeQueryContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class NodeQueryHelper
	{
		public static IEnumerable<INode> EnumerateNodes(this INode node, NodeQueryContext context, INode sourceNode = null, SourceElement sourceElementType = SourceElement.NONE, System.Object sourceElement = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeQueryHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateNodes", node, context, sourceNode, sourceElementType, sourceElement), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
			}
		}
	}
	public static class EvaluationValidator
	{
		public static System.Boolean IsSourceValid(this INode node, System.Int32 inputIndex, IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSourceValid", node, inputIndex, source), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean CanEvaluate(this INode node, System.Int32 inputIndex, IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanEvaluate", node, inputIndex, source), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean AreEvaluationConnectionsValid(this NodeGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean AreEvaluationConnectionsValid(this NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}
	}
	[Flags]
	public enum OperationInvokeSource
	{
		SyncImport = 1,
		AsyncImport = 2,
		Continuation = 4,
		SyncCall = 8,
		AsyncCall = 0x10,
		SyncResumption = 0x20,
		AsyncResumption = 0x40,
		NONE = 0,
		ALL_Imports = 3,
		ALL_Calls = 0x18,
		ALL_Sync = 0x29,
		ALL_Async = 0x52,
		ALL_Resumptions = 0x60,
		ALL = 0x7F
	}
	public struct ImpulseFlowContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean isAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isAsync", value);
			}
		}

		public System.Boolean isContinuation
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isContinuation"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isContinuation", value);
			}
		}

		public HashSet<IOperation> allWalkedOperations
		{
			get
			{
				return (HashSet<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "allWalkedOperations"), typeof(HashSet<IOperation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "allWalkedOperations", value);
			}
		}

		public HashSet<IOperation> continuationLoopOperations
		{
			get
			{
				return (HashSet<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuationLoopOperations"), typeof(HashSet<IOperation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "continuationLoopOperations", value);
			}
		}

		public void ClearContinuation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearContinuation");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseFlowContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct ImpulseSource : IEquatable<ImpulseSource>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode node
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "node"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "node", value);
			}
		}

		public System.Int32 impulseIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseIndex", value);
			}
		}

		public System.Boolean Equals(ImpulseSource other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseSource()
		{
		}
	}
	public abstract class ImpulseValidationError : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract System.String Description { get; }

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseValidationError()
		{
		}
	}
	public class InvalidImpulseTargetError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode SourceNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SourceNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SourceNode", value);
			}
		}

		public System.Int32 ImpulseIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation TargetOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TargetOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "TargetOperation", value);
			}
		}

		public System.String Reason
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reason"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reason", value);
			}
		}

		public override System.String Description
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InvalidImpulseTargetError(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InvalidImpulseTargetError()
		{
		}
	}
	public class ImpulseLoopError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode Node
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Node"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Node", value);
			}
		}

		public System.Int32 ImpulseIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public System.Boolean IsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "IsAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "IsAsync", value);
			}
		}

		public override System.String Description
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseLoopError(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseLoopError()
		{
		}
	}
	public class ImpulseFlowError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode ReferencingNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ReferencingNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ReferencingNode", value);
			}
		}

		public System.Int32 ImpulseIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		public System.Boolean ContextIsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContextIsAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ContextIsAsync", value);
			}
		}

		public System.Boolean ContextIsContinuation
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContextIsContinuation"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ContextIsContinuation", value);
			}
		}

		public System.String Reason
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reason"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reason", value);
			}
		}

		public IOperation Origin
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Origin"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Origin", value);
			}
		}

		public System.Boolean OriginIsAsync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginIsAsync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginIsAsync", value);
			}
		}

		public System.Boolean OriginIsContinuation
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginIsContinuation"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginIsContinuation", value);
			}
		}

		public override System.String Description
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
			}
		}

		public void SetOriginInfo(IOperation origin, System.Boolean originIsAsync, System.Boolean originIsContinuation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetOriginInfo", origin, originIsAsync, originIsContinuation);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ImpulseFlowError(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class ImpulseValidator
	{
		public static InvalidImpulseTargetError ValidateTarget(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateTarget", node, impulseIndex, target), typeof(InvalidImpulseTargetError)) is InvalidImpulseTargetError __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to InvalidImpulseTargetError");
			}
		}

		public static System.Boolean CanImpulse(this INode node, System.String impulseName, IOperation target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseName, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean CanImpulse(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseIndex, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean WouldFormContinuationLoop(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "WouldFormContinuationLoop", node, impulseIndex, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesForImpulse(this INode node, System.Int32 impulseIndex)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesForImpulse", node, impulseIndex), typeof(OperationInvokeSource)) is OperationInvokeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationInvokeSource");
			}
		}

		public static OperationInvokeSource ComputeNodeOperationInvokeSources(this INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeNodeOperationInvokeSources", node), typeof(OperationInvokeSource)) is OperationInvokeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationInvokeSource");
			}
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromImpulseImport(NodeRuntime runtime, System.Int32 importIndex, INode target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromImpulseImport", runtime, importIndex, target), typeof(OperationInvokeSource)) is OperationInvokeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationInvokeSource");
			}
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromSource(this INode node, INode target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromSource", node, target), typeof(OperationInvokeSource)) is OperationInvokeSource __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OperationInvokeSource");
			}
		}

		public static System.Boolean ReachesAsyncOperation(this IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ReachesAsyncOperation", operation), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static ImpulseValidationError ValidateImpulseFlow(this IOperation targettedOperation, ImpulseFlowContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseFlow", targettedOperation, context), typeof(ImpulseValidationError)) is ImpulseValidationError __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseValidationError");
			}
		}

		public static void GetSourcesUnreachableFromImports(this NodeRuntime runtime, HashSet<ImpulseSource> sources)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "GetSourcesUnreachableFromImports", runtime, sources);
		}

		private static void RemoveReachableSources(IOperation operation, HashSet<ImpulseSource> sources, HashSet<Node> walkedNodes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "RemoveReachableSources", operation, sources, walkedNodes);
		}

		public static ImpulseValidationError ValidateImpulseConnections(this NodeGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", group), typeof(ImpulseValidationError)) is ImpulseValidationError __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseValidationError");
			}
		}

		public static ImpulseValidationError ValidateImpulseConnections(this NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", runtime), typeof(ImpulseValidationError)) is ImpulseValidationError __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ImpulseValidationError");
			}
		}
	}
	public static class NodeHelper
	{
		public static System.Int32 FindLinearOutputIndex(this IOutput output)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOutputIndex", output), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static System.Int32 FindLinearOperationIndex(this IOperation operation)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOperationIndex", operation), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static IOutput RemapOutput(this IOutput output, Dictionary<INode, INode> remappedNodes = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RemapOutput", output, remappedNodes), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public static IOperation RemapTarget(this IOperation target, Dictionary<INode, INode> remappedNodes = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RemapTarget", target, remappedNodes), typeof(IOperation)) is IOperation __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOperation");
			}
		}
	}
	public class ObjectCastAttribute : Attribute
	{
		public ObjectCastAttribute()
		{
		}
	}
	public abstract class Output<T> : IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Node _node
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_node"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_node", value);
			}
		}

		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}

		public abstract DataClass OutputDataClass { get; }

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public abstract class OutputNode<T> : Node, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node));
			}
		}

		public System.Int32 OutputIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputIndex"), typeof(System.Int32));
			}
		}

		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}

		public abstract DataClass OutputDataClass { get; }

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OutputNode()
		{
		}
	}
	public abstract class ValueOutputNode<T> : OutputNode<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override DataClass OutputDataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass));
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ValueOutputNode()
		{
		}
	}
	public struct InsertedConversion : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode conversion
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "conversion"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "conversion", value);
			}
		}

		public INode targetNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "targetNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "targetNode", value);
			}
		}

		public ElementRef targetInput
		{
			get
			{
				return (ElementRef)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "targetInput"), typeof(ElementRef));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "targetInput", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InsertedConversion(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InsertedConversion()
		{
		}
	}
	public struct ConnectionResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean connected
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "connected"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "connected", value);
			}
		}

		public System.String failReason
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "failReason"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "failReason", value);
			}
		}

		public List<InsertedConversion> conversions
		{
			get
			{
				return (List<InsertedConversion>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "conversions"), typeof(List<InsertedConversion>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "conversions", value);
			}
		}

		public NodeOverloadContext overload
		{
			get
			{
				return (NodeOverloadContext)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "overload"), typeof(NodeOverloadContext));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "overload", value);
			}
		}

		public static ConnectionResult Success
		{
			get
			{
				return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Success"), typeof(ConnectionResult));
			}
		}

		public ConnectionResult Combine(ConnectionResult other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Combine", other), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public ConnectionResult AddInsertedConversion(InsertedConversion conversion)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInsertedConversion", conversion), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public static ConnectionResult Failed(System.String reason)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Failed", reason), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public static ConnectionResult Conversion(InsertedConversion conversion)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Conversion", conversion), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public static ConnectionResult Conversions(List<InsertedConversion> conversions)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Conversions", conversions), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public static ConnectionResult Overload(NodeOverloadContext overload)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Overload", overload), typeof(ConnectionResult)) is ConnectionResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ConnectionResult");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public ConnectionResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface ICast : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean IsImplicit
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean));
			}
		}

		Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type));
			}
		}

		Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type));
			}
		}
	}
	public struct InputType : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "type", value);
			}
		}

		public NodeRuntime runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "runtime", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public InputType(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputType()
		{
		}
	}
	public class NodeConnections : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Dictionary<string, InputType> fixedInputs
		{
			get
			{
				return (Dictionary<string, InputType>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "fixedInputs"), typeof(Dictionary<string, InputType>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "fixedInputs", value);
			}
		}

		public Dictionary<string, List<InputType>> listInputs
		{
			get
			{
				return (Dictionary<string, List<InputType>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "listInputs"), typeof(Dictionary<string, List<InputType>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "listInputs", value);
			}
		}

		public Dictionary<string, InputType> fixedReferences
		{
			get
			{
				return (Dictionary<string, InputType>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "fixedReferences"), typeof(Dictionary<string, InputType>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "fixedReferences", value);
			}
		}

		public System.Boolean SetInput(ElementRef input, System.String name, Type type, NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInput", input, name, type, runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean SetInput(System.String name, Type type, NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInput", name, type, runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean SetReference(System.String name, Type type, NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", name, type, runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean SetListInput(System.String name, System.Int32 index, Type type, NodeRuntime runtime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetListInput", name, index, type, runtime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static NodeConnections GetFromNode(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeConnections", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFromNode", node), typeof(NodeConnections)) is NodeConnections __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeConnections");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeConnections(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeOverloadAttribute : Attribute
	{
		public System.String OverloadName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverloadName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverloadName", value);
			}
		}
	}
	public class NodeOverloadCollection : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<Type> _overloads
		{
			get
			{
				return (List<Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_overloads"), typeof(List<Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_overloads", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public IEnumerable<Type> Overloads
		{
			get
			{
				return (IEnumerable<Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overloads"), typeof(IEnumerable<Type>));
			}
		}

		internal void Add(Type type)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", type);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeOverloadCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct OverloadResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String failReason
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "failReason"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "failReason", value);
			}
		}

		public System.Boolean IsSuccess
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSuccess"), typeof(System.Boolean));
			}
		}

		public static OverloadResult Success
		{
			get
			{
				return (OverloadResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Success"), typeof(OverloadResult));
			}
		}

		public static OverloadResult Fail(System.String reason)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Fail", reason), typeof(OverloadResult)) is OverloadResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OverloadResult");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OverloadResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OverloadResult()
		{
		}
	}
	public class NodeOverloadContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<INode, Type> overloads
		{
			get
			{
				return (Dictionary<INode, Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "overloads"), typeof(Dictionary<INode, Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "overloads", value);
			}
		}

		private Dictionary<INode, INode> swappedNodes
		{
			get
			{
				return (Dictionary<INode, INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "swappedNodes"), typeof(Dictionary<INode, INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "swappedNodes", value);
			}
		}

		private HashSet<INode> affectedEvaluatingNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "affectedEvaluatingNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "affectedEvaluatingNodes", value);
			}
		}

		private HashSet<INode> affectedImpulsingNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "affectedImpulsingNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "affectedImpulsingNodes", value);
			}
		}

		private List<InsertedConversion> insertedCasts
		{
			get
			{
				return (List<InsertedConversion>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "insertedCasts"), typeof(List<InsertedConversion>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "insertedCasts", value);
			}
		}

		private NodeQueryAcceleration query
		{
			get
			{
				return (NodeQueryAcceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "query"), typeof(NodeQueryAcceleration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "query", value);
			}
		}

		public NodeGroup Group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Boolean OverloadedAnyNodes
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverloadedAnyNodes"), typeof(System.Boolean));
			}
		}

		public IEnumerable<KeyValuePair<INode, Type>> Overloads
		{
			get
			{
				return (IEnumerable<KeyValuePair<INode, Type>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overloads"), typeof(IEnumerable<KeyValuePair<INode, Type>>));
			}
		}

		public IEnumerable<KeyValuePair<INode, INode>> SwappedNodes
		{
			get
			{
				return (IEnumerable<KeyValuePair<INode, INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SwappedNodes"), typeof(IEnumerable<KeyValuePair<INode, INode>>));
			}
		}

		public IEnumerable<INode> AffectedEvaluatingNodes
		{
			get
			{
				return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedEvaluatingNodes"), typeof(IEnumerable<INode>));
			}
		}

		public IEnumerable<INode> AffectedImpulsingNodes
		{
			get
			{
				return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedImpulsingNodes"), typeof(IEnumerable<INode>));
			}
		}

		public List<InsertedConversion> InsertedCasts
		{
			get
			{
				return (List<InsertedConversion>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InsertedCasts"), typeof(List<InsertedConversion>));
			}
		}

		public INode GetSwappedNode(INode sourceNode)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSwappedNode", sourceNode), typeof(INode)) is INode __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to INode");
			}
		}

		public OverloadResult TryOverload(INode node, NodeConnections connections, System.Boolean allowMergingGroups = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryOverload", node, connections, allowMergingGroups), typeof(OverloadResult)) is OverloadResult __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to OverloadResult");
			}
		}

		public void SwapNodes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SwapNodes");
		}

		private NodeConnections GetModifiedConnections(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetModifiedConnections", node), typeof(NodeConnections)) is NodeConnections __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeConnections");
			}
		}

		public Type GetOverloadedType(INode node)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOverloadedType", node), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		private Type GetOverloadedType(IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOverloadedType", source), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public NodeOverloadContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeOverloadContext()
		{
		}
	}
	public static class NodeOverloadHelper
	{
		private static Dictionary<string, NodeOverloadCollection> overloads
		{
			get
			{
				return (Dictionary<string, NodeOverloadCollection>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "overloads"), typeof(Dictionary<string, NodeOverloadCollection>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "overloads", value);
			}
		}

		private static CancellationTokenSource generationCancellation
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationCancellation"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationCancellation", value);
			}
		}

		private static System.Object generationLock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock", value);
			}
		}

		public static NodeOverloadCollection GetOverloads(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOverloads", name), typeof(NodeOverloadCollection)) is NodeOverloadCollection __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NodeOverloadCollection");
			}
		}

		public static Dictionary<string, NodeOverloadCollection> SearchOverloads()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SearchOverloads"), typeof(Dictionary<string, NodeOverloadCollection>)) is Dictionary<string, NodeOverloadCollection> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Dictionary<string, NodeOverloadCollection>");
			}
		}

		private static void CurrentDomain_AssemblyLoad(System.Object sender, AssemblyLoadEventArgs args)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CurrentDomain_AssemblyLoad", sender, args);
		}

		public static Type FindOverload(System.String name, Type currentType, OverloadSearchContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindOverload", name, currentType, context), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public static System.Int32 RankOverload(Type overload, OverloadSearchContext context)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankOverload", overload, context), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int?");
			}
		}

		public static IOutput SkipImplicitCasts(this IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SkipImplicitCasts", source), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public static IOutput GetActualConnectedSource(this IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetActualConnectedSource", source), typeof(IOutput)) is IOutput __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IOutput");
			}
		}

		public static Type GetActualConnectedType(this IOutput source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetActualConnectedType", source), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}
	}
	public class OverloadSearchContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static Type[] emptyTypes
		{
			get
			{
				return (Type[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadSearchContext", ResoniteBridge.ResoniteBridgeValueType.Type), "emptyTypes"), typeof(Type[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadSearchContext", ResoniteBridge.ResoniteBridgeValueType.Type), "emptyTypes", value);
			}
		}

		private Dictionary<Type, Type> genericParameters
		{
			get
			{
				return (Dictionary<Type, Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "genericParameters"), typeof(Dictionary<Type, Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "genericParameters", value);
			}
		}

		public NodeConnections Connections
		{
			get
			{
				return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Connections"), typeof(NodeConnections));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Connections", value);
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Runtime", value);
			}
		}

		public System.Boolean AllowMergingGroups
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllowMergingGroups"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllowMergingGroups", value);
			}
		}

		public Type GetCompatibleNodeType(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public void BeginNewOverload()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginNewOverload");
		}

		public System.Boolean CanTargetRuntime(InputMetadataBase input, NodeRuntime targetRuntime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanTargetRuntime", input, targetRuntime), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean CanAccomodate(Type source, Type target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccomodate", source, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean TryMatchGenericArguments(Type source, Type target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryMatchGenericArguments", source, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean UpdateGenericParameter(Type generic, Type newType)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGenericParameter", generic, newType), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Type InstanceType(Type type, Type currentType)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InstanceType", type, currentType), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OverloadSearchContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OverloadSearchContext()
		{
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class PassthroughNodeAttribute : Attribute
	{
		public PassthroughNodeAttribute()
		{
		}
	}
	public enum PrimitiveClass
	{
		NONE,
		Boolean,
		Char,
		String,
		SignedInteger,
		UnsignedInteger,
		FloatingPoint
	}
	public static class TypeHelper
	{
		public static System.Int32 RankType(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankType", type), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static System.Int32 GetPrimitiveRanking(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveRanking", type), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static System.Boolean CanImplicitlyConvertTo(Type from, Type to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImplicitlyConvertTo", from, to), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean CanExplicitlyConvertTo(Type from, Type to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanExplicitlyConvertTo", from, to), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static Type CombineTypes(Type a, Type b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CombineTypes", a, b), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public static Type AccomodatePrimitive(PrimitiveClass primitiveClass, Type target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AccomodatePrimitive", primitiveClass, target), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public static System.Int32 GetPrimitiveClassRank(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassRank", type), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static System.Int32 GetPrimitiveClassMaxRank(this PrimitiveClass primitiveClass)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassMaxRank", primitiveClass), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public static Type GetPrimitive(this PrimitiveClass primitiveClass, System.Int32 rank)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitive", primitiveClass, rank), typeof(Type)) is Type __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Type");
			}
		}

		public static System.Boolean CanAccomodate(this PrimitiveClass source, PrimitiveClass target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanAccomodate", source, target), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static PrimitiveClass ClassifyPrimitive(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ClassifyPrimitive", type), typeof(PrimitiveClass)) is PrimitiveClass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to PrimitiveClass");
			}
		}
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class PossibleContinuationsAttribute : Attribute
	{
		private HashSet<string> continuations
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuations"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "continuations", value);
			}
		}

		public IEnumerable<string> Continuations
		{
			get
			{
				return (IEnumerable<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Continuations"), typeof(IEnumerable<string>));
			}
		}

		public System.Boolean CanContinueTo(System.String str)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanContinueTo", str), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}
	}
	public interface ITaskScheduler : ResoniteBridge.ResoniteBridgeValueHolder
	{
		void Post(Operation action);
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class NodeCategoryAttribute : Attribute
	{
		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeNameAttribute : Attribute
	{
		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public System.Boolean SimpleView
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SimpleView"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SimpleView", value);
			}
		}
	}
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class OldElementNameAttribute : Attribute
	{
		public System.String OldName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OldName", value);
			}
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class OldNodeNameAttribute : Attribute
	{
		public System.String OldName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OldName", value);
			}
		}
	}
	public class OrderedSet<T> : IEnumerable<T>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<T> list
		{
			get
			{
				return (List<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "list"), typeof(List<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "list", value);
			}
		}

		private HashSet<T> set
		{
			get
			{
				return (HashSet<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "set"), typeof(HashSet<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "set", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
			}
		}

		public System.Boolean Add(T item)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", item), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public List<T>.Enumerator GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(List<T>.Enumerator)) is List<T>.Enumerator __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to List<T>.Enumerator");
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(IEnumerator)) is IEnumerator __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerator");
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(IEnumerator<T>)) is IEnumerator<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerator<T>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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

		public OrderedSet(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class ReflectionHelper
	{
		private static ResoniteBridge.ResoniteBridgeValue cachedTypes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes", value);
			}
		}

		public static System.Boolean IsUnmanaged(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsUnmanaged", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean IsNullable(this Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsNullable", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.String GetNiceTypeName(this Type type, System.String open = "<", System.String close = ">")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetNiceTypeName", type, open, close), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static MethodInfo FindMethodInHierarchy(this Type type, System.String name, BindingFlags flags)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindMethodInHierarchy", type, name, flags), typeof(MethodInfo)) is MethodInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to MethodInfo");
			}
		}

		public static IEnumerable<FieldInfo> EnumerateAllInstanceFields(this Type type, Predicate<Type> filter = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllInstanceFields", type, filter), typeof(IEnumerable<FieldInfo>)) is IEnumerable<FieldInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<FieldInfo>");
			}
		}

		public static IEnumerable<FieldInfo> EnumerateAllInstanceFields(this Type type, BindingFlags bindingFlags, Predicate<Type> filter = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllInstanceFields", type, bindingFlags, filter), typeof(IEnumerable<FieldInfo>)) is IEnumerable<FieldInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<FieldInfo>");
			}
		}

		public static IEnumerable<PropertyInfo> EnumerateAllProperties(this Type type, BindingFlags bindingFlags, Predicate<Type> filter = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllProperties", type, bindingFlags, filter), typeof(IEnumerable<PropertyInfo>)) is IEnumerable<PropertyInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<PropertyInfo>");
			}
		}
	}
	public class ValueCastAttribute : Attribute
	{
		public Type From
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "From"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "From", value);
			}
		}

		public Type To
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "To"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "To", value);
			}
		}
	}
}
internal class ProtoFluxCore_ProcessedByFody : ResoniteBridge.ResoniteBridgeValueHolder
{
	internal System.String FodyVersion
	{
		get
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "FodyVersion"), typeof(System.String));
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "FodyVersion", value);
		}
	}

	internal System.String NodeWeaver
	{
		get
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NodeWeaver"), typeof(System.String));
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "NodeWeaver", value);
		}
	}

	private ResoniteBridge.ResoniteBridgeValue __backing;

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

	public ProtoFluxCore_ProcessedByFody(ResoniteBridge.ResoniteBridgeValue value)
	{
		__backing = value;
	}
}
