using ResoniteBridge;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnumsNET;
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueBottom"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueBottom", value);
				}
			}

			public System.Int32 objectBottom
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectBottom"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectBottom", value);
				}
			}

			public System.UInt16 pinCount
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "pinCount"), typeof(System.UInt16)) is System.UInt16 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ushort");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "pinCount", value);
				}
			}

			public System.UInt16 sourceFrame
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sourceFrame"), typeof(System.UInt16)) is System.UInt16 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ushort");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sourceFrame", value);
				}
			}

			public System.Int32 valueStoreOffset
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueStoreOffset", value);
				}
			}

			public System.Int32 objectStoreOffset
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectStoreOffset", value);
				}
			}

			public IExecutionRuntime runtime
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nestedNode"), typeof(IExecutionNestedNode)) is IExecutionNestedNode __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IExecutionNestedNode");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nestedNode", value);
				}
			}

			public ScopePoint sharedScope
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sharedScope"), typeof(ScopePoint)) is ScopePoint __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ScopePoint");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sharedScope", value);
				}
			}

			public override System.String ToString()
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

			public StackFrame(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public StackFrame()
			{
			}
		}

		public struct StackLayout : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public short[] layout
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "layout"), typeof(short[])) is short[] __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to short[]");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "layout", value);
				}
			}

			public System.Int16 valueSize
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int16)) is System.Int16 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to short");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
				}
			}

			public System.Int16 objectSize
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectSize"), typeof(System.Int16)) is System.Int16 __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to short");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectSize", value);
				}
			}

			public StackLayout(short[] layout, System.Int16 valueSize, System.Int16 objectSize)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "StackLayout", ResoniteBridge.ResoniteBridgeValueType.Type), layout, valueSize, objectSize);
			}

			public override System.String ToString()
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

			public StackLayout(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public StackLayout()
			{
			}
		}

		public Stack<ExecutionImpulseExportHandler> _impulseExportHandlers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulseExportHandlers"), typeof(Stack<ExecutionImpulseExportHandler>)) is Stack<ExecutionImpulseExportHandler> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<ExecutionImpulseExportHandler>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulseExportHandlers", value);
			}
		}

		public Stack<ExecutionAsyncImpulseExportHandler> _asyncImpulseExportHandlers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_asyncImpulseExportHandlers"), typeof(Stack<ExecutionAsyncImpulseExportHandler>)) is Stack<ExecutionAsyncImpulseExportHandler> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<ExecutionAsyncImpulseExportHandler>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_asyncImpulseExportHandlers", value);
			}
		}

		public StackFrame[] _frames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_frames"), typeof(StackFrame[])) is StackFrame[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StackFrame[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_frames", value);
			}
		}

		public System.UInt16 _allocatedFrames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedFrames"), typeof(System.UInt16)) is System.UInt16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedFrames", value);
			}
		}

		public System.UInt16 _currentFrameIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentFrameIndex"), typeof(System.UInt16)) is System.UInt16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentFrameIndex", value);
			}
		}

		public StackLayout stackLayout
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackLayout"), typeof(StackLayout)) is StackLayout __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StackLayout");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackLayout", value);
			}
		}

		public HashSet<IExecutionRuntime> onceEnteredRuntimes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "onceEnteredRuntimes"), typeof(HashSet<IExecutionRuntime>)) is HashSet<IExecutionRuntime> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionRuntime>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Values"), typeof(ValueStack)) is ValueStack __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueStack");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Objects"), typeof(ObjectStack)) is ObjectStack __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectStack");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseExport"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ImpulseExport", value);
			}
		}

		public System.Int32 CurrentFramePins
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFramePins"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 CurrentValueStoreOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentValueStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 CurrentObjectStoreOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentObjectStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public SharedExecutionScope SharedScope
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SharedScope"), typeof(SharedExecutionScope)) is SharedExecutionScope __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SharedExecutionScope");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.UInt16 CurrentFrameIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFrameIndex"), typeof(System.UInt16)) is System.UInt16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort");
				}
			}
		}

		public System.Boolean CurrentFrameIsTop
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentFrameIsTop"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 MaxDepth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxDepth", value);
			}
		}

		public System.Int32 AutoYieldSafetyDepth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoYieldSafetyDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoYieldSafetyDepth", value);
			}
		}

		public System.Int32 CurrentDepth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentDepth", value);
			}
		}

		public System.Int32 InheritedDepth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InheritedDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InheritedDepth", value);
			}
		}

		public System.Boolean AbortExecution
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AbortExecution"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AbortExecution", value);
			}
		}

		public IExecutionRuntime CurrentRuntime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentRuntime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
			}
		}

		public IExecutionNestedNode CurrentNestedNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentNestedNode"), typeof(IExecutionNestedNode)) is IExecutionNestedNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionNestedNode");
				}
			}
		}

		public ScopePoint CurrentScope
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentScope"), typeof(ScopePoint)) is ScopePoint __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ScopePoint");
				}
			}
		}

		public IExecutionRuntime GetFrameRuntime(System.Int32 frameIndex)
		{
			return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameRuntime", frameIndex), typeof(IExecutionRuntime));
		}

		public IExecutionNestedNode GetFrameNestedNode(System.Int32 frameIndex)
		{
			return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameNestedNode", frameIndex), typeof(IExecutionNestedNode));
		}

		public System.Int32 GetFrameSource(System.Int32 frameIndex)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetFrameSource", frameIndex), typeof(System.Int32));
		}

		public ExecutionContext()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContext", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public ExecutionContext(SharedExecutionScope scope)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContext", ResoniteBridge.ResoniteBridgeValueType.Type), scope);
		}

		public System.String StackLayoutDebug()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StackLayoutDebug"), typeof(System.String));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopInputs()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopInputs");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(System.Int32 index) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue", index), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(System.Int32 index)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObject", index), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(System.Int32 index, System.Int32 offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue", index, offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(System.Int32 index, System.Int32 offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObject", index, offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValueDirect<T>(System.Int32 offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValueDirect", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObjectDirect<T>(System.Int32 offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadObjectDirect", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredValue<T>(System.Int32 offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadStoredValue", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteStoredValue<T>(System.Int32 offset, T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteStoredValue", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T AccessStoredValue<T>(System.Int32 offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AccessStoredValue", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredObject<T>(System.Int32 offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadStoredObject", offset), typeof(T));
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

		public StackFrame CreateStackFrame(IExecutionRuntime runtime, IExecutionNestedNode nestedNode)
		{
			return (StackFrame)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateStackFrame", runtime, nestedNode), typeof(StackFrame));
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
			return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReturnToPreviousFrame"), typeof(System.UInt16));
		}

		public void StepIntoFrame(System.UInt16 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StepIntoFrame", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Boolean UnpinFrame()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnpinFrame"), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRawStackFrame()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRawStackFrame"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public void PopToLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopToLocal", mapping);
		}

		public void PushFromLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushFromLocal", mapping);
		}

		public void PushImpulseExportHandler(ExecutionImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushImpulseExportHandler", handler);
		}

		public void PushAsyncImpulseExportHandler(ExecutionAsyncImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PushAsyncImpulseExportHandler", handler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopAsyncImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PopAsyncImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void InvokeImpulseExport(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeImpulseExport", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Task InvokeAsyncImpulseExport(System.Int32 index)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeAsyncImpulseExport", index), typeof(Task));
		}

		public void CaptureContextFrom(ExecutionContext source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureContextFrom", source);
		}

		public NodeContextPath CaptureContextPath()
		{
			return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureContextPath"), typeof(NodeContextPath));
		}

		public System.Boolean IsCurrentPath(IExecutionRuntime rootRuntime, NodeContextPath path)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsCurrentPath", rootRuntime, path), typeof(System.Boolean));
		}

		public System.Int32 ComputeStackDepth()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeStackDepth"), typeof(System.Int32));
		}

		public void EnterExecution()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterExecution");
		}

		public Task TryEnterAsyncExecution()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterAsyncExecution"), typeof(Task));
		}

		public void ExitExecution()
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

		public void WalkStackAndCopyTo(System.UInt16 frameIndex, ExecutionContext target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WalkStackAndCopyTo", frameIndex, target);
		}

		public System.Boolean TryEnterRuntimeOnce(IExecutionRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterRuntimeOnce", runtime), typeof(System.Boolean));
		}

		public void ExitRuntimeOnce(IExecutionRuntime runtime)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitRuntimeOnce", runtime);
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

		public ExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class ExecutionContextExtensions
	{
		public static NotImplementedException Exception()
		{
			return (NotImplementedException)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Exception"), typeof(NotImplementedException));
		}

		public static T ReadValue<T>(this ValueArgument<T> input, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", input, context), typeof(T));
		}

		public static T ReadObject<T>(this ObjectArgument<T> input, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", input, context), typeof(T));
		}

		public static T ReadValue<T>(this IInputList list, System.Int32 index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T));
		}

		public static T ReadObject<T>(this IInputList list, System.Int32 index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T));
		}

		public static T ReadValue<T>(this ValueArgumentList<T> list, System.Int32 index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T));
		}

		public static T ReadObject<T>(this ObjectArgumentList<T> list, System.Int32 index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this System.Int32 index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this System.Int32 index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValueDirect<T>(this System.Int32 offset, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValueDirect", offset, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObjectDirect<T>(this System.Int32 offset, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObjectDirect", offset, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this IInputList list, System.Int32 index, ExecutionContext context, System.Int32 listOffset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this IInputList list, System.Int32 index, ExecutionContext context, System.Int32 listOffset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this ValueArgumentList<T> list, System.Int32 index, ExecutionContext context, System.Int32 listOffset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this ObjectArgumentList<T> list, System.Int32 index, ExecutionContext context, System.Int32 listOffset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ValueInput<T> input, ExecutionContext context, T defaultValue = default(T)) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, context, defaultValue), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ObjectInput<T> input, ExecutionContext context, T defaultValue = default(T))
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, context, defaultValue), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ValueInputList<T> input, System.Int32 index, ExecutionContext context, T defaultValue = default(T)) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, index, context, defaultValue), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ObjectInputList<T> input, System.Int32 index, ExecutionContext context, T defaultValue = default(T))
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, index, context, defaultValue), typeof(T));
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
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ExecuteAsync", impulse, context), typeof(Task));
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
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ExecuteAsync", call, context), typeof(Task));
		}

		public static void MoveToContext<C>(this C context, NodeContextPath previousPath, NodeContextPath nextPath) where C : ExecutionContext
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "MoveToContext", context, previousPath, nextPath);
		}
	}
	public abstract class ExtendedExecutionContext<C> : ExecutionContext, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		public ExecutionEventDispatcher<C> _eventDispatcher
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_eventDispatcher"), typeof(ExecutionEventDispatcher<C>)) is ExecutionEventDispatcher<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionEventDispatcher<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Updates"), typeof(ExecutionUpdateDispatcher<C>)) is ExecutionUpdateDispatcher<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionUpdateDispatcher<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Changes"), typeof(ExecutionChangesDispatcher<C>)) is ExecutionChangesDispatcher<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionChangesDispatcher<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledEventCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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

		public ExtendedExecutionContext()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExtendedExecutionContext", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public ExtendedExecutionContext(SharedExecutionScope sharedExecutionScope, ExecutionUpdateDispatcher<C> updateDispatcher, ExecutionEventDispatcher<C> eventDispatcher, ExecutionChangesDispatcher<C> changesDispatcher)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExtendedExecutionContext", ResoniteBridge.ResoniteBridgeValueType.Type), sharedExecutionScope, updateDispatcher, eventDispatcher, changesDispatcher);
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

		public ExtendedExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ExtendedExecutionContext : ExtendedExecutionContext<ExtendedExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ExtendedExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExtendedExecutionContext()
		{
		}
	}
	public interface IGlobalValue : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean IsWriteable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsWriteable"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		Type ValueType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		System.Object BoxedValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BoxedValue"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
		}
	}
	public interface IGlobalValue<T> : IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		T Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
		}

		System.Boolean SetValue(T newValue);
	}
	public class ObjectStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public object[] stack
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stack"), typeof(object[])) is object[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object[]");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Top"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Top", value);
			}
		}

		public System.Int32 Bottom
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bottom"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bottom", value);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Int32 GetBottomPosition(System.Int32 bottom, System.Int32 offset)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBottomPosition", bottom, offset), typeof(System.Int32));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Int32 GetPosition(System.Int32 offset)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPosition", offset), typeof(System.Int32));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Push<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Push", obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Pop<T>()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop"), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(System.Int32 offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", offset), typeof(T));
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

		public ObjectStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectStack()
		{
		}
	}
	public struct ScopeKey : IEquatable<ScopeKey>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IExecutionRuntime runtime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nestedNode"), typeof(IExecutionNestedNode)) is IExecutionNestedNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionNestedNode");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nestedNode", value);
			}
		}

		public ScopeKey(IExecutionRuntime runtime, IExecutionNestedNode nestedNode = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeKey", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, nestedNode);
		}

		public System.Boolean Equals(ScopeKey other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public static bool operator ==(ScopeKey left, ScopeKey right)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeKey", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(ScopeKey left, ScopeKey right)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeKey", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valuesOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valuesOffset", value);
			}
		}

		public System.Int32 objectsOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectsOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectsOffset", value);
			}
		}

		public NodeStoreOffsets(System.Int32 valuesOffset, System.Int32 objectsOffset)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeStoreOffsets", ResoniteBridge.ResoniteBridgeValueType.Type), valuesOffset, objectsOffset);
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
		public IGlobalValue[] _mappedGlobals
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_mappedGlobals"), typeof(IGlobalValue[])) is IGlobalValue[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IGlobalValue[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_mappedGlobals", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue nestedScopes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nestedScopes"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<ScopeKey, ScopePoint>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nestedScopes", value);
			}
		}

		public Dictionary<IExecutionNode, NodeStoreOffsets> explicitNodeMap
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "explicitNodeMap"), typeof(Dictionary<IExecutionNode, NodeStoreOffsets>)) is Dictionary<IExecutionNode, NodeStoreOffsets> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IExecutionNode, NodeStoreOffsets>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Parent"), typeof(ScopePoint)) is ScopePoint __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ScopePoint");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Key"), typeof(ScopeKey)) is ScopeKey __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ScopeKey");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
			}
		}

		public IExecutionNestedNode NestedNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedNode"), typeof(IExecutionNestedNode)) is IExecutionNestedNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionNestedNode");
				}
			}
		}

		public System.Boolean IsRoot
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsRoot"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 Depth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Depth"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Depth", value);
			}
		}

		public System.Int32 NestedScopeCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedScopeCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ValuesStoreOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValuesStoreOffset", value);
			}
		}

		public System.Int32 ObjectsStoreOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectsStoreOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectsStoreOffset", value);
			}
		}

		public System.Boolean AreGlobalsMapped
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AreGlobalsMapped"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public ScopePoint()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopePoint", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public ScopePoint(ScopePoint parent, in ScopeKey key, System.Int32 valuesStoreOffset, System.Int32 objectsStoreOffset)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopePoint", ResoniteBridge.ResoniteBridgeValueType.Type), parent, key, valuesStoreOffset, objectsStoreOffset);
		}

		public ScopePoint GetNestedScope(in ScopeKey key)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedScope", key), typeof(ScopePoint));
		}

		public ScopePoint AllocateScope(ScopeKey key, System.Int32 valuesStoreOffset, System.Int32 objectsStoreOffset)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateScope", key, valuesStoreOffset, objectsStoreOffset), typeof(ScopePoint));
		}

		public void MapGlobals(IGlobalValue[] globals)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobals", globals);
		}

		public T ReadGlobal<T>(GlobalRef<T> globalRef)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", globalRef), typeof(T));
		}

		public T ReadGlobal<T>(System.Int32 index)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", index), typeof(T));
		}

		public System.Boolean WriteGlobal<T>(GlobalRef<T> globalRef, T value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteGlobal", globalRef, value), typeof(System.Boolean));
		}

		public System.Boolean WriteGlobal<T>(System.Int32 index, T value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteGlobal", index, value), typeof(System.Boolean));
		}

		public System.Boolean HasAnyStoreDataInHierarchy()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasAnyStoreDataInHierarchy"), typeof(System.Boolean));
		}

		public void CaptureExplicitNodeMap()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureExplicitNodeMap");
		}

		public NodeStoreOffsets? GetStoredOffset(IExecutionNode node)
		{
			return (NodeStoreOffsets?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoredOffset", node), typeof(NodeStoreOffsets));
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

		public ScopePoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SharedExecutionScope : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Object _lock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lock"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lock", value);
			}
		}

		public System.Int32 _allocatedValueStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedValueStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedValueStoreSize", value);
			}
		}

		public System.Int32 _allocatedObjectStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_allocatedObjectStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_allocatedObjectStoreSize", value);
			}
		}

		public ScopePoint RootScope
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RootScope"), typeof(ScopePoint)) is ScopePoint __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ScopePoint");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesStore"), typeof(byte[])) is byte[] __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValuesStore", value);
			}
		}

		public object[] ObjectsStore
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectsStore"), typeof(object[])) is object[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectsStore", value);
			}
		}

		public SharedExecutionScope()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "SharedExecutionScope", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public ScopePoint GetNestedScopeOrAllocate(ScopePoint sourcePoint, IExecutionRuntime runtime, IExecutionNestedNode node)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedScopeOrAllocate", sourcePoint, runtime, node), typeof(ScopePoint));
		}

		public System.Boolean HasAnyStoreDataInHierarchy()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasAnyStoreDataInHierarchy"), typeof(System.Boolean));
		}

		public ScopePoint CaptureScopeAndSwap(ref byte[] valuesStore, ref object[] objectsStore)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CaptureScopeAndSwap", valuesStore, objectsStore), typeof(ScopePoint));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
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

		public SharedExecutionScope(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SimpleGlobalValue<T> : IGlobalValue<T>, IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public T Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BoxedValue"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
		}

		public System.Boolean IsWriteable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsWriteable"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Type ValueType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public System.Boolean SetValue(T newValue)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", newValue), typeof(System.Boolean));
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

		public SimpleGlobalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SimpleGlobalValue()
		{
		}
	}
	public class ValueStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte[] stack
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stack"), typeof(byte[])) is byte[] __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stack", value);
			}
		}

		public System.Int32 Top
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Top"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Top", value);
			}
		}

		public System.Int32 Bottom
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bottom"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bottom", value);
			}
		}

		public System.Int32 Size
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Size"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Int32 GetBottomPosition(System.Int32 bottom, System.Int32 offset)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBottomPosition", bottom, offset), typeof(System.Int32));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Push<T>(T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Push", value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public System.Int32 GetPosition<T>(System.Int32 offset) where T : struct
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPosition", offset), typeof(System.Int32));
		}

		public unsafe T Pop<T>() where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pop"), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(System.Int32 offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write<T>(System.Int32 offset, T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Access<T>(System.Int32 offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", offset), typeof(T));
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

		public ResoniteBridge.ResoniteBridgeValue GetRawStack()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRawStack"), typeof(ResoniteBridge.ResoniteBridgeValue));
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

		public ValueStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueStack()
		{
		}
	}
	public interface IVariable<C, T> : INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		T Read(C context);

		System.Boolean Write(T value, C context);
	}
	public struct ObjectLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
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

		public ObjectLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectLocal()
		{
		}
	}
	public struct ValueLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public System.Int32 offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		public T Access(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", context), typeof(T));
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

		public ValueLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueLocal()
		{
		}
	}
	public class ExecutionChangesDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public NodeGroup group
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "group"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "group", value);
			}
		}

		public SortedSet<ElementPath<INode>> changedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "changedNodes"), typeof(SortedSet<ElementPath<INode>>)) is SortedSet<ElementPath<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SortedSet<ElementPath<INode>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "changedNodes", value);
			}
		}

		public SortedSet<ElementPath<INode>> backBuffer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "backBuffer"), typeof(SortedSet<ElementPath<INode>>)) is SortedSet<ElementPath<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SortedSet<ElementPath<INode>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentChangedCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public IEnumerable<ElementPath<INode>> CurrentChangedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentChangedNodes"), typeof(IEnumerable<ElementPath<INode>>)) is IEnumerable<ElementPath<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<ElementPath<INode>>");
				}
			}
		}

		public event Action FirstChangeRegistered;

		public ExecutionChangesDispatcher(NodeGroup group)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionChangesDispatcher", ResoniteBridge.ResoniteBridgeValueType.Type), group);
		}

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
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChangeToAllListeners", runtime, context), typeof(System.Int32));
		}

		public System.Int32 DispatchChangeToAllRecursively(ExecutionRuntime<C> runtime, C context)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChangeToAllRecursively", runtime, context), typeof(System.Int32));
		}

		public System.Int32 DispatchChanges(ExecutionRuntime<C> runtime, C context)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DispatchChanges", runtime, context), typeof(System.Int32));
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
		public struct Event : IEquatable<Event>, IComparable<Event>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public NodeContextPath path
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(NodeContextPath)) is NodeContextPath __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to NodeContextPath");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
				}
			}

			public NodeEventHandler<C> handler
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "handler"), typeof(NodeEventHandler<C>)) is NodeEventHandler<C> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to NodeEventHandler<C>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "handler", value);
				}
			}

			public System.Object eventData
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "eventData"), typeof(System.Object)) is System.Object __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to object");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "eventData", value);
				}
			}

			public Event(NodeContextPath path, NodeEventHandler<C> handler, System.Object eventData)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Event", ResoniteBridge.ResoniteBridgeValueType.Type), path, handler, eventData);
			}

			public System.Int32 CompareTo(Event other)
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
			}

			public System.Boolean Equals(Event other)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
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

			public Event(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Event()
			{
			}
		}

		public List<Event> orderedEvents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "orderedEvents"), typeof(List<Event>)) is List<Event> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Event>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "orderedEvents", value);
			}
		}

		public List<Event> unorderedEvents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "unorderedEvents"), typeof(List<Event>)) is List<Event> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Event>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledEventCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ScheduledOrderedEventCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledOrderedEventCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ScheduledUnorderedEventCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ScheduledUnorderedEventCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Boolean IsEmpty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
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
		public struct UpdateNode : IComparable<UpdateNode>, IEquatable<UpdateNode>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public NodeContextPath path
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(NodeContextPath)) is NodeContextPath __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to NodeContextPath");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
				}
			}

			public IExecutionUpdateReceiver<C> receiver
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "receiver"), typeof(IExecutionUpdateReceiver<C>)) is IExecutionUpdateReceiver<C> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IExecutionUpdateReceiver<C>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "receiver", value);
				}
			}

			public UpdateNode(NodeContextPath path, IExecutionUpdateReceiver<C> receiver)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UpdateNode", ResoniteBridge.ResoniteBridgeValueType.Type), path, receiver);
			}

			public System.Boolean Equals(UpdateNode other)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
			}

			public System.Int32 CompareTo(UpdateNode other)
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
			}

			public override System.Int32 GetHashCode()
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
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

			public UpdateNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public UpdateNode()
			{
			}
		}

		public SortedDictionary<int, SortedSet<UpdateNode>> updateBuckets
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "updateBuckets"), typeof(SortedDictionary<int, SortedSet<UpdateNode>>)) is SortedDictionary<int, SortedSet<UpdateNode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SortedDictionary<int, SortedSet<UpdateNode>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmpty"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 UpdateBucketCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UpdateBucketCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 TotalUpdateNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalUpdateNodes"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateAllBuckets", runtime, context), typeof(System.Int32));
		}

		public void UpdateBucket(System.Int32 bucket, ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBucket", bucket, runtime, context);
		}

		public System.Int32 UpdateBucket(SortedSet<UpdateNode> list, ref NodeContextPath current, C context)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBucket", list, current, context), typeof(System.Int32));
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
		public class ScopeNode : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IScopeEventListener<C> Node
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Node"), typeof(IScopeEventListener<C>)) is IScopeEventListener<C> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IScopeEventListener<C>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Node", value);
				}
			}

			public System.Boolean NewlyAdded
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NewlyAdded"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "NewlyAdded", value);
				}
			}

			public System.Boolean Exists
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Exists"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Exists", value);
				}
			}

			public ScopeNode(IScopeEventListener<C> node)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ScopeNode", ResoniteBridge.ResoniteBridgeValueType.Type), node);
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

			public ScopeNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ScopeNode()
			{
			}
		}

		public Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>> registeredNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "registeredNodes"), typeof(Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>)) is Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "registeredNodes", value);
			}
		}

		public System.Boolean _hasNewNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hasNewNodes"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hasNewNodes", value);
			}
		}

		public void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateScopesAndSendRemoved", runtime, context);
		}

		public void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context, System.Boolean scanForNewNodes)
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

		public void ProcessScope(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessScope", runtime, context);
		}

		public Dictionary<IScopeEventListener<C>, ScopeNode> EnsureScopeDictionary(NodeContextPath path)
		{
			return (Dictionary<IScopeEventListener<C>, ScopeNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureScopeDictionary", path), typeof(Dictionary<IScopeEventListener<C>, ScopeNode>));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialOperation"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NextOperation"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsyncContext"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAsyncContext", value);
			}
		}

		public ExecutionAbortedException(IExecutionRuntime runtime, IOperation initialOperation, IOperation nextOperation, System.Boolean isAsync)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionAbortedException", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, initialOperation, nextOperation, isAsync);
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

		public ExecutionAbortedException(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionAbortedException()
		{
		}
	}
	public class EvaluateSequence<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public EvaluationSequence<C> Sequence
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Sequence"), typeof(EvaluationSequence<C>)) is EvaluationSequence<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to EvaluationSequence<C>");
				}
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

		public EvaluateSequence(EvaluationSequence<C> sequence)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluateSequence", ResoniteBridge.ResoniteBridgeValueType.Type), sequence);
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

		public EvaluateSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluateSequence()
		{
		}
	}
	public abstract class ExecutionControlNode<C> : IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 FixedValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 InputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 OutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 OperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.String Overload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Boolean IsPassthrough
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public NodeMetadata Metadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata)) is NodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeMetadata");
				}
			}
		}

		public System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 FixedLocalsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedValueLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedObjectLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedReferenceCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
			}
		}

		public System.Boolean ListensToChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 FixedStoresCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedValueStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedObjectStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Boolean HasSingleContinuation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSingleContinuation"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean HasSyncAsyncTransition
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSyncAsyncTransition"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 IndexInGroup
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		public System.Int32 FixedGlobalRefCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ArgumentCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 AllocationIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ValueStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		public System.Int32 ObjectStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectStoreStartOffset", value);
			}
		}

		public abstract void Evaluate(C context);

		public IOperation GetOperation(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation));
		}

		public ExecutionOperationHandler<T> GetOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationHandler", index), typeof(ExecutionOperationHandler<T>));
		}

		public short[] GetDefaultStackLayout()
		{
			return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStackLayout"), typeof(short[]));
		}

		public ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicOperationHandler", listIndex, index), typeof(ExecutionOperationHandler<T>));
		}

		public IInputList GetInputList(System.Int32 index)
		{
			return (IInputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputList", index), typeof(IInputList));
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public System.Object GetInputDefaultValue(System.Int32 index)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputDefaultValue", index), typeof(System.Object));
		}

		public System.String GetInputName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputName", index), typeof(System.String));
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput));
		}

		public System.Int32 GetInputStackOffset(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputStackOffset", index), typeof(System.Int32));
		}

		public Type GetInputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type));
		}

		public DataClass GetInputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputTypeClass", index), typeof(DataClass));
		}

		public IOutput GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput));
		}

		public System.String GetOutputName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputName", index), typeof(System.String));
		}

		public Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		public DataClass GetOutputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass));
		}

		public System.Int32 GetValueInputSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueInputSize", index), typeof(System.Int32));
		}

		public System.Int32 GetValueOutputSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutputSize", index), typeof(System.Int32));
		}

		public System.Boolean IsImpulseImplicit(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsImpulseImplicit", index), typeof(System.Boolean));
		}

		public System.Boolean IsInputConditional(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean));
		}

		public System.Boolean IsOutputImplicit(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOutputImplicit", index), typeof(System.Boolean));
		}

		public void SetInputSource(System.Int32 index, IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInputSource", index, source);
		}

		public IOutputList GetOutputList(System.Int32 index)
		{
			return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputList", index), typeof(IOutputList));
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		public IImpulseList GetImpulseList(System.Int32 index)
		{
			return (IImpulseList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseList", index), typeof(IImpulseList));
		}

		public SyncOperationList GetOperationList(System.Int32 index)
		{
			return (SyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationList", index), typeof(SyncOperationList));
		}

		public System.String GetInputListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListName", index), typeof(System.String));
		}

		public Type GetInputListTypeConstraint(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListTypeConstraint", index), typeof(Type));
		}

		public System.String GetOutputListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListName", index), typeof(System.String));
		}

		public System.String GetOperationListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListName", index), typeof(System.String));
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
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalDataClass", index), typeof(DataClass));
		}

		public Type GetLocalType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalType", index), typeof(Type));
		}

		public System.Int32 GetValueLocalSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueLocalSize", index), typeof(System.Int32));
		}

		public void SetLocalOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalOffset", index, offset);
		}

		public System.String GetImpulseListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListName", index), typeof(System.String));
		}

		public System.String GetReferenceName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceName", index), typeof(System.String));
		}

		public Type GetReferenceType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceType", index), typeof(Type));
		}

		public INode GetReferenceTarget(System.Int32 index)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceTarget", index), typeof(INode));
		}

		public void SetReferenceTarget(System.Int32 index, INode target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReferenceTarget", index, target);
		}

		public System.Boolean TrySetReferenceTarget(System.Int32 index, INode target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetReferenceTarget", index, target), typeof(System.Boolean));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputListeningToChanges", index), typeof(System.Boolean));
		}

		public CrossRuntimeInputAttribute GetInputCrossRuntime(System.Int32 index)
		{
			return (CrossRuntimeInputAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputCrossRuntime", index), typeof(CrossRuntimeInputAttribute));
		}

		public OutputChangeSource GetOutputChangeType(System.Int32 index)
		{
			return (OutputChangeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputChangeType", index), typeof(OutputChangeSource));
		}

		public DataClass GetStoreDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreDataClass", index), typeof(DataClass));
		}

		public Type GetStoreType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreType", index), typeof(Type));
		}

		public System.Int32 GetValueStoreSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueStoreSize", index), typeof(System.Int32));
		}

		public void SetStoreOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStoreOffset", index, offset);
		}

		public System.String GetImpulseName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseName", index), typeof(System.String));
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public System.Boolean IsOperationAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean));
		}

		public System.Boolean IsOperationListAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationListAsync", index), typeof(System.Boolean));
		}

		public AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncOperationHandler", index), typeof(AsyncExecutionOperationHandler<T>));
		}

		public AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicAsyncOperationHandler", listIndex, index), typeof(AsyncExecutionOperationHandler<T>));
		}

		IOperationList INode.GetOperationList(System.Int32 index)
		{
			return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "INode.GetOperationList", index), typeof(IOperationList));
		}

		public System.String GetGlobalRefName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefName", index), typeof(System.String));
		}

		public Type GetGlobalRefValueType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefValueType", index), typeof(Type));
		}

		public Global GetGlobalRefBinding(System.Int32 index)
		{
			return (Global)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefBinding", index), typeof(Global));
		}

		public void SetGlobalRefBinding(System.Int32 index, Global binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public System.Boolean TrySetGlobalRefBinding(System.Int32 index, Global binding)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetGlobalRefBinding", index, binding), typeof(System.Boolean));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationContinueTo", index, impulseName), typeof(System.Boolean));
		}

		public System.Boolean CanOperationListContinueTo(System.Int32 index, System.String impulseName)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationListContinueTo", index, impulseName), typeof(System.Boolean));
		}

		public System.Boolean OperationHasSingleContinuation(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSingleContinuation", index), typeof(System.Boolean));
		}

		public System.Boolean OperationHasSyncAsyncTransition(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSyncAsyncTransition", index), typeof(System.Boolean));
		}

		public System.String GetOperationName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationName", index), typeof(System.String));
		}

		public System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean));
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

		public ExecutionControlNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionControlNode()
		{
		}
	}
	public class LoadValueFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Size
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Size"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Size", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public LoadValueFromLocal(System.Int32 size, System.Int32 offset)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "LoadValueFromLocal", ResoniteBridge.ResoniteBridgeValueType.Type), size, offset);
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

		public LoadValueFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LoadValueFromLocal()
		{
		}
	}
	public class LoadObjectFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Size
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Size"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Size", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public LoadObjectFromLocal(System.Int32 size, System.Int32 offset)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "LoadObjectFromLocal", ResoniteBridge.ResoniteBridgeValueType.Type), size, offset);
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

		public LoadObjectFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LoadObjectFromLocal()
		{
		}
	}
	public class PopToLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public LocalNodeData Mapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Mapping"), typeof(LocalNodeData)) is LocalNodeData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LocalNodeData");
				}
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

		public PopToLocal(in LocalNodeData mapping)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "PopToLocal", ResoniteBridge.ResoniteBridgeValueType.Type), mapping);
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

		public PopToLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PopToLocal()
		{
		}
	}
	public class PushObject<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public T Object
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Object"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
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

		public PushObject(T @object)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "PushObject", ResoniteBridge.ResoniteBridgeValueType.Type), @object);
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

		public PushObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PushObject()
		{
		}
	}
	public class PushValue<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public T Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
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

		public PushValue(T value)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "PushValue", ResoniteBridge.ResoniteBridgeValueType.Type), value);
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
		public static ResoniteBridge.ResoniteBridgeValue _sizeCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache", value);
			}
		}

		public static System.Int32 SizeOf(Type type)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOf", type), typeof(System.Int32));
		}

		public unsafe static System.Int32 SizeOfGeneric<T>() where T : struct
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOfGeneric"), typeof(System.Int32));
		}
	}
	[AttributeUsage(AttributeTargets.Field)]
	public class ExecutionInputAttribute : CrossRuntimeInputAttribute
	{
		public override System.Boolean IsValidTargetRuntime(NodeRuntime runtime)
		{
			Type type = runtime.GetType();
			if (!type.IsGenericType)
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(ExecutionRuntime<>);
		}
	}
	public abstract class ExecutionNode<C> : Node, IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, ExecutionNodeMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		public BindingFlags OPERATION_BIND_FLAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OPERATION_BIND_FLAGS"), typeof(BindingFlags)) is BindingFlags __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BindingFlags");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OPERATION_BIND_FLAGS", value);
			}
		}

		public BindingFlags LOCALS_BIND_FLAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LOCALS_BIND_FLAGS"), typeof(BindingFlags)) is BindingFlags __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BindingFlags");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LOCALS_BIND_FLAGS", value);
			}
		}

		public BindingFlags STORES_BIND_FLAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "STORES_BIND_FLAGS"), typeof(BindingFlags)) is BindingFlags __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BindingFlags");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "STORES_BIND_FLAGS", value);
			}
		}

		public BindingFlags GLOBAL_BIND_FLAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "GLOBAL_BIND_FLAGS"), typeof(BindingFlags)) is BindingFlags __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BindingFlags");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedLocalsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedValueLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedObjectLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedStoresCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedValueStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedObjectStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ValueStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		public System.Int32 ObjectStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ObjectStoreStartOffset", value);
			}
		}

		public virtual ExecutionNodeMetadata ExecutionMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionMetadata"), typeof(ExecutionNodeMetadata)) is ExecutionNodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionNodeMetadata");
				}
			}
		}

		public abstract void Evaluate(C context);

		public virtual System.Int32 GetValueInputSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueInputSize", index), typeof(System.Int32));
		}

		public virtual System.Int32 GetInputStackOffset(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputStackOffset", index), typeof(System.Int32));
		}

		public virtual short[] GetDefaultStackLayout()
		{
			return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStackLayout"), typeof(short[]));
		}

		public virtual System.Int32 GetValueOutputSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutputSize", index), typeof(System.Int32));
		}

		public virtual System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean));
		}

		public virtual ExecutionOperationHandler<T> GetOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationHandler", index), typeof(ExecutionOperationHandler<T>));
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(System.Int32 index) where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncOperationHandler", index), typeof(AsyncExecutionOperationHandler<T>));
		}

		public virtual void GlobalChanged<T>(System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GlobalChanged", index, value, context);
		}

		public virtual void ListGlobalChanged<T>(System.Int32 listIndex, System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListGlobalChanged", listIndex, index, value, context);
		}

		public MethodInfo GetHandlerMethod(System.Int32 index, System.Boolean async)
		{
			return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandlerMethod", index, async), typeof(MethodInfo));
		}

		public virtual ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicOperationHandler", listIndex, index), typeof(ExecutionOperationHandler<T>));
		}

		public virtual AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(System.Int32 listIndex, System.Int32 index) where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDynamicAsyncOperationHandler", listIndex, index), typeof(AsyncExecutionOperationHandler<T>));
		}

		public virtual DataClass GetLocalDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalDataClass", index), typeof(DataClass));
		}

		public virtual Type GetLocalType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalType", index), typeof(Type));
		}

		public virtual System.Int32 GetValueLocalSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueLocalSize", index), typeof(System.Int32));
		}

		public virtual void SetLocalOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalOffset", index, offset);
		}

		public virtual DataClass GetStoreDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreDataClass", index), typeof(DataClass));
		}

		public virtual Type GetStoreType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStoreType", index), typeof(Type));
		}

		public virtual System.Int32 GetValueStoreSize(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueStoreSize", index), typeof(System.Int32));
		}

		public virtual void SetStoreOffset(System.Int32 index, System.Int32 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStoreOffset", index, offset);
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

		public ExecutionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public override System.Int32 OutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public DataClass OutputDataClass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override IOutput GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput));
		}

		public override Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		public override DataClass GetOutputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass));
		}

		public sealed override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public abstract T Compute(C context);

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

		public ValueFunctionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public override System.Int32 OutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public DataClass OutputDataClass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override IOutput GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput));
		}

		public override Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		public override DataClass GetOutputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass));
		}

		public sealed override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public abstract T Compute(C context);

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

		public ObjectFunctionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public virtual void ComputeOutputs(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
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

		public VoidNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public ExecutionOperationHandler<C> Handler
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(ExecutionOperationHandler<C>)) is ExecutionOperationHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionOperationHandler<C>");
				}
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public virtual ExecutionOperationHandler<T> GetHandler<T>() where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>));
		}

		public abstract IOperation Run(C context);

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

		public ActionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		public sealed override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public abstract void Do(C context);

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

		public ActionFlowNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		public sealed override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public abstract System.Boolean Do(C context);

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

		public ActionBreakableFlowNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncHandler<T>() where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncHandler"), typeof(AsyncExecutionOperationHandler<T>));
		}

		public abstract Task<IOperation> RunAsync(C context);

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

		public AsyncActionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		public sealed override Task<IOperation> RunAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public abstract Task Do(C context);

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

		public AsyncActionFlowNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Next"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Next", value);
			}
		}

		public sealed override Task<IOperation> RunAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public abstract Task<bool> Do(C context);

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

		public AsyncActionBreakableFlowNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Int32 FixedValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedLocalsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedValueLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedObjectLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedStoresCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedValueStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedObjectStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 ValueStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValueStoreStartOffset", value);
			}
		}

		System.Int32 ObjectStoreStartOffset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreStartOffset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputNodesMustBeLocal"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}
	}
	public struct OperationExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo)) is MethodInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MethodInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		public OperationExecutionMetadata(MethodInfo method)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), method);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SyncMethod"), typeof(MethodInfo)) is MethodInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MethodInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AsyncMethod"), typeof(MethodInfo)) is MethodInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MethodInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AsyncMethod", value);
			}
		}

		public OperationListExecutionMetadata(MethodInfo syncMethod, MethodInfo asyncMethod)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationListExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), syncMethod, asyncMethod);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedActionCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedActionCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedLocalsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocalsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedStoresCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStoresCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicActionCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicActionCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueStackSize", value);
			}
		}

		public System.Int32 FixedObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectStackSize", value);
			}
		}

		public System.Int32 FixedValueLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueLocalsSize", value);
			}
		}

		public System.Int32 FixedObjectLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectLocalsSize", value);
			}
		}

		public System.Int32 FixedValueStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedValueStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedValueStoresSize", value);
			}
		}

		public System.Int32 FixedObjectStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedObjectStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedObjectStoresSize", value);
			}
		}

		public short[] DefaultFixedStackLayout
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultFixedStackLayout"), typeof(short[])) is short[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short[]");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputs"), typeof(List<InputExecutionMetadata>)) is List<InputExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputs"), typeof(List<OutputExecutionMetadata>)) is List<OutputExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperations"), typeof(List<OperationExecutionMetadata>)) is List<OperationExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OperationExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedLocals"), typeof(List<LocalExecutionMetadata>)) is List<LocalExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<LocalExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedStores"), typeof(List<StoreExecutionMetadata>)) is List<StoreExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<StoreExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefExecutionMetadata>)) is List<GlobalRefExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GlobalRefExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperations"), typeof(List<OperationListExecutionMetadata>)) is List<OperationListExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OperationListExecutionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListExecutionMetadata>)) is List<GlobalRefListExecutionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GlobalRefListExecutionMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicGlobalRefs", value);
			}
		}

		public void GenerateDefaultStackLayout()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateDefaultStackLayout");
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

		public ExecutionNodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionNodeMetadata()
		{
		}
	}
	public struct GlobalRefExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo)) is MethodInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MethodInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		public GlobalRefExecutionMetadata(MethodInfo method)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), method);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Method"), typeof(MethodInfo)) is MethodInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MethodInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Method", value);
			}
		}

		public GlobalRefListExecutionMetadata(MethodInfo method)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefListExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), method);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "size"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackOffset"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackOffset", value);
			}
		}

		public InputExecutionMetadata(System.Int16 size, System.Int16 stackOffset)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InputExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), size, stackOffset);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		public LocalExecutionMetadata(FieldInfo field, DataClass dataClass)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "LocalExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), field, dataClass);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "size"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "size", value);
			}
		}

		public OutputExecutionMetadata(System.Int16 size)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), size);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		public StoreExecutionMetadata(FieldInfo field, DataClass dataClass)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "StoreExecutionMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), field, dataClass);
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
		public AsyncCallExportWrapper(System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncCallExportWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), index);
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
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

		public AsyncCallExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCallExportWrapper()
		{
		}
	}
	public class AsyncExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public AsyncExecutionListOperationHandler<C> Handler
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(AsyncExecutionListOperationHandler<C>)) is AsyncExecutionListOperationHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncExecutionListOperationHandler<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Handler", value);
			}
		}

		public AsyncExecutionListOperationWrapper(AsyncExecutionListOperationHandler<C> handler, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncExecutionListOperationWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), handler, index);
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
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

		public AsyncExecutionListOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncExecutionListOperationWrapper()
		{
		}
	}
	public class AsyncOperationSequence<C> : OperationSequence<C, IAsyncOperation, AsyncExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override System.Boolean IsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public AsyncOperationSequence(ExecutionRuntime<C> runtime, IAsyncOperation origin)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncOperationSequence", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, origin);
		}

		public override AsyncExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			return (AsyncExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler", operation), typeof(AsyncExecutionOperationHandler<C>));
		}

		public override Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
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

		public AsyncOperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncOperationSequence()
		{
		}
	}
	public class EvaluationAnalysisContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public HashSet<EvaluationSequence<C>> processedSequences
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "processedSequences"), typeof(HashSet<EvaluationSequence<C>>)) is HashSet<EvaluationSequence<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<EvaluationSequence<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "processedSequences", value);
			}
		}

		public HashSet<IExecutionNode<C>> globalEvaluatedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globalEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>)) is HashSet<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionNode<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "globalEvaluatedNodes", value);
			}
		}

		public HashSet<IExecutionNode<C>> sequenceEvaluatedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sequenceEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>)) is HashSet<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionNode<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sequenceEvaluatedNodes", value);
			}
		}

		public HashSet<IExecutionNode<C>> localNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localNodes"), typeof(HashSet<IExecutionNode<C>>)) is HashSet<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionNode<C>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>)) is ExecutionRuntime<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalNodes"), typeof(IEnumerable<IExecutionNode<C>>)) is IEnumerable<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<IExecutionNode<C>>");
				}
			}
		}

		public EvaluationAnalysisContext(ExecutionRuntime<C> runtime)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationAnalysisContext", ResoniteBridge.ResoniteBridgeValueType.Type), runtime);
		}

		public System.Boolean BeginSequence(EvaluationSequence<C> sequence)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginSequence", sequence), typeof(System.Boolean));
		}

		public System.Boolean MarkNodeEvaluated(IExecutionNode<C> node, EvaluationSequence<C> sequence, System.Boolean external)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkNodeEvaluated", node, sequence, external), typeof(System.Boolean));
		}

		public void MarkLocal(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkLocal", node);
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

		public EvaluationAnalysisContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluationAnalysisContext()
		{
		}
	}
	public class EvaluationBuildContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public HashSet<IExecutionNode<C>> evaluatedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluatedNodes"), typeof(HashSet<IExecutionNode<C>>)) is HashSet<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionNode<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluatedNodes", value);
			}
		}

		public System.Boolean MarkEvaluated(IExecutionNode<C> node)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkEvaluated", node), typeof(System.Boolean));
		}

		public void ClearEvaluated()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearEvaluated");
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

		public EvaluationBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluationBuildContext()
		{
		}
	}
	public class CallExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public CallExportWrapper(System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CallExportWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), index);
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation));
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
		public ContinuationExportWrapper(System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ContinuationExportWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), index);
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation));
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
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

		public ContinuationExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuationExportWrapper()
		{
		}
	}
	public struct EvaluationAction<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public IExecutionNode<C> node
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "node"), typeof(IExecutionNode<C>)) is IExecutionNode<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionNode<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stackLayout"), typeof(ExecutionContext.StackLayout)) is ExecutionContext.StackLayout __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionContext.StackLayout");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stackLayout", value);
			}
		}

		public EvaluationAction(IExecutionNode<C> node, short[] stackLayout, System.Int16 valueSize, System.Int16 objectSize)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationAction", ResoniteBridge.ResoniteBridgeValueType.Type), node, stackLayout, valueSize, objectSize);
		}

		public EvaluationAction(IExecutionNode<C> node)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationAction", ResoniteBridge.ResoniteBridgeValueType.Type), node);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public EvaluationAction(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluationAction()
		{
		}
	}
	public class EvaluationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Boolean isRoot
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isRoot"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isRoot", value);
			}
		}

		public HashSet<IExecutionNode<C>> rootNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "rootNodes"), typeof(HashSet<IExecutionNode<C>>)) is HashSet<IExecutionNode<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IExecutionNode<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "rootNodes", value);
			}
		}

		public IExecutionNode<C> firstNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "firstNode"), typeof(IExecutionNode<C>)) is IExecutionNode<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionNode<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "firstNode", value);
			}
		}

		public List<IOutput> outputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputs"), typeof(List<IOutput>)) is List<IOutput> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IOutput>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputs", value);
			}
		}

		public List<EvaluationAction<C>> evaluationSequence
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluationSequence"), typeof(List<EvaluationAction<C>>)) is List<EvaluationAction<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<EvaluationAction<C>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>)) is ExecutionRuntime<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Boolean IsLocal
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLocal"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLocal", value);
			}
		}

		public EvaluationSequence(ExecutionRuntime<C> runtime, List<IOutput> outputs)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationSequence", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, outputs);
		}

		public EvaluationSequence(ExecutionRuntime<C> runtime, IExecutionNode<C> node, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationSequence", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, node, index);
		}

		public void MarkLocal()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkLocal");
		}

		public void Analyze(EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Analyze", context);
		}

		public void AnalyzeRecursive(IExecutionNode<C> node, EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AnalyzeRecursive", node, context);
		}

		public void Build(EvaluationBuildContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Build", context);
		}

		public System.Boolean BuildRecursive(IExecutionNode<C> node, EvaluationBuildContext<C> context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BuildRecursive", node, context), typeof(System.Boolean));
		}

		public T EvaluateValue<T>(IOutput output, C context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValue", output, context), typeof(T));
		}

		public T EvaluateObject<T>(IOutput output, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObject", output, context), typeof(T));
		}

		public void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValueToStack", output, context);
		}

		public void EvaluateObjectToStack<T>(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObjectToStack", output, context);
		}

		public void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Evaluate", context);
		}

		public System.String ToDebugString(System.String prefix = "")
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToDebugString", prefix), typeof(System.String));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public EvaluationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public EvaluationSequence()
		{
		}
	}
	public delegate void ExecutionGlobalRefHandler<in C, T>(T value, C context) where C : ExecutionContext;
	public delegate void ExecutionGlobalRefListHandler<in C, T>(System.Int32 index, T value, C context) where C : ExecutionContext;
	public class ExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public ExecutionListOperationHandler<C> Handler
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Handler"), typeof(ExecutionListOperationHandler<C>)) is ExecutionListOperationHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionListOperationHandler<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Handler", value);
			}
		}

		public ExecutionListOperationWrapper(ExecutionListOperationHandler<C> handler, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionListOperationWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), handler, index);
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(IOperation));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "handler"), typeof(VoidExecutionOperationHandler<C>)) is VoidExecutionOperationHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VoidExecutionOperationHandler<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "handler", value);
			}
		}

		public VoidExecutionOperationWrapper(VoidExecutionOperationHandler<C> handler)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "VoidExecutionOperationWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), handler);
		}

		public IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "handler"), typeof(AsyncVoidExecutionOperationHandler<C>)) is AsyncVoidExecutionOperationHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncVoidExecutionOperationHandler<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "handler", value);
			}
		}

		public AsyncVoidExecutionOperationWrapper(AsyncVoidExecutionOperationHandler<C> handler)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncVoidExecutionOperationWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), handler);
		}

		public Task<IOperation> RunAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresScopeData"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Int32 ValueStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 ObjectStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 TotalValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 TotalObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		IEnumerable<IExecutionNode> Nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<IExecutionNode>)) is IEnumerable<IExecutionNode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<IExecutionNode>");
				}
			}
		}

		T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : struct;

		T EvaluateObject<T>(IOutput output, ExecutionContext context);

		void SetValue<T>(IOutput output, T value, ExecutionContext context) where T : struct;

		void SetObject<T>(IOutput output, T value, ExecutionContext context);

		void Execute(ISyncOperation action, ExecutionContext context);

		Task ExecuteAsync(IOperation action, ExecutionContext context);

		System.String GetEvaluationSequenceDebug(IOutput output);
	}
	public class ExecutionRuntime<C> : NodeRuntime<IExecutionNode<C>>, IExecutionRuntime, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public EvaluationSequence<C> _exportsEvaluationSequence
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_exportsEvaluationSequence"), typeof(EvaluationSequence<C>)) is EvaluationSequence<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to EvaluationSequence<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_exportsEvaluationSequence", value);
			}
		}

		public Dictionary<IExecutionNode<C>, EvaluationSequence<C>> evaluationSequences
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluationSequences"), typeof(Dictionary<IExecutionNode<C>, EvaluationSequence<C>>)) is Dictionary<IExecutionNode<C>, EvaluationSequence<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IExecutionNode<C>, EvaluationSequence<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluationSequences", value);
			}
		}

		public List<int> importsMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "importsMapping"), typeof(List<int>)) is List<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "importsMapping", value);
			}
		}

		public Dictionary<IOutput, int> localValueMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localValueMapping"), typeof(Dictionary<IOutput, int>)) is Dictionary<IOutput, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IOutput, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localValueMapping", value);
			}
		}

		public Dictionary<IExecutionNode<C>, LocalNodeData> localNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localNodes"), typeof(Dictionary<IExecutionNode<C>, LocalNodeData>)) is Dictionary<IExecutionNode<C>, LocalNodeData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IExecutionNode<C>, LocalNodeData>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localNodes", value);
			}
		}

		public Dictionary<IOperation, IOperationSequence<C>> operationSequences
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "operationSequences"), typeof(Dictionary<IOperation, IOperationSequence<C>>)) is Dictionary<IOperation, IOperationSequence<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IOperation, IOperationSequence<C>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "operationSequences", value);
			}
		}

		public System.Int32 _evaluationFlagsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_evaluationFlagsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_evaluationFlagsSize", value);
			}
		}

		public System.Int32 _localValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localValueStackSize", value);
			}
		}

		public System.Int32 _localObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localObjectStackSize", value);
			}
		}

		public System.Int32 _valueLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_valueLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_valueLocalsSize", value);
			}
		}

		public System.Int32 _objectLocalsSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_objectLocalsSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_objectLocalsSize", value);
			}
		}

		public System.Boolean _requiresScopeData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_requiresScopeData"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_requiresScopeData", value);
			}
		}

		public System.Int32 _valueStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_valueStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_valueStoresSize", value);
			}
		}

		public System.Int32 _objectStoresSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_objectStoresSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_objectStoresSize", value);
			}
		}

		public System.Boolean RequiresScopeData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresScopeData"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 ValueStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ObjectStoreSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ObjectStoreSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 TotalValueStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalValueStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 TotalObjectStackSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalObjectStackSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		IEnumerable<IExecutionNode> IExecutionRuntime.Nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<IExecutionNode>)) is IEnumerable<IExecutionNode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<IExecutionNode>");
				}
			}
		}

		public override Type GetCompatibleNodeType(Type type)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type));
		}

		public T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValue", output, context), typeof(T));
		}

		public T EvaluateObject<T>(IOutput output, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateObject", output, context), typeof(T));
		}

		public void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EvaluateValueToStack", output, context);
		}

		public void EvaluateObjectToStack<T>(IOutput output, C context)
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
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", operation, context), typeof(Task));
		}

		public void Rebuild()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Rebuild");
		}

		public void MapLocalNode(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapLocalNode", node);
		}

		public EvaluationSequence<C> EnsureSequence(IExecutionNode<C> node)
		{
			return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureSequence", node), typeof(EvaluationSequence<C>));
		}

		public EvaluationSequence<C> GetSequence(IExecutionNode<C> node)
		{
			return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSequence", node), typeof(EvaluationSequence<C>));
		}

		public System.Boolean IsLocalNode(IExecutionNode<C> node)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsLocalNode", node), typeof(System.Boolean));
		}

		public System.Int32 GetLocalValueMapping(IOutput output)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLocalValueMapping", output), typeof(System.Int32));
		}

		public LocalNodeData GetStaticNodeMapping(IExecutionNode<C> node)
		{
			return (LocalNodeData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStaticNodeMapping", node), typeof(LocalNodeData));
		}

		public void MapSequence(IOperation alias, IOperation existing)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapSequence", alias, existing);
		}

		public void SetNullSequence(IOperation alias)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetNullSequence", alias);
		}

		public System.Boolean IsEvaluationDirty(C context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsEvaluationDirty", context), typeof(System.Boolean));
		}

		public void MarkEvaluationDirty(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkEvaluationDirty", context);
		}

		public System.Boolean IsEvaluated(IExecutionNode<C> node, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsEvaluated", node, context), typeof(System.Boolean));
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
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncImpulseImport", index, context), typeof(Task));
		}

		public void ExecuteSequence(ISyncOperation operation, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSequence", operation, context);
		}

		public Task ExecuteAsyncSequence(IOperation operation, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncSequence", operation, context), typeof(Task));
		}

		public void ExecuteResumption(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteResumption", resumption, context);
		}

		public Task ExecuteAsyncResumption(AsyncResumption resumption, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsyncResumption", resumption, context), typeof(Task));
		}

		public void ResumeExecution(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeExecution", resumption, context);
		}

		public Task ResumeAsyncExecution(AsyncResumption resumption, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitStackFrame", context), typeof(System.Boolean));
		}

		public void ClearValueLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearValueLocals", context);
		}

		public void ClearObjectLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearObjectLocals", context);
		}

		public void ClearEvaluatedFlags(C context)
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

		public void InvokeImpulseExport(C context, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InvokeImpulseExport", context, index);
		}

		public System.Int32 GetOperationSequenceSteps(IOperation operation)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationSequenceSteps", operation), typeof(System.Int32));
		}

		public System.String GetEvaluationSequenceDebug(IOutput output)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEvaluationSequenceDebug", output), typeof(System.String));
		}

		public System.Int32 DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, System.Boolean cache = true, HashSet<NodeRuntime> walkedRuntimes = null) where T : INode
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(System.Int32));
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

		public void MapGlobalsInternal(IGlobalValue[] globals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobalsInternal", globals, context);
		}

		public System.Int32 RestoreSharedScope(ScopePoint rootScope, C context, byte[] values, object[] objects)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RestoreSharedScope", rootScope, context, values, objects), typeof(System.Int32));
		}

		public System.Int32 RestoreSharedScopeInternal(ScopePoint point, C context, byte[] values, object[] objects)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RestoreSharedScopeInternal", point, context, values, objects), typeof(System.Int32));
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

		public ExecutionRuntime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExecutionRuntime()
		{
		}
	}
	public abstract class ImpulseExportWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Boolean IsLast
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLast"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLast", value);
			}
		}

		public ImpulseExportWrapper(System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseExportWrapper", ResoniteBridge.ResoniteBridgeValueType.Type), index);
		}

		public System.Boolean ShouldBeContinuation(C context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldBeContinuation", context), typeof(System.Boolean));
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

		public ImpulseExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseExportWrapper()
		{
		}
	}
	public struct LocalNodeData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "index", value);
			}
		}

		public System.Boolean isImplicit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isImplicit", value);
			}
		}

		public System.Int32 valueStart
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueStart"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueStart", value);
			}
		}

		public System.Int32 valueSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "valueSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "valueSize", value);
			}
		}

		public System.Int32 objectStart
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectStart"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectStart", value);
			}
		}

		public System.Int32 objectSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "objectSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "objectSize", value);
			}
		}

		public LocalNodeData(System.Int32 index, System.Boolean isImplicit, System.Int32 valueStart, System.Int32 valueSize, System.Int32 objectStart, System.Int32 objectSize)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "LocalNodeData", ResoniteBridge.ResoniteBridgeValueType.Type), index, isImplicit, valueStart, valueSize, objectStart, objectSize);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public LocalNodeData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalNodeData()
		{
		}
	}
	public interface IOperationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		ExecutionRuntime<C> Runtime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>)) is ExecutionRuntime<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<C>");
				}
			}
		}

		System.Boolean IsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Int32 SequenceSteps
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SequenceSteps"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		void Build();

		IOperation ExecuteSync(C context);

		Task<IOperation> ExecuteAsync(C context);
	}
	public abstract class OperationSequence<C, O, H> : IOperationSequence<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where O : class, IOperation where H : Delegate
	{
		public O origin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "origin"), typeof(O)) is O __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to O");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(ExecutionRuntime<C>)) is ExecutionRuntime<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SequenceSteps"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public List<H> operationSequence
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "operationSequence"), typeof(List<H>)) is List<H> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<H>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "operationSequence", value);
			}
		}

		public abstract System.Boolean IsAsync { get; }

		public OperationSequence(ExecutionRuntime<C> runtime, O origin)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationSequence", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, origin);
		}

		void IOperationSequence<C>.Build()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationSequence<C>.Build");
		}

		public void StitchSequence(Node node, IOperation initialOperationSkip)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StitchSequence", node, initialOperationSkip);
		}

		public IOperation BuildOperationStep(IOperation operation, ref IOperation initialOperationSkip)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BuildOperationStep", operation, initialOperationSkip), typeof(IOperation));
		}

		public virtual System.Boolean IsSupported(IOperation operation)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsSupported", operation), typeof(System.Boolean));
		}

		public abstract H GetHandler(IOperation operation);

		public virtual IOperation ExecuteSync(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSync", context), typeof(IOperation));
		}

		public virtual Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
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

		public OperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OperationSequence()
		{
		}
	}
	public class SyncOperationSequence<C> : OperationSequence<C, ISyncOperation, ExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override System.Boolean IsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public SyncOperationSequence(ExecutionRuntime<C> runtime, ISyncOperation origin)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "SyncOperationSequence", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, origin);
		}

		public override ExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			return (ExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler", operation), typeof(ExecutionOperationHandler<C>));
		}

		public override IOperation ExecuteSync(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExecuteSync", context), typeof(IOperation));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
			}
		}

		IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context);

		Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context);
	}
	[NodeOverload("Core.Nest")]
	public class NestedNode<C> : VoidNode<C>, IExecutionNestedNode, INestedNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public abstract class InputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(ArgumentList inputList, IOutput output);

			public abstract void SetImport(System.Int32 index, ExecutionRuntime<C> group, C context, System.Int32 valueOffset, System.Int32 objectOffset);

			public abstract void EvaluateInput(ExecutionRuntime<C> group, C context);

			public abstract void SetFromStack(System.Int32 index, ExecutionRuntime<C> group, C context);

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

			public InputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public InputMapping()
			{
			}
		}

		public abstract class OutputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(OutputList outputList, IOutput output);

			public abstract void ExtractExport(System.Int32 index, ExecutionRuntime<C> runtime, C context);

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

			public OutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public OutputMapping()
			{
			}
		}

		public abstract class InputMapping<T> : InputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
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

			public InputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public InputMapping()
			{
			}
		}

		public abstract class OutputMapping<T> : OutputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
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

			public OutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public OutputMapping()
			{
			}
		}

		public class ValueInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			public IInput<T> input
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "input"), typeof(IInput<T>)) is IInput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IInput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "input", value);
				}
			}

			public ValueOutput<T> import
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "import"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "import", value);
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

			public ValueInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ValueInputMapping()
			{
			}
		}

		public class ObjectInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IInput<T> input
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "input"), typeof(IInput<T>)) is IInput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IInput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "input", value);
				}
			}

			public ObjectOutput<T> import
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "import"), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "import", value);
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

			public ObjectInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ObjectInputMapping()
			{
			}
		}

		public class ValueOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			public ValueOutput<T> output
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "output"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "output", value);
				}
			}

			public IOutput export
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "export"), typeof(IOutput)) is IOutput __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOutput");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "export", value);
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

			public ValueOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ValueOutputMapping()
			{
			}
		}

		public class ObjectOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public ObjectOutput<T> output
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "output"), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "output", value);
				}
			}

			public IOutput export
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "export"), typeof(IOutput)) is IOutput __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOutput");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "export", value);
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

			public ObjectOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public ObjectOutputMapping()
			{
			}
		}

		public static Type _valueInputMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueInputMapping"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueInputMapping", value);
			}
		}

		public static Type _objectInputMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectInputMapping"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectInputMapping", value);
			}
		}

		public static Type _valueOutputMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueOutputMapping"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_valueOutputMapping", value);
			}
		}

		public static Type _objectOutputMapping
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type), "_objectOutputMapping"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(ExecutionRuntime<C>)) is ExecutionRuntime<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<C>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ArgumentList)) is ArgumentList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ArgumentList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Outputs"), typeof(OutputList)) is OutputList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operations"), typeof(MixedOperationList)) is MixedOperationList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MixedOperationList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Impulses"), typeof(CallList)) is CallList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CallList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "GlobalRefs"), typeof(GlobalRefList)) is GlobalRefList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRefList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "GlobalRefs", value);
			}
		}

		public List<InputMapping> _inputMappings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputMappings"), typeof(List<InputMapping>)) is List<InputMapping> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputMapping>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputMappings", value);
			}
		}

		public List<OutputMapping> _outputMappings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputMappings"), typeof(List<OutputMapping>)) is List<OutputMapping> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputMapping>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetGroup"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
			}
		}

		NodeRuntime INestedNode.TargetRuntime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
			}
		}

		IExecutionRuntime IExecutionNestedNode.TargetRuntime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(IExecutionRuntime)) is IExecutionRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IExecutionRuntime");
				}
			}
		}

		public override System.Boolean CanBeEvaluated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override System.Boolean IsInputConditional(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean));
		}

		public IOutput GetTargetExport(IOutput output)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetTargetExport", output), typeof(IOutput));
		}

		public IOutput GetImportSource(IOutput import)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportSource", import), typeof(IOutput));
		}

		public void MapTarget()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapTarget");
		}

		public void EnterTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterTargetFrame", context);
		}

		public void ExitTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitTargetFrame", context);
		}

		public IOperation DoOperations(C context, System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperations", context, index), typeof(IOperation));
		}

		public Task<IOperation> DoOperationsAsync(C context, System.Int32 index)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperationsAsync", context, index), typeof(Task<IOperation>));
		}

		public void OnGlobalRefsChanged<T>(System.Int32 index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalRefsChanged", index, value, context);
		}

		public void MapGlobals(IGlobalValue[] scopeGlobals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MapGlobals", scopeGlobals, context);
		}

		public IOperation FinishOperations(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishOperations", context), typeof(IOperation));
		}

		public IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeExecution", resumption, context), typeof(IOperation));
		}

		public Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task<IOperation>));
		}

		public System.Int32 DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, System.Boolean cache, HashSet<NodeRuntime> walkedRuntimes) where T : INode
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(System.Int32));
		}

		public void OnImpulseExport(ExecutionContext context, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnImpulseExport", context, index);
		}

		public override void ComputeOutputs(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public void EnterNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnterNestedFrame", context);
		}

		public void FinishNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishNestedFrame", context);
		}

		public void ExtractExports(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractExports", context);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public NestedNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public NestedNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class NestedNodeHelper
	{
		public static NestedNode<C> AddNestedNode<C>(this ExecutionRuntime<C> runtime, ExecutionRuntime<C> target) where C : ExecutionContext
		{
			return (NestedNode<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NestedNodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddNestedNode", runtime, target), typeof(NestedNode<C>));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		public virtual void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		public abstract TimeSpan GetDuration(ExecutionContext context);

		public override Task Do(ExecutionContext context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Do", context), typeof(Task));
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

		public DelayTime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>)) is ValueInput<TimeSpan> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<TimeSpan>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayTimeSpan()
		{
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsInt : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelaySecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelaySecondsInt()
		{
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsFloat : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelaySecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelaySecondsFloat()
		{
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsDouble : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>)) is ValueInput<double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelaySecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelaySecondsDouble()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DelayedValue"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DelayedValue", value);
			}
		}

		public override void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		public DelayTimeWithValue()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DelayTimeWithValue", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public DelayTimeWithValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithValueTimeSpan<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>)) is ValueInput<TimeSpan> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<TimeSpan>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithValueTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithValueTimeSpan()
		{
		}
	}
	public class DelayWithValueSecondsInt<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<int> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithValueSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithValueSecondsInt()
		{
		}
	}
	public class DelayWithValueSecondsFloat<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<float> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithValueSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithValueSecondsFloat()
		{
		}
	}
	public class DelayWithValueSecondsDouble<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<double> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>)) is ValueInput<double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithValueSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithValueSecondsDouble()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DelayedValue"), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DelayedValue", value);
			}
		}

		public override void BeforeDelay(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeforeDelay", context);
		}

		public DelayTimeWithObject()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DelayTimeWithObject", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public DelayTimeWithObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DelayWithObjectTimeSpan<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<TimeSpan>)) is ValueInput<TimeSpan> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<TimeSpan>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithObjectTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithObjectTimeSpan()
		{
		}
	}
	public class DelayWithObjectSecondsInt<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithObjectSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithObjectSecondsInt()
		{
		}
	}
	public class DelayWithObjectSecondsFloat<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithObjectSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithObjectSecondsFloat()
		{
		}
	}
	public class DelayWithObjectSecondsDouble<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Duration"), typeof(ValueInput<double>)) is ValueInput<double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Duration", value);
			}
		}

		public override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDuration", context), typeof(TimeSpan));
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

		public DelayWithObjectSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DelayWithObjectSecondsDouble()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override System.Object Compute(ExecutionContext context)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object));
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

		public Box(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Box()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ValueConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueConstant()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ObjectConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectConstant()
		{
		}
	}
	public static class ConstantHelper
	{
		public static ValueConstant<T> AddValueConstant<T>(this ExecutionRuntime<ExecutionContext> runtime, T value) where T : struct
		{
			return (ValueConstant<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddValueConstant", runtime, value), typeof(ValueConstant<T>));
		}

		public static ObjectConstant<T> AddObjectConstant<T>(this ExecutionRuntime<ExecutionContext> runtime, T value)
		{
			return (ObjectConstant<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddObjectConstant", runtime, value), typeof(ObjectConstant<T>));
		}

		public static ValueConstant<T> AddValueConstant<C, T>(this ExecutionRuntime<C> runtime, T value) where C : ExecutionContext where T : struct
		{
			return (ValueConstant<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddValueConstant", runtime, value), typeof(ValueConstant<T>));
		}

		public static ObjectConstant<T> AddObjectConstant<C, T>(this ExecutionRuntime<C> runtime, T value) where C : ExecutionContext
		{
			return (ObjectConstant<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConstantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AddObjectConstant", runtime, value), typeof(ObjectConstant<T>));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ContinuouslyChangingValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuouslyChangingValueRelay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ContinuouslyChangingObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuouslyChangingObjectRelay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>)) is ValueArgument<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ValueOutputs"), typeof(ValueOutputList<T>)) is ValueOutputList<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutputList<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ValueOutputs", value);
			}
		}

		public override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public ValueDemultiplex()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ValueDemultiplex", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ValueDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>)) is ValueArgument<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ValueOutputs"), typeof(ObjectOutputList<T>)) is ObjectOutputList<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectOutputList<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ValueOutputs", value);
			}
		}

		public override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public ObjectDemultiplex()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ObjectDemultiplex", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ObjectDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
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

		public ValueEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueEvaluationPoint()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
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

		public ObjectEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectEvaluationPoint()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>)) is DisplayHandler<C, T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DisplayHandler<C, T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputListensToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Changed", context);
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

		public ExternalValueDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalValueDisplay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>)) is DisplayHandler<C, T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DisplayHandler<C, T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputListensToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Changed", context);
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

		public ExternalObjectDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalObjectDisplay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnPulsed"), typeof(ImpulseDisplayHandler<C>)) is ImpulseDisplayHandler<C> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseDisplayHandler<C>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnPulsed", value);
			}
		}

		public override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
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

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalImpulseDisplay()
		{
		}
	}
	public class ExternalImpulseDisplay : ExternalImpulseDisplay<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalImpulseDisplay()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Input", false)]
	[ChangeSource]
	[NodeOverload("Core.Input")]
	public class ExternalValueInput<C, T> : ValueFunctionNode<C, T>, IScopeEventListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C> where T : struct
	{
		public Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> _changeListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)) is Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
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

		public override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ExternalValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalValueInput()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Input", false)]
	[ChangeSource]
	[NodeOverload("Core.Input")]
	public class ExternalObjectInput<C, T> : ObjectFunctionNode<C, T>, IScopeEventListener<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExtendedExecutionContext<C>
	{
		public Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> _changeListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)) is Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
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

		public override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ExternalObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalObjectInput()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Filter"), typeof(Func<T, T>)) is Func<T, T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Func<T, T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Filter", value);
			}
		}

		public override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ExternalValueInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalValueInputWithFilter()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Filter"), typeof(Func<T, T>)) is Func<T, T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Func<T, T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Filter", value);
			}
		}

		public override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ExternalObjectInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalObjectInputWithFilter()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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

		public ExternalCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalCall()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
			}
		}

		public Task Execute(C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(Task));
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

		public ExternalAsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ExternalAsyncCall()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Count"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reverse"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Iteration"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncFor()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncFor", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public AsyncFor(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Start"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "End"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "StepSize"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Current"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncRangeLoopInt()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncRangeLoopInt", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public AsyncRangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Calls"), typeof(AsyncCallList)) is AsyncCallList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCallList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Calls", value);
			}
		}

		public override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncSequence()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncSequence", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public AsyncSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
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

		public AsyncWhile(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncWhile()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Count"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reverse"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Iteration"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public For()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "For", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public For(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
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

		public If(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public If()
		{
		}
	}
	[NodeCategory("Flow")]
	public class ImpulseDemultiplexer : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SyncOperationList Operations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operations"), typeof(SyncOperationList)) is SyncOperationList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SyncOperationList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public IOperation DoOperations(ExecutionContext context, System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoOperations", context, index), typeof(IOperation));
		}

		public ImpulseDemultiplexer()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseDemultiplexer", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ImpulseDemultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Impulses"), typeof(ContinuationList)) is ContinuationList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ContinuationList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Impulses", value);
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public ImpulseMultiplexer()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseMultiplexer", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ImpulseMultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Start"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "End"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "StepSize"), typeof(ValueInput<int>)) is ValueInput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Current"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeEvaluated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public RangeLoopInt()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "RangeLoopInt", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public RangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Calls"), typeof(CallList)) is CallList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CallList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Calls", value);
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public Sequence()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Sequence", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopStart"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopIteration"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopEnd"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LoopEnd", value);
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
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

		public While(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public While()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Object"), typeof(ObjectArgument<object>)) is ObjectArgument<object> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<object>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Object", value);
			}
		}

		public override Type Compute(ExecutionContext context)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(Type));
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

		public GetType(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GetType()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>)) is GlobalRef<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRef<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		public GlobalToValueOutput()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalToValueOutput", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public GlobalToValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>)) is GlobalRef<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRef<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		public GlobalToObjectOutput()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalToObjectOutput", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public GlobalToObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(Reference<INode>)) is Reference<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<INode>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(Reference<INode>)) is Reference<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<INode>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
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

		public Link(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Link()
		{
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Local")]
	public class LocalValue<T> : ValueFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueLocal<T> _data
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ValueLocal<T>)) is ValueLocal<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueLocal<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
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

		public LocalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalValue()
		{
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Local")]
	public class LocalObject<T> : ObjectFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectLocal<T> _data
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ObjectLocal<T>)) is ObjectLocal<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectLocal<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
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

		public LocalObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalObject()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ValueInputList<T>)) is ValueInputList<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInputList<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>)) is ValueArgument<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InputCount"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "InputCount", value);
			}
		}

		public override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public ValueMultiplex()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ValueMultiplex", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ValueMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Inputs"), typeof(ObjectInputList<T>)) is ObjectInputList<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInputList<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Index"), typeof(ValueArgument<int>)) is ValueArgument<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ObjectOutput<T>)) is ObjectOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InputCount"), typeof(ValueOutput<int>)) is ValueOutput<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "InputCount", value);
			}
		}

		public override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public ObjectMultiplex()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ObjectMultiplex", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public ObjectMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "HasValue"), typeof(ValueArgument<bool>)) is ValueArgument<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "HasValue", value);
			}
		}

		public override T? Compute(ExecutionContext context)
		{
			return (T?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public PackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PackNullable()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Nullable"), typeof(ObjectArgument<T?>)) is ObjectArgument<T?> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T?>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueOutput<T>)) is ValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "HasValue"), typeof(ValueOutput<bool>)) is ValueOutput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "HasValue", value);
			}
		}

		public override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeOutputs", context);
		}

		public UnpackNullable()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnpackNullable", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public UnpackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueArgument<bool>)) is ValueArgument<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ValueConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueConditional()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueArgument<bool>)) is ValueArgument<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Condition", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ObjectConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectConditional()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public ValueEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueEquals()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public ObjectEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectEquals()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Instance"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Instance", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public IsNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public IsNull()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Instance"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Instance", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public NotNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NotNull()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public ValueNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueNotEquals()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public override System.Boolean Compute(ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Boolean));
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

		public ObjectNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectNotEquals()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "B", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public NullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NullCoalesce()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Operands"), typeof(ObjectInputList<T>)) is ObjectInputList<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInputList<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Operands", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public MultiNullCoalesce()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "MultiNullCoalesce", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public MultiNullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reference"), typeof(Reference<T>)) is Reference<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reference", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ReferenceToOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ReferenceToOutput()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<T>)) is ValueArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueRelay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<T>)) is ObjectArgument<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public ObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectRelay()
		{
		}
	}
	[NodeCategory("Core")]
	[NodeName("Continuation Relay", false)]
	[NodeOverload("Core.ContinuationRelay")]
	public class ContinuationRelay : ActionFlowNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override void Do(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Do", context);
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>));
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean));
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

		public ContinuationRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuationRelay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(Call)) is Call __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Call");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		public override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>));
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean));
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

		public CallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CallRelay()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTriggered"), typeof(AsyncCall)) is AsyncCall __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AsyncCall");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnTriggered", value);
			}
		}

		public override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public override AsyncExecutionOperationHandler<T> GetAsyncHandler<T>()
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsyncHandler"), typeof(AsyncExecutionOperationHandler<T>));
		}

		public override System.Boolean IsOperationPassthrough(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationPassthrough", index), typeof(System.Boolean));
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

		public AsyncCallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCallRelay()
		{
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Store")]
	public class StoredValue<T> : ValueFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueStore<T> _data
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ValueStore<T>)) is ValueStore<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueStore<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
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

		public StoredValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public StoredValue()
		{
		}
	}
	[NodeCategory("Variables")]
	[NodeOverload("Core.Store")]
	public class StoredObject<T> : ObjectFunctionNode<ExecutionContext, T>, IVariable<ExecutionContext, T>, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectStore<T> _data
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_data"), typeof(ObjectStore<T>)) is ObjectStore<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectStore<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_data", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public System.Boolean Write(T value, ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context), typeof(System.Boolean));
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

		public StoredObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public StoredObject()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<object>)) is ObjectArgument<object> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<object>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Input", value);
			}
		}

		public override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(T));
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

		public Unbox(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Unbox()
		{
		}
	}
	public abstract class WriteBase<C, T> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnWritten
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		public abstract IVariable<C, T> GetVariable(C context);

		public abstract T GetValue(IVariable<C, T> variable, C context);

		public override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
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

		public WriteBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>)) is Reference<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T));
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

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueWrite()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>)) is Reference<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T));
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

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectWrite()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>)) is ObjectInput<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T));
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

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueIndirectWrite()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>)) is ObjectInput<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Value", value);
			}
		}

		public sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValue", variable, context), typeof(T));
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

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectIndirectWrite()
		{
		}
	}
	public class ValueWrite<T> : ValueWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueWrite()
		{
		}
	}
	public class ObjectWrite<T> : ObjectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectWrite()
		{
		}
	}
	public class ValueIndirectWrite<T> : ValueIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueIndirectWrite()
		{
		}
	}
	public class ObjectIndirectWrite<T> : ObjectIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectIndirectWrite()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>)) is GlobalRef<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRef<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		public override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		public WriteValueToGlobal()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "WriteValueToGlobal", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public WriteValueToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Global"), typeof(GlobalRef<T>)) is GlobalRef<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRef<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Value"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnWritten"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "OnFail", value);
			}
		}

		public override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Run", context), typeof(IOperation));
		}

		public void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnGlobalChanged", value, context);
		}

		public WriteObjectToGlobal()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "WriteObjectToGlobal", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public WriteObjectToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class WriteLatchBase<C, T> : VoidNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnSet
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnSet"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnReset"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFail"), typeof(Continuation)) is Continuation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Continuation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Set"), typeof(Operation)) is Operation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Operation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reset"), typeof(Operation)) is Operation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Operation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Reset", value);
			}
		}

		public IOperation DoSet(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoSet", context), typeof(IOperation));
		}

		public IOperation DoReset(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoReset", context), typeof(IOperation));
		}

		public abstract IVariable<C, T> GetVariable(C context);

		public abstract T GetSetValue(IVariable<C, T> variable, C context);

		public abstract T GetResetValue(IVariable<C, T> variable, C context);

		public WriteLatchBase()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "WriteLatchBase", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public WriteLatchBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>)) is Reference<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		public override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T));
		}

		public override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T));
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

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueWriteLatch()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(Reference<IVariable<C, T>>)) is Reference<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Reference<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		public override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T));
		}

		public override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T));
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

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectWriteLatch()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>)) is ObjectInput<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ValueInput<T>)) is ValueInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		public override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T));
		}

		public override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T));
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

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueIndirectWriteLatch()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>)) is ObjectInput<IVariable<C, T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<IVariable<C, T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SetValue"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ResetValue"), typeof(ObjectInput<T>)) is ObjectInput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectInput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ResetValue", value);
			}
		}

		public override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		public override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetValue", variable, context), typeof(T));
		}

		public override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResetValue", variable, context), typeof(T));
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

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectIndirectWriteLatch()
		{
		}
	}
	public class ValueWriteLatch<T> : ValueWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueWriteLatch()
		{
		}
	}
	public class ObjectWriteLatch<T> : ObjectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectWriteLatch()
		{
		}
	}
	public class ValueIndirectWriteLatch<T> : ValueIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueIndirectWriteLatch()
		{
		}
	}
	public class ObjectIndirectWriteLatch<T> : ObjectIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectIndirectWriteLatch()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<I>)) is ValueArgument<I> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<I>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Type InputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
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

		public ValueCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<I>)) is ObjectArgument<I> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<I>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Type InputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override O Compute(ExecutionContext context)
		{
			return (O)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(O));
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

		public ObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectCast()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ObjectArgument<I?>)) is ObjectArgument<I?> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ObjectArgument<I?>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Type InputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public override System.Object Compute(ExecutionContext context)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object));
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

		public NullableToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NullableToObjectCast()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueArgument<I>)) is ValueArgument<I> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueArgument<I>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsImplicit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Type InputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public override System.Object Compute(ExecutionContext context)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Compute", context), typeof(System.Object));
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

		public ValueToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueToObjectCast()
		{
		}
	}
}
namespace ProtoFlux.Runtimes.DSP
{
	public abstract class DSP_Action<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		public List<DSP_Dependency<TSequence>> _dependencies
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_dependencies"), typeof(List<DSP_Dependency<TSequence>>)) is List<DSP_Dependency<TSequence>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<DSP_Dependency<TSequence>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Node"), typeof(TNode)) is TNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TNode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputIndex", value);
			}
		}

		public System.Int32 OutputIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OutputIndex", value);
			}
		}

		public DSP_Action(TNode node)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Action", ResoniteBridge.ResoniteBridgeValueType.Type), node);
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

		public DSP_Action(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Action()
		{
		}
	}
	public abstract class DSP_Buffer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract Type BufferType { get; }

		public abstract void Recycle();

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

		public DSP_Buffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionContext"), typeof(ProtoFlux.Runtimes.Execution.ExecutionContext)) is ProtoFlux.Runtimes.Execution.ExecutionContext __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProtoFlux.Runtimes.Execution.ExecutionContext");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExecutionContext", value);
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

		public DSP_BuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_BuildContext()
		{
		}
	}
	public abstract class DSP_BuildContext<TNode, TSequence, TContext, TBuffer, TAction> : DSP_BuildContext, ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction>, new() where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		public Dictionary<TNode, TSequence> nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodes"), typeof(Dictionary<TNode, TSequence>)) is Dictionary<TNode, TSequence> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<TNode, TSequence>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nodes", value);
			}
		}

		public List<TSequence> rootSequences
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "rootSequences"), typeof(List<TSequence>)) is List<TSequence> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<TSequence>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "rootSequences", value);
			}
		}

		public TaskCompletionSource<bool> completion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "completion"), typeof(TaskCompletionSource<bool>)) is TaskCompletionSource<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TaskCompletionSource<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "completion", value);
			}
		}

		public DSP_ResultHandler<TBuffer> resultHandler
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "resultHandler"), typeof(DSP_ResultHandler<TBuffer>)) is DSP_ResultHandler<TBuffer> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DSP_ResultHandler<TBuffer>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "resultHandler", value);
			}
		}

		public System.Int32 outputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputCount", value);
			}
		}

		public System.Int32 remainingOutputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "remainingOutputs"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "remainingOutputs", value);
			}
		}

		public Dictionary<TNode, TSequence>.KeyCollection CollectedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CollectedNodes"), typeof(Dictionary<TNode, TSequence>.KeyCollection)) is Dictionary<TNode, TSequence>.KeyCollection __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<TNode, TSequence>.KeyCollection");
				}
			}
		}

		public void Collect(List<IOutput> outputs, ProtoFlux.Runtimes.Execution.ExecutionContext executionContext)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", outputs, executionContext);
		}

		public TSequence Collect(TNode node)
		{
			return (TSequence)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", node), typeof(TSequence));
		}

		public Task Execute(TContext context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Execute", context), typeof(Task));
		}

		public void HandleResult(System.Int32 index, TBuffer buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleResult", index, buffer);
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

		public DSP_BuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_BuildContext()
		{
		}
	}
	public static class DSP_BuildContextHelper
	{
		public static void Collect<T>(this ValueInput<T> input, ResoniteBridge.ResoniteBridgeValue mask) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}

		public static void Collect<T>(this ObjectInput<T> input, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}

		public static void Collect<T>(this System.Int32 input, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}
	}
	public delegate void DSP_ResultHandler<B>(System.Int32 resultIndex, B buffer) where B : DSP_Buffer;
	public abstract class DSP_Context<B, C> : ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		public List<B> inputBuffers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputBuffers"), typeof(List<B>)) is List<B> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<B>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputBuffers", value);
			}
		}

		public List<B> outputBuffers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputBuffers"), typeof(List<B>)) is List<B> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<B>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputBuffers", value);
			}
		}

		public List<int> sharedOutputBuffers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sharedOutputBuffers"), typeof(List<int>)) is List<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<int>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionContext"), typeof(ProtoFlux.Runtimes.Execution.ExecutionContext)) is ProtoFlux.Runtimes.Execution.ExecutionContext __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProtoFlux.Runtimes.Execution.ExecutionContext");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResultHandler"), typeof(DSP_ResultHandler<B>)) is DSP_ResultHandler<B> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DSP_ResultHandler<B>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ResultHandler", value);
			}
		}

		public void SetResult(System.Int32 resultIndex, B buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetResult", resultIndex, buffer);
		}

		public B GetInputBuffer(System.Int32 index)
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputBuffer", index), typeof(B));
		}

		public B GetOutputBuffer(System.Int32 index)
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputBuffer", index), typeof(B));
		}

		public B TryGetInputBuffer(System.Int32 index)
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetInputBuffer", index), typeof(B));
		}

		public B TryGetOutputBuffer(System.Int32 index)
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetOutputBuffer", index), typeof(B));
		}

		public B TryGetOutputBufferOrReuseInput(System.Int32 index, Predicate<B> filter)
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetOutputBufferOrReuseInput", index, filter), typeof(B));
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
			return (C)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneContext"), typeof(C));
		}

		public virtual void RecycleContext()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleContext");
		}

		public abstract B CloneBuffer(B buffer);

		public abstract void RecycleBuffer(B buffer);

		public abstract C CloneSelf();

		public void EnsureInputBufferCountForIndex(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureInputBufferCountForIndex", index);
		}

		public void EnsureOutputBufferCountForIndex(System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureOutputBufferCountForIndex", index);
		}

		public void EnsureBufferCountForIndex(List<B> list, System.Int32 index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureBufferCountForIndex", list, index);
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

		public DSP_Context(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Context()
		{
		}
	}
	public struct DSP_Dependency<TSequence> : ResoniteBridge.ResoniteBridgeValueHolder where TSequence : class
	{
		public TSequence sequence
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sequence"), typeof(TSequence)) is TSequence __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TSequence");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "inputIndex", value);
			}
		}

		public System.Int32 outputIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "outputIndex", value);
			}
		}

		public System.Boolean IsResultDependency
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsResultDependency"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public DSP_Dependency(TSequence sequence, System.Int32 inputIndex, System.Int32 outputIndex)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Dependency", ResoniteBridge.ResoniteBridgeValueType.Type), sequence, inputIndex, outputIndex);
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
		public static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, DSP_NodeMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		public static DSP_NodeMetadata GetMetadata(Type type)
		{
			return (DSP_NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadata", type), typeof(DSP_NodeMetadata));
		}

		public static System.Boolean IsDSP(InputMetadataBase input)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", input), typeof(System.Boolean));
		}

		public static System.Boolean IsDSP(OutputMetadataBase output)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", output), typeof(System.Boolean));
		}
	}
	public abstract class DSP_Node<B, C> : Node, IDSP_Node<B, C>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		public virtual DSP_NodeMetadata DSP_Metadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DSP_Metadata"), typeof(DSP_NodeMetadata)) is DSP_NodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DSP_NodeMetadata");
				}
			}
		}

		public System.Boolean HasExecutionEntryPoints
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 InputBufferCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputBufferCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 OutputBufferCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputBufferCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 BaseInputIndex(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseInputIndex", index), typeof(System.Int32));
		}

		public System.Int32 BaseOutputIndex(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseOutputIndex", index), typeof(System.Int32));
		}

		public System.Int32 BaseInputListIndex(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseInputListIndex", index), typeof(System.Int32));
		}

		public System.Int32 BaseOutputListIndex(System.Int32 index)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BaseOutputListIndex", index), typeof(System.Int32));
		}

		public abstract void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask);

		public IOutput GetInputBufferSource(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputBufferSource", index), typeof(IOutput));
		}

		public System.Boolean IsInputBufferConditional(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputBufferConditional", index), typeof(System.Boolean));
		}

		public abstract void Process(C context);

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

		public DSP_Node(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExecutionRuntime"), typeof(ExecutionRuntime<TExecutionContext>)) is ExecutionRuntime<TExecutionContext> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ExecutionRuntime<TExecutionContext>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputNodesMustBeLocal"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public Task<TBuffer> Process(IOutput output, TContext context)
		{
			return (Task<TBuffer>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", output, context), typeof(Task<TBuffer>));
		}

		public Task Process(List<IOutput> outputs, TContext context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", outputs, context), typeof(Task));
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

		public DSP_Runtime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Runtime()
		{
		}
	}
	public abstract class DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		public List<TAction> _actions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actions"), typeof(List<TAction>)) is List<TAction> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<TAction>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actions", value);
			}
		}

		public List<TBuffer> _dependencyBuffers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_dependencyBuffers"), typeof(List<TBuffer>)) is List<TBuffer> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<TBuffer>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_dependencyBuffers", value);
			}
		}

		public System.Int32 _missingDependencies
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_missingDependencies"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_missingDependencies", value);
			}
		}

		public TNode LastNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastNode"), typeof(TNode)) is TNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TNode");
				}
			}
		}

		public void AllocateDependency(System.Int32 inputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateDependency", inputIndex);
		}

		public System.Boolean SetDependency(System.Int32 inputIndex, TBuffer buffer)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetDependency", inputIndex, buffer), typeof(System.Boolean));
		}

		public void AddStep(TNode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddStep", node);
		}

		public void AddStep(IDSP_Node node, System.Int32 inputIndex, System.Int32 outputIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddStep", node, inputIndex, outputIndex);
		}

		public abstract TAction CreateAction(IDSP_Node node);

		public void RegisterDependency(IOutput output, System.Int32 inputIndex, TSequence targetSequence)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterDependency", output, inputIndex, targetSequence);
		}

		public void RegisterResultDependency(IOutput output, System.Int32 resultIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterResultDependency", output, resultIndex);
		}

		public TAction FindAction(IOutput output)
		{
			return (TAction)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindAction", output), typeof(TAction));
		}

		public void ScheduleRun(TContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleRun", context);
		}

		public void RunSequence(TContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunSequence", context);
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

		public DSP_Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DSP_Metadata"), typeof(DSP_NodeMetadata)) is DSP_NodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DSP_NodeMetadata");
				}
			}
		}

		System.Boolean HasExecutionEntryPoints
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Int32 InputBufferCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputBufferCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 OutputBufferCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputBufferCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		IOutput GetInputBufferSource(System.Int32 index);

		System.Boolean IsInputBufferConditional(System.Int32 index);

		void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedBufferOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicBufferInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicBufferOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Boolean HasExecutionEntryPoints
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasExecutionEntryPoints"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasExecutionEntryPoints", value);
			}
		}

		public List<InputMetadata> FixedBufferInputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferInputs"), typeof(List<InputMetadata>)) is List<InputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedBufferOutputs"), typeof(List<OutputMetadata>)) is List<OutputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferInputs"), typeof(List<InputListMetadata>)) is List<InputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicBufferOutputs"), typeof(List<OutputListMetadata>)) is List<OutputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputListMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DynamicBufferOutputs", value);
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

		public DSP_NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_NodeMetadata()
		{
		}
	}
}
namespace ProtoFlux.Runtimes.DSP.Array
{
	public class DSP_Array_Action : DSP_Action<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DSP_Array_Action(IDSP_Array_Node node)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_Action", ResoniteBridge.ResoniteBridgeValueType.Type), node);
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

		public DSP_Array_Buffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BufferType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public T[] Buffer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Buffer"), typeof(T[])) is T[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Buffer", value);
			}
		}

		public DSP_Array_Buffer(System.Int32 size)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_Buffer", ResoniteBridge.ResoniteBridgeValueType.Type), size);
		}

		public override void Copy(DSP_Array_Buffer source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Copy", source);
		}

		public override DSP_Array_Buffer Clone(DSP_Array_Context context, DSP_Array_Buffer source)
		{
			return (DSP_Array_Buffer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone", context, source), typeof(DSP_Array_Buffer));
		}

		public override void Recycle()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Recycle");
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

		public DSP_Array_BuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_BuildContext()
		{
		}
	}
	public class DSP_Array_Context : DSP_Context<DSP_Array_Buffer, DSP_Array_Context>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DSP_Array_Buffer<T> AllocateBuffer<T>() where T : struct
		{
			return (DSP_Array_Buffer<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllocateBuffer"), typeof(DSP_Array_Buffer<T>));
		}

		public override DSP_Array_Buffer CloneBuffer(DSP_Array_Buffer buffer)
		{
			return (DSP_Array_Buffer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneBuffer", buffer), typeof(DSP_Array_Buffer));
		}

		public override DSP_Array_Context CloneSelf()
		{
			return (DSP_Array_Context)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloneSelf"), typeof(DSP_Array_Context));
		}

		public override void EnqueueTask(Action<DSP_Array_Context> task)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnqueueTask", task);
		}

		public override void RecycleContext()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleContext");
		}

		public override void RecycleBuffer(DSP_Array_Buffer buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecycleBuffer", buffer);
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

		public DSP_Array_Context(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Context()
		{
		}
	}
	public static class DSP_Array_BufferExtensions
	{
		public static T[] GetInputBuffer<T>(this ValueInput<T> input, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetInputBuffer", input, context), typeof(T[]));
		}

		public static T[] GetOutputBuffer<T>(this ValueOutput<T> input, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", input, context), typeof(T[]));
		}

		public static T[] GetOutputBufferOrReuse<T>(this ValueOutput<T> input, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBufferOrReuse", input, context), typeof(T[]));
		}

		public static T[] GetInputBuffer<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetInputBuffer", index, context), typeof(T[]));
		}

		public static T[] GetOutputBuffer<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context), typeof(T[]));
		}

		public static T[] GetOutputBufferOrReuse<T>(this System.Int32 index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBufferOrReuse", index, context), typeof(T[]));
		}

		public static T[] GetOutputBuffer<T>(System.Int32 index, DSP_Array_Context context, System.Boolean allowReuse) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context, allowReuse), typeof(T[]));
		}
	}
	public abstract class DSP_Array_Node : DSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Array_Node, IDSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public DSP_Array_Node(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Node()
		{
		}
	}
	public class DSP_Array_Runtime<C> : DSP_Runtime<IDSP_Array_Node, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_BuildContext, DSP_Array_Sequence, DSP_Array_Action, C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ProtoFlux.Runtimes.Execution.ExecutionContext
	{
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

		public DSP_Array_Runtime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Runtime()
		{
		}
	}
	public class DSP_Array_Sequence : DSP_Sequence<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override DSP_Array_Action CreateAction(IDSP_Node node)
		{
			return (DSP_Array_Action)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateAction", node), typeof(DSP_Array_Action));
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

		public DSP_Array_Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DSP_Array_Sequence()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestAddArraysNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestAddArraysNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestAddArraysNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[NodeOverload("Core.Add")]
	public class TestAddArraysNodeExecution : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> A
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "A"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "B"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestAddArraysNodeExecution()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestAddArraysNodeExecution", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestAddArraysNodeExecution(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TestAmplifyArray : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Multiplier"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Multiplier", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestAmplifyArray()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestAmplifyArray", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestAmplifyArray(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TestConditionalCollectArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> OnTrue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnTrue"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnFalse"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Condition"), typeof(ValueInput<bool>)) is ValueInput<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestConditionalCollectArrayNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestConditionalCollectArrayNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestConditionalCollectArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TestNegateArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Input"), typeof(ValueInput<float>)) is ValueInput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueInput<float>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestNegateArrayNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestNegateArrayNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestNegateArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TestRandomArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestRandomArrayNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestRandomArrayNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestRandomArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TestSequenceArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Output"), typeof(ValueOutput<float>)) is ValueOutput<float> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ValueOutput<float>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, ResoniteBridge.ResoniteBridgeValue mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Process", context);
		}

		public TestSequenceArrayNode()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TestSequenceArrayNode", ResoniteBridge.ResoniteBridgeValueType.Type));
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

		public TestSequenceArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
}
namespace ProtoFlux.Core
{
	public static class CastHelper
	{
		public static Dictionary<Type, Dictionary<Type, List<Type>>> valueCasts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "valueCasts"), typeof(Dictionary<Type, Dictionary<Type, List<Type>>>)) is Dictionary<Type, Dictionary<Type, List<Type>>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, Dictionary<Type, List<Type>>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "valueCasts", value);
			}
		}

		public static List<Type> objectCasts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "objectCasts"), typeof(List<Type>)) is List<Type> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Type>");
				}
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
			return (IReadOnlyList<Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetValueCastNodes", from, to), typeof(IReadOnlyList<Type>));
		}

		public static Type GetCastNode(Type from, Type to, NodeRuntime runtime)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CastHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCastNode", from, to, runtime), typeof(Type));
		}
	}
	public class ChangeListenerAttribute : Attribute
	{
	}
	public class ChangeSourceAttribute : Attribute
	{
	}
	public struct ChangeSourceInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean continuous
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuous"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "continuous", value);
			}
		}

		public List<ElementPath<IOutput>> outputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "outputs"), typeof(List<ElementPath<IOutput>>)) is List<ElementPath<IOutput>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ElementPath<IOutput>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProducesChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
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

		public void Combine(ElementPath<IOutput> output, ref System.Boolean allocatedList)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Combine", output, allocatedList);
		}

		public System.Boolean Combine(ChangeSourceInfo other, ref System.Boolean allocatedList)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Combine", other, allocatedList), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ChangeSourceInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ChangeSourceInfo()
		{
		}
	}
	public class ChangeTrackingBuildContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public HashSet<NodeGroup> _currentlyProcessing
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentlyProcessing"), typeof(HashSet<NodeGroup>)) is HashSet<NodeGroup> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<NodeGroup>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentlyProcessing", value);
			}
		}

		public HashSet<NodeGroup> _currentConflicts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentConflicts"), typeof(HashSet<NodeGroup>)) is HashSet<NodeGroup> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<NodeGroup>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasConflicts"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean ContainsCurrentlyProcessing(NodeGroup group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContainsCurrentlyProcessing", group), typeof(System.Boolean));
		}

		public System.Boolean TryNestInto(NodeGroup group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryNestInto", group), typeof(System.Boolean));
		}

		public void NestOut(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NestOut", group);
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

		public ChangeTrackingBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ChangeTrackingBuildContext()
		{
		}
	}
	public class ChangeTrackingData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public HashSet<NodeGroup> NestedGroups
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NestedGroups"), typeof(HashSet<NodeGroup>)) is HashSet<NodeGroup> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<NodeGroup>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContinuousChanges"), typeof(List<ElementPath<INode>>)) is List<ElementPath<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ElementPath<INode>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ChangeListeners"), typeof(Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>)) is Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ExportsInfo"), typeof(Dictionary<IOutput, ChangeSourceInfo>)) is Dictionary<IOutput, ChangeSourceInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<IOutput, ChangeSourceInfo>");
				}
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
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ChangeTrackingData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ChangeTrackingData()
		{
		}
	}
	public class ContinuouslyChangingAttribute : Attribute
	{
	}
	public class NodeGroup : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ChangeTrackingData changeTrackingData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "changeTrackingData"), typeof(ChangeTrackingData)) is ChangeTrackingData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ChangeTrackingData");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "changeTrackingData", value);
			}
		}

		public List<NodeRuntime> runtimes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtimes"), typeof(List<NodeRuntime>)) is List<NodeRuntime> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<NodeRuntime>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "runtimes", value);
			}
		}

		public System.Int32 _nodeAllocationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_nodeAllocationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_nodeAllocationCount", value);
			}
		}

		public System.Boolean ChangeTrackingBuilt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTrackingBuilt"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeTrackingBuilt", value);
			}
		}

		public System.Boolean ChangeTrackingDirty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTrackingDirty"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeTrackingDirty", value);
			}
		}

		public System.Boolean RequiresRebuild
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresRebuild"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IgnoreChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IgnoreChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IgnoreChanges", value);
			}
		}

		public IReadOnlyList<ElementPath<INode>> ContinuousChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContinuousChanges"), typeof(IReadOnlyList<ElementPath<INode>>)) is IReadOnlyList<ElementPath<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IReadOnlyList<ElementPath<INode>>");
				}
			}
		}

		public Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection ActiveChangeSources
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveChangeSources"), typeof(Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection)) is Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection");
				}
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RuntimeCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IEnumerable<NodeRuntime> Runtimes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtimes"), typeof(IEnumerable<NodeRuntime>)) is IEnumerable<NodeRuntime> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<NodeRuntime>");
				}
			}
		}

		public System.Int32 TotalNodeCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalNodeCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public event Action<NodeGroup> ChangeTrackingInvalidated;

		public void MarkChangeTrackingDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkChangeTrackingDirty");
		}

		public System.Boolean ContainsNestedGroup(NodeGroup group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContainsNestedGroup", group), typeof(System.Boolean));
		}

		public System.Boolean CheckChangeTracking()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckChangeTracking"), typeof(System.Boolean));
		}

		public void OutputChanged(ElementPath<IOutput> output, HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OutputChanged", output, changedNodes);
		}

		public void OutputChanged(ElementPath<IOutput> output, SortedSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OutputChanged", output, changedNodes);
		}

		public void AllChanged(HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllChanged", changedNodes);
		}

		public void AllChanged(SortedSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AllChanged", changedNodes);
		}

		public void RebuildChangeTrackingData()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RebuildChangeTrackingData");
		}

		public ChangeTrackingData BuildChangeTrackingData(ChangeTrackingBuildContext context)
		{
			return (ChangeTrackingData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BuildChangeTrackingData", context), typeof(ChangeTrackingData));
		}

		public ChangeSourceInfo GetChangeInfo(IOutput output, Dictionary<IOutput, ChangeSourceInfo> infos, Dictionary<INestedNode, ChangeTrackingData> nestedData)
		{
			return (ChangeSourceInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetChangeInfo", output, infos, nestedData), typeof(ChangeSourceInfo));
		}

		public void CombineInputs(INode node, ref ChangeSourceInfo info, Dictionary<IOutput, ChangeSourceInfo> infos, Dictionary<INestedNode, ChangeTrackingData> nestedData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineInputs", node, info, infos, nestedData);
		}

		public System.String DebugChangeTrackingData()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DebugChangeTrackingData"), typeof(System.String));
		}

		public System.String PrintDebugStructure()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintDebugStructure"), typeof(System.String));
		}

		public void PrintRuntime(StringBuilder str, NodeRuntime runtime, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintRuntime", str, runtime, indent);
		}

		public void PrintNode(StringBuilder str, INode node, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintNode", str, node, indent);
		}

		public System.String PrintInputSource(IOutput source)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintInputSource", source), typeof(System.String));
		}

		public System.String PrintImpulseTarget(IOperation target)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintImpulseTarget", target), typeof(System.String));
		}

		public void Indent(StringBuilder str, System.Int32 indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Indent", str, indent);
		}

		public NodeRuntime GetRuntime(System.Int32 index)
		{
			return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRuntime", index), typeof(NodeRuntime));
		}

		public System.Int32 GetNodeAllocationIndex()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodeAllocationIndex"), typeof(System.Int32));
		}

		public NodeGroup(System.String name)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeGroup", ResoniteBridge.ResoniteBridgeValueType.Type), name);
		}

		public R AddRuntime<R>() where R : NodeRuntime, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddRuntime"), typeof(R));
		}

		public R GetRuntime<R>() where R : NodeRuntime
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRuntime"), typeof(R));
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
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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
		public System.Object Value { get; private set; }

		public DefaultValueAttribute(System.Object value)
		{
			Value = value;
		}
	}
	public class AsyncCallList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class InternalCall : IAsyncCall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOperation Target
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperation");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ImpulseType");
					}
				}
			}

			IOperation IImpulse.Target
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperation");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
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

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public InternalCall()
			{
			}
		}

		public List<InternalCall> calls
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "calls"), typeof(List<InternalCall>)) is List<InternalCall> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InternalCall>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse));
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
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
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

		public AsyncCallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCallList()
		{
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public AsyncOperationList List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(AsyncOperationList)) is AsyncOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to AsyncOperationList");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Node");
					}
				}
			}

			IOperationList IListOperation.List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList)) is IOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperationList");
					}
				}
			}

			public Operation(System.Int32 index, AsyncOperationList list)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Operation", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
			}

			public override System.String ToString()
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Operation()
			{
			}
		}

		public List<Operation> _operations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>)) is List<Operation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Operation>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IAsyncOperation AddOperation()
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(IAsyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public IAsyncOperation GetOperation(System.Int32 index)
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IAsyncOperation));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public AsyncOperationList(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncOperationList", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.AddOperation"), typeof(IOperation));
		}

		IOperation IOperationList.GetOperation(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.GetOperation", index), typeof(IOperation));
		}

		System.Boolean IOperationList.IsOperationAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.IsOperationAsync", index), typeof(System.Boolean));
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

		public AsyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncOperationList()
		{
		}
	}
	public class CallList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class InternalCall : ICall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public ISyncOperation Target
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ISyncOperation");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ImpulseType");
					}
				}
			}

			IOperation IImpulse.Target
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperation");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
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

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public InternalCall()
			{
			}
		}

		public List<InternalCall> calls
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "calls"), typeof(List<InternalCall>)) is List<InternalCall> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InternalCall>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse));
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
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
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

		public CallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CallList()
		{
		}
	}
	public class ContinuationList : IImpulseList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class InternalContinuation : IContinuation, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOperation Target
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperation");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to ImpulseType");
					}
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

			public InternalContinuation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public InternalContinuation()
			{
			}
		}

		public List<InternalContinuation> continuations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuations"), typeof(List<InternalContinuation>)) is List<InternalContinuation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InternalContinuation>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddImpulse", target), typeof(IImpulse));
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
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(System.Int32 index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
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

		public ContinuationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContinuationList()
		{
		}
	}
	public class ListGlobalRef<T> : GlobalRef<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlobalRefList List
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(GlobalRefList)) is GlobalRefList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GlobalRefList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "List", value);
			}
		}

		public ListGlobalRef(GlobalRefList list, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ListGlobalRef", ResoniteBridge.ResoniteBridgeValueType.Type), list, index);
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
		public List<IGlobalRef> globalRefs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globalRefs"), typeof(List<IGlobalRef>)) is List<IGlobalRef> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IGlobalRef>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public GlobalRefList(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefList", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		public IGlobalRef<T> AddGlobalRef<T>(Global<T> binding = null)
		{
			return (IGlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGlobalRef", binding), typeof(IGlobalRef<T>));
		}

		public void SetGlobalRefBinding<T>(System.Int32 index, Global<T> binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public IGlobalRef GetUntypedGlobalRef(System.Int32 index)
		{
			return (IGlobalRef)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUntypedGlobalRef", index), typeof(IGlobalRef));
		}

		public IGlobalRef<T> GetGlobalRef<T>(System.Int32 index)
		{
			return (IGlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRef", index), typeof(IGlobalRef<T>));
		}

		public void RemoveGlobalRef()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveGlobalRef");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		IOperationList List
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList)) is IOperationList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperationList");
				}
			}
		}
	}
	public abstract class InputListBase : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract class Input : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract IOutput GenericSource { get; set; }

			public abstract Type InputType { get; }

			public abstract DataClass DataClass { get; }

			public abstract System.Object DefaultValue { get; }

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

			public Input(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Input()
			{
			}
		}

		public class Input<T> : Input, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOutput<T> Source
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOutput<T>");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Type");
					}
				}
			}

			public override IOutput GenericSource
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GenericSource"), typeof(IOutput)) is IOutput __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOutput");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass)) is DataClass __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to DataClass");
					}
				}
			}

			public override System.Object DefaultValue
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.Object)) is System.Object __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to object");
					}
				}
			}

			IOutput IInput.Source
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOutput");
					}
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

			public Input(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Input()
			{
			}
		}

		public List<Input> _inputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputs"), typeof(List<Input>)) is List<Input> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Input>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IInput<T> GetInput<T>(System.Int32 index)
		{
			return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInput", index), typeof(IInput<T>));
		}

		public IInput<T> AddInput<T>(IOutput<T> source = null)
		{
			return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source), typeof(IInput<T>));
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
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput));
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
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type));
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass));
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object));
		}

		public void AddInput(IOutput source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInput", source);
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

		public InputListBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputListBase()
		{
		}
	}
	public class InputList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public InputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputList()
		{
		}
	}
	public class ArgumentList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ArgumentList()
		{
		}
	}
	public interface IOperationList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public MixedOperationList List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(MixedOperationList)) is MixedOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to MixedOperationList");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Node");
					}
				}
			}

			public abstract System.Boolean IsAsync { get; }

			IOperationList IListOperation.List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList)) is IOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperationList");
					}
				}
			}

			public Operation(System.Int32 index, MixedOperationList list)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Operation", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
			}

			public override System.String ToString()
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Operation()
			{
			}
		}

		public class SyncOperation : Operation, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public override System.Boolean IsAsync
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to bool");
					}
				}
			}

			public SyncOperation(System.Int32 index, MixedOperationList list)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "SyncOperation", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to bool");
					}
				}
			}

			public AsyncOperation(System.Int32 index, MixedOperationList list)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncOperation", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
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

			public AsyncOperation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public AsyncOperation()
			{
			}
		}

		public List<Operation> _operations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>)) is List<Operation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Operation>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public ISyncOperation AddSyncOperation()
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddSyncOperation"), typeof(ISyncOperation));
		}

		public IAsyncOperation AddAsyncOperation()
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddAsyncOperation"), typeof(IAsyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public IOperation GetOperation(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation));
		}

		public System.Boolean IsOperationAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public MixedOperationList(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "MixedOperationList", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.AddOperation"), typeof(IOperation));
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

		public MixedOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public MixedOperationList()
		{
		}
	}
	public abstract class ObjectInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<IObjectOutput<T>> inputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputs"), typeof(List<IObjectOutput<T>>)) is List<IObjectOutput<T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IObjectOutput<T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass));
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object));
		}

		public Type GetInputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type));
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput));
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

		public ObjectInputListBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectInputListBase()
		{
		}
	}
	public class ObjectInputList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectInputList()
		{
		}
	}
	public class ObjectArgumentList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ObjectArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectArgumentList()
		{
		}
	}
	public class ObjectOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<ListObjectOutput<T>> _outputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<ListObjectOutput<T>>)) is List<ListObjectOutput<T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ListObjectOutput<T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public ListObjectOutput<T> AddOutput()
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(ListObjectOutput<T>));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public ListObjectOutput<T> GetOutput(System.Int32 index)
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(ListObjectOutput<T>));
		}

		IOutput IOutputList.GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOutputList.GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		IListOutput IOutputList.AddOutput()
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOutputList.AddOutput"), typeof(IListOutput));
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOutput");
		}

		public ObjectOutputList(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ObjectOutputList", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		IOutputList List
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList)) is IOutputList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutputList");
				}
			}
		}
	}
	public class ListValueOutput<T> : ValueOutput<T>, IListOutput, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IOutputList List
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList)) is IOutputList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutputList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public ListValueOutput(System.Int32 index, IOutputList list)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ListValueOutput", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOutputList)) is IOutputList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutputList");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public ListObjectOutput(System.Int32 index, IOutputList list)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ListObjectOutput", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
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
		public List<IOutput> _outputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<IOutput>)) is List<IOutput> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IOutput>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public OutputList(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputList", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
		}

		public IOutput GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		public IListOutput AddOutputAuto(Type type)
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutputAuto", type), typeof(IListOutput));
		}

		public ListValueOutput<T> AddValueOutput<T>() where T : struct
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddValueOutput"), typeof(ListValueOutput<T>));
		}

		public ListObjectOutput<T> AddObjectOutput<T>()
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddObjectOutput"), typeof(ListObjectOutput<T>));
		}

		public ListValueOutput<T> GetValueOutput<T>(System.Int32 index) where T : struct
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueOutput", index), typeof(ListValueOutput<T>));
		}

		public ListObjectOutput<T> GetObjectOutput<T>(System.Int32 index)
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetObjectOutput", index), typeof(ListObjectOutput<T>));
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
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(IListOutput));
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
				}
			}

			public SyncOperationList List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(SyncOperationList)) is SyncOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to SyncOperationList");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Node");
					}
				}
			}

			IOperationList IListOperation.List
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "List"), typeof(IOperationList)) is IOperationList __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IOperationList");
					}
				}
			}

			public Operation(System.Int32 index, SyncOperationList list)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Operation", ResoniteBridge.ResoniteBridgeValueType.Type), index, list);
			}

			public override System.String ToString()
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Operation()
			{
			}
		}

		public List<Operation> _operations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_operations"), typeof(List<Operation>)) is List<Operation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Operation>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public ISyncOperation AddOperation()
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOperation"), typeof(ISyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOperation");
		}

		public ISyncOperation GetOperation(System.Int32 index)
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(ISyncOperation));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public SyncOperationList(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "SyncOperationList", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.AddOperation"), typeof(IOperation));
		}

		IOperation IOperationList.GetOperation(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.GetOperation", index), typeof(IOperation));
		}

		System.Boolean IOperationList.IsOperationAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOperationList.IsOperationAsync", index), typeof(System.Boolean));
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

		public SyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SyncOperationList()
		{
		}
	}
	public abstract class ValueInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public List<IValueOutput<T>> inputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "inputs"), typeof(List<IValueOutput<T>>)) is List<IValueOutput<T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IValueOutput<T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public DataClass GetDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDataClass", index), typeof(DataClass));
		}

		public System.Object GetDefaultValue(System.Int32 index)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultValue", index), typeof(System.Object));
		}

		public Type GetInputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type));
		}

		public IOutput GetInputSource(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput));
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

		public ValueInputListBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueInputListBase()
		{
		}
	}
	public class ValueInputList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueInputList()
		{
		}
	}
	public class ValueArgumentList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
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

		public ValueArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueArgumentList()
		{
		}
	}
	public class ValueOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public List<ListValueOutput<T>> _outputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputs"), typeof(List<ListValueOutput<T>>)) is List<ListValueOutput<T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ListValueOutput<T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Owner"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public ListValueOutput<T> AddOutput()
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddOutput"), typeof(ListValueOutput<T>));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public ListValueOutput<T> GetOutput(System.Int32 index)
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(ListValueOutput<T>));
		}

		IOutput IOutputList.GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOutputList.GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		IListOutput IOutputList.AddOutput()
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IOutputList.AddOutput"), typeof(IListOutput));
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveOutput");
		}

		public ValueOutputList(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ValueOutputList", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
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

		public AsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncCall()
		{
		}
	}
	public class AsyncOperation : IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public AsyncOperation(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncOperation", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
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

		public AsyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AsyncResumption()
		{
		}
	}
	public struct Call : ICall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ISyncOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
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

		public Call(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Call()
		{
		}
	}
	public struct Continuation : IContinuation, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
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

		public Continuation(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Continuation()
		{
		}
	}
	public abstract class GlobalRef : IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public abstract Global UntypedGlobal { get; }

		public abstract void ClearReference();

		public GlobalRef(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRef", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
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

		public GlobalRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GlobalRef()
		{
		}
	}
	public class GlobalRef<T> : GlobalRef, IGlobalRef<T>, IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Global<T> _global
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_global"), typeof(Global<T>)) is Global<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Global<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UntypedGlobal"), typeof(Global)) is Global __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Global");
				}
			}
		}

		public Global<T> Global
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Global"), typeof(Global<T>)) is Global<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Global<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Global", value);
			}
		}

		public GlobalRef(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRef", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		public override void ClearReference()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearReference");
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
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Read", global, context), typeof(T));
		}

		public static System.Boolean Write<T>(this GlobalRef<T> global, T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", global, value, context), typeof(System.Boolean));
		}
	}
	public struct ObjectArgument<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>)) is IObjectOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IObjectOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		IOutput IInput.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput");
				}
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
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

		public ObjectArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectArgument()
		{
		}
	}
	public struct ObjectInput<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>)) is IObjectOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IObjectOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		IOutput IInput.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput");
				}
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
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

		public ObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectInput()
		{
		}
	}
	public class ObjectOutput<T> : Output<T>, IObjectOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override DataClass OutputDataClass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
		}

		public ObjectOutput(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ObjectOutput", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public Operation(Node owner, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Operation", ResoniteBridge.ResoniteBridgeValueType.Type), owner, index);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Target", value);
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

		public Reference(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Reference()
		{
		}
	}
	public struct SyncResumption : ISyncResumption, IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ISyncOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
			}
		}

		IOperation IImpulse.Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Target", value);
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

		public SyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SyncResumption()
		{
		}
	}
	public struct ValueArgument<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>)) is IValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IValueOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		IOutput IInput.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput");
				}
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
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

		public ValueArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueArgument()
		{
		}
	}
	public struct ValueInput<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>)) is IValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IValueOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		IOutput IInput.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput");
				}
			}
		}

		IOutput<T> IInput<T>.Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Source", value);
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

		public ValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueInput()
		{
		}
	}
	public class ValueOutput<T> : Output<T>, IValueOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override DataClass OutputDataClass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
		}

		public ValueOutput(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ValueOutput", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UntypedGlobal"), typeof(Global)) is Global __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Global");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Global"), typeof(Global<T>)) is Global<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Global<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseType"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
			}
		}
	}
	public interface ICall : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new ISyncOperation Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ISyncOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Target"), typeof(ISyncOperation)) is ISyncOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ISyncOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		IOutput Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput)) is IOutput __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput");
				}
			}
		}
	}
	public interface IInput<T> : IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IOutput<T> Source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IOutput<T>)) is IOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IValueOutput<T>)) is IValueOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IValueOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Source"), typeof(IObjectOutput<T>)) is IObjectOutput<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IObjectOutput<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}
	}
	public interface IOutput : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node OwnerNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		DataClass OutputDataClass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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
		public T _value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_value", value);
			}
		}

		public System.Boolean _hasValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hasValue"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hasValue", value);
			}
		}

		public T Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
		}

		public System.Boolean HasValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasValue"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public UnmanagedNullable(T value)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), value);
		}

		public static implicit operator T?(UnmanagedNullable<T> unmanagedNullable)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", unmanagedNullable), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static implicit operator UnmanagedNullable<T>(T? nullable)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", nullable), typeof(UnmanagedNullable<T>)) is UnmanagedNullable<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UnmanagedNullable<T>");
			}
		}

		public static implicit operator UnmanagedNullable<T>(T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "UnmanagedNullable", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", value), typeof(UnmanagedNullable<T>)) is UnmanagedNullable<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UnmanagedNullable<T>");
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
		public System.Int32 offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
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

		public ObjectStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ObjectStore()
		{
		}
	}
	public struct ValueStore<T> : IStore<T>, IStore, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public System.Int32 offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "offset"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "offset", value);
			}
		}

		public System.Int32 Offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", value, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Access(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Access", context), typeof(T));
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

		public ValueStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ValueStore()
		{
		}
	}
	public abstract class CrossRuntimeInputAttribute : Attribute
	{
		public abstract System.Boolean IsValidTargetRuntime(NodeRuntime runtime);
	}
	public interface INestedNode : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		NodeGroup TargetGroup
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetGroup"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
			}
		}

		NodeRuntime TargetRuntime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRuntime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "index"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "listIndex"), typeof(System.Int16)) is System.Int16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to short");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDynamic"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean AddToList
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AddToList"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public ElementRef(System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ElementRef", ResoniteBridge.ResoniteBridgeValueType.Type), index);
		}

		public ElementRef(System.Int32 listIndex, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ElementRef", ResoniteBridge.ResoniteBridgeValueType.Type), listIndex, index);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ElementRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ElementRef()
		{
		}
	}
	public class AsyncCallExport : ImpulseExport, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AsyncCallExport(ImpulseExportNode node, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "AsyncCallExport", ResoniteBridge.ResoniteBridgeValueType.Type), node, index);
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
		public CallExport(ImpulseExportNode node, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "CallExport", ResoniteBridge.ResoniteBridgeValueType.Type), node, index);
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
		public ContinuationExport(ImpulseExportNode node, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ContinuationExport", ResoniteBridge.ResoniteBridgeValueType.Type), node, index);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public ImpulseExport(ImpulseExportNode node, System.Int32 index)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseExport", ResoniteBridge.ResoniteBridgeValueType.Type), node, index);
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

		public ImpulseExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseExport()
		{
		}
	}
	public class ImpulseExportNode : Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ImpulseExportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseExportNode()
		{
		}
	}
	public class DataImportNode : Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public DataImportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DataImportNode()
		{
		}
	}
	public abstract class Global : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public NodeRuntime Runtime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		public abstract Type ValueType { get; }

		public abstract System.Int32 ListenerCount { get; }

		public abstract void AddMatchingTypeToList(GlobalRefList list);

		public abstract void UpdateToInitialValue<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		public abstract void ResetValueToDefault<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		public Global(NodeRuntime runtime, System.Int32 index, System.String name)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Global", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, index, name);
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

		public Global(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Global()
		{
		}
	}
	public class Global<T> : Global, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<GlobalRef<T>> _listeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_listeners"), typeof(List<GlobalRef<T>>)) is List<GlobalRef<T>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GlobalRef<T>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public override System.Int32 ListenerCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListenerCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public Global(NodeRuntime runtime, System.Int32 index, System.String name)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Global", ResoniteBridge.ResoniteBridgeValueType.Type), runtime, index, name);
		}

		public void ValueChanged<C>(T value, C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ValueChanged", value, context);
		}

		public override void UpdateToInitialValue<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateToInitialValue", context);
		}

		public override void ResetValueToDefault<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetValueToDefault", context);
		}

		public void RegisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", listener);
		}

		public void UnregisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterListener", listener);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public override void AddMatchingTypeToList(GlobalRefList list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMatchingTypeToList", list);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isAsync", value);
			}
		}

		public ImpulseImport(IOperation target, System.Boolean isAsync)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseImport", ResoniteBridge.ResoniteBridgeValueType.Type), target, isAsync);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public ImpulseMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public GlobalRefListMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefListMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public GlobalRefMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}
	}
	public class ImpulseListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(ImpulseType)) is ImpulseType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseType");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public ImpulseListMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseListMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TypeConstraint"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClassConstraint"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClassConstraint", value);
			}
		}

		public InputListMetadata(System.Int32 index, FieldInfo field, System.Object defaultValue)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InputListMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field, defaultValue);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InputType", value);
			}
		}

		public InputMetadata(System.Int32 index, FieldInfo field, DataClass dataClass, System.Object defaultValue)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InputMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field, dataClass, defaultValue);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsConditional"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsConditional", value);
			}
		}

		public bool? IsListeningToChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListeningToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListeningToChanges", value);
			}
		}

		public PropertyInfo IsListeningToChangesEval
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListeningToChangesEval"), typeof(PropertyInfo)) is PropertyInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PropertyInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CrossRuntime"), typeof(CrossRuntimeInputAttribute)) is CrossRuntimeInputAttribute __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CrossRuntimeInputAttribute");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPotentiallyListeningToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public InputMetadataBase(System.Int32 index, FieldInfo field, System.Object defaultValue)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InputMetadataBase", ResoniteBridge.ResoniteBridgeValueType.Type), index, field, defaultValue);
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

		public InputMetadataBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public InputMetadataBase()
		{
		}
	}
	public class NodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Dictionary<string, InputMetadata> _inputsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputsByName"), typeof(Dictionary<string, InputMetadata>)) is Dictionary<string, InputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, InputMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputsByName", value);
			}
		}

		public Dictionary<string, OutputMetadata> _outputsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputsByName"), typeof(Dictionary<string, OutputMetadata>)) is Dictionary<string, OutputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, OutputMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputsByName", value);
			}
		}

		public Dictionary<string, InputListMetadata> _inputListsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_inputListsByName"), typeof(Dictionary<string, InputListMetadata>)) is Dictionary<string, InputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, InputListMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_inputListsByName", value);
			}
		}

		public Dictionary<string, OutputListMetadata> _outputListsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_outputListsByName"), typeof(Dictionary<string, OutputListMetadata>)) is Dictionary<string, OutputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, OutputListMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_outputListsByName", value);
			}
		}

		public Dictionary<string, ImpulseMetadata> _impulsesByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulsesByName"), typeof(Dictionary<string, ImpulseMetadata>)) is Dictionary<string, ImpulseMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, ImpulseMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulsesByName", value);
			}
		}

		public Dictionary<string, OperationMetadata> _actionsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actionsByName"), typeof(Dictionary<string, OperationMetadata>)) is Dictionary<string, OperationMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, OperationMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actionsByName", value);
			}
		}

		public Dictionary<string, ImpulseListMetadata> _impulseListsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_impulseListsByName"), typeof(Dictionary<string, ImpulseListMetadata>)) is Dictionary<string, ImpulseListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, ImpulseListMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_impulseListsByName", value);
			}
		}

		public Dictionary<string, OperationListMetadata> _actionListsByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_actionListsByName"), typeof(Dictionary<string, OperationListMetadata>)) is Dictionary<string, OperationListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, OperationListMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_actionListsByName", value);
			}
		}

		public Dictionary<string, ReferenceMetadata> _referencesByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_referencesByName"), typeof(Dictionary<string, ReferenceMetadata>)) is Dictionary<string, ReferenceMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, ReferenceMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPassthrough", value);
			}
		}

		public System.Boolean IsPotentiallyListeningToChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPotentiallyListeningToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPotentiallyListeningToChanges", value);
			}
		}

		public System.Int32 FixedInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedReferenceCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 FixedGlobalRefCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DynamicGlobalRefCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public List<InputMetadata> FixedInputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputs"), typeof(List<InputMetadata>)) is List<InputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputs"), typeof(List<OutputMetadata>)) is List<OutputMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulses"), typeof(List<ImpulseMetadata>)) is List<ImpulseMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ImpulseMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperations"), typeof(List<OperationMetadata>)) is List<OperationMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OperationMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferences"), typeof(List<ReferenceMetadata>)) is List<ReferenceMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ReferenceMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefMetadata>)) is List<GlobalRefMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GlobalRefMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputs"), typeof(List<InputListMetadata>)) is List<InputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InputListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputs"), typeof(List<OutputListMetadata>)) is List<OutputListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OutputListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulses"), typeof(List<ImpulseListMetadata>)) is List<ImpulseListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ImpulseListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperations"), typeof(List<OperationListMetadata>)) is List<OperationListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OperationListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListMetadata>)) is List<GlobalRefListMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GlobalRefListMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicInputs"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean HasDynamicOutputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicOutputs"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean HasDynamicImpulses
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicImpulses"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean HasDynamicActions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicActions"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean HasDynamicGlobalRefs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasDynamicGlobalRefs"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Int32 FixedArgumentCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedArgumentCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedArgumentCount", value);
			}
		}

		public System.Int32 FixedContinuationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedContinuationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedContinuationCount", value);
			}
		}

		public System.Int32 FixedCallCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedCallCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedCallCount", value);
			}
		}

		public System.Int32 FixedAsyncCallCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedAsyncCallCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedAsyncCallCount", value);
			}
		}

		public System.Int32 FixedSyncOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedSyncOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedSyncOperationCount", value);
			}
		}

		public System.Int32 FixedAsyncOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedAsyncOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FixedAsyncOperationCount", value);
			}
		}

		public T GetElementByName<T>(System.String name, List<T> list, ref Dictionary<string, T> dict) where T : class, IElementMetadata
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetElementByName", name, list, dict), typeof(T));
		}

		public void ComputeMetadata()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeMetadata");
		}

		public InputMetadata GetInputByName(System.String name)
		{
			return (InputMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputByName", name), typeof(InputMetadata));
		}

		public OutputMetadata GetOutputByName(System.String name)
		{
			return (OutputMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputByName", name), typeof(OutputMetadata));
		}

		public ImpulseMetadata GetImpulseByName(System.String name)
		{
			return (ImpulseMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseByName", name), typeof(ImpulseMetadata));
		}

		public OperationMetadata GetOperationByName(System.String name)
		{
			return (OperationMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationByName", name), typeof(OperationMetadata));
		}

		public InputListMetadata GetInputListByName(System.String name)
		{
			return (InputListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListByName", name), typeof(InputListMetadata));
		}

		public OutputListMetadata GetOutputListByName(System.String name)
		{
			return (OutputListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListByName", name), typeof(OutputListMetadata));
		}

		public ImpulseListMetadata GetImpulseListByName(System.String name)
		{
			return (ImpulseListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListByName", name), typeof(ImpulseListMetadata));
		}

		public OperationListMetadata GetOperationListByName(System.String name)
		{
			return (OperationListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListByName", name), typeof(OperationListMetadata));
		}

		public ReferenceMetadata GetReferenceByName(System.String name)
		{
			return (ReferenceMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceByName", name), typeof(ReferenceMetadata));
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

		public NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeMetadata()
		{
		}
	}
	public static class NodeMetadataHelper
	{
		public static ResoniteBridge.ResoniteBridgeValue _metadataCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, NodeMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache", value);
			}
		}

		public static NodeMetadata GetMetadata(Type type)
		{
			return (NodeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadata", type), typeof(NodeMetadata));
		}
	}
	public class OperationListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportsSync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportsSync", value);
			}
		}

		public System.Boolean SupportsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute)) is PossibleContinuationsAttribute __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PossibleContinuationsAttribute");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PossibleContinuations", value);
			}
		}

		public OperationListMetadata(System.Int32 index, FieldInfo field, System.Boolean supportsSync, System.Boolean supportsAsync)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationListMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field, supportsSync, supportsAsync);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelf"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute)) is PossibleContinuationsAttribute __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PossibleContinuationsAttribute");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PossibleContinuations", value);
			}
		}

		public OperationMetadata(System.Int32 index, System.Boolean isAsync, Type nodeClass)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, isAsync, nodeClass);
		}

		public OperationMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OperationMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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

		public OperationMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OperationMetadata()
		{
		}
	}
	public class OutputListMetadata : OutputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type TypeConstraint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TypeConstraint"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClassConstraint"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataClassConstraint", value);
			}
		}

		public OutputListMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputListMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsImplicit", value);
			}
		}

		public OutputMetadata(System.Int32 index, Type ownerType, Type outputType, DataClass dataClass)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, ownerType, outputType, dataClass);
		}

		public OutputMetadata(System.Int32 index, FieldInfo field, DataClass dataClass)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field, dataClass);
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

		public OutputMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OutputMetadata()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeTypeEval"), typeof(PropertyInfo)) is PropertyInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PropertyInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeType"), typeof(OutputChangeSource)) is OutputChangeSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputChangeSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeType", value);
			}
		}

		public OutputMetadataBase(System.Int32 index, Type ownerType, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OutputMetadataBase", ResoniteBridge.ResoniteBridgeValueType.Type), index, ownerType, field);
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

		public OutputMetadataBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OutputMetadataBase()
		{
		}
	}
	public class ReferenceMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferenceType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Field"), typeof(FieldInfo)) is FieldInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to FieldInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Field", value);
			}
		}

		public ReferenceMetadata(System.Int32 index, FieldInfo field)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReferenceMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), index, field);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
			}
		}

		NodeMetadata Metadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata)) is NodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeMetadata");
				}
			}
		}

		System.Int32 IndexInGroup
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		System.Int32 AllocationIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.String Overload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.Boolean IsPassthrough
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Boolean ListensToChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.Int32 InputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 OutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 ArgumentCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 ImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 OperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedReferenceCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 FixedGlobalRefCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 DynamicInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 DynamicOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 DynamicImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		System.Int32 DynamicOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IndexInGroup"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IndexInGroup", value);
			}
		}

		public System.Int32 AllocationIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllocationIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllocationIndex", value);
			}
		}

		public virtual NodeMetadata Metadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(NodeMetadata)) is NodeMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeMetadata");
				}
			}
		}

		public virtual System.String Overload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overload"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public virtual System.Boolean IsPassthrough
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPassthrough"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public virtual System.Boolean ListensToChanges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListensToChanges"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public virtual System.Int32 InputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 OutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 ImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 ArgumentCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ArgumentCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 OperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedReferenceCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedReferenceCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 FixedGlobalRefCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FixedGlobalRefCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 DynamicInputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicInputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 DynamicOutputCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOutputCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 DynamicImpulseCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicImpulseCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public virtual System.Int32 DynamicOperationCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DynamicOperationCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputSource", index), typeof(IOutput));
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
			return (IInputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputList", index), typeof(IInputList));
		}

		public virtual System.String GetInputListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListName", index), typeof(System.String));
		}

		public virtual Type GetInputListTypeConstraint(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputListTypeConstraint", index), typeof(Type));
		}

		public virtual IOutput GetOutput(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutput", index), typeof(IOutput));
		}

		public virtual System.String GetOutputName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputName", index), typeof(System.String));
		}

		public virtual IOutputList GetOutputList(System.Int32 index)
		{
			return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputList", index), typeof(IOutputList));
		}

		public virtual System.String GetOutputListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputListName", index), typeof(System.String));
		}

		public virtual System.String GetInputName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputName", index), typeof(System.String));
		}

		public virtual Type GetInputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputType", index), typeof(Type));
		}

		public virtual DataClass GetInputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputTypeClass", index), typeof(DataClass));
		}

		public virtual System.Object GetInputDefaultValue(System.Int32 index)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputDefaultValue", index), typeof(System.Object));
		}

		public virtual System.Boolean IsInputConditional(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputConditional", index), typeof(System.Boolean));
		}

		public virtual System.Boolean IsInputListeningToChanges(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInputListeningToChanges", index), typeof(System.Boolean));
		}

		public virtual CrossRuntimeInputAttribute GetInputCrossRuntime(System.Int32 index)
		{
			return (CrossRuntimeInputAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInputCrossRuntime", index), typeof(CrossRuntimeInputAttribute));
		}

		public virtual Type GetOutputType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputType", index), typeof(Type));
		}

		public virtual DataClass GetOutputTypeClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputTypeClass", index), typeof(DataClass));
		}

		public virtual System.Boolean IsOutputImplicit(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOutputImplicit", index), typeof(System.Boolean));
		}

		public virtual OutputChangeSource GetOutputChangeType(System.Int32 index)
		{
			return (OutputChangeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOutputChangeType", index), typeof(OutputChangeSource));
		}

		public virtual IOperation GetImpulseTarget(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public virtual System.String GetImpulseName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseName", index), typeof(System.String));
		}

		public virtual void SetImpulseTarget(System.Int32 index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetImpulseTarget", index, target);
		}

		public virtual IImpulseList GetImpulseList(System.Int32 index)
		{
			return (IImpulseList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseList", index), typeof(IImpulseList));
		}

		public virtual System.String GetImpulseListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseListName", index), typeof(System.String));
		}

		public virtual IOperation GetOperation(System.Int32 index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperation", index), typeof(IOperation));
		}

		public virtual System.String GetOperationName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationName", index), typeof(System.String));
		}

		public virtual System.Boolean IsOperationAsync(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsOperationAsync", index), typeof(System.Boolean));
		}

		public virtual System.Boolean CanOperationContinueTo(System.Int32 index, System.String impulseName)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationContinueTo", index, impulseName), typeof(System.Boolean));
		}

		public virtual System.Boolean CanOperationListContinueTo(System.Int32 index, System.String impulseName)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanOperationListContinueTo", index, impulseName), typeof(System.Boolean));
		}

		public virtual IOperationList GetOperationList(System.Int32 index)
		{
			return (IOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationList", index), typeof(IOperationList));
		}

		public virtual System.String GetOperationListName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOperationListName", index), typeof(System.String));
		}

		public virtual ImpulseType GetImpulseType(System.Int32 index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public virtual System.Boolean OperationHasSingleContinuation(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSingleContinuation", index), typeof(System.Boolean));
		}

		public virtual System.Boolean OperationHasSyncAsyncTransition(System.Int32 index)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OperationHasSyncAsyncTransition", index), typeof(System.Boolean));
		}

		public virtual System.String GetReferenceName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceName", index), typeof(System.String));
		}

		public virtual Type GetReferenceType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceType", index), typeof(Type));
		}

		public virtual INode GetReferenceTarget(System.Int32 index)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferenceTarget", index), typeof(INode));
		}

		public virtual void SetReferenceTarget(System.Int32 index, INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReferenceTarget", index, node);
		}

		public virtual System.Boolean TrySetReferenceTarget(System.Int32 index, INode node)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetReferenceTarget", index, node), typeof(System.Boolean));
		}

		public virtual System.String GetGlobalRefName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefName", index), typeof(System.String));
		}

		public virtual Type GetGlobalRefValueType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefValueType", index), typeof(Type));
		}

		public virtual Global GetGlobalRefBinding(System.Int32 index)
		{
			return (Global)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalRefBinding", index), typeof(Global));
		}

		public virtual void SetGlobalRefBinding(System.Int32 index, Global binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetGlobalRefBinding", index, binding);
		}

		public virtual System.Boolean TrySetGlobalRefBinding(System.Int32 index, Global binding)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrySetGlobalRefBinding", index, binding), typeof(System.Boolean));
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
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public Node(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Node()
		{
		}
	}
	public abstract class NodeRuntime : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DataImportNode importNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "importNode"), typeof(DataImportNode)) is DataImportNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataImportNode");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "importNode", value);
			}
		}

		public ImpulseExportNode exportNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "exportNode"), typeof(ImpulseExportNode)) is ImpulseExportNode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ImpulseExportNode");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "exportNode", value);
			}
		}

		public List<IOutput> dataExports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataExports"), typeof(List<IOutput>)) is List<IOutput> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IOutput>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataExports", value);
			}
		}

		public OutputList dataImports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dataImports"), typeof(OutputList)) is OutputList __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputList");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dataImports", value);
			}
		}

		public List<ImpulseImport> impulseImports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseImports"), typeof(List<ImpulseImport>)) is List<ImpulseImport> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ImpulseImport>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseImports", value);
			}
		}

		public List<ImpulseExport> impulseExports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseExports"), typeof(List<ImpulseExport>)) is List<ImpulseExport> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ImpulseExport>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseExports", value);
			}
		}

		public List<Global> globals
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "globals"), typeof(List<Global>)) is List<Global> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Global>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataImportsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 DataExportsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataExportsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IEnumerable<IOutput> DataExports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataExports"), typeof(IEnumerable<IOutput>)) is IEnumerable<IOutput> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<IOutput>");
				}
			}
		}

		public System.Int32 ImpulseImportsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseImportsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 ImpulseExportCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ImpulseExportCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Int32 GlobalsCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalsCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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

		public abstract System.Int32 ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, System.Boolean cache) where T : INode;

		public void Init(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Init", group);
		}

		public abstract Type GetCompatibleNodeType(Type type);

		public ValueOutput<T> AddValueImport<T>() where T : struct
		{
			return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddValueImport"), typeof(ValueOutput<T>));
		}

		public ObjectOutput<T> AddObjectImport<T>()
		{
			return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddObjectImport"), typeof(ObjectOutput<T>));
		}

		public ValueOutput<T> GetValueImport<T>(System.Int32 index) where T : struct
		{
			return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueImport", index), typeof(ValueOutput<T>));
		}

		public ObjectOutput<T> GetObjectImport<T>(System.Int32 index)
		{
			return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetObjectImport", index), typeof(ObjectOutput<T>));
		}

		public IOutput GetImport(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImport", index), typeof(IOutput));
		}

		public Type GetImportType(System.Int32 index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportType", index), typeof(Type));
		}

		public DataClass GetImportDataClass(System.Int32 index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImportDataClass", index), typeof(DataClass));
		}

		public IOutput GetValueExport(System.Int32 index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetValueExport", index), typeof(IOutput));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsImpulseImportAsync", index), typeof(System.Boolean));
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
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulseImport", index), typeof(IOperation));
		}

		public ContinuationExport AddContinuationExport()
		{
			return (ContinuationExport)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContinuationExport"), typeof(ContinuationExport));
		}

		public CallExport AddCallExport()
		{
			return (CallExport)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddCallExport"), typeof(CallExport));
		}

		public AsyncCallExport AddAsyncCallExport()
		{
			return (AsyncCallExport)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddAsyncCallExport"), typeof(AsyncCallExport));
		}

		public void ClearImpulseExports()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearImpulseExports");
		}

		public Global<T> AddGlobal<T>(System.String name)
		{
			return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGlobal", name), typeof(Global<T>));
		}

		public Global GetGlobal(System.Int32 index)
		{
			return (Global)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobal", index), typeof(Global));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "CanTargetRuntime", ownerRuntime, inputCrossRuntime, source), typeof(System.Boolean));
		}

		public static System.Boolean CanTargetRuntime(NodeRuntime ownerRuntime, CrossRuntimeInputAttribute inputCrossRuntime, NodeRuntime targetRuntime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "CanTargetRuntime", ownerRuntime, inputCrossRuntime, targetRuntime), typeof(System.Boolean));
		}

		public static System.Boolean AreSameRuntimeTypes(NodeRuntime ownerRuntime, IOutput source)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "AreSameRuntimeTypes", ownerRuntime, source), typeof(System.Boolean));
		}

		public static System.Boolean AreSameRuntimeTypes(NodeRuntime ownerRuntime, NodeRuntime targetRuntime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "AreSameRuntimeTypes", ownerRuntime, targetRuntime), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public NodeRuntime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeRuntime()
		{
		}
	}
	public abstract class NodeRuntime<N> : NodeRuntime, ResoniteBridge.ResoniteBridgeValueHolder where N : class, INode
	{
		public List<N> nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodes"), typeof(List<N>)) is List<N> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<N>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nodes", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue cachedNodeTypes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedNodeTypes"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, IList>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cachedNodeTypes", value);
			}
		}

		public List<IExecutionNestedNode> cachedNestedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedNestedNodes"), typeof(List<IExecutionNestedNode>)) is List<IExecutionNestedNode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IExecutionNestedNode>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IEnumerable<N> Nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(IEnumerable<N>)) is IEnumerable<N> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<N>");
				}
			}
		}

		public static System.Boolean IsCompatibleNodeType(Type type)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeRuntime", ResoniteBridge.ResoniteBridgeValueType.Type), "IsCompatibleNodeType", type), typeof(System.Boolean));
		}

		public N GetNode(System.Int32 index)
		{
			return (N)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNode", index), typeof(N));
		}

		public override INode GetNodeGeneric(System.Int32 index)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodeGeneric", index), typeof(INode));
		}

		public void AddNode(N node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode", node);
		}

		public T AddNode<T>() where T : N, new()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode"), typeof(T));
		}

		public override INode AddNode(Type type)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddNode", type), typeof(INode));
		}

		public override System.Boolean RemoveNode(INode node)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveNode", node), typeof(System.Boolean));
		}

		public override System.Int32 RemoveNodes(Predicate<INode> predicate)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveNodes", predicate), typeof(System.Int32));
		}

		public override void SortNodesByIndex()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SortNodesByIndex");
		}

		public override Type GetCompatibleNodeType(Type type)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type));
		}

		public ConnectionResult ConnectInput(INode node, System.String inputName, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectInput", node, inputName, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult));
		}

		public ConnectionResult ConnectListInput(INode node, System.String listName, System.Int32 inputIndex, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectListInput", node, listName, inputIndex, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult));
		}

		public ConnectionResult ConnectListInput(INode node, System.String listName, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectListInput", node, listName, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult));
		}

		public ConnectionResult ConnectInput(INode node, ElementRef input, IOutput source, System.Boolean overload = true, System.Boolean explicitCast = false, System.Boolean allowMergingGroups = false)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectInput", node, input, source, overload, explicitCast, allowMergingGroups), typeof(ConnectionResult));
		}

		public ConnectionResult SetReference(INode node, System.String referenceName, INode target, System.Boolean overload = true)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", node, referenceName, target, overload), typeof(ConnectionResult));
		}

		public ConnectionResult SetReference(INode node, System.Int32 referenceIndex, INode target, System.Boolean overload = true, System.Boolean allowMergingGroups = false)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", node, referenceIndex, target, overload, allowMergingGroups), typeof(ConnectionResult));
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
			return (IEnumerable<IExecutionNestedNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedNodes", cache), typeof(IEnumerable<IExecutionNestedNode>));
		}

		public IEnumerable<T> GetNodesOfType<T>(System.Boolean cache) where T : INode
		{
			return (IEnumerable<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodesOfType", cache), typeof(IEnumerable<T>));
		}

		public override System.Int32 ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, System.Boolean cache)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachNode", action, context, cache), typeof(System.Int32));
		}

		public void ClearQueryCaches()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearQueryCaches");
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

		public NodeRuntime(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(NodeContextPath)) is NodeContextPath __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeContextPath");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "element"), typeof(E)) is E __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to E");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "element", value);
			}
		}

		public ElementPath(E element)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ElementPath", ResoniteBridge.ResoniteBridgeValueType.Type), element);
		}

		public ElementPath(E element, NodeContextPath path)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ElementPath", ResoniteBridge.ResoniteBridgeValueType.Type), element, path);
		}

		public ElementPath(E element, params INode[] path)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ElementPath", ResoniteBridge.ResoniteBridgeValueType.Type), element, path);
		}

		public ElementPath<E> Nest(INode node)
		{
			return (ElementPath<E>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Nest", node), typeof(ElementPath<E>));
		}

		public System.Boolean Equals(ElementPath<E> other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.Int32 CompareTo(ElementPath<E> other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
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

		public ElementPath(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ElementPath()
		{
		}
	}
	public struct NodeContextPath : IEquatable<NodeContextPath>, IComparable<NodeContextPath>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode[] path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(INode[])) is INode[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode[]");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PathLength"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public INode this[System.Int32 index] => GetNode(index);

		public INode GetNode(System.Int32 index)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNode", index), typeof(INode));
		}

		public NodeContextPath(INode[] path)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeContextPath", ResoniteBridge.ResoniteBridgeValueType.Type), path);
		}

		public NodeContextPath Nest(INode node)
		{
			return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Nest", node), typeof(NodeContextPath));
		}

		public System.Boolean Equals(NodeContextPath other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.Int32 CompareTo(NodeContextPath other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public System.Int32 FindSharedRootLength(NodeContextPath other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindSharedRootLength", other), typeof(System.Int32));
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
		public HashSet<NodeGroup> enteredGroups
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "enteredGroups"), typeof(HashSet<NodeGroup>)) is HashSet<NodeGroup> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<NodeGroup>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "enteredGroups", value);
			}
		}

		public List<INestedNode> nodePath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nodePath"), typeof(List<INestedNode>)) is List<INestedNode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<INestedNode>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentDepth"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public INestedNode GetNodePath(System.Int32 index)
		{
			return (INestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodePath", index), typeof(INestedNode));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryEnterNestedNode", node), typeof(System.Boolean));
		}

		public void ExitNestedNode(INestedNode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitNestedNode", node);
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

		public NodeEnumerationContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeEnumerationContext()
		{
		}
	}
	public class NodeQueryAcceleration : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Dictionary<INode, HashSet<INode>> evaluatingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "evaluatingNodes"), typeof(Dictionary<INode, HashSet<INode>>)) is Dictionary<INode, HashSet<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, HashSet<INode>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "evaluatingNodes", value);
			}
		}

		public Dictionary<INode, HashSet<INode>> impulsingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulsingNodes"), typeof(Dictionary<INode, HashSet<INode>>)) is Dictionary<INode, HashSet<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, HashSet<INode>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulsingNodes", value);
			}
		}

		public Dictionary<INode, HashSet<INode>> referencingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "referencingNodes"), typeof(Dictionary<INode, HashSet<INode>>)) is Dictionary<INode, HashSet<INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, HashSet<INode>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		public NodeQueryAcceleration(NodeGroup group)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeQueryAcceleration", ResoniteBridge.ResoniteBridgeValueType.Type), group);
		}

		public void Build()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Build");
		}

		public IEnumerable<INode> GetEvaluatingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEvaluatingNodes", node), typeof(IEnumerable<INode>));
		}

		public IEnumerable<INode> GetImpulsingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetImpulsingNodes", node), typeof(IEnumerable<INode>));
		}

		public IEnumerable<INode> GetReferencingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetReferencingNodes", node), typeof(IEnumerable<INode>));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkEvaluationInputs"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkEvaluationInputs", value);
			}
		}

		public System.Boolean WalkImpulseTargets
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkImpulseTargets"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkImpulseTargets", value);
			}
		}

		public System.Boolean WalkReferences
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkReferences"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkReferences", value);
			}
		}

		public System.Boolean WalkEvaluatingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkEvaluatingNodes"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkEvaluatingNodes", value);
			}
		}

		public System.Boolean WalkImpulsingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkImpulsingNodes"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkImpulsingNodes", value);
			}
		}

		public System.Boolean WalkReferencingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkReferencingNodes"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WalkReferencingNodes", value);
			}
		}

		public System.Boolean SkipWalkingBack
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SkipWalkingBack"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SkipWalkingBack", value);
			}
		}

		public NodeRuntime OnlyRuntime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "OnlyRuntime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NodeFilter"), typeof(Predicate<INode>)) is Predicate<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Predicate<INode>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WalkedNodes"), typeof(Dictionary<INode, bool>)) is Dictionary<INode, bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, bool>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LoopNodes"), typeof(HashSet<INode>)) is HashSet<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<INode>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Acceleration"), typeof(NodeQueryAcceleration)) is NodeQueryAcceleration __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeQueryAcceleration");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiresAcceleration"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean DetectedAnyLoops
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DetectedAnyLoops"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public void EnsureAllocatedStructures(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureAllocatedStructures", node);
		}

		public System.Boolean BeginWalkingNode(INode node)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginWalkingNode", node), typeof(System.Boolean));
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

		public NodeQueryContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeQueryContext()
		{
		}
	}
	public static class NodeQueryHelper
	{
		public static IEnumerable<INode> EnumerateNodes(this INode node, NodeQueryContext context, INode sourceNode = null, SourceElement sourceElementType = SourceElement.NONE, System.Object sourceElement = null)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeQueryHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateNodes", node, context, sourceNode, sourceElementType, sourceElement), typeof(IEnumerable<INode>));
		}
	}
	public static class EvaluationValidator
	{
		public static System.Boolean IsSourceValid(this INode node, System.Int32 inputIndex, IOutput source)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSourceValid", node, inputIndex, source), typeof(System.Boolean));
		}

		public static System.Boolean CanEvaluate(this INode node, System.Int32 inputIndex, IOutput source)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanEvaluate", node, inputIndex, source), typeof(System.Boolean));
		}

		public static System.Boolean AreEvaluationConnectionsValid(this NodeGroup group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", group), typeof(System.Boolean));
		}

		public static System.Boolean AreEvaluationConnectionsValid(this NodeRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", runtime), typeof(System.Boolean));
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isAsync", value);
			}
		}

		public System.Boolean isContinuation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "isContinuation"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "isContinuation", value);
			}
		}

		public HashSet<IOperation> allWalkedOperations
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "allWalkedOperations"), typeof(HashSet<IOperation>)) is HashSet<IOperation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IOperation>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "continuationLoopOperations"), typeof(HashSet<IOperation>)) is HashSet<IOperation> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<IOperation>");
				}
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

		public ImpulseFlowContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseFlowContext()
		{
		}
	}
	public struct ImpulseSource : IEquatable<ImpulseSource>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode node
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "node"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "impulseIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "impulseIndex", value);
			}
		}

		public ImpulseSource(INode node, System.Int32 impulseIndex)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseSource", ResoniteBridge.ResoniteBridgeValueType.Type), node, impulseIndex);
		}

		public System.Boolean Equals(ImpulseSource other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ImpulseValidationError(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SourceNode"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation TargetOperation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TargetOperation"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public InvalidImpulseTargetError(INode sourceNode, System.Int32 impulseIndex, IOperation targetOperation, System.String reason)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InvalidImpulseTargetError", ResoniteBridge.ResoniteBridgeValueType.Type), sourceNode, impulseIndex, targetOperation, reason);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Node"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public System.Boolean IsAsync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "IsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "IsAsync", value);
			}
		}

		public override System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public ImpulseLoopError(INode node, System.Int32 impulseIndex, System.Boolean isAsync)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseLoopError", ResoniteBridge.ResoniteBridgeValueType.Type), node, impulseIndex, isAsync);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ReferencingNode"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ImpulseIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation Target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Target"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContextIsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ContextIsAsync", value);
			}
		}

		public System.Boolean ContextIsContinuation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ContextIsContinuation"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ContextIsContinuation", value);
			}
		}

		public System.String Reason
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Reason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Origin"), typeof(IOperation)) is IOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IOperation");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginIsAsync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginIsAsync", value);
			}
		}

		public System.Boolean OriginIsContinuation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginIsContinuation"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginIsContinuation", value);
			}
		}

		public override System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public void SetOriginInfo(IOperation origin, System.Boolean originIsAsync, System.Boolean originIsContinuation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetOriginInfo", origin, originIsAsync, originIsContinuation);
		}

		public ImpulseFlowError(INode referencingNode, System.Int32 impulseIndex, IOperation target, ImpulseFlowContext context, System.String reason)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseFlowError", ResoniteBridge.ResoniteBridgeValueType.Type), referencingNode, impulseIndex, target, context, reason);
		}

		public ImpulseFlowError(INode referencingNode, System.Int32 impulseIndex, IOperation target, System.Boolean contextIsAsync, System.Boolean contextIsContinuation, System.String reason)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseFlowError", ResoniteBridge.ResoniteBridgeValueType.Type), referencingNode, impulseIndex, target, contextIsAsync, contextIsContinuation, reason);
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

		public ImpulseFlowError(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ImpulseFlowError()
		{
		}
	}
	public static class ImpulseValidator
	{
		public static InvalidImpulseTargetError ValidateTarget(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			return (InvalidImpulseTargetError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateTarget", node, impulseIndex, target), typeof(InvalidImpulseTargetError));
		}

		public static System.Boolean CanImpulse(this INode node, System.String impulseName, IOperation target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseName, target), typeof(System.Boolean));
		}

		public static System.Boolean CanImpulse(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseIndex, target), typeof(System.Boolean));
		}

		public static System.Boolean WouldFormContinuationLoop(this INode node, System.Int32 impulseIndex, IOperation target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "WouldFormContinuationLoop", node, impulseIndex, target), typeof(System.Boolean));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesForImpulse(this INode node, System.Int32 impulseIndex)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesForImpulse", node, impulseIndex), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeNodeOperationInvokeSources(this INode node)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeNodeOperationInvokeSources", node), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromImpulseImport(NodeRuntime runtime, System.Int32 importIndex, INode target)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromImpulseImport", runtime, importIndex, target), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromSource(this INode node, INode target)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromSource", node, target), typeof(OperationInvokeSource));
		}

		public static System.Boolean ReachesAsyncOperation(this IOperation operation)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ReachesAsyncOperation", operation), typeof(System.Boolean));
		}

		public static ImpulseValidationError ValidateImpulseFlow(this IOperation targettedOperation, ImpulseFlowContext context)
		{
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseFlow", targettedOperation, context), typeof(ImpulseValidationError));
		}

		public static void GetSourcesUnreachableFromImports(this NodeRuntime runtime, HashSet<ImpulseSource> sources)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "GetSourcesUnreachableFromImports", runtime, sources);
		}

		public static void RemoveReachableSources(IOperation operation, HashSet<ImpulseSource> sources, HashSet<Node> walkedNodes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "RemoveReachableSources", operation, sources, walkedNodes);
		}

		public static ImpulseValidationError ValidateImpulseConnections(this NodeGroup group)
		{
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", group), typeof(ImpulseValidationError));
		}

		public static ImpulseValidationError ValidateImpulseConnections(this NodeRuntime runtime)
		{
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", runtime), typeof(ImpulseValidationError));
		}
	}
	public static class NodeHelper
	{
		public static System.Int32 FindLinearOutputIndex(this IOutput output)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOutputIndex", output), typeof(System.Int32));
		}

		public static System.Int32 FindLinearOperationIndex(this IOperation operation)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOperationIndex", operation), typeof(System.Int32));
		}

		public static IOutput RemapOutput(this IOutput output, Dictionary<INode, INode> remappedNodes = null)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RemapOutput", output, remappedNodes), typeof(IOutput));
		}

		public static IOperation RemapTarget(this IOperation target, Dictionary<INode, INode> remappedNodes = null)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RemapTarget", target, remappedNodes), typeof(IOperation));
		}
	}
	public class ObjectCastAttribute : Attribute
	{
	}
	public abstract class Output<T> : IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node _node
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_node"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public abstract DataClass OutputDataClass { get; }

		public Output(Node owner)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "Output", ResoniteBridge.ResoniteBridgeValueType.Type), owner);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public Output(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Output()
		{
		}
	}
	public abstract class OutputNode<T> : Node, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerNode"), typeof(Node)) is Node __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Node");
				}
			}
		}

		public System.Int32 OutputIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public abstract DataClass OutputDataClass { get; }

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

		public OutputNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDataClass"), typeof(DataClass)) is DataClass __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DataClass");
				}
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

		public ValueOutputNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "conversion"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "targetNode"), typeof(INode)) is INode __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "targetInput"), typeof(ElementRef)) is ElementRef __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ElementRef");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "targetInput", value);
			}
		}

		public InsertedConversion(INode conversion, INode targetNode, ElementRef targetInput)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InsertedConversion", ResoniteBridge.ResoniteBridgeValueType.Type), conversion, targetNode, targetInput);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "connected"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "connected", value);
			}
		}

		public System.String failReason
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "failReason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "conversions"), typeof(List<InsertedConversion>)) is List<InsertedConversion> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InsertedConversion>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "overload"), typeof(NodeOverloadContext)) is NodeOverloadContext __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeOverloadContext");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Success"), typeof(ConnectionResult)) is ConnectionResult __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConnectionResult");
				}
			}
		}

		public ConnectionResult(System.Boolean connected, System.String failReason = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), connected, failReason);
		}

		public ConnectionResult(InsertedConversion conversion)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), conversion);
		}

		public ConnectionResult(List<InsertedConversion> conversions)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), conversions);
		}

		public ConnectionResult(NodeOverloadContext overload, List<InsertedConversion> conversions)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), overload, conversions);
		}

		public ConnectionResult(NodeOverloadContext overload, InsertedConversion conversion = default(InsertedConversion))
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), overload, conversion);
		}

		public ConnectionResult Combine(ConnectionResult other)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Combine", other), typeof(ConnectionResult));
		}

		public ConnectionResult AddInsertedConversion(InsertedConversion conversion)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddInsertedConversion", conversion), typeof(ConnectionResult));
		}

		public static ConnectionResult Failed(System.String reason)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Failed", reason), typeof(ConnectionResult));
		}

		public static ConnectionResult Conversion(InsertedConversion conversion)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Conversion", conversion), typeof(ConnectionResult));
		}

		public static ConnectionResult Conversions(List<InsertedConversion> conversions)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Conversions", conversions), typeof(ConnectionResult));
		}

		public static ConnectionResult Overload(NodeOverloadContext overload)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ConnectionResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Overload", overload), typeof(ConnectionResult));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ConnectionResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ConnectionResult()
		{
		}
	}
	public interface ICast : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean IsImplicit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsImplicit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		Type InputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		Type OutputType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}
	}
	public struct InputType : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type type
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "runtime", value);
			}
		}

		public InputType(Type type, NodeRuntime runtime)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "InputType", ResoniteBridge.ResoniteBridgeValueType.Type), type, runtime);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "fixedInputs"), typeof(Dictionary<string, InputType>)) is Dictionary<string, InputType> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, InputType>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "listInputs"), typeof(Dictionary<string, List<InputType>>)) is Dictionary<string, List<InputType>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, List<InputType>>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "fixedReferences"), typeof(Dictionary<string, InputType>)) is Dictionary<string, InputType> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, InputType>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "fixedReferences", value);
			}
		}

		public System.Boolean SetInput(ElementRef input, System.String name, Type type, NodeRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInput", input, name, type, runtime), typeof(System.Boolean));
		}

		public System.Boolean SetInput(System.String name, Type type, NodeRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetInput", name, type, runtime), typeof(System.Boolean));
		}

		public System.Boolean SetReference(System.String name, Type type, NodeRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetReference", name, type, runtime), typeof(System.Boolean));
		}

		public System.Boolean SetListInput(System.String name, System.Int32 index, Type type, NodeRuntime runtime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetListInput", name, index, type, runtime), typeof(System.Boolean));
		}

		public static NodeConnections GetFromNode(INode node)
		{
			return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeConnections", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFromNode", node), typeof(NodeConnections));
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

		public NodeConnections(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeConnections()
		{
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeOverloadAttribute : Attribute
	{
		public System.String OverloadName { get; private set; }

		public NodeOverloadAttribute(System.String overloadName)
		{
			OverloadName = overloadName;
		}
	}
	public class NodeOverloadCollection : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<Type> _overloads
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_overloads"), typeof(List<Type>)) is List<Type> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Type>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public IEnumerable<Type> Overloads
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overloads"), typeof(IEnumerable<Type>)) is IEnumerable<Type> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<Type>");
				}
			}
		}

		public void Add(Type type)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", type);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public NodeOverloadCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NodeOverloadCollection()
		{
		}
	}
	public struct OverloadResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String failReason
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "failReason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSuccess"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public static OverloadResult Success
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Success"), typeof(OverloadResult)) is OverloadResult __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OverloadResult");
				}
			}
		}

		public OverloadResult(System.String errorReason)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), errorReason);
		}

		public static OverloadResult Fail(System.String reason)
		{
			return (OverloadResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Fail", reason), typeof(OverloadResult));
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
		public Dictionary<INode, Type> overloads
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "overloads"), typeof(Dictionary<INode, Type>)) is Dictionary<INode, Type> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, Type>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "overloads", value);
			}
		}

		public Dictionary<INode, INode> swappedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "swappedNodes"), typeof(Dictionary<INode, INode>)) is Dictionary<INode, INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<INode, INode>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "swappedNodes", value);
			}
		}

		public HashSet<INode> affectedEvaluatingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "affectedEvaluatingNodes"), typeof(HashSet<INode>)) is HashSet<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<INode>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "affectedEvaluatingNodes", value);
			}
		}

		public HashSet<INode> affectedImpulsingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "affectedImpulsingNodes"), typeof(HashSet<INode>)) is HashSet<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<INode>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "affectedImpulsingNodes", value);
			}
		}

		public List<InsertedConversion> insertedCasts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "insertedCasts"), typeof(List<InsertedConversion>)) is List<InsertedConversion> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InsertedConversion>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "insertedCasts", value);
			}
		}

		public NodeQueryAcceleration query
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "query"), typeof(NodeQueryAcceleration)) is NodeQueryAcceleration __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeQueryAcceleration");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(NodeGroup)) is NodeGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverloadedAnyNodes"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public IEnumerable<KeyValuePair<INode, Type>> Overloads
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Overloads"), typeof(IEnumerable<KeyValuePair<INode, Type>>)) is IEnumerable<KeyValuePair<INode, Type>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<KeyValuePair<INode, Type>>");
				}
			}
		}

		public IEnumerable<KeyValuePair<INode, INode>> SwappedNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SwappedNodes"), typeof(IEnumerable<KeyValuePair<INode, INode>>)) is IEnumerable<KeyValuePair<INode, INode>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<KeyValuePair<INode, INode>>");
				}
			}
		}

		public IEnumerable<INode> AffectedEvaluatingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedEvaluatingNodes"), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
				}
			}
		}

		public IEnumerable<INode> AffectedImpulsingNodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedImpulsingNodes"), typeof(IEnumerable<INode>)) is IEnumerable<INode> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<INode>");
				}
			}
		}

		public List<InsertedConversion> InsertedCasts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InsertedCasts"), typeof(List<InsertedConversion>)) is List<InsertedConversion> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<InsertedConversion>");
				}
			}
		}

		public INode GetSwappedNode(INode sourceNode)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSwappedNode", sourceNode), typeof(INode));
		}

		public NodeOverloadContext(NodeGroup group, NodeRuntime runtime)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadContext", ResoniteBridge.ResoniteBridgeValueType.Type), group, runtime);
		}

		public OverloadResult TryOverload(INode node, NodeConnections connections, System.Boolean allowMergingGroups = false)
		{
			return (OverloadResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryOverload", node, connections, allowMergingGroups), typeof(OverloadResult));
		}

		public void SwapNodes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SwapNodes");
		}

		public NodeConnections GetModifiedConnections(INode node)
		{
			return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetModifiedConnections", node), typeof(NodeConnections));
		}

		public Type GetOverloadedType(INode node)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOverloadedType", node), typeof(Type));
		}

		public Type GetOverloadedType(IOutput source)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOverloadedType", source), typeof(Type));
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
		public static Dictionary<string, NodeOverloadCollection> overloads
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "overloads"), typeof(Dictionary<string, NodeOverloadCollection>)) is Dictionary<string, NodeOverloadCollection> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, NodeOverloadCollection>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "overloads", value);
			}
		}

		public static CancellationTokenSource generationCancellation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationCancellation"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationCancellation", value);
			}
		}

		public static System.Object generationLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock", value);
			}
		}

		static NodeOverloadHelper()
		{
		}

		public static NodeOverloadCollection GetOverloads(System.String name)
		{
			return (NodeOverloadCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOverloads", name), typeof(NodeOverloadCollection));
		}

		public static Dictionary<string, NodeOverloadCollection> SearchOverloads()
		{
			return (Dictionary<string, NodeOverloadCollection>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SearchOverloads"), typeof(Dictionary<string, NodeOverloadCollection>));
		}

		public static void CurrentDomain_AssemblyLoad(System.Object sender, AssemblyLoadEventArgs args)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CurrentDomain_AssemblyLoad", sender, args);
		}

		public static Type FindOverload(System.String name, Type currentType, OverloadSearchContext context)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindOverload", name, currentType, context), typeof(Type));
		}

		public static int? RankOverload(Type overload, OverloadSearchContext context)
		{
			return (int?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankOverload", overload, context), typeof(System.Int32));
		}

		public static IOutput SkipImplicitCasts(this IOutput source)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SkipImplicitCasts", source), typeof(IOutput));
		}

		public static IOutput GetActualConnectedSource(this IOutput source)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetActualConnectedSource", source), typeof(IOutput));
		}

		public static Type GetActualConnectedType(this IOutput source)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetActualConnectedType", source), typeof(Type));
		}
	}
	public class OverloadSearchContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static Type[] emptyTypes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadSearchContext", ResoniteBridge.ResoniteBridgeValueType.Type), "emptyTypes"), typeof(Type[])) is Type[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadSearchContext", ResoniteBridge.ResoniteBridgeValueType.Type), "emptyTypes", value);
			}
		}

		public Dictionary<Type, Type> genericParameters
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "genericParameters"), typeof(Dictionary<Type, Type>)) is Dictionary<Type, Type> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, Type>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Connections"), typeof(NodeConnections)) is NodeConnections __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeConnections");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Runtime"), typeof(NodeRuntime)) is NodeRuntime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NodeRuntime");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllowMergingGroups"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllowMergingGroups", value);
			}
		}

		public OverloadSearchContext(NodeConnections connections, NodeRuntime runtime, System.Boolean allowMergingGroups)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadSearchContext", ResoniteBridge.ResoniteBridgeValueType.Type), connections, runtime, allowMergingGroups);
		}

		public Type GetCompatibleNodeType(Type type)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCompatibleNodeType", type), typeof(Type));
		}

		public void BeginNewOverload()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginNewOverload");
		}

		public System.Boolean CanTargetRuntime(InputMetadataBase input, NodeRuntime targetRuntime)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanTargetRuntime", input, targetRuntime), typeof(System.Boolean));
		}

		public System.Boolean CanAccomodate(Type source, Type target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccomodate", source, target), typeof(System.Boolean));
		}

		public System.Boolean TryMatchGenericArguments(Type source, Type target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryMatchGenericArguments", source, target), typeof(System.Boolean));
		}

		public System.Boolean UpdateGenericParameter(Type generic, Type newType)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGenericParameter", generic, newType), typeof(System.Boolean));
		}

		public Type InstanceType(Type type, Type currentType)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InstanceType", type, currentType), typeof(Type));
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
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankType", type), typeof(System.Int32));
		}

		public static System.Int32 GetPrimitiveRanking(this Type type)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveRanking", type), typeof(System.Int32));
		}

		public static System.Boolean CanImplicitlyConvertTo(Type from, Type to)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImplicitlyConvertTo", from, to), typeof(System.Boolean));
		}

		public static System.Boolean CanExplicitlyConvertTo(Type from, Type to)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanExplicitlyConvertTo", from, to), typeof(System.Boolean));
		}

		public static Type CombineTypes(Type a, Type b)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CombineTypes", a, b), typeof(Type));
		}

		public static Type AccomodatePrimitive(PrimitiveClass primitiveClass, Type target)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AccomodatePrimitive", primitiveClass, target), typeof(Type));
		}

		public static System.Int32 GetPrimitiveClassRank(this Type type)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassRank", type), typeof(System.Int32));
		}

		public static System.Int32 GetPrimitiveClassMaxRank(this PrimitiveClass primitiveClass)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassMaxRank", primitiveClass), typeof(System.Int32));
		}

		public static Type GetPrimitive(this PrimitiveClass primitiveClass, System.Int32 rank)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitive", primitiveClass, rank), typeof(Type));
		}

		public static System.Boolean CanAccomodate(this PrimitiveClass source, PrimitiveClass target)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanAccomodate", source, target), typeof(System.Boolean));
		}

		public static PrimitiveClass ClassifyPrimitive(this Type type)
		{
			return (PrimitiveClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ClassifyPrimitive", type), typeof(PrimitiveClass));
		}
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class PossibleContinuationsAttribute : Attribute
	{
		private HashSet<string> continuations = new HashSet<string>();

		public IEnumerable<string> Continuations => continuations;

		public System.Boolean CanContinueTo(System.String str)
		{
			return continuations.Contains(str);
		}

		public PossibleContinuationsAttribute(params string[] continuations)
		{
			foreach (string item in continuations)
			{
				this.continuations.Add(item);
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
		public System.String Name { get; private set; }

		public NodeCategoryAttribute(System.String name)
		{
			Name = name;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeNameAttribute : Attribute
	{
		public System.String Name { get; private set; }

		public System.Boolean SimpleView { get; private set; }

		public NodeNameAttribute(System.String name, System.Boolean simpleView = false)
		{
			Name = name;
			SimpleView = simpleView;
		}
	}
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class OldElementNameAttribute : Attribute
	{
		public System.String OldName { get; private set; }

		public OldElementNameAttribute(System.String oldName)
		{
			OldName = oldName;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class OldNodeNameAttribute : Attribute
	{
		public System.String OldName { get; private set; }

		public OldNodeNameAttribute(System.String oldName)
		{
			OldName = oldName;
		}
	}
	public class OrderedSet<T> : IEnumerable<T>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<T> list
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "list"), typeof(List<T>)) is List<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "list", value);
			}
		}

		public HashSet<T> set
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "set"), typeof(HashSet<T>)) is HashSet<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public System.Boolean Add(T item)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", item), typeof(System.Boolean));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clear");
		}

		public List<T>.Enumerator GetEnumerator()
		{
			return (List<T>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(List<T>.Enumerator));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IEnumerable.GetEnumerator"), typeof(IEnumerator));
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return (IEnumerator<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IEnumerable<T>.GetEnumerator"), typeof(IEnumerator<T>));
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

		public OrderedSet(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public OrderedSet()
		{
		}
	}
	public static class ReflectionHelper
	{
		public static ResoniteBridge.ResoniteBridgeValue cachedTypes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes", value);
			}
		}

		public static System.Boolean IsUnmanaged(this Type type)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsUnmanaged", type), typeof(System.Boolean));
		}

		public static System.Boolean IsNullable(this Type type)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsNullable", type), typeof(System.Boolean));
		}

		public static System.String GetNiceTypeName(this Type type, System.String open = "<", System.String close = ">")
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetNiceTypeName", type, open, close), typeof(System.String));
		}

		public static MethodInfo FindMethodInHierarchy(this Type type, System.String name, BindingFlags flags)
		{
			return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindMethodInHierarchy", type, name, flags), typeof(MethodInfo));
		}

		public static IEnumerable<FieldInfo> EnumerateAllInstanceFields(this Type type, Predicate<Type> filter = null)
		{
			return (IEnumerable<FieldInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllInstanceFields", type, filter), typeof(IEnumerable<FieldInfo>));
		}

		public static IEnumerable<FieldInfo> EnumerateAllInstanceFields(this Type type, BindingFlags bindingFlags, Predicate<Type> filter = null)
		{
			return (IEnumerable<FieldInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllInstanceFields", type, bindingFlags, filter), typeof(IEnumerable<FieldInfo>));
		}

		public static IEnumerable<PropertyInfo> EnumerateAllProperties(this Type type, BindingFlags bindingFlags, Predicate<Type> filter = null)
		{
			return (IEnumerable<PropertyInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateAllProperties", type, bindingFlags, filter), typeof(IEnumerable<PropertyInfo>));
		}
	}
	public class ValueCastAttribute : Attribute
	{
		public Type From { get; private set; }

		public Type To { get; private set; }

		public ValueCastAttribute(Type from, Type to)
		{
			From = from;
			To = to;
		}
	}
}
public class ProtoFluxCore_ProcessedByFody : ResoniteBridge.ResoniteBridgeValueHolder
{
	public System.String FodyVersion
	{
		get
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "FodyVersion"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "FodyVersion", value);
		}
	}

	public System.String NodeWeaver
	{
		get
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "NodeWeaver"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "NodeWeaver", value);
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

	public ProtoFluxCore_ProcessedByFody(ResoniteBridge.ResoniteBridgeValue value)
	{
		__backing = value;
	}

	public ProtoFluxCore_ProcessedByFody()
	{
	}
}
