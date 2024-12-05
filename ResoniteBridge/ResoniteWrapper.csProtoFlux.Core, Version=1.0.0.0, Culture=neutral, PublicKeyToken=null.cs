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


//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
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
			public int valueBottom
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "valueBottom"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "valueBottom", value);
				}
			}

			public int objectBottom
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "objectBottom"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "objectBottom", value);
				}
			}

			public ushort pinCount
			{
				get
				{
					return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "pinCount"), typeof(ushort));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "pinCount", value);
				}
			}

			public ushort sourceFrame
			{
				get
				{
					return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "sourceFrame"), typeof(ushort));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "sourceFrame", value);
				}
			}

			public int valueStoreOffset
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "valueStoreOffset"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "valueStoreOffset", value);
				}
			}

			public int objectStoreOffset
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "objectStoreOffset"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "objectStoreOffset", value);
				}
			}

			public IExecutionRuntime runtime
			{
				get
				{
					return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "runtime"), typeof(IExecutionRuntime));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "runtime", value);
				}
			}

			public IExecutionNestedNode nestedNode
			{
				get
				{
					return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "nestedNode"), typeof(IExecutionNestedNode));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "nestedNode", value);
				}
			}

			public ScopePoint sharedScope
			{
				get
				{
					return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "sharedScope"), typeof(ScopePoint));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "sharedScope", value);
				}
			}

			public override string ToString()
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public StackFrame(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public struct StackLayout : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public short[] layout
			{
				get
				{
					return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "layout"), typeof(short[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "layout", value);
				}
			}

			public short valueSize
			{
				get
				{
					return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "valueSize"), typeof(short));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "valueSize", value);
				}
			}

			public short objectSize
			{
				get
				{
					return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "objectSize"), typeof(short));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "objectSize", value);
				}
			}

			public StackLayout(short[] layout, short valueSize, short objectSize)
			{
				this.layout = layout;
				this.valueSize = valueSize;
				this.objectSize = objectSize;
			}

			public override string ToString()
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public StackLayout(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private Stack<ExecutionImpulseExportHandler> _impulseExportHandlers
		{
			get
			{
				return (Stack<ExecutionImpulseExportHandler>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_impulseExportHandlers"), typeof(Stack<ExecutionImpulseExportHandler>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_impulseExportHandlers", value);
			}
		}

		private Stack<ExecutionAsyncImpulseExportHandler> _asyncImpulseExportHandlers
		{
			get
			{
				return (Stack<ExecutionAsyncImpulseExportHandler>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_asyncImpulseExportHandlers"), typeof(Stack<ExecutionAsyncImpulseExportHandler>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_asyncImpulseExportHandlers", value);
			}
		}

		private StackFrame[] _frames
		{
			get
			{
				return (StackFrame[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_frames"), typeof(StackFrame[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_frames", value);
			}
		}

		private ushort _allocatedFrames
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_allocatedFrames"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_allocatedFrames", value);
			}
		}

		private ushort _currentFrameIndex
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_currentFrameIndex"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_currentFrameIndex", value);
			}
		}

		internal StackLayout stackLayout
		{
			get
			{
				return (StackLayout)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stackLayout"), typeof(StackLayout));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stackLayout", value);
			}
		}

		private HashSet<IExecutionRuntime> onceEnteredRuntimes
		{
			get
			{
				return (HashSet<IExecutionRuntime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "onceEnteredRuntimes"), typeof(HashSet<IExecutionRuntime>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "onceEnteredRuntimes", value);
			}
		}

		public ValueStack Values
		{
			get
			{
				return (ValueStack)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Values"), typeof(ValueStack));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Values", value);
			}
		}

		public ObjectStack Objects
		{
			get
			{
				return (ObjectStack)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Objects"), typeof(ObjectStack));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Objects", value);
			}
		}

		public int ImpulseExport
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ImpulseExport"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ImpulseExport", value);
			}
		}

		public int CurrentFramePins => _frames[_currentFrameIndex].pinCount;

		public int CurrentValueStoreOffset => _frames[_currentFrameIndex].valueStoreOffset;

		public int CurrentObjectStoreOffset => _frames[_currentFrameIndex].objectStoreOffset;

		public SharedExecutionScope SharedScope
		{
			get
			{
				return (SharedExecutionScope)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SharedScope"), typeof(SharedExecutionScope));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SharedScope", value);
			}
		}

		public bool IsEmpty => _allocatedFrames == 0;

		public ushort CurrentFrameIndex => _currentFrameIndex;

		public bool CurrentFrameIsTop => _currentFrameIndex == _allocatedFrames - 1;

		public int MaxDepth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MaxDepth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MaxDepth", value);
			}
		}

		public int AutoYieldSafetyDepth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AutoYieldSafetyDepth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AutoYieldSafetyDepth", value);
			}
		}

		public int CurrentDepth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CurrentDepth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CurrentDepth", value);
			}
		}

		public int InheritedDepth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InheritedDepth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InheritedDepth", value);
			}
		}

		public bool AbortExecution
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AbortExecution"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AbortExecution", value);
			}
		}

		public IExecutionRuntime CurrentRuntime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CurrentRuntime"), typeof(IExecutionRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CurrentRuntime", value);
			}
		}

		public IExecutionNestedNode CurrentNestedNode
		{
			get
			{
				return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CurrentNestedNode"), typeof(IExecutionNestedNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CurrentNestedNode", value);
			}
		}

		public ScopePoint CurrentScope
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CurrentScope"), typeof(ScopePoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CurrentScope", value);
			}
		}

		public IExecutionRuntime GetFrameRuntime(int frameIndex)
		{
			return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFrameRuntime", frameIndex), typeof(IExecutionRuntime));
		}

		public IExecutionNestedNode GetFrameNestedNode(int frameIndex)
		{
			return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFrameNestedNode", frameIndex), typeof(IExecutionNestedNode));
		}

		public int GetFrameSource(int frameIndex)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFrameSource", frameIndex), typeof(int));
		}

		public ExecutionContext()
			: this(new SharedExecutionScope())
		{
		}

		public ExecutionContext(SharedExecutionScope scope)
		{
			Values = new ValueStack();
			Objects = new ObjectStack();
			SharedScope = scope;
		}

		public string StackLayoutDebug()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StackLayoutDebug"), typeof(string));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PopInputs()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PopInputs");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(int index) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadValue", index), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(int index)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadObject", index), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValue<T>(int index, int offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadValue", index, offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObject<T>(int index, int offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadObject", index, offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadValueDirect<T>(int offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadValueDirect", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadObjectDirect<T>(int offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadObjectDirect", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredValue<T>(int offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadStoredValue", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteStoredValue<T>(int offset, T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteStoredValue", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T AccessStoredValue<T>(int offset)
		{
			return (ref T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessStoredValue", offset), typeof(ref T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T ReadStoredObject<T>(int offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadStoredObject", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteStoredObject<T>(int offset, T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteStoredObject", offset, value);
		}

		public void AllocateFrame(IExecutionRuntime runtime, IExecutionNestedNode nestedNode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllocateFrame", runtime, nestedNode);
		}

		private ref StackFrame CreateStackFrame(IExecutionRuntime runtime, IExecutionNestedNode nestedNode)
		{
			return (ref StackFrame)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CreateStackFrame", runtime, nestedNode), typeof(ref StackFrame));
		}

		public void DeallocateFrame()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeallocateFrame");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PinFrame()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PinFrame");
		}

		public ushort ReturnToPreviousFrame()
		{
			return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReturnToPreviousFrame"), typeof(ushort));
		}

		public void StepIntoFrame(ushort index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StepIntoFrame", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool UnpinFrame()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UnpinFrame"), typeof(bool));
		}

		public Span<StackFrame> GetRawStackFrame()
		{
			return (Span<StackFrame>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawStackFrame"), typeof(Span<StackFrame>));
		}

		internal void PopToLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PopToLocal", mapping);
		}

		internal void PushFromLocal(in LocalNodeData mapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PushFromLocal", mapping);
		}

		internal void PushImpulseExportHandler(ExecutionImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PushImpulseExportHandler", handler);
		}

		internal void PushAsyncImpulseExportHandler(ExecutionAsyncImpulseExportHandler handler)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PushAsyncImpulseExportHandler", handler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PopImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PopImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PopAsyncImpulseExportHandler()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PopAsyncImpulseExportHandler");
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void InvokeImpulseExport(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InvokeImpulseExport", index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Task InvokeAsyncImpulseExport(int index)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InvokeAsyncImpulseExport", index), typeof(Task));
		}

		public void CaptureContextFrom(ExecutionContext source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CaptureContextFrom", source);
		}

		public NodeContextPath CaptureContextPath()
		{
			return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CaptureContextPath"), typeof(NodeContextPath));
		}

		public NodeContextPath CaptureContextPath(out IExecutionRuntime rootRuntime)
		{
			return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CaptureContextPath", rootRuntime), typeof(NodeContextPath));
		}

		public bool IsCurrentPath(IExecutionRuntime rootRuntime, NodeContextPath path)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsCurrentPath", rootRuntime, path), typeof(bool));
		}

		public int ComputeStackDepth()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeStackDepth"), typeof(int));
		}

		internal void EnterExecution()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnterExecution");
		}

		internal async Task TryEnterAsyncExecution()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryEnterAsyncExecution"), typeof(Task));
		}

		internal void ExitExecution()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExitExecution");
		}

		public void InheritExecutionDepthFrom(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InheritExecutionDepthFrom", context);
		}

		public void SubtractInheritedDepth()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SubtractInheritedDepth");
		}

		public void ClearExecutionDepth()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearExecutionDepth");
		}

		private void WalkStackAndCopyTo(ushort frameIndex, ExecutionContext target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WalkStackAndCopyTo", frameIndex, target);
		}

		public bool TryEnterRuntimeOnce(IExecutionRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryEnterRuntimeOnce", runtime), typeof(bool));
		}

		public void ExitRuntimeOnce(IExecutionRuntime runtime)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExitRuntimeOnce", runtime);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class ExecutionContextExtensions
	{
		private static NotImplementedException Exception()
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

		public static T ReadValue<T>(this IInputList list, int index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T));
		}

		public static T ReadObject<T>(this IInputList list, int index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T));
		}

		public static T ReadValue<T>(this ValueArgumentList<T> list, int index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context), typeof(T));
		}

		public static T ReadObject<T>(this ObjectArgumentList<T> list, int index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this int index, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this int index, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", index, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValueDirect<T>(this int offset, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValueDirect", offset, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObjectDirect<T>(this int offset, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObjectDirect", offset, context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this IInputList list, int index, ExecutionContext context, int listOffset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this IInputList list, int index, ExecutionContext context, int listOffset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadObject", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadValue<T>(this ValueArgumentList<T> list, int index, ExecutionContext context, int listOffset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadValue", list, index, context, listOffset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ReadObject<T>(this ObjectArgumentList<T> list, int index, ExecutionContext context, int listOffset)
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
		public static T Evaluate<T>(this ValueInputList<T> input, int index, ExecutionContext context, T defaultValue = default(T)) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionContextExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "Evaluate", input, index, context, defaultValue), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Evaluate<T>(this ObjectInputList<T> input, int index, ExecutionContext context, T defaultValue = default(T))
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
		private ExecutionEventDispatcher<C> _eventDispatcher;

		public ExecutionUpdateDispatcher<C> Updates { get; set; }

		public ExecutionChangesDispatcher<C> Changes { get; set; }

		public int ScheduledEventCount => _eventDispatcher?.ScheduledEventCount ?? 0;

		public void GetEventDispatcher(out ExecutionEventDispatcher<C> eventDispatcher)
		{
			eventDispatcher = _eventDispatcher;
		}

		public void DispatchEvents(ExecutionRuntime<C> runtime)
		{
			_eventDispatcher.DispatchEvents(runtime, (C)this);
		}

		public void SetEventDispatcher(ExecutionEventDispatcher<C> eventDispatcher)
		{
			_eventDispatcher = eventDispatcher;
		}

		public ExtendedExecutionContext()
			: this(new SharedExecutionScope(), new ExecutionUpdateDispatcher<C>(), new ExecutionEventDispatcher<C>(), (ExecutionChangesDispatcher<C>)null)
		{
		}

		public ExtendedExecutionContext(SharedExecutionScope sharedExecutionScope, ExecutionUpdateDispatcher<C> updateDispatcher, ExecutionEventDispatcher<C> eventDispatcher, ExecutionChangesDispatcher<C> changesDispatcher)
			: base(sharedExecutionScope)
		{
			Updates = updateDispatcher;
			Changes = changesDispatcher;
			_eventDispatcher = eventDispatcher;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
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
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExtendedExecutionContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IGlobalValue : ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool IsWriteable { get; }

		Type ValueType { get; }

		object BoxedValue { get; }
	}
	public interface IGlobalValue<T> : IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		T Value { get; }

		bool SetValue(T newValue);
	}
	public class ObjectStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private object[] stack
		{
			get
			{
				return (object[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stack"), typeof(object[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stack", value);
			}
		}

		public int Top
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Top"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Top", value);
			}
		}

		public int Bottom
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bottom"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bottom", value);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetBottomPosition(int bottom, int offset)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBottomPosition", bottom, offset), typeof(int));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetPosition(int offset)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPosition", offset), typeof(int));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Push<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Push", obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Pop<T>()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pop"), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(int offset)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write<T>(int offset, T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", offset, obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Pop(int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pop", size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Store(int size, int offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Store", size, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Load(int size, int offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Load", size, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Allocate(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Allocate", count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear(int position, int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear", position, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void DeAllocate(int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeAllocate", size);
		}

		public void CopyBottomTo(int sourceBottom, int targetBottom, int count, ObjectStack target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyBottomTo", sourceBottom, targetBottom, count, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ScopeKey : IEquatable<ScopeKey>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IExecutionRuntime runtime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "runtime"), typeof(IExecutionRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "runtime", value);
			}
		}

		public IExecutionNestedNode nestedNode
		{
			get
			{
				return (IExecutionNestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "nestedNode"), typeof(IExecutionNestedNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "nestedNode", value);
			}
		}

		public ScopeKey(IExecutionRuntime runtime, IExecutionNestedNode nestedNode = null)
		{
			this.runtime = runtime;
			this.nestedNode = nestedNode;
		}

		public bool Equals(ScopeKey other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(ScopeKey left, ScopeKey right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(ScopeKey left, ScopeKey right)
		{
			return !(left == right);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ScopeKey(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct NodeStoreOffsets : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int valuesOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "valuesOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "valuesOffset", value);
			}
		}

		public int objectsOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "objectsOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "objectsOffset", value);
			}
		}

		public NodeStoreOffsets(int valuesOffset, int objectsOffset)
		{
			this.valuesOffset = valuesOffset;
			this.objectsOffset = objectsOffset;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeStoreOffsets(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ScopePoint : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IGlobalValue[] _mappedGlobals
		{
			get
			{
				return (IGlobalValue[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_mappedGlobals"), typeof(IGlobalValue[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_mappedGlobals", value);
			}
		}

		private ConcurrentDictionary<ScopeKey, ScopePoint> nestedScopes
		{
			get
			{
				return (ConcurrentDictionary<ScopeKey, ScopePoint>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "nestedScopes"), typeof(ConcurrentDictionary<ScopeKey, ScopePoint>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "nestedScopes", value);
			}
		}

		private Dictionary<IExecutionNode, NodeStoreOffsets> explicitNodeMap
		{
			get
			{
				return (Dictionary<IExecutionNode, NodeStoreOffsets>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "explicitNodeMap"), typeof(Dictionary<IExecutionNode, NodeStoreOffsets>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "explicitNodeMap", value);
			}
		}

		public ScopePoint Parent
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Parent"), typeof(ScopePoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Parent", value);
			}
		}

		public ScopeKey Key
		{
			get
			{
				return (ScopeKey)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Key"), typeof(ScopeKey));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Key", value);
			}
		}

		public IExecutionRuntime Runtime => Key.runtime;

		public IExecutionNestedNode NestedNode => Key.nestedNode;

		public bool IsRoot => Parent == null;

		public int Depth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Depth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Depth", value);
			}
		}

		public int NestedScopeCount => nestedScopes?.Count ?? 0;

		public int ValuesStoreOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValuesStoreOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValuesStoreOffset", value);
			}
		}

		public int ObjectsStoreOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ObjectsStoreOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ObjectsStoreOffset", value);
			}
		}

		public bool AreGlobalsMapped => _mappedGlobals != null;

		public ScopePoint()
		{
		}

		public ScopePoint(ScopePoint parent, in ScopeKey key, int valuesStoreOffset, int objectsStoreOffset)
		{
			Parent = parent;
			Key = key;
			ValuesStoreOffset = valuesStoreOffset;
			ObjectsStoreOffset = objectsStoreOffset;
			Depth = parent.Depth + 1;
		}

		public ScopePoint GetNestedScope(in ScopeKey key)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNestedScope", key), typeof(ScopePoint));
		}

		public ScopePoint AllocateScope(ScopeKey key, int valuesStoreOffset, int objectsStoreOffset)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllocateScope", key, valuesStoreOffset, objectsStoreOffset), typeof(ScopePoint));
		}

		internal void MapGlobals(IGlobalValue[] globals)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapGlobals", globals);
		}

		public T ReadGlobal<T>(GlobalRef<T> globalRef)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadGlobal", globalRef), typeof(T));
		}

		public T ReadGlobal<T>(int index)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadGlobal", index), typeof(T));
		}

		public bool WriteGlobal<T>(GlobalRef<T> globalRef, T value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteGlobal", globalRef, value), typeof(bool));
		}

		public bool WriteGlobal<T>(int index, T value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteGlobal", index, value), typeof(bool));
		}

		public bool HasAnyStoreDataInHierarchy()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasAnyStoreDataInHierarchy"), typeof(bool));
		}

		public void ComputeTotalStoreSizes(out int valueStoreSize, out int objectStoreSize)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeTotalStoreSizes", valueStoreSize, objectStoreSize);
		}

		internal void CaptureExplicitNodeMap()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CaptureExplicitNodeMap");
		}

		internal NodeStoreOffsets? GetStoredOffset(IExecutionNode node)
		{
			return (NodeStoreOffsets?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetStoredOffset", node), typeof(NodeStoreOffsets?));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ScopePoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class SharedExecutionScope : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private object _lock
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_lock"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_lock", value);
			}
		}

		private int _allocatedValueStoreSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_allocatedValueStoreSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_allocatedValueStoreSize", value);
			}
		}

		private int _allocatedObjectStoreSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_allocatedObjectStoreSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_allocatedObjectStoreSize", value);
			}
		}

		public ScopePoint RootScope
		{
			get
			{
				return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RootScope"), typeof(ScopePoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RootScope", value);
			}
		}

		public byte[] ValuesStore
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValuesStore"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValuesStore", value);
			}
		}

		public object[] ObjectsStore
		{
			get
			{
				return (object[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ObjectsStore"), typeof(object[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ObjectsStore", value);
			}
		}

		public SharedExecutionScope()
		{
			RootScope = new ScopePoint();
			ValuesStore = new byte[16384];
			ObjectsStore = new object[4096];
		}

		public ScopePoint GetNestedScopeOrAllocate(ScopePoint sourcePoint, IExecutionRuntime runtime, IExecutionNestedNode node)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNestedScopeOrAllocate", sourcePoint, runtime, node), typeof(ScopePoint));
		}

		public bool HasAnyStoreDataInHierarchy()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasAnyStoreDataInHierarchy"), typeof(bool));
		}

		public void ComputeTotalStoreSizes(out int valueStoreSize, out int objectStoreSize)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeTotalStoreSizes", valueStoreSize, objectStoreSize);
		}

		public ScopePoint CaptureScopeAndSwap(ref byte[] valuesStore, ref object[] objectsStore)
		{
			return (ScopePoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CaptureScopeAndSwap", valuesStore, objectsStore), typeof(ScopePoint));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SharedExecutionScope(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class SimpleGlobalValue<T> : IGlobalValue<T>, IGlobalValue, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		public object BoxedValue => Value;

		public bool IsWriteable => true;

		public Type ValueType => typeof(T);

		public bool SetValue(T newValue)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValue", newValue), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SimpleGlobalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueStack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private byte[] stack
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stack"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stack", value);
			}
		}

		public int Top
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Top"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Top", value);
			}
		}

		public int Bottom
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bottom"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bottom", value);
			}
		}

		public int Size => stack.Length;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetBottomPosition(int bottom, int offset)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBottomPosition", bottom, offset), typeof(int));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Push<T>(T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Push", value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetPosition<T>(int offset) where T : struct
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPosition", offset), typeof(int));
		}

		public unsafe T Pop<T>() where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pop"), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read<T>(int offset) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", offset), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write<T>(int offset, T value) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", offset, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T Access<T>(int offset) where T : struct
		{
			return (ref T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Access", offset), typeof(ref T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Pop(int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pop", size);
		}

		public void Store(int size, int offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Store", size, offset);
		}

		public void Load(int size, int offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Load", size, offset);
		}

		public void Allocate(int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Allocate", size);
		}

		public void Clear(int position, int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear", position, size);
		}

		public void DeAllocate(int size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeAllocate", size);
		}

		public void CopyBottomTo(int sourceBottom, int targetBottom, int size, ValueStack target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyBottomTo", sourceBottom, targetBottom, size, target);
		}

		public Span<byte> GetRawStack()
		{
			return (Span<byte>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawStack"), typeof(Span<byte>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueStack(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IVariable<C, T> : INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		T Read(C context);

		bool Write(T value, C context);
	}
	public struct ObjectLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal int offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ValueLocal<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		internal int offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "offset", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context);
		}

		public ref T Access(ExecutionContext context)
		{
			return (ref T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Access", context), typeof(ref T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ExecutionChangesDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private NodeGroup group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "group", value);
			}
		}

		private SortedSet<ElementPath<INode>> changedNodes
		{
			get
			{
				return (SortedSet<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "changedNodes"), typeof(SortedSet<ElementPath<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "changedNodes", value);
			}
		}

		private SortedSet<ElementPath<INode>> backBuffer
		{
			get
			{
				return (SortedSet<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "backBuffer"), typeof(SortedSet<ElementPath<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "backBuffer", value);
			}
		}

		public int CurrentChangedCount => changedNodes.Count;

		public bool IsEmpty => CurrentChangedCount == 0;

		public IEnumerable<ElementPath<INode>> CurrentChangedNodes => changedNodes;

		public event Action FirstChangeRegistered;

		public ExecutionChangesDispatcher(NodeGroup group)
		{
			this.group = group;
		}

		public void AllTrackedChanged()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllTrackedChanged");
		}

		public void MarkChanged(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkChanged", node);
		}

		public void MarkChanged(INode node, NodeContextPath path)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkChanged", node, path);
		}

		public void OutputChanged(ElementPath<IOutput> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OutputChanged", node);
		}

		public void ClearChanges()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearChanges");
		}

		public int DispatchChangeToAllListeners(ExecutionRuntime<C> runtime, C context)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DispatchChangeToAllListeners", runtime, context), typeof(int));
		}

		private int DispatchChangeToAllRecursively(ExecutionRuntime<C> runtime, C context)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DispatchChangeToAllRecursively", runtime, context), typeof(int));
		}

		public int DispatchChanges(ExecutionRuntime<C> runtime, C context)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DispatchChanges", runtime, context), typeof(int));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionChangesDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate void NodeEventHandler<in C>(C context, object eventData) where C : ExecutionContext;
	public class ExecutionEventDispatcher<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private struct Event : IEquatable<Event>, IComparable<Event>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public NodeContextPath path
			{
				get
				{
					return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "path"), typeof(NodeContextPath));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "path", value);
				}
			}

			public NodeEventHandler<C> handler
			{
				get
				{
					return (NodeEventHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "handler"), typeof(NodeEventHandler<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "handler", value);
				}
			}

			public object eventData
			{
				get
				{
					return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "eventData"), typeof(object));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "eventData", value);
				}
			}

			public Event(NodeContextPath path, NodeEventHandler<C> handler, object eventData)
			{
				this.path = path;
				this.handler = handler;
				this.eventData = eventData;
			}

			public int CompareTo(Event other)
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
			}

			public bool Equals(Event other)
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Event(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<Event> orderedEvents
		{
			get
			{
				return (List<Event>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "orderedEvents"), typeof(List<Event>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "orderedEvents", value);
			}
		}

		private List<Event> unorderedEvents
		{
			get
			{
				return (List<Event>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "unorderedEvents"), typeof(List<Event>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "unorderedEvents", value);
			}
		}

		public int ScheduledEventCount => ScheduledOrderedEventCount + ScheduledUnorderedEventCount;

		public int ScheduledOrderedEventCount => orderedEvents.Count;

		public int ScheduledUnorderedEventCount => unorderedEvents.Count;

		public bool IsEmpty => ScheduledEventCount == 0;

		public event Action FirstEventRegistered;

		public void ScheduleEvent(NodeContextPath path, NodeEventHandler<C> handler, object eventData, bool ordered = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ScheduleEvent", path, handler, eventData, ordered);
		}

		public void ScheduleEvent(NodeContextPath path, Action<C> handler, bool ordered = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ScheduleEvent", path, handler, ordered);
		}

		public void DispatchEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DispatchEvents", runtime, context);
		}

		public void ClearEvents()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearEvents");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionEventDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
					return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "path"), typeof(NodeContextPath));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "path", value);
				}
			}

			public IExecutionUpdateReceiver<C> receiver
			{
				get
				{
					return (IExecutionUpdateReceiver<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "receiver"), typeof(IExecutionUpdateReceiver<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "receiver", value);
				}
			}

			public UpdateNode(NodeContextPath path, IExecutionUpdateReceiver<C> receiver)
			{
				this.path = path;
				this.receiver = receiver;
			}

			public bool Equals(UpdateNode other)
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
			}

			public int CompareTo(UpdateNode other)
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
			}

			public override int GetHashCode()
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public UpdateNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private SortedDictionary<int, SortedSet<UpdateNode>> updateBuckets
		{
			get
			{
				return (SortedDictionary<int, SortedSet<UpdateNode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "updateBuckets"), typeof(SortedDictionary<int, SortedSet<UpdateNode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "updateBuckets", value);
			}
		}

		public bool IsEmpty => updateBuckets.Count == 0;

		public int UpdateBucketCount => updateBuckets.Count;

		public int TotalUpdateNodes => updateBuckets.Sum((KeyValuePair<int, SortedSet<UpdateNode>> b) => b.Value.Count);

		public event Action FirstNodeRegistered;

		public event Action BecameEmpty;

		public void RegisterNode(NodeContextPath path, IExecutionUpdateReceiver<C> node, int bucket)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RegisterNode", path, node, bucket);
		}

		public void UnregisterNode(NodeContextPath path, IExecutionUpdateReceiver<C> node, int bucket)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UnregisterNode", path, node, bucket);
		}

		public int UpdateAllBuckets(ExecutionRuntime<C> runtime, C context)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateAllBuckets", runtime, context), typeof(int));
		}

		public void UpdateBucket(int bucket, ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateBucket", bucket, runtime, context);
		}

		private int UpdateBucket(SortedSet<UpdateNode> list, ref NodeContextPath current, C context)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateBucket", list, current, context), typeof(int));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionUpdateDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
					return (IScopeEventListener<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Node"), typeof(IScopeEventListener<C>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Node", value);
				}
			}

			public bool NewlyAdded
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "NewlyAdded"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "NewlyAdded", value);
				}
			}

			public bool Exists
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Exists"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Exists", value);
				}
			}

			public ScopeNode(IScopeEventListener<C> node)
			{
				Node = node;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public ScopeNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>> registeredNodes
		{
			get
			{
				return (Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "registeredNodes"), typeof(Dictionary<NodeContextPath, Dictionary<IScopeEventListener<C>, ScopeNode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "registeredNodes", value);
			}
		}

		private bool _hasNewNodes
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_hasNewNodes"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_hasNewNodes", value);
			}
		}

		public void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateScopesAndSendRemoved", runtime, context);
		}

		private void UpdateScopesAndSendRemoved(ExecutionRuntime<C> runtime, C context, bool scanForNewNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateScopesAndSendRemoved", runtime, context, scanForNewNodes);
		}

		public void SendAllRemovedEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SendAllRemovedEvents", runtime, context);
		}

		public void SendAddedEvents(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SendAddedEvents", runtime, context);
		}

		private void ProcessScope(ExecutionRuntime<C> runtime, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessScope", runtime, context);
		}

		private Dictionary<IScopeEventListener<C>, ScopeNode> EnsureScopeDictionary(NodeContextPath path)
		{
			return (Dictionary<IScopeEventListener<C>, ScopeNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureScopeDictionary", path), typeof(Dictionary<IScopeEventListener<C>, ScopeNode>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ScopeAddRemoveDispatcher(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ExecutionAbortedException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IExecutionRuntime Runtime
		{
			get
			{
				return (IExecutionRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Runtime"), typeof(IExecutionRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Runtime", value);
			}
		}

		public IOperation InitialOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InitialOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InitialOperation", value);
			}
		}

		public IOperation NextOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "NextOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "NextOperation", value);
			}
		}

		public bool IsAsyncContext
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsAsyncContext"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsAsyncContext", value);
			}
		}

		public ExecutionAbortedException(IExecutionRuntime runtime, IOperation initialOperation, IOperation nextOperation, bool isAsync)
		{
			Runtime = runtime;
			InitialOperation = initialOperation;
			NextOperation = nextOperation;
			IsAsyncContext = isAsync;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionAbortedException(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class EvaluateSequence<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public EvaluationSequence<C> Sequence
		{
			get
			{
				return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Sequence"), typeof(EvaluationSequence<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Sequence", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public EvaluateSequence(EvaluationSequence<C> sequence)
		{
			Sequence = sequence;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public EvaluateSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal abstract class ExecutionControlNode<C> : IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int FixedValueStackSize
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public int FixedObjectStackSize
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public int InputCount
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public int OutputCount
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public int FixedInputCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedOutputCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int DynamicInputCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int DynamicOutputCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedImpulseCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedOperationCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int ImpulseCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int OperationCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int DynamicImpulseCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int DynamicOperationCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public string Overload
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool IsPassthrough
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public NodeMetadata Metadata
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool CanBeEvaluated
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedLocalsCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedValueLocalsSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedObjectLocalsSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedReferenceCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool ListensToChanges
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedStoresCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedValueStoresSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int FixedObjectStoresSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool HasSingleContinuation
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool HasSyncAsyncTransition
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int IndexInGroup
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int FixedGlobalRefCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int ArgumentCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int AllocationIndex
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int ValueStoreStartOffset
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int ObjectStoreStartOffset
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public abstract void Evaluate(C context);

		public IOperation GetOperation(int index)
		{
			throw new NotImplementedException();
		}

		public ExecutionOperationHandler<T> GetOperationHandler<T>(int index) where T : ExecutionContext
		{
			throw new NotImplementedException();
		}

		public short[] GetDefaultStackLayout()
		{
			throw new NotSupportedException();
		}

		public ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(int listIndex, int index) where T : ExecutionContext
		{
			throw new NotImplementedException();
		}

		public IInputList GetInputList(int index)
		{
			throw new NotImplementedException();
		}

		public IOperation GetImpulseTarget(int index)
		{
			throw new NotImplementedException();
		}

		public object GetInputDefaultValue(int index)
		{
			throw new NotImplementedException();
		}

		public string GetInputName(int index)
		{
			throw new NotSupportedException();
		}

		public IOutput GetInputSource(int index)
		{
			throw new NotSupportedException();
		}

		public int GetInputStackOffset(int index)
		{
			throw new NotSupportedException();
		}

		public Type GetInputType(int index)
		{
			throw new NotSupportedException();
		}

		public DataClass GetInputTypeClass(int index)
		{
			throw new NotSupportedException();
		}

		public IOutput GetOutput(int index)
		{
			throw new NotSupportedException();
		}

		public string GetOutputName(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetOutputType(int index)
		{
			throw new NotSupportedException();
		}

		public DataClass GetOutputTypeClass(int index)
		{
			throw new NotSupportedException();
		}

		public int GetValueInputSize(int index)
		{
			throw new NotSupportedException();
		}

		public int GetValueOutputSize(int index)
		{
			throw new NotSupportedException();
		}

		public bool IsImpulseImplicit(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsInputConditional(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsOutputImplicit(int index)
		{
			throw new NotImplementedException();
		}

		public void SetInputSource(int index, IOutput source)
		{
			throw new NotImplementedException();
		}

		public IOutputList GetOutputList(int index)
		{
			throw new NotImplementedException();
		}

		public void SetImpulseTarget(int index, IOperation target)
		{
			throw new NotImplementedException();
		}

		public IImpulseList GetImpulseList(int index)
		{
			throw new NotImplementedException();
		}

		public SyncOperationList GetOperationList(int index)
		{
			throw new NotImplementedException();
		}

		public string GetInputListName(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetInputListTypeConstraint(int index)
		{
			throw new NotImplementedException();
		}

		public string GetOutputListName(int index)
		{
			throw new NotImplementedException();
		}

		public string GetOperationListName(int index)
		{
			throw new NotImplementedException();
		}

		public void CopyDynamicOutputLayout(INode source)
		{
			throw new NotImplementedException();
		}

		public void CopyDynamicOperationLayout(INode source)
		{
			throw new NotImplementedException();
		}

		public DataClass GetLocalDataClass(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetLocalType(int index)
		{
			throw new NotImplementedException();
		}

		public int GetValueLocalSize(int index)
		{
			throw new NotImplementedException();
		}

		public void SetLocalOffset(int index, int offset)
		{
			throw new NotImplementedException();
		}

		public string GetImpulseListName(int index)
		{
			throw new NotImplementedException();
		}

		public string GetReferenceName(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetReferenceType(int index)
		{
			throw new NotImplementedException();
		}

		public INode GetReferenceTarget(int index)
		{
			throw new NotImplementedException();
		}

		public void SetReferenceTarget(int index, INode target)
		{
			throw new NotImplementedException();
		}

		public bool TrySetReferenceTarget(int index, INode target)
		{
			throw new NotImplementedException();
		}

		public void SetInputSource(ElementRef input, IOutput source)
		{
			throw new NotImplementedException();
		}

		public void Initialize(NodeRuntime runtime, int allocationIndex)
		{
			throw new NotImplementedException();
		}

		public bool IsInputListeningToChanges(int index)
		{
			throw new NotImplementedException();
		}

		public CrossRuntimeInputAttribute GetInputCrossRuntime(int index)
		{
			throw new NotImplementedException();
		}

		public OutputChangeSource GetOutputChangeType(int index)
		{
			throw new NotImplementedException();
		}

		public DataClass GetStoreDataClass(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetStoreType(int index)
		{
			throw new NotImplementedException();
		}

		public int GetValueStoreSize(int index)
		{
			throw new NotImplementedException();
		}

		public void SetStoreOffset(int index, int offset)
		{
			throw new NotImplementedException();
		}

		public string GetImpulseName(int index)
		{
			throw new NotImplementedException();
		}

		public ImpulseType GetImpulseType(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsOperationAsync(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsOperationListAsync(int index)
		{
			throw new NotImplementedException();
		}

		public AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(int index) where T : ExecutionContext
		{
			throw new NotImplementedException();
		}

		public AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(int listIndex, int index) where T : ExecutionContext
		{
			throw new NotImplementedException();
		}

		IOperationList INode.GetOperationList(int index)
		{
			throw new NotImplementedException();
		}

		public string GetGlobalRefName(int index)
		{
			throw new NotImplementedException();
		}

		public Type GetGlobalRefValueType(int index)
		{
			throw new NotImplementedException();
		}

		public Global GetGlobalRefBinding(int index)
		{
			throw new NotImplementedException();
		}

		public void SetGlobalRefBinding(int index, Global binding)
		{
			throw new NotImplementedException();
		}

		public bool TrySetGlobalRefBinding(int index, Global binding)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void GlobalChanged<T>(int index, T newValue, C context)
		{
			throw new NotImplementedException();
		}

		public void ListGlobalChanged<T>(int listIndex, int index, T newValue, C context)
		{
			throw new NotImplementedException();
		}

		public bool CanOperationContinueTo(int index, string impulseName)
		{
			throw new NotImplementedException();
		}

		public bool CanOperationListContinueTo(int index, string impulseName)
		{
			throw new NotImplementedException();
		}

		public bool OperationHasSingleContinuation(int index)
		{
			throw new NotImplementedException();
		}

		public bool OperationHasSyncAsyncTransition(int index)
		{
			throw new NotImplementedException();
		}

		public string GetOperationName(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsOperationPassthrough(int index)
		{
			throw new NotImplementedException();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	internal class LoadValueFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int Size
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public int Offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public LoadValueFromLocal(int size, int offset)
		{
			Size = size;
			Offset = offset;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LoadValueFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class LoadObjectFromLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int Size
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public int Offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Offset", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public LoadObjectFromLocal(int size, int offset)
		{
			Size = size;
			Offset = offset;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LoadObjectFromLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class PopToLocal<C> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public LocalNodeData Mapping
		{
			get
			{
				return (LocalNodeData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mapping"), typeof(LocalNodeData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mapping", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public PopToLocal(in LocalNodeData mapping)
		{
			Mapping = mapping;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PopToLocal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class PushObject<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public T Object
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Object"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Object", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public PushObject(T @object)
		{
			Object = @object;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PushObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class PushValue<C, T> : ExecutionControlNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public override void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public PushValue(T value)
		{
			Value = value;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PushValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class ExecutionHelper
	{
		private static ConcurrentDictionary<Type, int> _sizeCache
		{
			get
			{
				return (ConcurrentDictionary<Type, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache"), typeof(ConcurrentDictionary<Type, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_sizeCache", value);
			}
		}

		public static int SizeOf(Type type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOf", type), typeof(int));
		}

		private unsafe static int SizeOfGeneric<T>() where T : struct
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ExecutionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SizeOfGeneric"), typeof(int));
		}
	}
	[AttributeUsage(AttributeTargets.Field)]
	public class ExecutionInputAttribute : CrossRuntimeInputAttribute, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override bool IsValidTargetRuntime(NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsValidTargetRuntime", runtime), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionInputAttribute(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ExecutionNode<C> : Node, IExecutionNode<C>, IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private static ConcurrentDictionary<Type, ExecutionNodeMetadata> _metadataCache = new ConcurrentDictionary<Type, ExecutionNodeMetadata>();

		private const BindingFlags OPERATION_BIND_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private const BindingFlags LOCALS_BIND_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private const BindingFlags STORES_BIND_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private const BindingFlags GLOBAL_BIND_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		public abstract bool CanBeEvaluated { get; }

		public virtual int FixedValueStackSize => ExecutionMetadata.FixedValueStackSize;

		public virtual int FixedObjectStackSize => ExecutionMetadata.FixedObjectStackSize;

		public virtual int FixedLocalsCount => ExecutionMetadata.FixedLocalsCount;

		public virtual int FixedValueLocalsSize => ExecutionMetadata.FixedValueLocalsSize;

		public virtual int FixedObjectLocalsSize => ExecutionMetadata.FixedObjectLocalsSize;

		public virtual int FixedStoresCount => ExecutionMetadata.FixedStoresCount;

		public virtual int FixedValueStoresSize => ExecutionMetadata.FixedValueStoresSize;

		public virtual int FixedObjectStoresSize => ExecutionMetadata.FixedObjectStoresSize;

		public int ValueStoreStartOffset { get; set; } = -1073741824;


		public int ObjectStoreStartOffset { get; set; } = -1073741824;


		public virtual ExecutionNodeMetadata ExecutionMetadata
		{
			get
			{
				Type type = GetType();
				if (_metadataCache.TryGetValue(type, out var value))
				{
					return value;
				}
				NodeMetadata metadata = base.Metadata;
				value = new ExecutionNodeMetadata();
				foreach (InputMetadata fixedInput in metadata.FixedInputs)
				{
					if (!fixedInput.IsConditional)
					{
						switch (fixedInput.DataClass)
						{
							case DataClass.Value:
							{
								int num = ExecutionHelper.SizeOf(fixedInput.InputType);
								value.FixedValueStackSize += num;
								break;
							}
							case DataClass.Object:
								value.FixedObjectStackSize++;
								break;
							default:
								throw new NotImplementedException("Unsupported data class");
						}
					}
				}
				int num2 = -value.FixedValueStackSize;
				int num3 = -value.FixedObjectStackSize;
				foreach (InputMetadata fixedInput2 in metadata.FixedInputs)
				{
					switch (fixedInput2.DataClass)
					{
						case DataClass.Value:
						{
							int num4 = ExecutionHelper.SizeOf(fixedInput2.InputType);
							if (fixedInput2.IsConditional)
							{
								value.FixedInputs.Add(new InputExecutionMetadata((short)num4, -1));
								break;
							}
							value.FixedInputs.Add(new InputExecutionMetadata((short)num4, (short)num2));
							num2 += num4;
							break;
						}
						case DataClass.Object:
							if (fixedInput2.IsConditional)
							{
								value.FixedInputs.Add(new InputExecutionMetadata(-1, -1));
								break;
							}
							value.FixedInputs.Add(new InputExecutionMetadata(-1, (short)num3));
							num3++;
							break;
						default:
							throw new NotImplementedException("Unsupported data class");
					}
				}
				foreach (OutputMetadata fixedOutput in metadata.FixedOutputs)
				{
					switch (fixedOutput.DataClass)
					{
						case DataClass.Value:
							value.FixedOutputs.Add(new OutputExecutionMetadata((short)ExecutionHelper.SizeOf(fixedOutput.OutputType)));
							break;
						case DataClass.Object:
							value.FixedOutputs.Add(new OutputExecutionMetadata(-1));
							break;
						default:
							throw new NotImplementedException("Unsupported data class");
					}
				}
				foreach (OperationMetadata fixedOperation in metadata.FixedOperations)
				{
					if (fixedOperation.IsSelf)
					{
						value.FixedOperations.Add(default(OperationExecutionMetadata));
						continue;
					}
					MethodInfo methodInfo = type.FindMethodInHierarchy("Do" + fixedOperation.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (methodInfo == null)
					{
						throw new Exception("Matching method not found for operation " + fixedOperation.Name);
					}
					value.FixedOperations.Add(new OperationExecutionMetadata(methodInfo));
				}
				foreach (OperationListMetadata dynamicOperation in metadata.DynamicOperations)
				{
					MethodInfo methodInfo2 = null;
					MethodInfo methodInfo3 = null;
					if (dynamicOperation.SupportsSync)
					{
						methodInfo2 = type.FindMethodInHierarchy("Do" + dynamicOperation.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
						if (methodInfo2 == null)
						{
							throw new Exception("Matching sync method not found for operation list " + dynamicOperation.Name);
						}
					}
					if (dynamicOperation.SupportsAsync)
					{
						methodInfo3 = type.FindMethodInHierarchy("Do" + dynamicOperation.Name + "Async", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
						if (methodInfo3 == null)
						{
							throw new Exception("Matching async method not found for operation list " + dynamicOperation.Name);
						}
					}
					value.DynamicOperations.Add(new OperationListExecutionMetadata(methodInfo2, methodInfo3));
				}
				foreach (GlobalRefMetadata fixedGlobalRef in metadata.FixedGlobalRefs)
				{
					MethodInfo methodInfo4 = type.FindMethodInHierarchy("On" + fixedGlobalRef.Name + "Changed", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (methodInfo4 == null)
					{
						throw new Exception("Matching GlobalRef change not found for " + fixedGlobalRef.Name);
					}
					value.FixedGlobalRefs.Add(new GlobalRefExecutionMetadata(methodInfo4));
				}
				foreach (GlobalRefListMetadata dynamicGlobalRef in metadata.DynamicGlobalRefs)
				{
					MethodInfo methodInfo5 = type.FindMethodInHierarchy("On" + dynamicGlobalRef.Name + "Changed", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (methodInfo5 == null)
					{
						throw new Exception("Matching GlobalRefList change not found for " + dynamicGlobalRef.Name);
					}
					value.DynamicGlobalRefs.Add(new GlobalRefListExecutionMetadata(methodInfo5));
				}
				foreach (FieldInfo item in type.EnumerateAllInstanceFields((Type t) => !t.IsGenericType || t.GetGenericTypeDefinition() != typeof(ExecutionNode<>)))
				{
					if (item.FieldType.IsGenericType)
					{
						Type genericTypeDefinition = item.FieldType.GetGenericTypeDefinition();
						if (genericTypeDefinition == typeof(ValueLocal<>))
						{
							value.FixedLocals.Add(new LocalExecutionMetadata(item, DataClass.Value));
						}
						else if (genericTypeDefinition == typeof(ObjectLocal<>))
						{
							value.FixedLocals.Add(new LocalExecutionMetadata(item, DataClass.Object));
						}
						else if (genericTypeDefinition == typeof(ValueStore<>))
						{
							value.FixedStores.Add(new StoreExecutionMetadata(item, DataClass.Value));
						}
						else if (genericTypeDefinition == typeof(ObjectStore<>))
						{
							value.FixedStores.Add(new StoreExecutionMetadata(item, DataClass.Object));
						}
					}
				}
				foreach (LocalExecutionMetadata fixedLocal in value.FixedLocals)
				{
					if (fixedLocal.valueSize > 0)
					{
						value.FixedValueLocalsSize += fixedLocal.valueSize;
					}
					else
					{
						value.FixedObjectLocalsSize++;
					}
				}
				foreach (StoreExecutionMetadata fixedStore in value.FixedStores)
				{
					if (fixedStore.valueSize > 0)
					{
						value.FixedValueStoresSize += fixedStore.valueSize;
					}
					else
					{
						value.FixedObjectStoresSize++;
					}
				}
				value.GenerateDefaultStackLayout();
				_metadataCache.TryAdd(type, value);
				return value;
			}
		}

		public abstract void Evaluate(C context);

		public virtual int GetValueInputSize(int index)
		{
			ExecutionNodeMetadata executionMetadata = ExecutionMetadata;
			if (index < executionMetadata.FixedInputCount)
			{
				return executionMetadata.FixedInputs[index].size;
			}
			InputListMetadata listMetadata;
			return ExecutionHelper.SizeOf(GetDynamicInputList(ref index, out listMetadata).GetInputType(index));
		}

		public virtual int GetInputStackOffset(int index)
		{
			return ExecutionMetadata.FixedInputs[index].stackOffset;
		}

		public virtual short[] GetDefaultStackLayout()
		{
			return ExecutionMetadata.DefaultFixedStackLayout;
		}

		public virtual int GetValueOutputSize(int index)
		{
			ExecutionNodeMetadata executionMetadata = ExecutionMetadata;
			if (index < executionMetadata.FixedOutputCount)
			{
				OutputExecutionMetadata outputExecutionMetadata = executionMetadata.FixedOutputs[index];
				if (outputExecutionMetadata.size <= 0)
				{
					throw new InvalidOperationException($"Output with index {index} is not of value type");
				}
				return outputExecutionMetadata.size;
			}
			OutputListMetadata listMetadata;
			return ExecutionHelper.SizeOf(GetDynamicOutputList(ref index, out listMetadata).GetOutputType(index));
		}

		public virtual bool IsOperationPassthrough(int index)
		{
			return false;
		}

		public virtual ExecutionOperationHandler<T> GetOperationHandler<T>(int index) where T : ExecutionContext
		{
			MethodInfo handlerMethod = GetHandlerMethod(index, async: false);
			if (handlerMethod.ReturnType == typeof(void))
			{
				return new VoidExecutionOperationWrapper<T>((VoidExecutionOperationHandler<T>)Delegate.CreateDelegate(typeof(VoidExecutionOperationHandler<T>), this, handlerMethod)).Run;
			}
			return (ExecutionOperationHandler<T>)Delegate.CreateDelegate(typeof(ExecutionOperationHandler<T>), this, handlerMethod);
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(int index) where T : ExecutionContext
		{
			MethodInfo handlerMethod = GetHandlerMethod(index, async: true);
			if (handlerMethod.ReturnType == typeof(Task))
			{
				return new AsyncVoidExecutionOperationWrapper<T>((AsyncVoidExecutionOperationHandler<T>)Delegate.CreateDelegate(typeof(AsyncVoidExecutionOperationHandler<T>), this, handlerMethod)).RunAsync;
			}
			return (AsyncExecutionOperationHandler<T>)Delegate.CreateDelegate(typeof(AsyncExecutionOperationHandler<T>), this, handlerMethod);
		}

		public virtual void GlobalChanged<T>(int index, T value, C context)
		{
			MethodInfo methodInfo = ExecutionMetadata.FixedGlobalRefs[index].Method;
			if (methodInfo.IsGenericMethodDefinition)
			{
				methodInfo = methodInfo.MakeGenericMethod(typeof(T));
			}
			((ExecutionGlobalRefHandler<C, T>)methodInfo.CreateDelegate(typeof(ExecutionGlobalRefHandler<C, T>), this))(value, context);
		}

		public virtual void ListGlobalChanged<T>(int listIndex, int index, T value, C context)
		{
			MethodInfo methodInfo = ExecutionMetadata.DynamicGlobalRefs[listIndex].Method;
			if (methodInfo.IsGenericMethodDefinition)
			{
				methodInfo = methodInfo.MakeGenericMethod(typeof(T));
			}
			Type typeFromHandle = typeof(ExecutionGlobalRefListHandler<C, T>);
			((ExecutionGlobalRefListHandler<C, T>)methodInfo.CreateDelegate(typeFromHandle, this))(index, value, context);
		}

		private MethodInfo GetHandlerMethod(int index, bool async)
		{
			OperationExecutionMetadata operationExecutionMetadata = ExecutionMetadata.FixedOperations[index];
			if (operationExecutionMetadata.Method == null)
			{
				return GetType().GetMethod(async ? "RunAsync" : "Run");
			}
			return operationExecutionMetadata.Method;
		}

		public virtual ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(int listIndex, int index) where T : ExecutionContext
		{
			OperationListExecutionMetadata operationListExecutionMetadata = ExecutionMetadata.DynamicOperations[listIndex];
			if (operationListExecutionMetadata.SyncMethod == null)
			{
				throw new InvalidOperationException("Operation list doesn't support sync operations");
			}
			return new ExecutionListOperationWrapper<T>((ExecutionListOperationHandler<T>)Delegate.CreateDelegate(typeof(ExecutionListOperationHandler<T>), this, operationListExecutionMetadata.SyncMethod), index).Execute;
		}

		public virtual AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(int listIndex, int index) where T : ExecutionContext
		{
			OperationListExecutionMetadata operationListExecutionMetadata = ExecutionMetadata.DynamicOperations[listIndex];
			if (operationListExecutionMetadata.AsyncMethod == null)
			{
				throw new InvalidOperationException("Operation list doesn't support async operations");
			}
			return new AsyncExecutionListOperationWrapper<T>((AsyncExecutionListOperationHandler<T>)Delegate.CreateDelegate(typeof(AsyncExecutionListOperationHandler<T>), this, operationListExecutionMetadata.AsyncMethod), index).ExecuteAsync;
		}

		public virtual DataClass GetLocalDataClass(int index)
		{
			return ExecutionMetadata.FixedLocals[index].dataClass;
		}

		public virtual Type GetLocalType(int index)
		{
			return ExecutionMetadata.FixedLocals[index].type;
		}

		public virtual int GetValueLocalSize(int index)
		{
			return ExecutionMetadata.FixedLocals[index].valueSize;
		}

		public virtual void SetLocalOffset(int index, int offset)
		{
			FieldInfo field = ExecutionMetadata.FixedLocals[index].field;
			FieldInfo field2 = field.FieldType.GetField("offset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			object value = field.GetValue(this);
			field2.SetValue(value, offset);
			field.SetValue(this, value);
		}

		public virtual DataClass GetStoreDataClass(int index)
		{
			return ExecutionMetadata.FixedStores[index].dataClass;
		}

		public virtual Type GetStoreType(int index)
		{
			return ExecutionMetadata.FixedStores[index].type;
		}

		public virtual int GetValueStoreSize(int index)
		{
			return ExecutionMetadata.FixedStores[index].valueSize;
		}

		public virtual void SetStoreOffset(int index, int offset)
		{
			FieldInfo field = ExecutionMetadata.FixedStores[index].field;
			FieldInfo field2 = field.FieldType.GetField("offset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			object value = field.GetValue(this);
			field2.SetValue(value, offset);
			field.SetValue(this, value);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class ValueFunctionNode<C, T> : ExecutionNode<C>, IValueOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where T : struct
	{
		public Node OwnerNode => this;

		public override int OutputCount => 1;

		public Type OutputType => typeof(T);

		public DataClass OutputDataClass => DataClass.Value;

		public override bool CanBeEvaluated => true;

		public override IOutput GetOutput(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return this;
		}

		public override Type GetOutputType(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return typeof(T);
		}

		public override DataClass GetOutputTypeClass(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return DataClass.Value;
		}

		public sealed override void Evaluate(C context)
		{
			T value = Compute(context);
			context.PopInputs();
			context.Values.Push(value);
		}

		protected abstract T Compute(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class ObjectFunctionNode<C, T> : ExecutionNode<C>, IObjectOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Node OwnerNode => this;

		public override int OutputCount => 1;

		public Type OutputType => typeof(T);

		public DataClass OutputDataClass => DataClass.Object;

		public override bool CanBeEvaluated => true;

		public override IOutput GetOutput(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return this;
		}

		public override Type GetOutputType(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return typeof(T);
		}

		public override DataClass GetOutputTypeClass(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return DataClass.Object;
		}

		public sealed override void Evaluate(C context)
		{
			T obj = Compute(context);
			context.PopInputs();
			context.Objects.Push(obj);
		}

		protected abstract T Compute(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class VoidNode<C> : ExecutionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override bool CanBeEvaluated => true;

		public override void Evaluate(C context)
		{
			ComputeOutputs(context);
			context.PopInputs();
		}

		protected virtual void ComputeOutputs(C context)
		{
			throw new NotImplementedException($"Method Compute() is not implemented on derived type {GetType()}");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
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
		public Node OwnerNode => this;

		public ExecutionOperationHandler<C> Handler => Run;

		public override bool CanBeEvaluated => false;

		public override void Evaluate(C context)
		{
			throw new NotSupportedException("Evaluation is not supported for action nodes.");
		}

		public virtual ExecutionOperationHandler<T> GetHandler<T>() where T : ExecutionContext
		{
			return (ExecutionOperationHandler<T>)new ExecutionOperationHandler<C>(Run);
		}

		protected abstract IOperation Run(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class ActionFlowNode<C> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next;

		protected sealed override IOperation Run(C context)
		{
			Do(context);
			return Next.Target;
		}

		protected abstract void Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class ActionBreakableFlowNode<C> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next;

		protected sealed override IOperation Run(C context)
		{
			if (Do(context))
			{
				return Next.Target;
			}
			return null;
		}

		protected abstract bool Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class AsyncActionNode<C> : ExecutionNode<C>, IExecutionAsyncOperationNode, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Node OwnerNode => this;

		public override bool CanBeEvaluated => false;

		public override void Evaluate(C context)
		{
			throw new NotSupportedException("Evaluation is not supported for action nodes.");
		}

		public virtual AsyncExecutionOperationHandler<T> GetAsyncHandler<T>() where T : ExecutionContext
		{
			return (AsyncExecutionOperationHandler<T>)new AsyncExecutionOperationHandler<C>(RunAsync);
		}

		protected abstract Task<IOperation> RunAsync(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class AsyncActionFlowNode<C> : AsyncActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next;

		protected sealed override async Task<IOperation> RunAsync(C context)
		{
			await Do(context);
			return Next.Target;
		}

		protected abstract Task Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class AsyncActionBreakableFlowNode<C> : AsyncActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation Next;

		protected sealed override async Task<IOperation> RunAsync(C context)
		{
			if (await Do(context))
			{
				return Next.Target;
			}
			return null;
		}

		protected abstract Task<bool> Do(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public interface IExecutionNode : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool CanBeEvaluated { get; }

		int FixedValueStackSize { get; }

		int FixedObjectStackSize { get; }

		int FixedLocalsCount { get; }

		int FixedValueLocalsSize { get; }

		int FixedObjectLocalsSize { get; }

		int FixedStoresCount { get; }

		int FixedValueStoresSize { get; }

		int FixedObjectStoresSize { get; }

		int ValueStoreStartOffset { get; set; }

		int ObjectStoreStartOffset { get; set; }

		int GetValueInputSize(int index);

		int GetInputStackOffset(int index);

		short[] GetDefaultStackLayout();

		int GetValueOutputSize(int index);

		bool IsOperationPassthrough(int index);

		ExecutionOperationHandler<T> GetOperationHandler<T>(int index) where T : ExecutionContext;

		ExecutionOperationHandler<T> GetDynamicOperationHandler<T>(int listIndex, int index) where T : ExecutionContext;

		AsyncExecutionOperationHandler<T> GetAsyncOperationHandler<T>(int index) where T : ExecutionContext;

		AsyncExecutionOperationHandler<T> GetDynamicAsyncOperationHandler<T>(int listIndex, int index) where T : ExecutionContext;

		DataClass GetLocalDataClass(int index);

		Type GetLocalType(int index);

		int GetValueLocalSize(int index);

		void SetLocalOffset(int index, int offset);

		DataClass GetStoreDataClass(int index);

		Type GetStoreType(int index);

		int GetValueStoreSize(int index);

		void SetStoreOffset(int index, int offset);
	}
	public interface IExecutionNode<in C> : IExecutionNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		void Evaluate(C context);

		void GlobalChanged<T>(int index, T value, C context);

		void ListGlobalChanged<T>(int listIndex, int index, T value, C context);
	}
	public interface IExecutionRuntimeInterop : ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool InputNodesMustBeLocal { get; }
	}
	public struct OperationExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Method", value);
			}
		}

		public OperationExecutionMetadata(MethodInfo method)
		{
			Method = method;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OperationExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct OperationListExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo SyncMethod
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SyncMethod"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SyncMethod", value);
			}
		}

		public MethodInfo AsyncMethod
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "AsyncMethod"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "AsyncMethod", value);
			}
		}

		public OperationListExecutionMetadata(MethodInfo syncMethod, MethodInfo asyncMethod)
		{
			SyncMethod = syncMethod;
			AsyncMethod = asyncMethod;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OperationListExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ExecutionNodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int FixedInputCount => FixedInputs.Count;

		public int FixedOutputCount => FixedOutputs.Count;

		public int FixedActionCount => FixedOperations.Count;

		public int FixedLocalsCount => FixedLocals.Count;

		public int FixedStoresCount => FixedStores.Count;

		public int DynamicActionCount => DynamicOperations.Count;

		public int FixedValueStackSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedValueStackSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedValueStackSize", value);
			}
		}

		public int FixedObjectStackSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedObjectStackSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedObjectStackSize", value);
			}
		}

		public int FixedValueLocalsSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedValueLocalsSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedValueLocalsSize", value);
			}
		}

		public int FixedObjectLocalsSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedObjectLocalsSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedObjectLocalsSize", value);
			}
		}

		public int FixedValueStoresSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedValueStoresSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedValueStoresSize", value);
			}
		}

		public int FixedObjectStoresSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedObjectStoresSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedObjectStoresSize", value);
			}
		}

		public short[] DefaultFixedStackLayout
		{
			get
			{
				return (short[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DefaultFixedStackLayout"), typeof(short[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DefaultFixedStackLayout", value);
			}
		}

		public List<InputExecutionMetadata> FixedInputs
		{
			get
			{
				return (List<InputExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedInputs"), typeof(List<InputExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedInputs", value);
			}
		}

		public List<OutputExecutionMetadata> FixedOutputs
		{
			get
			{
				return (List<OutputExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedOutputs"), typeof(List<OutputExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedOutputs", value);
			}
		}

		public List<OperationExecutionMetadata> FixedOperations
		{
			get
			{
				return (List<OperationExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedOperations"), typeof(List<OperationExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedOperations", value);
			}
		}

		public List<LocalExecutionMetadata> FixedLocals
		{
			get
			{
				return (List<LocalExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedLocals"), typeof(List<LocalExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedLocals", value);
			}
		}

		public List<StoreExecutionMetadata> FixedStores
		{
			get
			{
				return (List<StoreExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedStores"), typeof(List<StoreExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedStores", value);
			}
		}

		public List<GlobalRefExecutionMetadata> FixedGlobalRefs
		{
			get
			{
				return (List<GlobalRefExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedGlobalRefs", value);
			}
		}

		public List<OperationListExecutionMetadata> DynamicOperations
		{
			get
			{
				return (List<OperationListExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicOperations"), typeof(List<OperationListExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicOperations", value);
			}
		}

		public List<GlobalRefListExecutionMetadata> DynamicGlobalRefs
		{
			get
			{
				return (List<GlobalRefListExecutionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListExecutionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicGlobalRefs", value);
			}
		}

		internal void GenerateDefaultStackLayout()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateDefaultStackLayout");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionNodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct GlobalRefExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Method", value);
			}
		}

		public GlobalRefExecutionMetadata(MethodInfo method)
		{
			Method = method;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRefExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct GlobalRefListExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MethodInfo Method
		{
			get
			{
				return (MethodInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Method"), typeof(MethodInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Method", value);
			}
		}

		public GlobalRefListExecutionMetadata(MethodInfo method)
		{
			Method = method;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRefListExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct InputExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public short size
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "size"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "size", value);
			}
		}

		public short stackOffset
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stackOffset"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stackOffset", value);
			}
		}

		public InputExecutionMetadata(short size, short stackOffset)
		{
			this.size = size;
			this.stackOffset = stackOffset;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InputExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct LocalExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public FieldInfo field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "field", value);
			}
		}

		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "type", value);
			}
		}

		public DataClass dataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "dataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "dataClass", value);
			}
		}

		public short valueSize
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "valueSize"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "valueSize", value);
			}
		}

		public LocalExecutionMetadata(FieldInfo field, DataClass dataClass)
		{
			this.field = field;
			type = field.FieldType.GetGenericArguments()[0];
			this.dataClass = dataClass;
			if (dataClass == DataClass.Value)
			{
				valueSize = (short)ExecutionHelper.SizeOf(type);
			}
			else
			{
				valueSize = -1;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocalExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct OutputExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public short size
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "size"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "size", value);
			}
		}

		public OutputExecutionMetadata(short size)
		{
			this.size = size;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OutputExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct StoreExecutionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public FieldInfo field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "field", value);
			}
		}

		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "type", value);
			}
		}

		public DataClass dataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "dataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "dataClass", value);
			}
		}

		public short valueSize
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "valueSize"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "valueSize", value);
			}
		}

		public StoreExecutionMetadata(FieldInfo field, DataClass dataClass)
		{
			this.field = field;
			type = field.FieldType.GetGenericArguments()[0];
			this.dataClass = dataClass;
			if (dataClass == DataClass.Value)
			{
				valueSize = (short)ExecutionHelper.SizeOf(type);
			}
			else
			{
				valueSize = -1;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StoreExecutionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate void ExecutionNodeOperation<T, C>(T node, C context) where T : INode where C : ExecutionContext;
	public class AsyncCallExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public AsyncCallExportWrapper(int index)
			: base(index)
		{
		}

		public async Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncCallExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class AsyncExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public AsyncExecutionListOperationHandler<C> Handler
		{
			get
			{
				return (AsyncExecutionListOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Handler"), typeof(AsyncExecutionListOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Handler", value);
			}
		}

		public AsyncExecutionListOperationWrapper(AsyncExecutionListOperationHandler<C> handler, int index)
		{
			Handler = handler;
			Index = index;
		}

		public Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncExecutionListOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class AsyncOperationSequence<C> : OperationSequence<C, IAsyncOperation, AsyncExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override bool IsAsync => true;

		public AsyncOperationSequence(ExecutionRuntime<C> runtime, IAsyncOperation origin)
			: base(runtime, origin)
		{
		}

		protected override AsyncExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			return (AsyncExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHandler", operation), typeof(AsyncExecutionOperationHandler<C>));
		}

		public override async Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncOperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class EvaluationAnalysisContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private HashSet<EvaluationSequence<C>> processedSequences
		{
			get
			{
				return (HashSet<EvaluationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "processedSequences"), typeof(HashSet<EvaluationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "processedSequences", value);
			}
		}

		private HashSet<IExecutionNode<C>> globalEvaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "globalEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "globalEvaluatedNodes", value);
			}
		}

		private HashSet<IExecutionNode<C>> sequenceEvaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "sequenceEvaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "sequenceEvaluatedNodes", value);
			}
		}

		private HashSet<IExecutionNode<C>> localNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "localNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "localNodes", value);
			}
		}

		public ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Runtime", value);
			}
		}

		public IEnumerable<IExecutionNode<C>> LocalNodes => localNodes;

		public EvaluationAnalysisContext(ExecutionRuntime<C> runtime)
		{
			Runtime = runtime;
		}

		public bool BeginSequence(EvaluationSequence<C> sequence)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BeginSequence", sequence), typeof(bool));
		}

		public bool MarkNodeEvaluated(IExecutionNode<C> node, EvaluationSequence<C> sequence, bool external)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkNodeEvaluated", node, sequence, external), typeof(bool));
		}

		public void MarkLocal(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkLocal", node);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public EvaluationAnalysisContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class EvaluationBuildContext<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private HashSet<IExecutionNode<C>> evaluatedNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "evaluatedNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "evaluatedNodes", value);
			}
		}

		public bool MarkEvaluated(IExecutionNode<C> node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkEvaluated", node), typeof(bool));
		}

		public void ClearEvaluated()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearEvaluated");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public EvaluationBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class CallExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public CallExportWrapper(int index)
			: base(index)
		{
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CallExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ContinuationExportWrapper<C> : ImpulseExportWrapper<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public ContinuationExportWrapper(int index)
			: base(index)
		{
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", context), typeof(IOperation));
		}

		public async Task<IOperation> ExecuteAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuationExportWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal struct EvaluationAction<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public IExecutionNode<C> node
		{
			get
			{
				return (IExecutionNode<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "node"), typeof(IExecutionNode<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "node", value);
			}
		}

		public ExecutionContext.StackLayout stackLayout
		{
			get
			{
				return (ExecutionContext.StackLayout)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stackLayout"), typeof(ExecutionContext.StackLayout));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stackLayout", value);
			}
		}

		public EvaluationAction(IExecutionNode<C> node, short[] stackLayout, short valueSize, short objectSize)
		{
			this.node = node;
			this.stackLayout = new ExecutionContext.StackLayout(stackLayout, valueSize, objectSize);
		}

		public EvaluationAction(IExecutionNode<C> node)
		{
			this.node = node;
			stackLayout = default(ExecutionContext.StackLayout);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public EvaluationAction(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class EvaluationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private bool isRoot
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isRoot"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isRoot", value);
			}
		}

		private HashSet<IExecutionNode<C>> rootNodes
		{
			get
			{
				return (HashSet<IExecutionNode<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rootNodes"), typeof(HashSet<IExecutionNode<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rootNodes", value);
			}
		}

		private IExecutionNode<C> firstNode
		{
			get
			{
				return (IExecutionNode<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "firstNode"), typeof(IExecutionNode<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "firstNode", value);
			}
		}

		private List<IOutput> outputs
		{
			get
			{
				return (List<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "outputs"), typeof(List<IOutput>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "outputs", value);
			}
		}

		private List<EvaluationAction<C>> evaluationSequence
		{
			get
			{
				return (List<EvaluationAction<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "evaluationSequence"), typeof(List<EvaluationAction<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "evaluationSequence", value);
			}
		}

		public ExecutionRuntime<C> Runtime
		{
			get
			{
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Runtime"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Runtime", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public bool IsLocal
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsLocal"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsLocal", value);
			}
		}

		public EvaluationSequence(ExecutionRuntime<C> runtime, List<IOutput> outputs)
		{
			Runtime = runtime;
			Index = -1;
			this.outputs = outputs;
			isRoot = true;
			foreach (IOutput output in outputs)
			{
				if (output.OwnerNode is IExecutionNode<C> item)
				{
					rootNodes.Add(item);
					if (firstNode == null)
					{
						firstNode = item;
					}
				}
			}
		}

		public EvaluationSequence(ExecutionRuntime<C> runtime, IExecutionNode<C> node, int index)
		{
			Runtime = runtime;
			Index = index;
			rootNodes.Add(node);
			firstNode = node;
			if (!node.CanBeEvaluated)
			{
				MarkLocal();
			}
		}

		internal void MarkLocal()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkLocal");
		}

		internal void Analyze(EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Analyze", context);
		}

		private void AnalyzeRecursive(IExecutionNode<C> node, EvaluationAnalysisContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AnalyzeRecursive", node, context);
		}

		internal void Build(EvaluationBuildContext<C> context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Build", context);
		}

		private bool BuildRecursive(IExecutionNode<C> node, EvaluationBuildContext<C> context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BuildRecursive", node, context), typeof(bool));
		}

		internal T EvaluateValue<T>(IOutput output, C context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateValue", output, context), typeof(T));
		}

		internal T EvaluateObject<T>(IOutput output, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateObject", output, context), typeof(T));
		}

		internal void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateValueToStack", output, context);
		}

		internal void EvaluateObjectToStack<T>(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateObjectToStack", output, context);
		}

		internal void Evaluate(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Evaluate", context);
		}

		public string ToDebugString(string prefix = "")
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToDebugString", prefix), typeof(string));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public EvaluationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate void ExecutionGlobalRefHandler<in C, T>(T value, C context) where C : ExecutionContext;
	public delegate void ExecutionGlobalRefListHandler<in C, T>(int index, T value, C context) where C : ExecutionContext;
	internal class ExecutionListOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public ExecutionListOperationHandler<C> Handler
		{
			get
			{
				return (ExecutionListOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Handler"), typeof(ExecutionListOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Handler", value);
			}
		}

		public ExecutionListOperationWrapper(ExecutionListOperationHandler<C> handler, int index)
		{
			Handler = handler;
			Index = index;
		}

		public IOperation Execute(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionListOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate IOperation ExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate IOperation ExecutionListOperationHandler<in C>(C context, int index) where C : ExecutionContext;
	public delegate Task<IOperation> AsyncExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate Task<IOperation> AsyncExecutionListOperationHandler<in C>(C context, int index) where C : ExecutionContext;
	public delegate void ExecutionImpulseExportHandler(ExecutionContext context, int index);
	public delegate Task ExecutionAsyncImpulseExportHandler(ExecutionContext context, int index);
	public delegate void VoidExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public delegate Task AsyncVoidExecutionOperationHandler<in C>(C context) where C : ExecutionContext;
	public class VoidExecutionOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public VoidExecutionOperationHandler<C> handler
		{
			get
			{
				return (VoidExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "handler"), typeof(VoidExecutionOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "handler", value);
			}
		}

		public VoidExecutionOperationWrapper(VoidExecutionOperationHandler<C> handler)
		{
			this.handler = handler;
		}

		public IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VoidExecutionOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AsyncVoidExecutionOperationWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public AsyncVoidExecutionOperationHandler<C> handler
		{
			get
			{
				return (AsyncVoidExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "handler"), typeof(AsyncVoidExecutionOperationHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "handler", value);
			}
		}

		public AsyncVoidExecutionOperationWrapper(AsyncVoidExecutionOperationHandler<C> handler)
		{
			this.handler = handler;
		}

		public async Task<IOperation> RunAsync(C context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncVoidExecutionOperationWrapper(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IExecutionRuntime : ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool RequiresScopeData { get; }

		int ValueStoreSize { get; }

		int ObjectStoreSize { get; }

		int TotalValueStackSize { get; }

		int TotalObjectStackSize { get; }

		IEnumerable<IExecutionNode> Nodes { get; }

		T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : unmanaged;

		T EvaluateObject<T>(IOutput output, ExecutionContext context);

		void SetValue<T>(IOutput output, T value, ExecutionContext context) where T : unmanaged;

		void SetObject<T>(IOutput output, T value, ExecutionContext context);

		void Execute(ISyncOperation action, ExecutionContext context);

		Task ExecuteAsync(IOperation action, ExecutionContext context);

		string GetEvaluationSequenceDebug(IOutput output);
	}
	public class ExecutionRuntime<C> : NodeRuntime<IExecutionNode<C>>, IExecutionRuntime, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private EvaluationSequence<C> _exportsEvaluationSequence
		{
			get
			{
				return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_exportsEvaluationSequence"), typeof(EvaluationSequence<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_exportsEvaluationSequence", value);
			}
		}

		private Dictionary<IExecutionNode<C>, EvaluationSequence<C>> evaluationSequences
		{
			get
			{
				return (Dictionary<IExecutionNode<C>, EvaluationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "evaluationSequences"), typeof(Dictionary<IExecutionNode<C>, EvaluationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "evaluationSequences", value);
			}
		}

		private List<int> importsMapping
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "importsMapping"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "importsMapping", value);
			}
		}

		private Dictionary<IOutput, int> localValueMapping
		{
			get
			{
				return (Dictionary<IOutput, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "localValueMapping"), typeof(Dictionary<IOutput, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "localValueMapping", value);
			}
		}

		private Dictionary<IExecutionNode<C>, LocalNodeData> localNodes
		{
			get
			{
				return (Dictionary<IExecutionNode<C>, LocalNodeData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "localNodes"), typeof(Dictionary<IExecutionNode<C>, LocalNodeData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "localNodes", value);
			}
		}

		private Dictionary<IOperation, IOperationSequence<C>> operationSequences
		{
			get
			{
				return (Dictionary<IOperation, IOperationSequence<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "operationSequences"), typeof(Dictionary<IOperation, IOperationSequence<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "operationSequences", value);
			}
		}

		private int _evaluationFlagsSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_evaluationFlagsSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_evaluationFlagsSize", value);
			}
		}

		private int _localValueStackSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_localValueStackSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_localValueStackSize", value);
			}
		}

		private int _localObjectStackSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_localObjectStackSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_localObjectStackSize", value);
			}
		}

		private int _valueLocalsSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_valueLocalsSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_valueLocalsSize", value);
			}
		}

		private int _objectLocalsSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_objectLocalsSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_objectLocalsSize", value);
			}
		}

		private bool _requiresScopeData
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_requiresScopeData"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_requiresScopeData", value);
			}
		}

		private int _valueStoresSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_valueStoresSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_valueStoresSize", value);
			}
		}

		private int _objectStoresSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_objectStoresSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_objectStoresSize", value);
			}
		}

		public bool RequiresScopeData => _requiresScopeData;

		public int ValueStoreSize => _valueStoresSize;

		public int ObjectStoreSize => _objectStoresSize;

		public int TotalValueStackSize => _localValueStackSize + _evaluationFlagsSize;

		public int TotalObjectStackSize => _localObjectStackSize;

		IEnumerable<IExecutionNode> IExecutionRuntime.Nodes => base.Nodes;

		public override Type GetCompatibleNodeType(Type type)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCompatibleNodeType", type), typeof(Type));
		}

		public T EvaluateValue<T>(IOutput output, ExecutionContext context) where T : struct
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateValue", output, context), typeof(T));
		}

		public T EvaluateObject<T>(IOutput output, ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateObject", output, context), typeof(T));
		}

		internal void EvaluateValueToStack<T>(IOutput output, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateValueToStack", output, context);
		}

		internal void EvaluateObjectToStack<T>(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateObjectToStack", output, context);
		}

		public void SetValue<T>(IOutput output, T value, ExecutionContext context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValue", output, value, context);
		}

		public void SetObject<T>(IOutput output, T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetObject", output, value, context);
		}

		public void Execute(ISyncOperation action, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", action, context);
		}

		public async Task ExecuteAsync(IOperation operation, ExecutionContext context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsync", operation, context), typeof(Task));
		}

		public void Rebuild()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Rebuild");
		}

		private void MapLocalNode(IExecutionNode<C> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapLocalNode", node);
		}

		internal EvaluationSequence<C> EnsureSequence(IExecutionNode<C> node)
		{
			return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureSequence", node), typeof(EvaluationSequence<C>));
		}

		internal EvaluationSequence<C> GetSequence(IExecutionNode<C> node)
		{
			return (EvaluationSequence<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSequence", node), typeof(EvaluationSequence<C>));
		}

		internal bool IsLocalNode(IExecutionNode<C> node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsLocalNode", node), typeof(bool));
		}

		internal int GetLocalValueMapping(IOutput output)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLocalValueMapping", output), typeof(int));
		}

		internal LocalNodeData GetStaticNodeMapping(IExecutionNode<C> node)
		{
			return (LocalNodeData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetStaticNodeMapping", node), typeof(LocalNodeData));
		}

		internal void MapSequence(IOperation alias, IOperation existing)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapSequence", alias, existing);
		}

		internal void SetNullSequence(IOperation alias)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetNullSequence", alias);
		}

		public bool IsEvaluationDirty(C context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsEvaluationDirty", context), typeof(bool));
		}

		public void MarkEvaluationDirty(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkEvaluationDirty", context);
		}

		public bool IsEvaluated(IExecutionNode<C> node, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsEvaluated", node, context), typeof(bool));
		}

		public void MarkEvaluated(IExecutionNode<C> node, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkEvaluated", node, context);
		}

		public void EnsureEvaluated(IOutput output, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureEvaluated", output, context);
		}

		public void GetEvaluationIndex(IExecutionNode<C> node, out int pos, out int bitIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEvaluationIndex", node, pos, bitIndex);
		}

		public void ExecuteImpulseImport(int index, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteImpulseImport", index, context);
		}

		public Task ExecuteAsyncImpulseImport(int index, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsyncImpulseImport", index, context), typeof(Task));
		}

		public void ExecuteSequence(ISyncOperation operation, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteSequence", operation, context);
		}

		public async Task ExecuteAsyncSequence(IOperation operation, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsyncSequence", operation, context), typeof(Task));
		}

		public void ExecuteResumption(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteResumption", resumption, context);
		}

		public async Task ExecuteAsyncResumption(AsyncResumption resumption, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteAsyncResumption", resumption, context), typeof(Task));
		}

		internal void ResumeExecution(SyncResumption resumption, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResumeExecution", resumption, context);
		}

		internal async Task ResumeAsyncExecution(AsyncResumption resumption, C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task));
		}

		public void SetValueImport<T>(int index, T value, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValueImport", index, value, context);
		}

		public void SetObjectImport<T>(int index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetObjectImport", index, value, context);
		}

		public void SetValueImport<T>(IOutput output, T value, C context) where T : struct
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValueImport", output, value, context);
		}

		public void SetObjectImport<T>(IOutput output, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetObjectImport", output, value, context);
		}

		public void BeginStackFrame(C context, IExecutionNestedNode nestedNode = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BeginStackFrame", context, nestedNode);
		}

		public void PinStackFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PinStackFrame", context);
		}

		public bool ExitStackFrame(C context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExitStackFrame", context), typeof(bool));
		}

		internal void ClearValueLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearValueLocals", context);
		}

		internal void ClearObjectLocals(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearObjectLocals", context);
		}

		internal void ClearEvaluatedFlags(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearEvaluatedFlags", context);
		}

		public void RunEvaluation(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunEvaluation", context);
		}

		public void EndStackFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EndStackFrame", context);
		}

		internal void InvokeImpulseExport(C context, int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InvokeImpulseExport", context, index);
		}

		public int GetOperationSequenceSteps(IOperation operation)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperationSequenceSteps", operation), typeof(int));
		}

		public string GetEvaluationSequenceDebug(IOutput output)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEvaluationSequenceDebug", output), typeof(string));
		}

		public int DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, bool cache = true, HashSet<NodeRuntime> walkedRuntimes = null) where T : INode
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(int));
		}

		public void MapGlobals(IGlobalValue[] globals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapGlobals", globals, context);
		}

		public void UpdateGlobal<T>(Global<T> global, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateGlobal", global, value, context);
		}

		public void UpdateGlobalsToInitialValue(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateGlobalsToInitialValue", context);
		}

		public void ResetGlobalsToDefault(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResetGlobalsToDefault", context);
		}

		internal void MapGlobalsInternal(IGlobalValue[] globals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapGlobalsInternal", globals, context);
		}

		public int RestoreSharedScope(ScopePoint rootScope, C context, byte[] values, object[] objects)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RestoreSharedScope", rootScope, context, values, objects), typeof(int));
		}

		private int RestoreSharedScopeInternal(ScopePoint point, C context, byte[] values, object[] objects)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RestoreSharedScopeInternal", point, context, values, objects), typeof(int));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExecutionRuntime(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ImpulseExportWrapper<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public int Index { get; private set; }

		public bool IsLast { get; internal set; }

		public ImpulseExportWrapper(int index)
		{
			Index = index;
		}

		protected bool ShouldBeContinuation(C context)
		{
			if (IsLast)
			{
				return context.CurrentFramePins == 1;
			}
			return false;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	internal struct LocalNodeData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "index", value);
			}
		}

		public bool isImplicit
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isImplicit"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isImplicit", value);
			}
		}

		public int valueStart
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "valueStart"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "valueStart", value);
			}
		}

		public int valueSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "valueSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "valueSize", value);
			}
		}

		public int objectStart
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "objectStart"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "objectStart", value);
			}
		}

		public int objectSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "objectSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "objectSize", value);
			}
		}

		public LocalNodeData(int index, bool isImplicit, int valueStart, int valueSize, int objectStart, int objectSize)
		{
			this.index = index;
			this.isImplicit = isImplicit;
			this.valueStart = valueStart;
			this.valueSize = valueSize;
			this.objectStart = objectStart;
			this.objectSize = objectSize;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocalNodeData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal interface IOperationSequence<C> : ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		ExecutionRuntime<C> Runtime { get; }

		bool IsAsync { get; }

		int SequenceSteps { get; }

		void Build();

		IOperation ExecuteSync(C context);

		Task<IOperation> ExecuteAsync(C context);
	}
	internal abstract class OperationSequence<C, O, H> : IOperationSequence<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext where O : class, IOperation where H : Delegate
	{
		private O origin;

		public ExecutionRuntime<C> Runtime { get; private set; }

		public int SequenceSteps => operationSequence.Count;

		protected List<H> operationSequence { get; private set; } = new List<H>();


		public abstract bool IsAsync { get; }

		public OperationSequence(ExecutionRuntime<C> runtime, O origin)
		{
			Runtime = runtime;
			this.origin = origin;
		}

		void IOperationSequence<C>.Build()
		{
			IOperation operation = origin;
			IOperation initialOperationSkip = null;
			while (operation != null)
			{
				operation = BuildOperationStep(operation, ref initialOperationSkip);
			}
			if (operationSequence.Count != 0 && operationSequence[operationSequence.Count - 1].Target is ImpulseExportWrapper<C> impulseExportWrapper)
			{
				impulseExportWrapper.IsLast = true;
			}
		}

		internal void StitchSequence(Node node, IOperation initialOperationSkip)
		{
			IOperation operation = null;
			for (int i = 0; i < node.ImpulseCount; i++)
			{
				IOperation impulseTarget = node.GetImpulseTarget(i);
				if (impulseTarget != null)
				{
					if (operation != null)
					{
						throw new InvalidProgramException("Cannot have passthrough operations on nodes that have multiple impulse outputs");
					}
					operation = impulseTarget;
				}
			}
			if (operation != null)
			{
				Runtime.MapSequence(initialOperationSkip, operation);
			}
			else
			{
				Runtime.SetNullSequence(initialOperationSkip);
			}
		}

		internal IOperation BuildOperationStep(IOperation operation, ref IOperation initialOperationSkip)
		{
			H handler = GetHandler(operation);
			if (handler != null)
			{
				operationSequence.Add(handler);
				initialOperationSkip = null;
			}
			else if (initialOperationSkip == null)
			{
				initialOperationSkip = operation;
			}
			Node ownerNode = operation.OwnerNode;
			if (ownerNode == null || operation is ImpulseExport)
			{
				return null;
			}
			int index = operation.FindLinearOperationIndex();
			if (!ownerNode.OperationHasSingleContinuation(index))
			{
				if (handler == null)
				{
					StitchSequence(ownerNode, initialOperationSkip);
				}
				return null;
			}
			for (int i = 0; i < ownerNode.FixedImpulseCount; i++)
			{
				if (ownerNode.GetImpulseType(i) == ImpulseType.Continuation && ownerNode.CanOperationContinueTo(index, ownerNode.GetImpulseName(i)))
				{
					IOperation impulseTarget = ownerNode.GetImpulseTarget(i);
					if (impulseTarget != null && IsSupported(impulseTarget))
					{
						return impulseTarget;
					}
				}
			}
			for (int j = 0; j < ownerNode.DynamicImpulseCount; j++)
			{
				if (!ownerNode.CanOperationContinueTo(index, ownerNode.GetImpulseListName(j)))
				{
					continue;
				}
				IImpulseList impulseList = ownerNode.GetImpulseList(j);
				for (int k = 0; k < impulseList.Count; k++)
				{
					if (impulseList.GetImpulseType(k) == ImpulseType.Continuation)
					{
						IOperation impulseTarget2 = impulseList.GetImpulseTarget(k);
						if (impulseTarget2 != null && IsSupported(impulseTarget2))
						{
							return impulseTarget2;
						}
					}
				}
			}
			if (handler == null)
			{
				StitchSequence(ownerNode, initialOperationSkip);
			}
			return null;
		}

		protected virtual bool IsSupported(IOperation operation)
		{
			if (!(operation is O))
			{
				return operation is ContinuationExport;
			}
			return true;
		}

		protected abstract H GetHandler(IOperation operation);

		public virtual IOperation ExecuteSync(C context)
		{
			throw new InvalidOperationException("Sync execution is not supported on this sequence");
		}

		public virtual Task<IOperation> ExecuteAsync(C context)
		{
			throw new InvalidOperationException("Async execution is not supported on this sequence");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	internal class SyncOperationSequence<C> : OperationSequence<C, ISyncOperation, ExecutionOperationHandler<C>>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public override bool IsAsync => false;

		public SyncOperationSequence(ExecutionRuntime<C> runtime, ISyncOperation origin)
			: base(runtime, origin)
		{
		}

		protected override ExecutionOperationHandler<C> GetHandler(IOperation operation)
		{
			return (ExecutionOperationHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHandler", operation), typeof(ExecutionOperationHandler<C>));
		}

		public override IOperation ExecuteSync(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExecuteSync", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SyncOperationSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IExecutionNestedNode : INestedNode, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IExecutionRuntime TargetRuntime { get; }

		IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context);

		Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context);
	}
	[NodeOverload("Core.Nest")]
	public class NestedNode<C> : VoidNode<C>, IExecutionNestedNode, INestedNode, INode, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		private abstract class InputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(ArgumentList inputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", inputList, output);
			}

			public abstract void SetImport(int index, ExecutionRuntime<C> group, C context, int valueOffset, int objectOffset)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImport", index, group, context, valueOffset, objectOffset);
			}

			public abstract void EvaluateInput(ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateInput", group, context);
			}

			public abstract void SetFromStack(int index, ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetFromStack", index, group, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		private abstract class OutputMapping : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract void Map(OutputList outputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", outputList, output);
			}

			public abstract void ExtractExport(int index, ExecutionRuntime<C> runtime, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractExport", index, runtime, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		private abstract class InputMapping<T> : InputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		private abstract class OutputMapping<T> : OutputMapping, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		private class ValueInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			private IInput<T> input
			{
				get
				{
					return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "input"), typeof(IInput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "input", value);
				}
			}

			private ValueOutput<T> import
			{
				get
				{
					return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "import"), typeof(ValueOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "import", value);
				}
			}

			public override void Map(ArgumentList inputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", inputList, output);
			}

			public override void SetImport(int index, ExecutionRuntime<C> group, C context, int valueOffset, int objectOffset)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImport", index, group, context, valueOffset, objectOffset);
			}

			public override void EvaluateInput(ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateInput", group, context);
			}

			public override void SetFromStack(int index, ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetFromStack", index, group, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public ValueInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private class ObjectInputMapping<T> : InputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private IInput<T> input
			{
				get
				{
					return (IInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "input"), typeof(IInput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "input", value);
				}
			}

			private ObjectOutput<T> import
			{
				get
				{
					return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "import"), typeof(ObjectOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "import", value);
				}
			}

			public override void Map(ArgumentList inputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", inputList, output);
			}

			public override void SetImport(int index, ExecutionRuntime<C> group, C context, int valueOffset, int objectOffset)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImport", index, group, context, valueOffset, objectOffset);
			}

			public override void EvaluateInput(ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EvaluateInput", group, context);
			}

			public override void SetFromStack(int index, ExecutionRuntime<C> group, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetFromStack", index, group, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public ObjectInputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private class ValueOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
		{
			private ValueOutput<T> output
			{
				get
				{
					return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "output"), typeof(ValueOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "output", value);
				}
			}

			private IOutput export
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "export"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "export", value);
				}
			}

			public override void Map(OutputList outputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", outputList, output);
			}

			public override void ExtractExport(int index, ExecutionRuntime<C> runtime, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractExport", index, runtime, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public ValueOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private class ObjectOutputMapping<T> : OutputMapping<T>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private ObjectOutput<T> output
			{
				get
				{
					return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "output"), typeof(ObjectOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "output", value);
				}
			}

			private IOutput export
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "export"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "export", value);
				}
			}

			public override void Map(OutputList outputList, IOutput output)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Map", outputList, output);
			}

			public override void ExtractExport(int index, ExecutionRuntime<C> runtime, C context)
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractExport", index, runtime, context);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public ObjectOutputMapping(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
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
				return (ExecutionRuntime<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Target"), typeof(ExecutionRuntime<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Target", value);
			}
		}

		public ArgumentList Inputs
		{
			get
			{
				return (ArgumentList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Inputs"), typeof(ArgumentList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Inputs", value);
			}
		}

		public OutputList Outputs
		{
			get
			{
				return (OutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Outputs"), typeof(OutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Outputs", value);
			}
		}

		public MixedOperationList Operations
		{
			get
			{
				return (MixedOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Operations"), typeof(MixedOperationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Operations", value);
			}
		}

		public CallList Impulses
		{
			get
			{
				return (CallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Impulses"), typeof(CallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Impulses", value);
			}
		}

		public GlobalRefList GlobalRefs
		{
			get
			{
				return (GlobalRefList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "GlobalRefs"), typeof(GlobalRefList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "GlobalRefs", value);
			}
		}

		private List<InputMapping> _inputMappings
		{
			get
			{
				return (List<InputMapping>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_inputMappings"), typeof(List<InputMapping>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_inputMappings", value);
			}
		}

		private List<OutputMapping> _outputMappings
		{
			get
			{
				return (List<OutputMapping>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputMappings"), typeof(List<OutputMapping>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputMappings", value);
			}
		}

		NodeGroup INestedNode.TargetGroup => Target?.Group;

		NodeRuntime INestedNode.TargetRuntime => Target;

		IExecutionRuntime IExecutionNestedNode.TargetRuntime => Target;

		public override bool CanBeEvaluated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CanBeEvaluated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CanBeEvaluated", value);
			}
		}

		public override bool IsInputConditional(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsInputConditional", index), typeof(bool));
		}

		public IOutput GetTargetExport(IOutput output)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTargetExport", output), typeof(IOutput));
		}

		public IOutput GetImportSource(IOutput import)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImportSource", import), typeof(IOutput));
		}

		public void MapTarget()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapTarget");
		}

		internal void EnterTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnterTargetFrame", context);
		}

		internal void ExitTargetFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExitTargetFrame", context);
		}

		protected IOperation DoOperations(C context, int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DoOperations", context, index), typeof(IOperation));
		}

		protected async Task<IOperation> DoOperationsAsync(C context, int index)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DoOperationsAsync", context, index), typeof(Task<IOperation>));
		}

		private void OnGlobalRefsChanged<T>(int index, T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnGlobalRefsChanged", index, value, context);
		}

		internal void MapGlobals(IGlobalValue[] scopeGlobals, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MapGlobals", scopeGlobals, context);
		}

		private IOperation FinishOperations(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishOperations", context), typeof(IOperation));
		}

		public IOperation ResumeExecution(SyncResumption resumption, ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResumeExecution", resumption, context), typeof(IOperation));
		}

		public async Task<IOperation> ResumeAsyncExecution(AsyncResumption resumption, ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResumeAsyncExecution", resumption, context), typeof(Task<IOperation>));
		}

		internal int DoOnEachNode<T>(ExecutionNodeOperation<T, C> action, C context, bool cache, HashSet<NodeRuntime> walkedRuntimes) where T : INode
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DoOnEachNode", action, context, cache, walkedRuntimes), typeof(int));
		}

		private void OnImpulseExport(ExecutionContext context, int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnImpulseExport", context, index);
		}

		protected override void ComputeOutputs(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		private void EnterNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnterNestedFrame", context);
		}

		private void FinishNestedFrame(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishNestedFrame", context);
		}

		private void ExtractExports(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractExports", context);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public NestedNode()
		{
			((NestedNode<>)(object)this).Inputs = new ArgumentList();
			((NestedNode<>)(object)this).Outputs = new OutputList(this);
			((NestedNode<>)(object)this).Operations = new MixedOperationList(this, 0);
			((NestedNode<>)(object)this).Impulses = new CallList();
			((NestedNode<>)(object)this).GlobalRefs = new GlobalRefList(this, 0);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NestedNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		public AsyncCall OnTriggered;

		protected virtual void BeforeDelay(ExecutionContext context)
		{
		}

		protected abstract TimeSpan GetDuration(ExecutionContext context);

		protected override async Task Do(ExecutionContext context)
		{
			TimeSpan duration = GetDuration(context);
			Task delayTask = Task.Delay(duration);
			BeforeDelay(context);
			await OnTriggered.ExecuteAsync(context);
			await delayTask;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[NodeName("Delay", false)]
	public class DelayTimeSpan : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsInt : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelaySecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsFloat : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelaySecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeName("Delay", false)]
	public class DelaySecondsDouble : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelaySecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeName("Time Delay with Data", false)]
	[NodeOverload("Core.DelayWithData")]
	public abstract class DelayTimeWithValue<T> : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<T> Value;

		public readonly ValueOutput<T> DelayedValue;

		protected override void BeforeDelay(ExecutionContext context)
		{
			DelayedValue.Write(Value.Evaluate(context), context);
		}

		protected DelayTimeWithValue()
		{
			((DelayTimeWithValue<>)(object)this).DelayedValue = new ValueOutput<T>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class DelayWithValueTimeSpan<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithValueTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithValueSecondsInt<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithValueSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithValueSecondsFloat<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithValueSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithValueSecondsDouble<T> : DelayTimeWithValue<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithValueSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeName("Time Delay with Data", false)]
	[NodeOverload("Core.DelayWithData")]
	public abstract class DelayTimeWithObject<T> : DelayTime, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ObjectInput<T> Value;

		public readonly ObjectOutput<T> DelayedValue;

		protected override void BeforeDelay(ExecutionContext context)
		{
			DelayedValue.Write(Value.Evaluate(context), context);
		}

		protected DelayTimeWithObject()
		{
			((DelayTimeWithObject<>)(object)this).DelayedValue = new ObjectOutput<T>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class DelayWithObjectTimeSpan<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<TimeSpan> Duration
		{
			get
			{
				return (ValueInput<TimeSpan>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<TimeSpan>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithObjectTimeSpan(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithObjectSecondsInt<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<int> Duration
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithObjectSecondsInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithObjectSecondsFloat<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Duration
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithObjectSecondsFloat(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DelayWithObjectSecondsDouble<T> : DelayTimeWithObject<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<double> Duration
		{
			get
			{
				return (ValueInput<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Duration"), typeof(ValueInput<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Duration", value);
			}
		}

		protected override TimeSpan GetDuration(ExecutionContext context)
		{
			return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDuration", context), typeof(TimeSpan));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DelayWithObjectSecondsDouble(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		protected override object Compute(ExecutionContext context)
		{
			return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(object));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Box(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectConstant(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuouslyChangingValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuouslyChangingObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public ValueArgument<T> DefaultValue
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DefaultValue"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DefaultValue", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public ValueOutputList<T> ValueOutputs
		{
			get
			{
				return (ValueOutputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ValueOutputs"), typeof(ValueOutputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ValueOutputs", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		public ValueDemultiplex()
		{
			((ValueDemultiplex<>)(object)this).ValueOutputs = new ValueOutputList<T>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public ObjectArgument<T> DefaultValue
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DefaultValue"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DefaultValue", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public ObjectOutputList<T> ValueOutputs
		{
			get
			{
				return (ObjectOutputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ValueOutputs"), typeof(ObjectOutputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ValueOutputs", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		public ObjectDemultiplex()
		{
			((ObjectDemultiplex<>)(object)this).ValueOutputs = new ObjectOutputList<T>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectDemultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectEvaluationPoint(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public DisplayHandler<C, T> OnDisplay
		{
			get
			{
				return (DisplayHandler<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnDisplay", value);
			}
		}

		public bool InputListensToChanges
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InputListensToChanges"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Changed", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalValueDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public DisplayHandler<C, T> OnDisplay
		{
			get
			{
				return (DisplayHandler<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnDisplay"), typeof(DisplayHandler<C, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnDisplay", value);
			}
		}

		public bool InputListensToChanges
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InputListensToChanges"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InputListensToChanges", value);
			}
		}

		public void Changed(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Changed", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalObjectDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ImpulseDisplayHandler<C>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnPulsed"), typeof(ImpulseDisplayHandler<C>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnPulsed", value);
			}
		}

		protected override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ExternalImpulseDisplay : ExternalImpulseDisplay<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalImpulseDisplay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_changeListeners", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		public void AddedToScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddedToScope", context);
		}

		public void RemovedFromScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemovedFromScope", context);
		}

		public void SetValue(T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValue", value);
		}

		protected override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_changeListeners"), typeof(Dictionary<NodeContextPath, ExecutionChangesDispatcher<C>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_changeListeners", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		public void AddedToScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddedToScope", context);
		}

		public void RemovedFromScope(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemovedFromScope", context);
		}

		public void SetValue(T value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetValue", value);
		}

		protected override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Func<T, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Filter"), typeof(Func<T, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Filter", value);
			}
		}

		protected override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalValueInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Func<T, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Filter"), typeof(Func<T, T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Filter", value);
			}
		}

		protected override T Compute(C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalObjectInputWithFilter(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Target"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Target", value);
			}
		}

		public void Execute(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Target"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Target", value);
			}
		}

		public Task Execute(C context)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Execute", context), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ExternalAsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Count"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Count", value);
			}
		}

		public ValueInput<bool> Reverse
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Reverse"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Reverse", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Iteration
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Iteration"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Iteration", value);
			}
		}

		public override bool CanBeEvaluated => false;

		protected override async Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncFor()
		{
			Iteration = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncFor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Start"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Start", value);
			}
		}

		public ValueInput<int> End
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "End"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "End", value);
			}
		}

		public ValueInput<int> StepSize
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "StepSize"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "StepSize", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Current
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Current"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Current", value);
			}
		}

		public override bool CanBeEvaluated => false;

		protected override async Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncRangeLoopInt()
		{
			Current = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncRangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (AsyncCallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Calls"), typeof(AsyncCallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Calls", value);
			}
		}

		protected override async Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public AsyncSequence()
		{
			Calls = new AsyncCallList();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncSequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		public AsyncCall LoopStart
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public AsyncCall LoopIteration
		{
			get
			{
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		protected override async Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncWhile(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Count"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Count", value);
			}
		}

		public ValueInput<bool> Reverse
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Reverse"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Reverse", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Iteration
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Iteration"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Iteration", value);
			}
		}

		public override bool CanBeEvaluated => false;

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		public For()
		{
			Iteration = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public For(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTrue"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTrue", value);
			}
		}

		public Continuation OnFalse
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFalse"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFalse", value);
			}
		}

		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public If(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeCategory("Flow")]
	public class ImpulseDemultiplexer : VoidNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SyncOperationList Operations
		{
			get
			{
				return (SyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Operations"), typeof(SyncOperationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Operations", value);
			}
		}

		public Continuation OnTriggered
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTriggered"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTriggered", value);
			}
		}

		public ValueOutput<int> Index
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public override bool CanBeEvaluated => false;

		public IOperation DoOperations(ExecutionContext context, int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DoOperations", context, index), typeof(IOperation));
		}

		public ImpulseDemultiplexer()
		{
			Operations = new SyncOperationList(this, 0);
			Index = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseDemultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public ContinuationList Impulses
		{
			get
			{
				return (ContinuationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Impulses"), typeof(ContinuationList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Impulses", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		public ImpulseMultiplexer()
		{
			Impulses = new ContinuationList();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseMultiplexer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Start"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Start", value);
			}
		}

		public ValueInput<int> End
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "End"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "End", value);
			}
		}

		public ValueInput<int> StepSize
		{
			get
			{
				return (ValueInput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "StepSize"), typeof(ValueInput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "StepSize", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		public ValueOutput<int> Current
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Current"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Current", value);
			}
		}

		public override bool CanBeEvaluated => false;

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		public RangeLoopInt()
		{
			Current = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public RangeLoopInt(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (CallList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Calls"), typeof(CallList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Calls", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		public Sequence()
		{
			Calls = new CallList();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		public Call LoopStart
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopStart"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopStart", value);
			}
		}

		public Call LoopIteration
		{
			get
			{
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopIteration"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopIteration", value);
			}
		}

		public Continuation LoopEnd
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopEnd"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopEnd", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public While(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Object"), typeof(ObjectArgument<object>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Object", value);
			}
		}

		protected override Type Compute(ExecutionContext context)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(Type));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GetType(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnGlobalChanged", value, context);
		}

		public GlobalToValueOutput()
		{
			((GlobalToValueOutput<>)(object)this).Global = new GlobalRef<T>(this, 0);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalToValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Global", value);
			}
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private void OnGlobalChanged(T value, ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnGlobalChanged", value, context);
		}

		public GlobalToObjectOutput()
		{
			((GlobalToObjectOutput<>)(object)this).Global = new GlobalRef<T>(this, 0);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalToObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Reference<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(Reference<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public Reference<INode> B
		{
			get
			{
				return (Reference<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(Reference<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Link(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueLocal<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_data"), typeof(ValueLocal<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocalValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectLocal<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_data"), typeof(ObjectLocal<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocalObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Inputs"), typeof(ValueInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Inputs", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public ValueOutput<T> Output
		{
			get
			{
				return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public new ValueOutput<int> InputCount
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "InputCount"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "InputCount", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		public ValueMultiplex()
		{
			((ValueMultiplex<>)(object)this).Inputs = new ValueInputList<T>();
			((ValueMultiplex<>)(object)this).Output = new ValueOutput<T>(this);
			((ValueMultiplex<>)(object)this).InputCount = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Inputs"), typeof(ObjectInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Inputs", value);
			}
		}

		public ValueArgument<int> Index
		{
			get
			{
				return (ValueArgument<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Index"), typeof(ValueArgument<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Index", value);
			}
		}

		public ObjectOutput<T> Output
		{
			get
			{
				return (ObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public new ValueOutput<int> InputCount
		{
			get
			{
				return (ValueOutput<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "InputCount"), typeof(ValueOutput<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "InputCount", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		public ObjectMultiplex()
		{
			((ObjectMultiplex<>)(object)this).Inputs = new ObjectInputList<T>();
			((ObjectMultiplex<>)(object)this).Output = new ObjectOutput<T>(this);
			((ObjectMultiplex<>)(object)this).InputCount = new ValueOutput<int>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectMultiplex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public ValueArgument<bool> HasValue
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "HasValue"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "HasValue", value);
			}
		}

		protected override T? Compute(ExecutionContext context)
		{
			return (T?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T?));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Nullable"), typeof(ObjectArgument<T?>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Nullable", value);
			}
		}

		public ValueOutput<T> Value
		{
			get
			{
				return (ValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public ValueOutput<bool> HasValue
		{
			get
			{
				return (ValueOutput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "HasValue"), typeof(ValueOutput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "HasValue", value);
			}
		}

		protected override void ComputeOutputs(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeOutputs", context);
		}

		public UnpackNullable()
		{
			((UnpackNullable<>)(object)this).Value = new ValueOutput<T>(this);
			((UnpackNullable<>)(object)this).HasValue = new ValueOutput<bool>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnpackNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTrue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTrue", value);
			}
		}

		public ValueInput<T> OnFalse
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFalse"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFalse", value);
			}
		}

		public ValueArgument<bool> Condition
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTrue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTrue", value);
			}
		}

		public ObjectInput<T> OnFalse
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFalse"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFalse", value);
			}
		}

		public ValueArgument<bool> Condition
		{
			get
			{
				return (ValueArgument<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueArgument<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectConditional(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ValueArgument<T> B
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ObjectArgument<T> B
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Instance"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Instance", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public IsNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Instance"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Instance", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NotNull(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ValueArgument<T> B
		{
			get
			{
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ObjectArgument<T> B
		{
			get
			{
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		protected override bool Compute(ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectNotEquals(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ObjectInput<T> B
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInputList<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Operands"), typeof(ObjectInputList<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Operands", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		public MultiNullCoalesce()
		{
			((MultiNullCoalesce<>)(object)this).Operands = new ObjectInputList<T>();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MultiNullCoalesce(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Reference<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Reference"), typeof(Reference<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Reference", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ReferenceToOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectArgument<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeCategory("Core")]
	[NodeName("Continuation Relay", false)]
	[NodeOverload("Core.ContinuationRelay")]
	public class ContinuationRelay : ActionFlowNode<ExecutionContext>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		protected override void Do(ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Do", context);
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>));
		}

		public override bool IsOperationPassthrough(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationPassthrough", index), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuationRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Call)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTriggered"), typeof(Call));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTriggered", value);
			}
		}

		protected override IOperation Run(ExecutionContext context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		public override ExecutionOperationHandler<T> GetHandler<T>()
		{
			return (ExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHandler"), typeof(ExecutionOperationHandler<T>));
		}

		public override bool IsOperationPassthrough(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationPassthrough", index), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (AsyncCall)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTriggered"), typeof(AsyncCall));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTriggered", value);
			}
		}

		protected override Task<IOperation> RunAsync(ExecutionContext context)
		{
			return (Task<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RunAsync", context), typeof(Task<IOperation>));
		}

		public override AsyncExecutionOperationHandler<T> GetAsyncHandler<T>()
		{
			return (AsyncExecutionOperationHandler<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAsyncHandler"), typeof(AsyncExecutionOperationHandler<T>));
		}

		public override bool IsOperationPassthrough(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationPassthrough", index), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncCallRelay(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueStore<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_data"), typeof(ValueStore<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StoredValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectStore<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_data"), typeof(ObjectStore<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_data", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		public T Read(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public bool Write(T value, ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StoredObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectArgument<object>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		protected override T Compute(ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Unbox(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class WriteBase<C, T> : ActionNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnWritten;

		public Continuation OnFail;

		protected abstract IVariable<C, T> GetVariable(C context);

		protected abstract T GetValue(IVariable<C, T> variable, C context);

		protected override IOperation Run(C context)
		{
			IVariable<C, T> variable = GetVariable(context);
			if (variable != null && variable.Write(GetValue(variable, context), context))
			{
				return OnWritten.Target;
			}
			return OnFail.Target;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
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
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		protected sealed override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected sealed override T GetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueWrite<T> : ValueWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectWrite<T> : ObjectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueIndirectWrite<T> : ValueIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectIndirectWrite<T> : ObjectIndirectWrite<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectIndirectWrite(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Global", value);
			}
		}

		public ValueInput<T> Value
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public Continuation OnWritten
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnWritten"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnWritten", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFail", value);
			}
		}

		protected override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnGlobalChanged", value, context);
		}

		public WriteValueToGlobal()
		{
			((WriteValueToGlobal<, >)(object)this).Global = new GlobalRef<T>(this, 0);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public WriteValueToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (GlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Global"), typeof(GlobalRef<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Global", value);
			}
		}

		public ObjectInput<T> Value
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Value"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Value", value);
			}
		}

		public Continuation OnWritten
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnWritten"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnWritten", value);
			}
		}

		public Continuation OnFail
		{
			get
			{
				return (Continuation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFail"), typeof(Continuation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFail", value);
			}
		}

		protected override IOperation Run(C context)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Run", context), typeof(IOperation));
		}

		private void OnGlobalChanged(T value, C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnGlobalChanged", value, context);
		}

		public WriteObjectToGlobal()
		{
			((WriteObjectToGlobal<, >)(object)this).Global = new GlobalRef<T>(this, 0);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public WriteObjectToGlobal(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class WriteLatchBase<C, T> : VoidNode<C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ExecutionContext
	{
		public Continuation OnSet;

		public Continuation OnReset;

		public Continuation OnFail;

		[PossibleContinuations(new string[] { "OnSet", "OnFail" })]
		public readonly Operation Set;

		[PossibleContinuations(new string[] { "OnReset", "OnFail" })]
		public readonly Operation Reset;

		public IOperation DoSet(C context)
		{
			IVariable<C, T> variable = GetVariable(context);
			if (variable != null && variable.Write(GetSetValue(variable, context), context))
			{
				return OnSet.Target;
			}
			return OnFail.Target;
		}

		public IOperation DoReset(C context)
		{
			IVariable<C, T> variable = GetVariable(context);
			if (variable != null && variable.Write(GetResetValue(variable, context), context))
			{
				return OnReset.Target;
			}
			return OnFail.Target;
		}

		protected abstract IVariable<C, T> GetVariable(C context);

		protected abstract T GetSetValue(IVariable<C, T> variable, C context);

		protected abstract T GetResetValue(IVariable<C, T> variable, C context);

		protected WriteLatchBase()
		{
			((WriteLatchBase<, >)(object)this).Set = new Operation(this, 0);
			((WriteLatchBase<, >)(object)this).Reset = new Operation(this, 1);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
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
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ValueInput<T> SetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SetValue", value);
			}
		}

		public ValueInput<T> ResetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ResetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSetValue", variable, context), typeof(T));
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetResetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (Reference<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(Reference<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> SetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SetValue", value);
			}
		}

		public ObjectInput<T> ResetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ResetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSetValue", variable, context), typeof(T));
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetResetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ValueInput<T> SetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SetValue", value);
			}
		}

		public ValueInput<T> ResetValue
		{
			get
			{
				return (ValueInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ResetValue"), typeof(ValueInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSetValue", variable, context), typeof(T));
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetResetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectInput<IVariable<C, T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Variable"), typeof(ObjectInput<IVariable<C, T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Variable", value);
			}
		}

		public ObjectInput<T> SetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SetValue", value);
			}
		}

		public ObjectInput<T> ResetValue
		{
			get
			{
				return (ObjectInput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ResetValue"), typeof(ObjectInput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ResetValue", value);
			}
		}

		protected override IVariable<C, T> GetVariable(C context)
		{
			return (IVariable<C, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", context), typeof(IVariable<C, T>));
		}

		protected override T GetSetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSetValue", variable, context), typeof(T));
		}

		protected override T GetResetValue(IVariable<C, T> variable, C context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetResetValue", variable, context), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueWriteLatch<T> : ValueWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectWriteLatch<T> : ObjectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueIndirectWriteLatch<T> : ValueIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectIndirectWriteLatch<T> : ObjectIndirectWriteLatch<ExecutionContext, T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectIndirectWriteLatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.Execution.Nodes.Casts
{
	[NodeCategory("Core/Casts")]
	[NodeOverload("Core.ValueCast")]
	public abstract class ValueCast<I, O> : ValueFunctionNode<ExecutionContext, O>, ICast, INode, ResoniteBridge.ResoniteBridgeValueHolder where I : struct where O : struct
	{
		public ValueArgument<I> Input;

		public override bool IsPassthrough => true;

		public Type InputType => typeof(I);

		public bool IsImplicit => TypeHelper.CanImplicitlyConvertTo(InputType, base.OutputType);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
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
				return (ObjectArgument<I>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectArgument<I>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		public Type InputType => typeof(I);

		public bool IsImplicit => TypeHelper.CanImplicitlyConvertTo(InputType, base.OutputType);

		protected override O Compute(ExecutionContext context)
		{
			return (O)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(O));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ObjectArgument<I?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ObjectArgument<I?>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public bool IsImplicit => true;

		public Type InputType => typeof(I?);

		protected override object Compute(ExecutionContext context)
		{
			return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(object));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NullableToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueArgument<I>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueArgument<I>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public override bool IsPassthrough => true;

		public bool IsImplicit => true;

		public Type InputType => typeof(I);

		protected override object Compute(ExecutionContext context)
		{
			return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Compute", context), typeof(object));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueToObjectCast(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.DSP
{
	public abstract class DSP_Action<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private List<DSP_Dependency<TSequence>> _dependencies;

		public TNode Node { get; private set; }

		public int InputIndex { get; private set; } = -1;


		public int OutputIndex { get; private set; } = -1;


		public DSP_Action(TNode node)
		{
			Node = node;
		}

		public void MapInputOutput(int inputIndex, int outputIndex)
		{
			InputIndex = inputIndex;
			OutputIndex = outputIndex;
		}

		public void Execute(TContext context, TAction next)
		{
			Node.Process(context);
			TSequence val = null;
			if (_dependencies != null)
			{
				for (int i = 0; i < _dependencies.Count; i++)
				{
					DSP_Dependency<TSequence> dSP_Dependency = _dependencies[i];
					TBuffer buffer = context.GetOutputBuffer(dSP_Dependency.outputIndex);
					bool flag = true;
					if (next != null && next.OutputIndex == dSP_Dependency.outputIndex)
					{
						flag = false;
					}
					else
					{
						for (int j = i + 1; j < _dependencies.Count; j++)
						{
							if (_dependencies[i].outputIndex == dSP_Dependency.outputIndex)
							{
								flag = false;
								break;
							}
						}
					}
					if (!flag)
					{
						buffer = context.CloneBuffer(buffer);
					}
					else
					{
						context.ClearOutputBuffer(dSP_Dependency.outputIndex);
					}
					if (dSP_Dependency.IsResultDependency)
					{
						context.SetResult(dSP_Dependency.inputIndex, buffer);
					}
					else if (dSP_Dependency.sequence.SetDependency(dSP_Dependency.inputIndex, buffer))
					{
						if (val != null || next != null)
						{
							dSP_Dependency.sequence.ScheduleRun(context.CloneContext());
						}
						else
						{
							val = dSP_Dependency.sequence;
						}
					}
				}
			}
			if (next != null)
			{
				context.RemapBuffersAndRecycle(next.OutputIndex, next.InputIndex);
			}
			else if (val != null)
			{
				context.RecycleBuffers();
				val.RunSequence(context);
			}
			else
			{
				context.RecycleContext();
			}
		}

		public void RequestResultDependency(int outputIndex, int resultIndex)
		{
			RequestDepedency(null, resultIndex, outputIndex);
		}

		public void RequestDepedency(TSequence sequence, int inputIndex, int outputIndex)
		{
			if (_dependencies == null)
			{
				_dependencies = new List<DSP_Dependency<TSequence>>();
			}
			_dependencies.Add(new DSP_Dependency<TSequence>(sequence, inputIndex, outputIndex));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
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
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class DSP_BuildContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ProtoFlux.Runtimes.Execution.ExecutionContext ExecutionContext { get; protected set; }

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class DSP_BuildContext<TNode, TSequence, TContext, TBuffer, TAction> : DSP_BuildContext, ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction>, new() where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private Dictionary<TNode, TSequence> nodes = new Dictionary<TNode, TSequence>();

		private List<TSequence> rootSequences = new List<TSequence>();

		private TaskCompletionSource<bool> completion;

		private DSP_ResultHandler<TBuffer> resultHandler;

		private int outputCount;

		private int remainingOutputs;

		public Dictionary<TNode, TSequence>.KeyCollection CollectedNodes => nodes.Keys;

		public void Collect(List<IOutput> outputs, ProtoFlux.Runtimes.Execution.ExecutionContext executionContext)
		{
			try
			{
				base.ExecutionContext = executionContext;
				for (int i = 0; i < outputs.Count; i++)
				{
					if (!(outputs[i].OwnerNode is TNode val))
					{
						throw new ArgumentException($"Output's owner node isn't node of type {typeof(TNode)}");
					}
					if (!nodes.TryGetValue(val, out var value))
					{
						value = Collect(val);
					}
					value.RegisterResultDependency(outputs[i], i);
				}
				outputCount = outputs.Count;
			}
			finally
			{
				base.ExecutionContext = null;
			}
		}

		private TSequence Collect(TNode node)
		{
			if (nodes.TryGetValue(node, out var value))
			{
				return value;
			}
			TSequence lastSequence = null;
			int lastSequenceInputIndex = -1;
			IOutput lastSequenceOutput = null;
			bool createdNewSequence = false;
			Span<bool> mask = stackalloc bool[node.InputBufferCount];
			node.Collect(this, mask);
			for (int i = 0; i < node.InputBufferCount; i++)
			{
				if (node.IsInputBufferConditional(i) && !mask[i])
				{
					continue;
				}
				IOutput inputBufferSource = node.GetInputBufferSource(i);
				if (inputBufferSource != null)
				{
					if (!(inputBufferSource.OwnerNode is TNode node2))
					{
						throw new ArgumentException($"Output's owner node isn't node of type {typeof(TNode)}");
					}
					AddSequence(Collect(node2), inputBufferSource, i);
				}
			}
			if (lastSequence == null)
			{
				createdNewSequence = true;
				lastSequence = new TSequence();
				rootSequences.Add(lastSequence);
			}
			if (createdNewSequence)
			{
				lastSequence.AddStep(node);
			}
			else
			{
				int outputIndex = lastSequenceOutput.FindLinearOutputIndex();
				lastSequence.AddStep(node, lastSequenceInputIndex, outputIndex);
			}
			nodes.Add(node, lastSequence);
			return lastSequence;
			void AddSequence(TSequence sequence, IOutput output, int inputIndex)
			{
				if (createdNewSequence || output.OwnerNode != sequence.LastNode || lastSequence != null)
				{
					if (!createdNewSequence)
					{
						createdNewSequence = true;
						TSequence val = new TSequence();
						if (lastSequence != null)
						{
							lastSequence.RegisterDependency(lastSequenceOutput, lastSequenceInputIndex, val);
						}
						lastSequence = val;
					}
					sequence.RegisterDependency(output, inputIndex, lastSequence);
				}
				else
				{
					lastSequence = sequence;
					lastSequenceInputIndex = inputIndex;
					lastSequenceOutput = output;
				}
			}
		}

		public async Task Execute(TContext context)
		{
			remainingOutputs = outputCount;
			completion = new TaskCompletionSource<bool>();
			resultHandler = context.ResultHandler;
			context.ResultHandler = HandleResult;
			try
			{
				foreach (TSequence rootSequence in rootSequences)
				{
					rootSequence.ScheduleRun(context.CloneContext());
				}
				await completion.Task.ConfigureAwait(continueOnCapturedContext: false);
			}
			finally
			{
				context.ResultHandler = resultHandler;
			}
		}

		private void HandleResult(int index, TBuffer buffer)
		{
			try
			{
				resultHandler?.Invoke(index, buffer);
			}
			finally
			{
				if (Interlocked.Decrement(ref remainingOutputs) == 0)
				{
					completion.SetResult(result: true);
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
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

		public static void Collect<T>(this int input, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_BuildContextHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Collect", input, mask);
		}
	}
	public delegate void DSP_ResultHandler<B>(int resultIndex, B buffer) where B : DSP_Buffer;
	public abstract class DSP_Context<B, C> : ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		private List<B> inputBuffers = new List<B>();

		private List<B> outputBuffers = new List<B>();

		private List<int> sharedOutputBuffers = new List<int>();

		public ProtoFlux.Runtimes.Execution.ExecutionContext ExecutionContext { get; set; }

		public DSP_ResultHandler<B> ResultHandler { get; set; }

		internal void SetResult(int resultIndex, B buffer)
		{
			ResultHandler(resultIndex, buffer);
		}

		public B GetInputBuffer(int index)
		{
			return inputBuffers[index];
		}

		public B GetOutputBuffer(int index)
		{
			return outputBuffers[index];
		}

		public B TryGetInputBuffer(int index)
		{
			if (inputBuffers.Count <= index)
			{
				return null;
			}
			return inputBuffers[index];
		}

		public B TryGetOutputBuffer(int index)
		{
			if (outputBuffers.Count <= index)
			{
				return null;
			}
			return outputBuffers[index];
		}

		public B TryGetOutputBufferOrReuseInput(int index, Predicate<B> filter)
		{
			B val = TryGetOutputBuffer(index);
			if (val != null)
			{
				return val;
			}
			for (int i = 0; i < inputBuffers.Count; i++)
			{
				val = inputBuffers[i];
				if (val == null || !filter(val))
				{
					continue;
				}
				bool flag = false;
				for (int j = 0; j < outputBuffers.Count; j++)
				{
					if (val == outputBuffers[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					SetOutputBuffer(index, val);
					while (sharedOutputBuffers.Count <= index)
					{
						sharedOutputBuffers.Add(-1);
					}
					sharedOutputBuffers[index] = i;
					return val;
				}
			}
			return null;
		}

		public void SetOutputBuffer(int index, B buffer)
		{
			EnsureOutputBufferCountForIndex(index);
			outputBuffers[index] = buffer;
		}

		public void MapInputBuffers(List<B> buffers)
		{
			if (inputBuffers.Count > 0)
			{
				throw new InvalidOperationException("Input buffers are already mapped, cannot map new set");
			}
			foreach (B buffer in buffers)
			{
				inputBuffers.Add(buffer);
			}
		}

		public void RemapBuffersAndRecycle(int outputIndex, int inputIndex)
		{
			B val = outputBuffers[outputIndex];
			for (int i = 0; i < inputBuffers.Count; i++)
			{
				B val2 = inputBuffers[i];
				if (val2 != null && val2 != val)
				{
					RecycleBuffer(inputBuffers[i]);
				}
				inputBuffers[i] = null;
			}
			for (int j = 0; j < outputBuffers.Count; j++)
			{
				B val3 = outputBuffers[j];
				if (val3 != null && val3 != val)
				{
					RecycleBuffer(outputBuffers[j]);
				}
				outputBuffers[j] = null;
			}
			EnsureInputBufferCountForIndex(inputIndex);
			EnsureOutputBufferCountForIndex(outputIndex);
			sharedOutputBuffers.Clear();
			inputBuffers[inputIndex] = val;
		}

		public void RecycleBuffers()
		{
			for (int i = 0; i < inputBuffers.Count; i++)
			{
				if (inputBuffers[i] != null)
				{
					RecycleBuffer(inputBuffers[i]);
				}
			}
			for (int j = 0; j < outputBuffers.Count; j++)
			{
				if (outputBuffers[j] != null)
				{
					RecycleBuffer(outputBuffers[j]);
				}
			}
			inputBuffers.Clear();
			outputBuffers.Clear();
			sharedOutputBuffers.Clear();
		}

		public void ClearOutputBuffer(int index)
		{
			if (sharedOutputBuffers.Count > index && sharedOutputBuffers[index] >= 0)
			{
				inputBuffers[sharedOutputBuffers[index]] = null;
				sharedOutputBuffers[index] = -1;
			}
			outputBuffers[index] = null;
		}

		public abstract void EnqueueTask(Action<C> task);

		public C CloneContext()
		{
			C val = CloneSelf();
			val.ExecutionContext = ExecutionContext;
			val.ResultHandler = ResultHandler;
			return val;
		}

		public virtual void RecycleContext()
		{
			RecycleBuffers();
			ExecutionContext = null;
			ResultHandler = null;
		}

		public abstract B CloneBuffer(B buffer);

		protected abstract void RecycleBuffer(B buffer);

		protected abstract C CloneSelf();

		private void EnsureInputBufferCountForIndex(int index)
		{
			EnsureBufferCountForIndex(inputBuffers, index);
		}

		private void EnsureOutputBufferCountForIndex(int index)
		{
			EnsureBufferCountForIndex(outputBuffers, index);
		}

		private void EnsureBufferCountForIndex(List<B> list, int index)
		{
			while (list.Count > index)
			{
				list.RemoveAt(list.Count - 1);
			}
			while (list.Count <= index)
			{
				list.Add(null);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	internal struct DSP_Dependency<TSequence> : ResoniteBridge.ResoniteBridgeValueHolder where TSequence : class
	{
		public TSequence sequence
		{
			get
			{
				return (TSequence)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "sequence"), typeof(TSequence));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "sequence", value);
			}
		}

		public int inputIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "inputIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "inputIndex", value);
			}
		}

		public int outputIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "outputIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "outputIndex", value);
			}
		}

		public bool IsResultDependency => sequence == null;

		public DSP_Dependency(TSequence sequence, int inputIndex, int outputIndex)
		{
			this.sequence = sequence;
			this.inputIndex = inputIndex;
			this.outputIndex = outputIndex;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Dependency(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class DSP_MetadataHelper
	{
		private static ConcurrentDictionary<Type, DSP_NodeMetadata> _metadataCache
		{
			get
			{
				return (ConcurrentDictionary<Type, DSP_NodeMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ConcurrentDictionary<Type, DSP_NodeMetadata>));
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

		public static bool IsDSP(InputMetadataBase input)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", input), typeof(bool));
		}

		public static bool IsDSP(OutputMetadataBase output)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_MetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDSP", output), typeof(bool));
		}
	}
	public abstract class DSP_Node<B, C> : Node, IDSP_Node<B, C>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		public virtual DSP_NodeMetadata DSP_Metadata => DSP_MetadataHelper.GetMetadata(GetType());

		public bool HasExecutionEntryPoints => DSP_Metadata.HasExecutionEntryPoints;

		public int InputBufferCount
		{
			get
			{
				DSP_NodeMetadata dSP_Metadata = DSP_Metadata;
				if (dSP_Metadata.DynamicBufferInputCount == 0)
				{
					return dSP_Metadata.FixedBufferInputCount;
				}
				int num = dSP_Metadata.FixedBufferInputCount;
				for (int i = 0; i < dSP_Metadata.DynamicBufferInputCount; i++)
				{
					int index = BaseInputListIndex(i);
					IInputList inputList = GetInputList(index);
					num += inputList.Count;
				}
				return num;
			}
		}

		public int OutputBufferCount
		{
			get
			{
				DSP_NodeMetadata dSP_Metadata = DSP_Metadata;
				if (dSP_Metadata.DynamicBufferOutputCount == 0)
				{
					return dSP_Metadata.FixedBufferOutputCount;
				}
				int num = dSP_Metadata.FixedBufferOutputCount;
				for (int i = 0; i < dSP_Metadata.DynamicBufferOutputCount; i++)
				{
					int index = BaseOutputListIndex(i);
					IOutputList outputList = GetOutputList(index);
					num += outputList.Count;
				}
				return num;
			}
		}

		private int BaseInputIndex(int index)
		{
			return DSP_Metadata.FixedBufferInputs[index].Index;
		}

		private int BaseOutputIndex(int index)
		{
			return DSP_Metadata.FixedBufferOutputs[index].Index;
		}

		private int BaseInputListIndex(int index)
		{
			return DSP_Metadata.DynamicBufferInputs[index].Index;
		}

		private int BaseOutputListIndex(int index)
		{
			return DSP_Metadata.DynamicBufferOutputs[index].Index;
		}

		private IInputList ConvertInputIndex(ref int index, out int listIndex)
		{
			if (index < FixedInputCount)
			{
				index = BaseInputIndex(index);
				listIndex = -1;
				return null;
			}
			index -= FixedInputCount;
			DSP_NodeMetadata dSP_Metadata = DSP_Metadata;
			for (int i = 0; i < dSP_Metadata.DynamicBufferInputCount; i++)
			{
				IInputList inputList = GetInputList(BaseInputListIndex(i));
				if (index < inputList.Count)
				{
					listIndex = i;
					return inputList;
				}
				index -= inputList.Count;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		private IInputList GetOutputList(ref int index, out int listIndex)
		{
			if (index < FixedInputCount)
			{
				index = BaseOutputIndex(index);
				listIndex = -1;
				return null;
			}
			index -= FixedInputCount;
			DSP_NodeMetadata dSP_Metadata = DSP_Metadata;
			for (int i = 0; i < dSP_Metadata.DynamicBufferInputCount; i++)
			{
				IInputList inputList = GetInputList(BaseInputListIndex(i));
				if (index < inputList.Count)
				{
					listIndex = i;
					return inputList;
				}
				index -= inputList.Count;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		public abstract void Collect(DSP_BuildContext context, Span<bool> mask);

		public IOutput GetInputBufferSource(int index)
		{
			int listIndex;
			IInputList inputList = ConvertInputIndex(ref index, out listIndex);
			if (inputList == null)
			{
				return GetInputSource(index);
			}
			return inputList.GetInputSource(index);
		}

		public bool IsInputBufferConditional(int index)
		{
			ConvertInputIndex(ref index, out var listIndex);
			if (listIndex < 0)
			{
				return IsInputConditional(index);
			}
			return Metadata.DynamicInputs[listIndex].IsConditional;
		}

		public abstract void Process(C context);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class DSP_Runtime<TNode, TContext, TBuffer, TBuildContext, TSequence, TAction, TExecutionContext> : NodeRuntime<TNode>, IExecutionRuntimeInterop, ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TBuildContext : DSP_BuildContext<TNode, TSequence, TContext, TBuffer, TAction>, new() where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction>, new() where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction> where TExecutionContext : ProtoFlux.Runtimes.Execution.ExecutionContext
	{
		public ExecutionRuntime<TExecutionContext> ExecutionRuntime { get; set; }

		public bool InputNodesMustBeLocal => true;

		public async Task<TBuffer> Process(IOutput output, TContext context)
		{
			TBuffer result = null;
			context.ResultHandler = delegate(int index, TBuffer buffer)
			{
				result = buffer;
			};
			await Process(new List<IOutput> { output }, context).ConfigureAwait(continueOnCapturedContext: false);
			return result;
		}

		public async Task Process(List<IOutput> outputs, TContext context)
		{
			TBuildContext val = new TBuildContext();
			TExecutionContext context2 = (TExecutionContext)context.ExecutionContext;
			ExecutionRuntime.BeginStackFrame(context2);
			val.Collect(outputs, context.ExecutionContext);
			foreach (TNode collectedNode in val.CollectedNodes)
			{
				if (!collectedNode.HasExecutionEntryPoints)
				{
					continue;
				}
				NodeMetadata metadata = collectedNode.Metadata;
				for (int i = 0; i < metadata.FixedInputCount; i++)
				{
					if (metadata.FixedInputs[i].CrossRuntime is ExecutionInputAttribute)
					{
						IOutput inputSource = collectedNode.GetInputSource(i);
						if (inputSource != null)
						{
							ExecutionRuntime.EnsureEvaluated(inputSource, context2);
						}
					}
				}
				for (int j = 0; j < metadata.DynamicInputCount; j++)
				{
					if (!(metadata.DynamicInputs[j].CrossRuntime is ExecutionInputAttribute))
					{
						continue;
					}
					IInputList inputList = collectedNode.GetInputList(j);
					for (int k = 0; k < inputList.Count; k++)
					{
						IOutput inputSource2 = inputList.GetInputSource(k);
						if (inputSource2 != null)
						{
							ExecutionRuntime.EnsureEvaluated(inputSource2, context2);
						}
					}
				}
			}
			await val.Execute(context).ConfigureAwait(continueOnCapturedContext: false);
			ExecutionRuntime.EndStackFrame((TExecutionContext)context.ExecutionContext);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> : ResoniteBridge.ResoniteBridgeValueHolder where TNode : class, IDSP_Node<TBuffer, TContext> where TSequence : DSP_Sequence<TNode, TSequence, TContext, TBuffer, TAction> where TContext : DSP_Context<TBuffer, TContext> where TBuffer : DSP_Buffer where TAction : DSP_Action<TNode, TSequence, TContext, TBuffer, TAction>
	{
		private List<TAction> _actions = new List<TAction>();

		private List<TBuffer> _dependencyBuffers = new List<TBuffer>();

		private int _missingDependencies;

		public TNode LastNode
		{
			get
			{
				if (_actions.Count == 0)
				{
					return null;
				}
				return _actions[_actions.Count - 1].Node;
			}
		}

		internal void AllocateDependency(int inputIndex)
		{
			while (_dependencyBuffers.Count <= inputIndex)
			{
				_dependencyBuffers.Add(null);
			}
			_missingDependencies++;
		}

		internal bool SetDependency(int inputIndex, TBuffer buffer)
		{
			_dependencyBuffers[inputIndex] = buffer;
			return Interlocked.Decrement(ref _missingDependencies) == 0;
		}

		internal void AddStep(TNode node)
		{
			if (_actions.Count > 0)
			{
				throw new InvalidOperationException("Node without input and output index mapping can be only added when it's first in the sequence");
			}
			AddStep(node, -1, -1);
		}

		internal void AddStep(IDSP_Node node, int inputIndex, int outputIndex)
		{
			TAction val = CreateAction(node);
			val.MapInputOutput(inputIndex, outputIndex);
			_actions.Add(val);
		}

		protected abstract TAction CreateAction(IDSP_Node node);

		internal void RegisterDependency(IOutput output, int inputIndex, TSequence targetSequence)
		{
			TAction val = FindAction(output);
			targetSequence.AllocateDependency(inputIndex);
			int outputIndex = output.FindLinearOutputIndex();
			val.RequestDepedency(targetSequence, inputIndex, outputIndex);
		}

		internal void RegisterResultDependency(IOutput output, int resultIndex)
		{
			TAction val = FindAction(output);
			int outputIndex = output.FindLinearOutputIndex();
			val.RequestResultDependency(outputIndex, resultIndex);
		}

		internal TAction FindAction(IOutput output)
		{
			if (!(output.OwnerNode is TNode val))
			{
				throw new ArgumentException($"Output's owner node isn't node of type {typeof(TNode)}");
			}
			for (int num = _actions.Count - 1; num >= 0; num--)
			{
				if (_actions[num].Node == val)
				{
					return _actions[num];
				}
			}
			throw new ArgumentException("No DSP Action produces given output");
		}

		internal void ScheduleRun(TContext context)
		{
			context.EnqueueTask(RunSequence);
		}

		internal void RunSequence(TContext context)
		{
			context.MapInputBuffers(_dependencyBuffers);
			for (int i = 0; i < _actions.Count; i++)
			{
				TAction val = _actions[i];
				int num = i + 1;
				val.Execute(context, (num == _actions.Count) ? null : _actions[num]);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public interface IDSP_Node : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		DSP_NodeMetadata DSP_Metadata { get; }

		bool HasExecutionEntryPoints { get; }

		int InputBufferCount { get; }

		int OutputBufferCount { get; }

		IOutput GetInputBufferSource(int index);

		bool IsInputBufferConditional(int index);

		void Collect(DSP_BuildContext context, Span<bool> mask);
	}
	public interface IDSP_Node<B, C> : IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder where B : DSP_Buffer where C : DSP_Context<B, C>
	{
		void Process(C context);
	}
	public class DSP_NodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int FixedBufferInputCount => FixedBufferInputs.Count;

		public int FixedBufferOutputCount => FixedBufferOutputs.Count;

		public int DynamicBufferInputCount => DynamicBufferInputs.Count;

		public int DynamicBufferOutputCount => DynamicBufferOutputs.Count;

		public bool HasExecutionEntryPoints
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasExecutionEntryPoints"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasExecutionEntryPoints", value);
			}
		}

		public List<InputMetadata> FixedBufferInputs
		{
			get
			{
				return (List<InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedBufferInputs"), typeof(List<InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedBufferInputs", value);
			}
		}

		public List<OutputMetadata> FixedBufferOutputs
		{
			get
			{
				return (List<OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedBufferOutputs"), typeof(List<OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedBufferOutputs", value);
			}
		}

		public List<InputListMetadata> DynamicBufferInputs
		{
			get
			{
				return (List<InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicBufferInputs"), typeof(List<InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicBufferInputs", value);
			}
		}

		public List<OutputListMetadata> DynamicBufferOutputs
		{
			get
			{
				return (List<OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicBufferOutputs"), typeof(List<OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicBufferOutputs", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
namespace ProtoFlux.Runtimes.DSP.Array
{
	public class DSP_Array_Action : DSP_Action<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DSP_Array_Action(IDSP_Array_Node node)
			: base(node)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_Action(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class DSP_Array_Buffer<T> : DSP_Array_Buffer, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override Type BufferType => typeof(T);

		public T[] Buffer
		{
			get
			{
				return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Buffer"), typeof(T[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Buffer", value);
			}
		}

		public DSP_Array_Buffer(int size)
		{
			Buffer = new T[size];
		}

		public override void Copy(DSP_Array_Buffer source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Copy", source);
		}

		public override DSP_Array_Buffer Clone(DSP_Array_Context context, DSP_Array_Buffer source)
		{
			return (DSP_Array_Buffer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", context, source), typeof(DSP_Array_Buffer));
		}

		public override void Recycle()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Recycle");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_Buffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DSP_Array_BuildContext : DSP_BuildContext<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_BuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DSP_Array_Context : DSP_Context<DSP_Array_Buffer, DSP_Array_Context>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DSP_Array_Buffer<T> AllocateBuffer<T>() where T : struct
		{
			return (DSP_Array_Buffer<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllocateBuffer"), typeof(DSP_Array_Buffer<T>));
		}

		public override DSP_Array_Buffer CloneBuffer(DSP_Array_Buffer buffer)
		{
			return (DSP_Array_Buffer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CloneBuffer", buffer), typeof(DSP_Array_Buffer));
		}

		protected override DSP_Array_Context CloneSelf()
		{
			return (DSP_Array_Context)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CloneSelf"), typeof(DSP_Array_Context));
		}

		public override void EnqueueTask(Action<DSP_Array_Context> task)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnqueueTask", task);
		}

		public override void RecycleContext()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecycleContext");
		}

		protected override void RecycleBuffer(DSP_Array_Buffer buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecycleBuffer", buffer);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_Context(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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

		public static T[] GetInputBuffer<T>(this int index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetInputBuffer", index, context), typeof(T[]));
		}

		public static T[] GetOutputBuffer<T>(this int index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context), typeof(T[]));
		}

		public static T[] GetOutputBufferOrReuse<T>(this int index, DSP_Array_Context context) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBufferOrReuse", index, context), typeof(T[]));
		}

		private static T[] GetOutputBuffer<T>(int index, DSP_Array_Context context, bool allowReuse) where T : struct
		{
			return (T[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "DSP_Array_BufferExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOutputBuffer", index, context, allowReuse), typeof(T[]));
		}
	}
	public abstract class DSP_Array_Node : DSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Array_Node, IDSP_Node<DSP_Array_Buffer, DSP_Array_Context>, IDSP_Node, INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class DSP_Array_Runtime<C> : DSP_Runtime<IDSP_Array_Node, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_BuildContext, DSP_Array_Sequence, DSP_Array_Action, C>, ResoniteBridge.ResoniteBridgeValueHolder where C : ProtoFlux.Runtimes.Execution.ExecutionContext
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_Runtime(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DSP_Array_Sequence : DSP_Sequence<IDSP_Array_Node, DSP_Array_Sequence, DSP_Array_Context, DSP_Array_Buffer, DSP_Array_Action>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		protected override DSP_Array_Action CreateAction(IDSP_Node node)
		{
			return (DSP_Array_Action)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CreateAction", node), typeof(DSP_Array_Action));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DSP_Array_Sequence(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ValueInput<float> B
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestAddArraysNode()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestAddArraysNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[NodeOverload("Core.Add")]
	public class TestAddArraysNodeExecution : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> A
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "A"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "A", value);
			}
		}

		public ValueInput<float> B
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "B"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "B", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestAddArraysNodeExecution()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestAddArraysNodeExecution(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TestAmplifyArray : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public ValueInput<float> Multiplier
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Multiplier"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Multiplier", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestAmplifyArray()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestAmplifyArray(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TestConditionalCollectArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> OnTrue
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnTrue"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnTrue", value);
			}
		}

		public ValueInput<float> OnFalse
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnFalse"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnFalse", value);
			}
		}

		public ValueInput<bool> Condition
		{
			get
			{
				return (ValueInput<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Condition"), typeof(ValueInput<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Condition", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestConditionalCollectArrayNode()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestConditionalCollectArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TestNegateArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueInput<float> Input
		{
			get
			{
				return (ValueInput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Input"), typeof(ValueInput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Input", value);
			}
		}

		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestNegateArrayNode()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestNegateArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TestRandomArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestRandomArrayNode()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestRandomArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TestSequenceArrayNode : DSP_Array_Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ValueOutput<float> Output
		{
			get
			{
				return (ValueOutput<float>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Output"), typeof(ValueOutput<float>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Output", value);
			}
		}

		public override void Collect(DSP_BuildContext context, Span<bool> mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Collect", context, mask);
		}

		public override void Process(DSP_Array_Context context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Process", context);
		}

		public TestSequenceArrayNode()
		{
			Output = new ValueOutput<float>(this);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TestSequenceArrayNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
	internal struct ChangeSourceInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public bool continuous
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "continuous"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "continuous", value);
			}
		}

		public List<ElementPath<IOutput>> outputs
		{
			get
			{
				return (List<ElementPath<IOutput>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "outputs"), typeof(List<ElementPath<IOutput>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "outputs", value);
			}
		}

		public bool ProducesChanges
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ProducesChanges"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ProducesChanges", value);
			}
		}

		public void SetContinuous()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetContinuous");
		}

		public void Add(IOutput output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", output);
		}

		public void Combine(ElementPath<IOutput> output, ref bool allocatedList)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Combine", output, allocatedList);
		}

		public bool Combine(ChangeSourceInfo other, ref bool allocatedList)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Combine", other, allocatedList), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ChangeSourceInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class ChangeTrackingBuildContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<NodeGroup> _currentlyProcessing
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_currentlyProcessing"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_currentlyProcessing", value);
			}
		}

		private HashSet<NodeGroup> _currentConflicts
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_currentConflicts"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_currentConflicts", value);
			}
		}

		public bool HasConflicts => _currentConflicts.Count > 0;

		public bool ContainsCurrentlyProcessing(NodeGroup group)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ContainsCurrentlyProcessing", group), typeof(bool));
		}

		public bool TryNestInto(NodeGroup group)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryNestInto", group), typeof(bool));
		}

		public void NestOut(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "NestOut", group);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ChangeTrackingBuildContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class ChangeTrackingData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public HashSet<NodeGroup> NestedGroups
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "NestedGroups"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "NestedGroups", value);
			}
		}

		public List<ElementPath<INode>> ContinuousChanges
		{
			get
			{
				return (List<ElementPath<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ContinuousChanges"), typeof(List<ElementPath<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ContinuousChanges", value);
			}
		}

		public Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>> ChangeListeners
		{
			get
			{
				return (Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ChangeListeners"), typeof(Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ChangeListeners", value);
			}
		}

		public Dictionary<IOutput, ChangeSourceInfo> ExportsInfo
		{
			get
			{
				return (Dictionary<IOutput, ChangeSourceInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ExportsInfo"), typeof(Dictionary<IOutput, ChangeSourceInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ExportsInfo", value);
			}
		}

		public void Sort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Sort");
		}

		public void RegisterListener(ElementPath<IOutput> output, ElementPath<INode> node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RegisterListener", output, node);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ChangeTrackingData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ContinuouslyChangingAttribute : Attribute
	{
	}
	public class NodeGroup : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ChangeTrackingData changeTrackingData
		{
			get
			{
				return (ChangeTrackingData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "changeTrackingData"), typeof(ChangeTrackingData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "changeTrackingData", value);
			}
		}

		private List<NodeRuntime> runtimes
		{
			get
			{
				return (List<NodeRuntime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "runtimes"), typeof(List<NodeRuntime>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "runtimes", value);
			}
		}

		private int _nodeAllocationCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_nodeAllocationCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_nodeAllocationCount", value);
			}
		}

		public bool ChangeTrackingBuilt
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ChangeTrackingBuilt"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ChangeTrackingBuilt", value);
			}
		}

		public bool ChangeTrackingDirty
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ChangeTrackingDirty"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ChangeTrackingDirty", value);
			}
		}

		public bool RequiresRebuild
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RequiresRebuild"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RequiresRebuild", value);
			}
		}

		public bool IgnoreChanges
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IgnoreChanges"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IgnoreChanges", value);
			}
		}

		public IReadOnlyList<ElementPath<INode>> ContinuousChanges => changeTrackingData.ContinuousChanges;

		public Dictionary<ElementPath<IOutput>, OrderedSet<ElementPath<INode>>>.KeyCollection ActiveChangeSources => changeTrackingData.ChangeListeners.Keys;

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public int RuntimeCount => runtimes.Count;

		public IEnumerable<NodeRuntime> Runtimes => runtimes;

		public int TotalNodeCount => runtimes.Sum((NodeRuntime r) => r.NodeCount);

		public event Action<NodeGroup> ChangeTrackingInvalidated;

		public void MarkChangeTrackingDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkChangeTrackingDirty");
		}

		public bool ContainsNestedGroup(NodeGroup group)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ContainsNestedGroup", group), typeof(bool));
		}

		private bool CheckChangeTracking()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckChangeTracking"), typeof(bool));
		}

		public void OutputChanged(ElementPath<IOutput> output, HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OutputChanged", output, changedNodes);
		}

		public void OutputChanged(ElementPath<IOutput> output, SortedSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OutputChanged", output, changedNodes);
		}

		public void AllChanged(HashSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllChanged", changedNodes);
		}

		public void AllChanged(SortedSet<ElementPath<INode>> changedNodes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllChanged", changedNodes);
		}

		public void RebuildChangeTrackingData()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RebuildChangeTrackingData");
		}

		private ChangeTrackingData BuildChangeTrackingData(ChangeTrackingBuildContext context)
		{
			return (ChangeTrackingData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BuildChangeTrackingData", context), typeof(ChangeTrackingData));
		}

		private ChangeSourceInfo GetChangeInfo(IOutput output, Dictionary<IOutput, ChangeSourceInfo> infos, Dictionary<INestedNode, ChangeTrackingData> nestedData)
		{
			return (ChangeSourceInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetChangeInfo", output, infos, nestedData), typeof(ChangeSourceInfo));
		}

		private void CombineInputs(INode node, ref ChangeSourceInfo info, Dictionary<IOutput, ChangeSourceInfo> infos, Dictionary<INestedNode, ChangeTrackingData> nestedData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CombineInputs", node, info, infos, nestedData);
		}

		public string DebugChangeTrackingData()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DebugChangeTrackingData"), typeof(string));
		}

		public string PrintDebugStructure()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PrintDebugStructure"), typeof(string));
		}

		private void PrintRuntime(StringBuilder str, NodeRuntime runtime, int indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PrintRuntime", str, runtime, indent);
		}

		private void PrintNode(StringBuilder str, INode node, int indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PrintNode", str, node, indent);
		}

		private string PrintInputSource(IOutput source)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PrintInputSource", source), typeof(string));
		}

		private string PrintImpulseTarget(IOperation target)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PrintImpulseTarget", target), typeof(string));
		}

		private void Indent(StringBuilder str, int indent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Indent", str, indent);
		}

		public NodeRuntime GetRuntime(int index)
		{
			return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRuntime", index), typeof(NodeRuntime));
		}

		internal int GetNodeAllocationIndex()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNodeAllocationIndex"), typeof(int));
		}

		public NodeGroup(string name)
		{
			Name = name;
		}

		public R AddRuntime<R>() where R : NodeRuntime, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddRuntime"), typeof(R));
		}

		public R GetRuntime<R>() where R : NodeRuntime
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRuntime"), typeof(R));
		}

		public void ForeachNode<T>(NodeEnumerationAction<T> action, bool cache) where T : INode
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForeachNode", action, cache);
		}

		public void ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, bool cache) where T : INode
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForeachNode", action, context, cache);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeGroup(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		public object Value
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		public DefaultValueAttribute(object value)
		{
			Value = value;
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
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType => ImpulseType.AsyncCall;

			IOperation IImpulse.Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<InternalCall> calls
		{
			get
			{
				return (List<InternalCall>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "calls"), typeof(List<InternalCall>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "calls", value);
			}
		}

		public int Count => calls.Count;

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddImpulse", target), typeof(IImpulse));
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public IImpulse GetImpulse(int index)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(int index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(int index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncCallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AsyncOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class Operation : IAsyncOperation, IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public int Index
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
				}
			}

			public AsyncOperationList List
			{
				get
				{
					return (AsyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(AsyncOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
				}
			}

			public Node OwnerNode => List.Owner;

			IOperationList IListOperation.List => List;

			public Operation(int index, AsyncOperationList list)
			{
				Index = index;
				List = list;
			}

			public override string ToString()
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int Count => _operations.Count;

		public IAsyncOperation AddOperation()
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOperation"), typeof(IAsyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOperation");
		}

		public IAsyncOperation GetOperation(int index)
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperation", index), typeof(IAsyncOperation));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public AsyncOperationList(Node owner, int index)
		{
			Owner = owner;
			Index = index;
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOperation"), typeof(IOperation));
		}

		IOperation IOperationList.GetOperation(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperation", index), typeof(IOperation));
		}

		bool IOperationList.IsOperationAsync(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationAsync", index), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
					return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(ISyncOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType => ImpulseType.Call;

			IOperation IImpulse.Target
			{
				get
				{
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public InternalCall(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<InternalCall> calls
		{
			get
			{
				return (List<InternalCall>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "calls"), typeof(List<InternalCall>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "calls", value);
			}
		}

		public int Count => calls.Count;

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddImpulse", target), typeof(IImpulse));
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public IImpulse GetImpulse(int index)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(int index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(int index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CallList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
					return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
				}
			}

			public ImpulseType ImpulseType => ImpulseType.Continuation;

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public InternalContinuation(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<InternalContinuation> continuations
		{
			get
			{
				return (List<InternalContinuation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "continuations"), typeof(List<InternalContinuation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "continuations", value);
			}
		}

		public int Count => continuations.Count;

		public IImpulse AddImpulse(IOperation target = null)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddImpulse", target), typeof(IImpulse));
		}

		public void RemoveImpulse()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveImpulse");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public IImpulse GetImpulse(int index)
		{
			return (IImpulse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulse", index), typeof(IImpulse));
		}

		public ImpulseType GetImpulseType(int index)
		{
			return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseType", index), typeof(ImpulseType));
		}

		public IOperation GetImpulseTarget(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseTarget", index), typeof(IOperation));
		}

		public void SetImpulseTarget(int index, IOperation target)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetImpulseTarget", index, target);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ListGlobalRef<T> : GlobalRef<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlobalRefList List
		{
			get
			{
				return (GlobalRefList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(GlobalRefList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
			}
		}

		public ListGlobalRef(GlobalRefList list, int index)
			: base(list.OwnerNode, index)
		{
			List = list;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ListGlobalRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlobalRefList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IGlobalRef> globalRefs
		{
			get
			{
				return (List<IGlobalRef>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "globalRefs"), typeof(List<IGlobalRef>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "globalRefs", value);
			}
		}

		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OwnerNode", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int Count => globalRefs.Count;

		public GlobalRefList(Node owner, int index)
		{
			Index = index;
			OwnerNode = owner;
		}

		public IGlobalRef<T> AddGlobalRef<T>(Global<T> binding = null)
		{
			return (IGlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddGlobalRef", binding), typeof(IGlobalRef<T>));
		}

		public void SetGlobalRefBinding<T>(int index, Global<T> binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetGlobalRefBinding", index, binding);
		}

		public IGlobalRef GetUntypedGlobalRef(int index)
		{
			return (IGlobalRef)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUntypedGlobalRef", index), typeof(IGlobalRef));
		}

		public IGlobalRef<T> GetGlobalRef<T>(int index)
		{
			return (IGlobalRef<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlobalRef", index), typeof(IGlobalRef<T>));
		}

		public void RemoveGlobalRef()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveGlobalRef");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRefList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IImpulseList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Count { get; }

		IImpulse AddImpulse(IOperation target = null);

		void RemoveImpulse();

		void Clear();

		ImpulseType GetImpulseType(int index);

		IImpulse GetImpulse(int index);

		IOperation GetImpulseTarget(int index);

		void SetImpulseTarget(int index, IOperation target);
	}
	public interface IInputList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Count { get; }

		IOutput GetInputSource(int index);

		void AddInput(IOutput source);

		void SetInputSource(int index, IOutput source);

		void RemoveInput();

		void Clear();

		Type GetInputType(int index);

		DataClass GetDataClass(int index);

		object GetDefaultValue(int index);
	}
	public interface IListOperation : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Index { get; }

		IOperationList List { get; }
	}
	public abstract class InputListBase : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private abstract class Input : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public abstract IOutput GenericSource { get; set; }

			public abstract Type InputType { get; }

			public abstract DataClass DataClass { get; }

			public abstract object DefaultValue { get; }

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		private class Input<T> : Input, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IOutput<T> Source
			{
				get
				{
					return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IOutput<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
				}
			}

			public override Type InputType => typeof(T);

			public override IOutput GenericSource
			{
				get
				{
					return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "GenericSource"), typeof(IOutput));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "GenericSource", value);
				}
			}

			public override DataClass DataClass
			{
				get
				{
					return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataClass"), typeof(DataClass));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataClass", value);
				}
			}

			public override object DefaultValue => default(T);

			IOutput IInput.Source => Source;

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Input(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<Input> _inputs = new List<Input>();

		public int Count => _inputs.Count;

		public IInput<T> GetInput<T>(int index)
		{
			return (IInput<T>)_inputs[index];
		}

		public IInput<T> AddInput<T>(IOutput<T> source = null)
		{
			Input<T> input = new Input<T>();
			input.Source = source;
			_inputs.Add(input);
			return input;
		}

		public void RemoveInput()
		{
			_inputs.RemoveAt(_inputs.Count - 1);
		}

		public void Clear()
		{
			_inputs.Clear();
		}

		public IOutput GetInputSource(int index)
		{
			return _inputs[index].GenericSource;
		}

		public void SetInputSource(int index, IOutput source)
		{
			SetInputSource(index, source, changeType: true);
		}

		public void SetInputSource(int index, IOutput source, bool changeType)
		{
			Input input = _inputs[index];
			if (source.OutputType != input.InputType)
			{
				if (!changeType)
				{
					throw new InvalidOperationException($"Type mismatch. Input is of type: {input.InputType}");
				}
				input = (Input)Activator.CreateInstance(typeof(Input<>).MakeGenericType(source.OutputType));
				_inputs[index] = input;
			}
			input.GenericSource = source;
		}

		public Type GetInputType(int index)
		{
			return _inputs[index].InputType;
		}

		public DataClass GetDataClass(int index)
		{
			return _inputs[index].DataClass;
		}

		public object GetDefaultValue(int index)
		{
			return _inputs[index].DefaultValue;
		}

		public void AddInput(IOutput source)
		{
			Input input = (Input)Activator.CreateInstance(typeof(Input<>).MakeGenericType(source.OutputType));
			input.GenericSource = source;
			_inputs.Add(input);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class InputList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ArgumentList : InputListBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IOperationList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Count { get; }

		IOperation AddOperation();

		void RemoveOperation();

		IOperation GetOperation(int index);

		bool IsOperationAsync(int index);

		void Clear();
	}
	public interface IOutputList : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node Owner { get; }

		int Count { get; }

		IOutput GetOutput(int index);

		Type GetOutputType(int index);

		DataClass GetOutputClass(int index);

		IListOutput AddOutput();

		void RemoveOutput();

		void Clear();
	}
	public class MixedOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract class Operation : IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public int Index
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
				}
			}

			public MixedOperationList List
			{
				get
				{
					return (MixedOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(MixedOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
				}
			}

			public Node OwnerNode => List.Owner;

			public abstract bool IsAsync
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsAsync"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsAsync", value);
				}
			}

			IOperationList IListOperation.List => List;

			public Operation(int index, MixedOperationList list)
			{
				Index = index;
				List = list;
			}

			public override string ToString()
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}
		}

		public class SyncOperation : Operation, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public override bool IsAsync => false;

			public SyncOperation(int index, MixedOperationList list)
				: base(index, list)
			{
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public SyncOperation(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public class AsyncOperation : Operation, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public override bool IsAsync => true;

			public AsyncOperation(int index, MixedOperationList list)
				: base(index, list)
			{
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public AsyncOperation(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int Count => _operations.Count;

		public ISyncOperation AddSyncOperation()
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddSyncOperation"), typeof(ISyncOperation));
		}

		public IAsyncOperation AddAsyncOperation()
		{
			return (IAsyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddAsyncOperation"), typeof(IAsyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOperation");
		}

		public IOperation GetOperation(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperation", index), typeof(IOperation));
		}

		public bool IsOperationAsync(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationAsync", index), typeof(bool));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public MixedOperationList(Node owner, int index)
		{
			Owner = owner;
			Index = index;
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOperation"), typeof(IOperation));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MixedOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ObjectInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IObjectOutput<T>> inputs = new List<IObjectOutput<T>>();

		public int Count => inputs.Count;

		public DataClass GetDataClass(int index)
		{
			return DataClass.Object;
		}

		public object GetDefaultValue(int index)
		{
			return default(T);
		}

		public Type GetInputType(int index)
		{
			return typeof(T);
		}

		public IOutput GetInputSource(int index)
		{
			return inputs[index];
		}

		public void SetInputSource(int index, IOutput source)
		{
			inputs[index] = (IObjectOutput<T>)source;
		}

		public void AddInput(IObjectOutput<T> source = null)
		{
			inputs.Add(source);
		}

		public void AddInput(IOutput source)
		{
			AddInput((IObjectOutput<T>)source);
		}

		public void RemoveInput()
		{
			inputs.RemoveAt(inputs.Count - 1);
		}

		public void Clear()
		{
			inputs.Clear();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class ObjectInputList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectArgumentList<T> : ObjectInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<ListObjectOutput<T>> _outputs
		{
			get
			{
				return (List<ListObjectOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputs"), typeof(List<ListObjectOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Count => _outputs.Count;

		public ListObjectOutput<T> AddOutput()
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutput"), typeof(ListObjectOutput<T>));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public ListObjectOutput<T> GetOutput(int index)
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutput", index), typeof(ListObjectOutput<T>));
		}

		IOutput IOutputList.GetOutput(int index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(int index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(int index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputType", index), typeof(Type));
		}

		IListOutput IOutputList.AddOutput()
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutput"), typeof(IListOutput));
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOutput");
		}

		public ObjectOutputList(Node owner)
		{
			Owner = owner;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectOutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IListOutput : IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Index { get; }

		IOutputList List { get; }
	}
	public class ListValueOutput<T> : ValueOutput<T>, IListOutput, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IOutputList List
		{
			get
			{
				return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(IOutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public ListValueOutput(int index, IOutputList list)
			: base(list.Owner)
		{
			Index = index;
			List = list;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ListValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ListObjectOutput<T> : ObjectOutput<T>, IListOutput, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOutputList List
		{
			get
			{
				return (IOutputList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(IOutputList));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public ListObjectOutput(int index, IOutputList list)
			: base(list.Owner)
		{
			Index = index;
			List = list;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ListObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class OutputList : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<IOutput> _outputs
		{
			get
			{
				return (List<IOutput>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputs"), typeof(List<IOutput>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Count => _outputs.Count;

		public OutputList(Node owner)
		{
			Owner = owner;
		}

		public IOutput GetOutput(int index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(int index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(int index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputType", index), typeof(Type));
		}

		public IListOutput AddOutputAuto(Type type)
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutputAuto", type), typeof(IListOutput));
		}

		public ListValueOutput<T> AddValueOutput<T>() where T : struct
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddValueOutput"), typeof(ListValueOutput<T>));
		}

		public ListObjectOutput<T> AddObjectOutput<T>()
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddObjectOutput"), typeof(ListObjectOutput<T>));
		}

		public ListValueOutput<T> GetValueOutput<T>(int index) where T : struct
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetValueOutput", index), typeof(ListValueOutput<T>));
		}

		public ListObjectOutput<T> GetObjectOutput<T>(int index)
		{
			return (ListObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetObjectOutput", index), typeof(ListObjectOutput<T>));
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOutput");
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public IListOutput AddOutput()
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutput"), typeof(IListOutput));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class SyncOperationList : IOperationList, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class Operation : ISyncOperation, IOperation, IListOperation, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public int Index
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
				}
			}

			public SyncOperationList List
			{
				get
				{
					return (SyncOperationList)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "List"), typeof(SyncOperationList));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "List", value);
				}
			}

			public Node OwnerNode => List.Owner;

			IOperationList IListOperation.List => List;

			public Operation(int index, SyncOperationList list)
			{
				Index = index;
				List = list;
			}

			public override string ToString()
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Operation(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private List<Operation> _operations
		{
			get
			{
				return (List<Operation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_operations"), typeof(List<Operation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_operations", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int Count => _operations.Count;

		public ISyncOperation AddOperation()
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOperation"), typeof(ISyncOperation));
		}

		public void RemoveOperation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOperation");
		}

		public ISyncOperation GetOperation(int index)
		{
			return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperation", index), typeof(ISyncOperation));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public SyncOperationList(Node owner, int index)
		{
			Owner = owner;
			Index = index;
		}

		IOperation IOperationList.AddOperation()
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOperation"), typeof(IOperation));
		}

		IOperation IOperationList.GetOperation(int index)
		{
			return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperation", index), typeof(IOperation));
		}

		bool IOperationList.IsOperationAsync(int index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsOperationAsync", index), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SyncOperationList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ValueInputListBase<T> : IInputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private List<IValueOutput<T>> inputs = new List<IValueOutput<T>>();

		public int Count => inputs.Count;

		public DataClass GetDataClass(int index)
		{
			return DataClass.Value;
		}

		public object GetDefaultValue(int index)
		{
			return default(T);
		}

		public Type GetInputType(int index)
		{
			return typeof(T);
		}

		public IOutput GetInputSource(int index)
		{
			return inputs[index];
		}

		public void SetInputSource(int index, IOutput source)
		{
			inputs[index] = (IValueOutput<T>)source;
		}

		public void AddInput(IValueOutput<T> source = null)
		{
			inputs.Add(source);
		}

		public void AddInput(IOutput source)
		{
			AddInput((IValueOutput<T>)source);
		}

		public void RemoveInput()
		{
			inputs.RemoveAt(inputs.Count - 1);
		}

		public void Clear()
		{
			inputs.Clear();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class ValueInputList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueInputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueArgumentList<T> : ValueInputListBase<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueArgumentList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueOutputList<T> : IOutputList, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		private List<ListValueOutput<T>> _outputs
		{
			get
			{
				return (List<ListValueOutput<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputs"), typeof(List<ListValueOutput<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputs", value);
			}
		}

		public Node Owner
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Owner"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Owner", value);
			}
		}

		public int Count => _outputs.Count;

		public ListValueOutput<T> AddOutput()
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutput"), typeof(ListValueOutput<T>));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public ListValueOutput<T> GetOutput(int index)
		{
			return (ListValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutput", index), typeof(ListValueOutput<T>));
		}

		IOutput IOutputList.GetOutput(int index)
		{
			return (IOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutput", index), typeof(IOutput));
		}

		public DataClass GetOutputClass(int index)
		{
			return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputClass", index), typeof(DataClass));
		}

		public Type GetOutputType(int index)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputType", index), typeof(Type));
		}

		IListOutput IOutputList.AddOutput()
		{
			return (IListOutput)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddOutput"), typeof(IListOutput));
		}

		public void RemoveOutput()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveOutput");
		}

		public ValueOutputList(Node owner)
		{
			Owner = owner;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueOutputList(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct AsyncCall : IAsyncCall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType => ImpulseType.AsyncCall;

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncCall(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AsyncOperation : IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OwnerNode", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public AsyncOperation(Node owner, int index)
		{
			OwnerNode = owner;
			Index = index;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncOperation(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct AsyncResumption : IAsyncResumption, IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType => ImpulseType.AsyncResumption;

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Call : ICall, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType => ImpulseType.Call;

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Call(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Continuation : IContinuation, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType => ImpulseType.Continuation;

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Continuation(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class GlobalRef : IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode { get; private set; }

		public int Index { get; private set; }

		public abstract Global UntypedGlobal { get; }

		public abstract void ClearReference();

		public GlobalRef(Node owner, int index)
		{
			OwnerNode = owner;
			Index = index;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class GlobalRef<T> : GlobalRef, IGlobalRef<T>, IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Global<T> _global
		{
			get
			{
				return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_global"), typeof(Global<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_global", value);
			}
		}

		public override Global UntypedGlobal => Global;

		public Global<T> Global
		{
			get
			{
				return (Global<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Global"), typeof(Global<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Global", value);
			}
		}

		public GlobalRef(Node owner, int index)
			: base(owner, index)
		{
		}

		public override void ClearReference()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearReference");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class GlobalRefHelper
	{
		public static T Read<T>(this GlobalRef<T> global, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Read", global, context), typeof(T));
		}

		public static bool Write<T>(this GlobalRef<T> global, T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "GlobalRefHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", global, value, context), typeof(bool));
		}
	}
	public struct ObjectArgument<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				return (IObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		public Type InputType => typeof(T);

		IOutput IInput.Source => Source;

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ObjectInput<T> : IObjectInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IObjectOutput<T> Source
		{
			get
			{
				return (IObjectOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IObjectOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		public Type InputType => typeof(T);

		IOutput IInput.Source => Source;

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ObjectOutput<T> : Output<T>, IObjectOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override DataClass OutputDataClass => DataClass.Object;

		public ObjectOutput(Node owner)
			: base(owner)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class Operation : ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode
		{
			get
			{
				return (Node)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OwnerNode"), typeof(Node));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OwnerNode", value);
			}
		}

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public Operation(Node owner, int index)
		{
			OwnerNode = owner;
			Index = index;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Operation(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Reference<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : INode
	{
		public T Target
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Target"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Reference(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct SyncResumption : ISyncResumption, IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ISyncOperation Target
		{
			get
			{
				return (ISyncOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(ISyncOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		public ImpulseType ImpulseType => ImpulseType.SyncResumption;

		IOperation IImpulse.Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Target", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SyncResumption(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ValueArgument<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				return (IValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		public Type InputType => typeof(T);

		IOutput IInput.Source => Source;

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueArgument(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ValueInput<T> : IValueInput<T>, IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public IValueOutput<T> Source
		{
			get
			{
				return (IValueOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IValueOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		public Type InputType => typeof(T);

		IOutput IInput.Source => Source;

		IOutput<T> IInput<T>.Source
		{
			get
			{
				return (IOutput<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Source"), typeof(IOutput<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Source", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueInput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ValueOutput<T> : Output<T>, IValueOutput<T>, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override DataClass OutputDataClass => DataClass.Value;

		public ValueOutput(Node owner)
			: base(owner)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueOutput(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IAsyncOperation : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IGlobalRef : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Global UntypedGlobal { get; }

		void ClearReference();
	}
	public interface IGlobalRef<T> : IGlobalRef, ResoniteBridge.ResoniteBridgeValueHolder
	{
		Global<T> Global { get; set; }
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
		IOperation Target { get; set; }

		ImpulseType ImpulseType { get; }
	}
	public interface ICall : IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new ISyncOperation Target { get; set; }
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
		new ISyncOperation Target { get; set; }
	}
	public interface IAsyncResumption : IResumption, IImpulse, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IInput : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Type InputType { get; }

		IOutput Source { get; }
	}
	public interface IInput<T> : IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IOutput<T> Source { get; set; }
	}
	public interface IValueInput<T> : IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		new IValueOutput<T> Source { get; set; }
	}
	public interface IObjectInput<T> : IInput<T>, IInput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		new IObjectOutput<T> Source { get; set; }
	}
	public interface IOperation : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node OwnerNode { get; }
	}
	public interface IOutput : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Node OwnerNode { get; }

		Type OutputType { get; }

		DataClass OutputDataClass { get; }
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_value", value);
			}
		}

		private bool _hasValue
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_hasValue"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_hasValue", value);
			}
		}

		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		public bool HasValue => _hasValue;

		public UnmanagedNullable(T value)
		{
			_hasValue = true;
			_value = value;
		}

		public static implicit operator T?(UnmanagedNullable<T> unmanagedNullable)
		{
			if (unmanagedNullable.HasValue)
			{
				return unmanagedNullable.Value;
			}
			return null;
		}

		public static implicit operator UnmanagedNullable<T>(T? nullable)
		{
			if (nullable.HasValue)
			{
				return new UnmanagedNullable<T>(nullable.Value);
			}
			return default(UnmanagedNullable<T>);
		}

		public static implicit operator UnmanagedNullable<T>(T value)
		{
			return new UnmanagedNullable<T>(value);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnmanagedNullable(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		internal int offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "offset", value);
			}
		}

		public int Offset => offset;

		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ObjectStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ValueStore<T> : IStore<T>, IStore, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		internal int offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "offset", value);
			}
		}

		public int Offset => offset;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Read(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", context), typeof(T));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(T value, ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", value, context);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T Access(ProtoFlux.Runtimes.Execution.ExecutionContext context)
		{
			return (ref T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Access", context), typeof(ref T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ValueStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class CrossRuntimeInputAttribute : Attribute
	{
		public abstract bool IsValidTargetRuntime(NodeRuntime runtime);
	}
	public interface INestedNode : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		NodeGroup TargetGroup { get; }

		NodeRuntime TargetRuntime { get; }

		IOutput GetTargetExport(IOutput output);

		IOutput GetImportSource(IOutput import);
	}
	public struct ElementRef : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public short index
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "index"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "index", value);
			}
		}

		public short listIndex
		{
			get
			{
				return (short)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "listIndex"), typeof(short));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "listIndex", value);
			}
		}

		public bool IsDynamic => listIndex >= 0;

		public bool AddToList
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AddToList"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AddToList", value);
			}
		}

		public ElementRef(int index)
		{
			this.index = (short)index;
			listIndex = -1;
		}

		public ElementRef(int listIndex, int index)
		{
			this.index = (short)index;
			this.listIndex = (short)listIndex;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ElementRef(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AsyncCallExport : ImpulseExport, IAsyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AsyncCallExport(ImpulseExportNode node, int index)
			: base(node, index)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AsyncCallExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class CallExport : ImpulseExport, ISyncOperation, IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public CallExport(ImpulseExportNode node, int index)
			: base(node, index)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CallExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ContinuationExport : ImpulseExport, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ContinuationExport(ImpulseExportNode node, int index)
			: base(node, index)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ContinuationExport(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ImpulseExport : IOperation, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode { get; private set; }

		public int Index { get; private set; }

		public ImpulseExport(ImpulseExportNode node, int index)
		{
			OwnerNode = node;
			Index = index;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
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
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseExportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DataImportNode : Node, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DataImportNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class Global : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public NodeRuntime Runtime { get; private set; }

		public int Index { get; internal set; }

		public string Name { get; private set; }

		public abstract Type ValueType { get; }

		public abstract int ListenerCount { get; }

		internal abstract void AddMatchingTypeToList(GlobalRefList list);

		internal abstract void UpdateToInitialValue<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		internal abstract void ResetValueToDefault<C>(C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext;

		public Global(NodeRuntime runtime, int index, string name)
		{
			Runtime = runtime;
			Index = index;
			Name = name;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class Global<T> : Global, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<GlobalRef<T>> _listeners
		{
			get
			{
				return (List<GlobalRef<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_listeners"), typeof(List<GlobalRef<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_listeners", value);
			}
		}

		public override Type ValueType => typeof(T);

		public override int ListenerCount => _listeners?.Count ?? 0;

		public Global(NodeRuntime runtime, int index, string name)
			: base(runtime, index, name)
		{
		}

		internal void ValueChanged<C>(T value, C context) where C : ProtoFlux.Runtimes.Execution.ExecutionContext
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValueChanged", value, context);
		}

		internal override void UpdateToInitialValue<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateToInitialValue", context);
		}

		internal override void ResetValueToDefault<C>(C context)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResetValueToDefault", context);
		}

		internal void RegisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RegisterListener", listener);
		}

		internal void UnregisterListener(GlobalRef<T> listener)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UnregisterListener", listener);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		internal override void AddMatchingTypeToList(GlobalRefList list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddMatchingTypeToList", list);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Global(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ImpulseImport : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public IOperation target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "target", value);
			}
		}

		public bool isAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isAsync", value);
			}
		}

		public ImpulseImport(IOperation target, bool isAsync)
		{
			this.target = target;
			this.isAsync = isAsync;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseImport(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ImpulseMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public ImpulseType Type
		{
			get
			{
				return (ImpulseType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Type"), typeof(ImpulseType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Type", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public ImpulseMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			if (field.FieldType == typeof(Continuation))
			{
				Type = ImpulseType.Continuation;
				return;
			}
			if (field.FieldType == typeof(Call))
			{
				Type = ImpulseType.Call;
				return;
			}
			if (field.FieldType == typeof(AsyncCall))
			{
				Type = ImpulseType.AsyncCall;
				return;
			}
			if (field.FieldType == typeof(SyncResumption))
			{
				Type = ImpulseType.SyncResumption;
				return;
			}
			if (field.FieldType == typeof(AsyncResumption))
			{
				Type = ImpulseType.AsyncResumption;
				return;
			}
			throw new NotImplementedException("Unsupported type of call: " + field.FieldType);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlobalRefListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public GlobalRefListMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRefListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlobalRefMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValueType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValueType", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public GlobalRefMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			ValueType = field.FieldType.GetGenericArguments()[0];
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlobalRefMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IElementMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Index { get; }

		string Name { get; }
	}
	public class ImpulseListMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public ImpulseType? Type
		{
			get
			{
				return (ImpulseType?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Type"), typeof(ImpulseType?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Type", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public ImpulseListMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			if (field.FieldType == typeof(ContinuationList))
			{
				Type = ImpulseType.Continuation;
			}
			else if (field.FieldType == typeof(CallList))
			{
				Type = ImpulseType.Call;
			}
			else if (field.FieldType == typeof(AsyncCallList))
			{
				Type = ImpulseType.AsyncCall;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class InputListMetadata : InputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type TypeConstraint
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TypeConstraint"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TypeConstraint", value);
			}
		}

		public DataClass? DataClassConstraint
		{
			get
			{
				return (DataClass?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataClassConstraint"), typeof(DataClass?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataClassConstraint", value);
			}
		}

		public InputListMetadata(int index, FieldInfo field, object defaultValue)
			: base(index, field, defaultValue)
		{
			if (!field.FieldType.IsGenericType)
			{
				return;
			}
			TypeConstraint = field.FieldType.GetGenericArguments()[0];
			Type genericTypeDefinition = field.FieldType.GetGenericTypeDefinition();
			if (genericTypeDefinition == typeof(ValueInputList<>) || genericTypeDefinition == typeof(ValueArgumentList<>))
			{
				DataClassConstraint = DataClass.Value;
				return;
			}
			if (genericTypeDefinition == typeof(ObjectInputList<>) || genericTypeDefinition == typeof(ObjectArgumentList<>))
			{
				DataClassConstraint = DataClass.Object;
				return;
			}
			throw new NotImplementedException("Unsupported list type: " + genericTypeDefinition);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InputListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class InputMetadata : InputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public DataClass DataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataClass", value);
			}
		}

		public Type InputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InputType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InputType", value);
			}
		}

		public InputMetadata(int index, FieldInfo field, DataClass dataClass, object defaultValue)
			: base(index, field, defaultValue)
		{
			DataClass = dataClass;
			InputType = field.FieldType.GenericTypeArguments[0];
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InputMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class InputMetadataBase : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index { get; internal set; }

		public string Name { get; internal set; }

		public FieldInfo Field { get; internal set; }

		public object DefaultValue { get; internal set; }

		public bool IsConditional { get; internal set; }

		public bool? IsListeningToChanges { get; internal set; }

		public PropertyInfo IsListeningToChangesEval { get; internal set; }

		public CrossRuntimeInputAttribute CrossRuntime { get; internal set; }

		public bool IsPotentiallyListeningToChanges
		{
			get
			{
				if (!IsListeningToChanges.GetValueOrDefault())
				{
					return IsListeningToChangesEval != null;
				}
				return true;
			}
		}

		public InputMetadataBase(int index, FieldInfo field, object defaultValue)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			IsConditional = !field.FieldType.Name.Contains("Argument");
			CrossRuntime = field.GetCustomAttribute<CrossRuntimeInputAttribute>(inherit: true);
			DefaultValue = defaultValue;
			IsListeningToChangesEval = field.DeclaringType.GetProperty(field.Name + "ListensToChanges", BindingFlags.Instance | BindingFlags.Public);
			if (IsListeningToChangesEval == null)
			{
				IsListeningToChanges = field.GetCustomAttribute<ChangeListenerAttribute>() != null;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class NodeMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<string, InputMetadata> _inputsByName
		{
			get
			{
				return (Dictionary<string, InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_inputsByName"), typeof(Dictionary<string, InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_inputsByName", value);
			}
		}

		private Dictionary<string, OutputMetadata> _outputsByName
		{
			get
			{
				return (Dictionary<string, OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputsByName"), typeof(Dictionary<string, OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputsByName", value);
			}
		}

		private Dictionary<string, InputListMetadata> _inputListsByName
		{
			get
			{
				return (Dictionary<string, InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_inputListsByName"), typeof(Dictionary<string, InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_inputListsByName", value);
			}
		}

		private Dictionary<string, OutputListMetadata> _outputListsByName
		{
			get
			{
				return (Dictionary<string, OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outputListsByName"), typeof(Dictionary<string, OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outputListsByName", value);
			}
		}

		private Dictionary<string, ImpulseMetadata> _impulsesByName
		{
			get
			{
				return (Dictionary<string, ImpulseMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_impulsesByName"), typeof(Dictionary<string, ImpulseMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_impulsesByName", value);
			}
		}

		private Dictionary<string, OperationMetadata> _actionsByName
		{
			get
			{
				return (Dictionary<string, OperationMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_actionsByName"), typeof(Dictionary<string, OperationMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_actionsByName", value);
			}
		}

		private Dictionary<string, ImpulseListMetadata> _impulseListsByName
		{
			get
			{
				return (Dictionary<string, ImpulseListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_impulseListsByName"), typeof(Dictionary<string, ImpulseListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_impulseListsByName", value);
			}
		}

		private Dictionary<string, OperationListMetadata> _actionListsByName
		{
			get
			{
				return (Dictionary<string, OperationListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_actionListsByName"), typeof(Dictionary<string, OperationListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_actionListsByName", value);
			}
		}

		private Dictionary<string, ReferenceMetadata> _referencesByName
		{
			get
			{
				return (Dictionary<string, ReferenceMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_referencesByName"), typeof(Dictionary<string, ReferenceMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_referencesByName", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public string Overload
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Overload"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Overload", value);
			}
		}

		public bool IsPassthrough
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsPassthrough"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsPassthrough", value);
			}
		}

		public bool IsPotentiallyListeningToChanges
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsPotentiallyListeningToChanges"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsPotentiallyListeningToChanges", value);
			}
		}

		public int FixedInputCount => FixedInputs.Count;

		public int FixedOutputCount => FixedOutputs.Count;

		public int FixedImpulseCount => FixedImpulses.Count;

		public int FixedOperationCount => FixedOperations.Count;

		public int FixedReferenceCount => FixedReferences.Count;

		public int FixedGlobalRefCount => FixedGlobalRefs.Count;

		public int DynamicInputCount => DynamicInputs.Count;

		public int DynamicOutputCount => DynamicOutputs.Count;

		public int DynamicImpulseCount => DynamicImpulses.Count;

		public int DynamicOperationCount => DynamicOperations.Count;

		public int DynamicGlobalRefCount => DynamicGlobalRefs.Count;

		public List<InputMetadata> FixedInputs
		{
			get
			{
				return (List<InputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedInputs"), typeof(List<InputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedInputs", value);
			}
		}

		public List<OutputMetadata> FixedOutputs
		{
			get
			{
				return (List<OutputMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedOutputs"), typeof(List<OutputMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedOutputs", value);
			}
		}

		public List<ImpulseMetadata> FixedImpulses
		{
			get
			{
				return (List<ImpulseMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedImpulses"), typeof(List<ImpulseMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedImpulses", value);
			}
		}

		public List<OperationMetadata> FixedOperations
		{
			get
			{
				return (List<OperationMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedOperations"), typeof(List<OperationMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedOperations", value);
			}
		}

		public List<ReferenceMetadata> FixedReferences
		{
			get
			{
				return (List<ReferenceMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedReferences"), typeof(List<ReferenceMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedReferences", value);
			}
		}

		public List<GlobalRefMetadata> FixedGlobalRefs
		{
			get
			{
				return (List<GlobalRefMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedGlobalRefs"), typeof(List<GlobalRefMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedGlobalRefs", value);
			}
		}

		public List<InputListMetadata> DynamicInputs
		{
			get
			{
				return (List<InputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicInputs"), typeof(List<InputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicInputs", value);
			}
		}

		public List<OutputListMetadata> DynamicOutputs
		{
			get
			{
				return (List<OutputListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicOutputs"), typeof(List<OutputListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicOutputs", value);
			}
		}

		public List<ImpulseListMetadata> DynamicImpulses
		{
			get
			{
				return (List<ImpulseListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicImpulses"), typeof(List<ImpulseListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicImpulses", value);
			}
		}

		public List<OperationListMetadata> DynamicOperations
		{
			get
			{
				return (List<OperationListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicOperations"), typeof(List<OperationListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicOperations", value);
			}
		}

		public List<GlobalRefListMetadata> DynamicGlobalRefs
		{
			get
			{
				return (List<GlobalRefListMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DynamicGlobalRefs"), typeof(List<GlobalRefListMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DynamicGlobalRefs", value);
			}
		}

		public bool HasDynamicInputs => DynamicInputs.Count > 0;

		public bool HasDynamicOutputs => DynamicOutputs.Count > 0;

		public bool HasDynamicImpulses => DynamicImpulses.Count > 0;

		public bool HasDynamicActions => DynamicOperations.Count > 0;

		public bool HasDynamicGlobalRefs => DynamicGlobalRefs.Count > 0;

		public int FixedArgumentCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedArgumentCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedArgumentCount", value);
			}
		}

		public int FixedContinuationCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedContinuationCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedContinuationCount", value);
			}
		}

		public int FixedCallCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedCallCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedCallCount", value);
			}
		}

		public int FixedAsyncCallCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedAsyncCallCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedAsyncCallCount", value);
			}
		}

		public int FixedSyncOperationCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedSyncOperationCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedSyncOperationCount", value);
			}
		}

		public int FixedAsyncOperationCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FixedAsyncOperationCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FixedAsyncOperationCount", value);
			}
		}

		private T GetElementByName<T>(string name, List<T> list, ref Dictionary<string, T> dict) where T : class, IElementMetadata
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetElementByName", name, list, dict), typeof(T));
		}

		public void ComputeMetadata()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeMetadata");
		}

		public InputMetadata GetInputByName(string name)
		{
			return (InputMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetInputByName", name), typeof(InputMetadata));
		}

		public OutputMetadata GetOutputByName(string name)
		{
			return (OutputMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputByName", name), typeof(OutputMetadata));
		}

		public ImpulseMetadata GetImpulseByName(string name)
		{
			return (ImpulseMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseByName", name), typeof(ImpulseMetadata));
		}

		public OperationMetadata GetOperationByName(string name)
		{
			return (OperationMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperationByName", name), typeof(OperationMetadata));
		}

		public InputListMetadata GetInputListByName(string name)
		{
			return (InputListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetInputListByName", name), typeof(InputListMetadata));
		}

		public OutputListMetadata GetOutputListByName(string name)
		{
			return (OutputListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutputListByName", name), typeof(OutputListMetadata));
		}

		public ImpulseListMetadata GetImpulseListByName(string name)
		{
			return (ImpulseListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulseListByName", name), typeof(ImpulseListMetadata));
		}

		public OperationListMetadata GetOperationListByName(string name)
		{
			return (OperationListMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOperationListByName", name), typeof(OperationListMetadata));
		}

		public ReferenceMetadata GetReferenceByName(string name)
		{
			return (ReferenceMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetReferenceByName", name), typeof(ReferenceMetadata));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class NodeMetadataHelper
	{
		private static ConcurrentDictionary<Type, NodeMetadata> _metadataCache
		{
			get
			{
				return (ConcurrentDictionary<Type, NodeMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_metadataCache"), typeof(ConcurrentDictionary<Type, NodeMetadata>));
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
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public bool SupportsSync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SupportsSync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SupportsSync", value);
			}
		}

		public bool SupportsAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SupportsAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SupportsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				return (PossibleContinuationsAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PossibleContinuations", value);
			}
		}

		public OperationListMetadata(int index, FieldInfo field, bool supportsSync, bool supportsAsync)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			SupportsSync = supportsSync;
			SupportsAsync = supportsAsync;
			PossibleContinuations = field.GetCustomAttribute<PossibleContinuationsAttribute>();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OperationListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class OperationMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public bool IsSelf => Name == "*";

		public bool IsAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsAsync", value);
			}
		}

		public PossibleContinuationsAttribute PossibleContinuations
		{
			get
			{
				return (PossibleContinuationsAttribute)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PossibleContinuations"), typeof(PossibleContinuationsAttribute));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PossibleContinuations", value);
			}
		}

		public OperationMetadata(int index, bool isAsync, Type nodeClass)
		{
			Index = index;
			Name = "*";
			IsAsync = isAsync;
			PossibleContinuations = nodeClass.GetCustomAttribute<PossibleContinuationsAttribute>();
		}

		public OperationMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			if (field.FieldType == typeof(AsyncOperation))
			{
				IsAsync = true;
			}
			PossibleContinuations = field.GetCustomAttribute<PossibleContinuationsAttribute>();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OperationMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class OutputListMetadata : OutputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type TypeConstraint
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TypeConstraint"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TypeConstraint", value);
			}
		}

		public DataClass? DataClassConstraint
		{
			get
			{
				return (DataClass?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataClassConstraint"), typeof(DataClass?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataClassConstraint", value);
			}
		}

		public OutputListMetadata(int index, FieldInfo field)
			: base(index, field.DeclaringType, field)
		{
			if (!field.FieldType.IsGenericType)
			{
				return;
			}
			TypeConstraint = field.FieldType.GetGenericArguments()[0];
			Type genericTypeDefinition = field.FieldType.GetGenericTypeDefinition();
			if (genericTypeDefinition == typeof(ValueOutputList<>))
			{
				DataClassConstraint = DataClass.Value;
				return;
			}
			if (genericTypeDefinition == typeof(ObjectOutputList<>))
			{
				DataClassConstraint = DataClass.Object;
				return;
			}
			throw new NotImplementedException("Unsupported list type: " + genericTypeDefinition);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OutputListMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class OutputMetadata : OutputMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type OutputType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OutputType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OutputType", value);
			}
		}

		public DataClass DataClass
		{
			get
			{
				return (DataClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataClass"), typeof(DataClass));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataClass", value);
			}
		}

		public bool IsImplicit
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsImplicit"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsImplicit", value);
			}
		}

		public OutputMetadata(int index, Type ownerType, Type outputType, DataClass dataClass)
			: base(index, ownerType, null)
		{
			OutputType = outputType;
			DataClass = dataClass;
			IsImplicit = true;
		}

		public OutputMetadata(int index, FieldInfo field, DataClass dataClass)
			: base(index, field.DeclaringType, field)
		{
			OutputType = field.FieldType.GenericTypeArguments[0];
			DataClass = dataClass;
			IsImplicit = false;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OutputMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		public int Index { get; private set; }

		public string Name { get; private set; }

		public FieldInfo Field { get; private set; }

		public PropertyInfo ChangeTypeEval { get; private set; }

		public OutputChangeSource ChangeType { get; private set; }

		public OutputMetadataBase(int index, Type ownerType, FieldInfo field)
		{
			Index = index;
			Name = field?.Name ?? "*";
			Field = field;
			PropertyInfo property = ownerType.GetProperty((!(field == null)) ? (field.Name + "ChangeType") : "OutputChangeType", BindingFlags.Instance | BindingFlags.Public);
			if (property != null)
			{
				ChangeType = OutputChangeSource.Dynamic;
				ChangeTypeEval = property;
				return;
			}
			ChangeType = OutputChangeSource.Passthrough;
			if (field != null)
			{
				if (field.GetCustomAttribute<ContinuouslyChangingAttribute>() != null)
				{
					ChangeType = OutputChangeSource.Continuous;
				}
				else if (field.GetCustomAttribute<ChangeSourceAttribute>() != null)
				{
					ChangeType = OutputChangeSource.Individual;
				}
			}
			else if (ownerType.GetCustomAttribute<ContinuouslyChangingAttribute>() != null)
			{
				ChangeType = OutputChangeSource.Continuous;
			}
			else if (ownerType.GetCustomAttribute<ChangeSourceAttribute>() != null)
			{
				ChangeType = OutputChangeSource.Individual;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class ReferenceMetadata : IElementMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public Type ReferenceType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ReferenceType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ReferenceType", value);
			}
		}

		public FieldInfo Field
		{
			get
			{
				return (FieldInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Field"), typeof(FieldInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Field", value);
			}
		}

		public ReferenceMetadata(int index, FieldInfo field)
		{
			Index = index;
			Name = field.Name;
			Field = field;
			ReferenceType = field.FieldType.GetGenericArguments()[0];
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ReferenceMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface INode : ResoniteBridge.ResoniteBridgeValueHolder
	{
		NodeRuntime Runtime { get; }

		NodeMetadata Metadata { get; }

		int IndexInGroup { get; set; }

		int AllocationIndex { get; }

		string Overload { get; }

		bool IsPassthrough { get; }

		bool ListensToChanges { get; }

		int InputCount { get; }

		int OutputCount { get; }

		int ArgumentCount { get; }

		int ImpulseCount { get; }

		int OperationCount { get; }

		int FixedInputCount { get; }

		int FixedOutputCount { get; }

		int FixedImpulseCount { get; }

		int FixedOperationCount { get; }

		int FixedReferenceCount { get; }

		int FixedGlobalRefCount { get; }

		int DynamicInputCount { get; }

		int DynamicOutputCount { get; }

		int DynamicImpulseCount { get; }

		int DynamicOperationCount { get; }

		void Initialize(NodeRuntime runtime, int allocationIndex);

		void Dispose();

		void SetInputSource(ElementRef input, IOutput source);

		IOutput GetInputSource(int index);

		void SetInputSource(int index, IOutput source);

		string GetInputName(int index);

		Type GetInputType(int index);

		DataClass GetInputTypeClass(int index);

		object GetInputDefaultValue(int index);

		bool IsInputConditional(int index);

		bool IsInputListeningToChanges(int index);

		CrossRuntimeInputAttribute GetInputCrossRuntime(int index);

		IInputList GetInputList(int index);

		string GetInputListName(int index);

		Type GetInputListTypeConstraint(int index);

		IOutput GetOutput(int index);

		string GetOutputName(int index);

		Type GetOutputType(int index);

		DataClass GetOutputTypeClass(int index);

		bool IsOutputImplicit(int index);

		OutputChangeSource GetOutputChangeType(int index);

		IOutputList GetOutputList(int index);

		string GetOutputListName(int index);

		string GetImpulseName(int index);

		IOperation GetImpulseTarget(int index);

		void SetImpulseTarget(int index, IOperation target);

		IOperation GetOperation(int index);

		string GetOperationName(int index);

		bool IsOperationAsync(int index);

		bool CanOperationContinueTo(int index, string impulseName);

		IImpulseList GetImpulseList(int index);

		string GetImpulseListName(int index);

		bool CanOperationListContinueTo(int index, string impulseName);

		IOperationList GetOperationList(int index);

		string GetOperationListName(int index);

		ImpulseType GetImpulseType(int index);

		bool OperationHasSingleContinuation(int index);

		bool OperationHasSyncAsyncTransition(int index);

		string GetReferenceName(int index);

		Type GetReferenceType(int index);

		INode GetReferenceTarget(int index);

		void SetReferenceTarget(int index, INode target);

		bool TrySetReferenceTarget(int index, INode target);

		string GetGlobalRefName(int index);

		Type GetGlobalRefValueType(int index);

		Global GetGlobalRefBinding(int index);

		void SetGlobalRefBinding(int index, Global binding);

		bool TrySetGlobalRefBinding(int index, Global binding);

		void CopyDynamicOutputLayout(INode source);

		void CopyDynamicOperationLayout(INode source);
	}
	public abstract class Node : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public NodeRuntime Runtime { get; private set; }

		public int IndexInGroup { get; set; }

		public int AllocationIndex { get; private set; }

		public virtual NodeMetadata Metadata => NodeMetadataHelper.GetMetadata(GetType());

		public virtual string Overload => Metadata.Overload;

		public virtual bool IsPassthrough => Metadata.IsPassthrough;

		public virtual bool ListensToChanges => Metadata.IsPotentiallyListeningToChanges;

		public virtual int InputCount
		{
			get
			{
				NodeMetadata metadata = Metadata;
				if (!metadata.HasDynamicInputs)
				{
					return metadata.FixedInputCount;
				}
				int num = metadata.FixedInputCount;
				for (int i = 0; i < metadata.DynamicInputs.Count; i++)
				{
					num += GetInputList(i).Count;
				}
				return num;
			}
		}

		public virtual int OutputCount
		{
			get
			{
				NodeMetadata metadata = Metadata;
				if (!metadata.HasDynamicOutputs)
				{
					return metadata.FixedOutputCount;
				}
				int num = metadata.FixedOutputCount;
				for (int i = 0; i < metadata.DynamicOutputCount; i++)
				{
					num += GetOutputList(i).Count;
				}
				return num;
			}
		}

		public virtual int ImpulseCount
		{
			get
			{
				NodeMetadata metadata = Metadata;
				if (!metadata.HasDynamicImpulses)
				{
					return metadata.FixedImpulseCount;
				}
				int num = metadata.FixedImpulseCount;
				for (int i = 0; i < metadata.DynamicImpulses.Count; i++)
				{
					num += GetImpulseList(i).Count;
				}
				return num;
			}
		}

		public virtual int ArgumentCount
		{
			get
			{
				NodeMetadata metadata = Metadata;
				if (!metadata.HasDynamicInputs)
				{
					return metadata.FixedArgumentCount;
				}
				int num = metadata.FixedArgumentCount;
				for (int i = 0; i < metadata.DynamicInputCount; i++)
				{
					if (!metadata.DynamicInputs[i].IsConditional)
					{
						num += GetInputList(i).Count;
					}
				}
				return num;
			}
		}

		public virtual int OperationCount => FixedOperationCount;

		public virtual int FixedInputCount => Metadata.FixedInputCount;

		public virtual int FixedOutputCount => Metadata.FixedOutputCount;

		public virtual int FixedImpulseCount => Metadata.FixedImpulseCount;

		public virtual int FixedOperationCount => Metadata.FixedOperationCount;

		public virtual int FixedReferenceCount => Metadata.FixedReferenceCount;

		public virtual int FixedGlobalRefCount => Metadata.FixedGlobalRefCount;

		public virtual int DynamicInputCount => Metadata.DynamicInputCount;

		public virtual int DynamicOutputCount => Metadata.DynamicOutputCount;

		public virtual int DynamicImpulseCount => Metadata.DynamicImpulseCount;

		public virtual int DynamicOperationCount => Metadata.DynamicOperationCount;

		public void Initialize(NodeRuntime runtime, int allocationIndex)
		{
			if (Runtime != null)
			{
				throw new InvalidOperationException("Runtime is already assigned to this node");
			}
			Runtime = runtime;
			AllocationIndex = allocationIndex;
		}

		public void Dispose()
		{
			if (Runtime == null)
			{
				throw new InvalidOperationException("Node hasn't been initialized");
			}
			for (int i = 0; i < FixedGlobalRefCount; i++)
			{
				SetGlobalRefBinding(i, null);
			}
			Runtime = null;
		}

		public virtual IInputList GetDynamicInputList(ref int index, out InputListMetadata listMetadata)
		{
			index -= FixedInputCount;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			for (int i = 0; i < metadata.DynamicInputCount; i++)
			{
				IInputList inputList = GetInputList(i);
				if (index < inputList.Count)
				{
					listMetadata = metadata.DynamicInputs[i];
					return inputList;
				}
				index -= inputList.Count;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		public virtual IOutputList GetDynamicOutputList(ref int index, out OutputListMetadata listMetadata)
		{
			index -= FixedOutputCount;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			for (int i = 0; i < metadata.DynamicOutputCount; i++)
			{
				IOutputList outputList = GetOutputList(i);
				if (index < outputList.Count)
				{
					listMetadata = metadata.DynamicOutputs[i];
					return outputList;
				}
				index -= outputList.Count;
			}
			throw new ArgumentOutOfRangeException("index", $"Could not find output. FixedOutputCount: {FixedOutputCount}. DynamicOutputCount: {DynamicOutputCount}. Node: {this}");
		}

		public virtual IOutput GetInputSource(int index)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			if (index < FixedInputCount)
			{
				FieldInfo field = metadata.FixedInputs[index].Field;
				object value = field.GetValue(this);
				return field.FieldType.GetProperty("Source").GetValue(value) as IOutput;
			}
			InputListMetadata listMetadata;
			return GetDynamicInputList(ref index, out listMetadata).GetInputSource(index);
		}

		public virtual void SetInputSource(ElementRef input, IOutput source)
		{
			if (input.IsDynamic)
			{
				IInputList inputList = GetInputList(input.listIndex);
				if (input.AddToList)
				{
					inputList.AddInput(source);
				}
				else
				{
					inputList.SetInputSource(input.index, source);
				}
			}
			else
			{
				SetInputSource(input.index, source);
			}
		}

		public virtual void SetInputSource(int index, IOutput source)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			if (index < FixedInputCount)
			{
				FieldInfo field = metadata.FixedInputs[index].Field;
				object value = field.GetValue(this);
				field.FieldType.GetProperty("Source").SetValue(value, source);
				field.SetValue(this, value);
			}
			else
			{
				GetDynamicInputList(ref index, out var _).SetInputSource(index, source);
			}
		}

		public virtual IInputList GetInputList(int index)
		{
			return Metadata.DynamicInputs[index].Field.GetValue(this) as IInputList;
		}

		public virtual string GetInputListName(int index)
		{
			return Metadata.DynamicInputs[index].Name;
		}

		public virtual Type GetInputListTypeConstraint(int index)
		{
			return Metadata.DynamicInputs[index].TypeConstraint;
		}

		public virtual IOutput GetOutput(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return metadata.FixedOutputs[index].Field.GetValue(this) as IOutput;
			}
			OutputListMetadata listMetadata;
			return GetDynamicOutputList(ref index, out listMetadata).GetOutput(index);
		}

		public virtual string GetOutputName(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return metadata.FixedOutputs[index].Name;
			}
			GetDynamicOutputList(ref index, out var listMetadata);
			return listMetadata.Name + $".[{index}]";
		}

		public virtual IOutputList GetOutputList(int index)
		{
			return Metadata.DynamicOutputs[index].Field.GetValue(this) as IOutputList;
		}

		public virtual string GetOutputListName(int index)
		{
			return Metadata.DynamicOutputs[index].Name;
		}

		public virtual string GetInputName(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].Name;
			}
			GetDynamicInputList(ref index, out var listMetadata);
			return listMetadata.Name + $".[{index}]";
		}

		public virtual Type GetInputType(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].InputType;
			}
			InputListMetadata listMetadata;
			return GetDynamicInputList(ref index, out listMetadata).GetInputType(index);
		}

		public virtual DataClass GetInputTypeClass(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].DataClass;
			}
			InputListMetadata listMetadata;
			return GetDynamicInputList(ref index, out listMetadata).GetDataClass(index);
		}

		public virtual object GetInputDefaultValue(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].DefaultValue;
			}
			InputListMetadata listMetadata;
			IInputList dynamicInputList = GetDynamicInputList(ref index, out listMetadata);
			return listMetadata.DefaultValue ?? dynamicInputList.GetDefaultValue(index);
		}

		public virtual bool IsInputConditional(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].IsConditional;
			}
			GetDynamicInputList(ref index, out var listMetadata);
			return listMetadata.IsConditional;
		}

		public virtual bool IsInputListeningToChanges(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return IsListening(metadata.FixedInputs[index]);
			}
			GetDynamicInputList(ref index, out var listMetadata);
			return IsListening(listMetadata);
			bool IsListening(InputMetadataBase m)
			{
				if (m.IsListeningToChangesEval != null)
				{
					return (bool)m.IsListeningToChangesEval.GetValue(this);
				}
				return m.IsListeningToChanges.Value;
			}
		}

		public virtual CrossRuntimeInputAttribute GetInputCrossRuntime(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedInputCount)
			{
				return metadata.FixedInputs[index].CrossRuntime;
			}
			GetDynamicInputList(ref index, out var listMetadata);
			return listMetadata.CrossRuntime;
		}

		public virtual Type GetOutputType(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return metadata.FixedOutputs[index].OutputType;
			}
			OutputListMetadata listMetadata;
			return GetDynamicOutputList(ref index, out listMetadata).GetOutputType(index);
		}

		public virtual DataClass GetOutputTypeClass(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return metadata.FixedOutputs[index].DataClass;
			}
			OutputListMetadata listMetadata;
			return GetDynamicOutputList(ref index, out listMetadata).GetOutputClass(index);
		}

		public virtual bool IsOutputImplicit(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return metadata.FixedOutputs[index].IsImplicit;
			}
			return false;
		}

		public virtual OutputChangeSource GetOutputChangeType(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOutputCount)
			{
				return GetChangeType(metadata.FixedOutputs[index]);
			}
			GetDynamicOutputList(ref index, out var listMetadata);
			return GetChangeType(listMetadata);
			OutputChangeSource GetChangeType(OutputMetadataBase m)
			{
				if (m.ChangeTypeEval != null)
				{
					return (OutputChangeSource)m.ChangeTypeEval.GetValue(this);
				}
				return m.ChangeType;
			}
		}

		public virtual IOperation GetImpulseTarget(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedImpulseCount)
			{
				FieldInfo field = metadata.FixedImpulses[index].Field;
				object value = field.GetValue(this);
				return field.FieldType.GetProperty("Target").GetValue(value) as IOperation;
			}
			ImpulseListMetadata listMetadata;
			return GetDynamicImpulseList(ref index, out listMetadata).GetImpulse(index).Target;
		}

		public virtual string GetImpulseName(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedImpulseCount)
			{
				return metadata.FixedImpulses[index].Name;
			}
			GetDynamicImpulseList(ref index, out var listMetadata);
			return listMetadata.Name + $".[{index}]";
		}

		public virtual void SetImpulseTarget(int index, IOperation target)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedImpulseCount)
			{
				FieldInfo field = metadata.FixedImpulses[index].Field;
				object value = field.GetValue(this);
				field.FieldType.GetProperty("Target").SetValue(value, target);
				field.SetValue(this, value);
			}
			else
			{
				GetDynamicImpulseList(ref index, out var _).SetImpulseTarget(index, target);
			}
		}

		public virtual IImpulseList GetImpulseList(int index)
		{
			return Metadata.DynamicImpulses[index].Field.GetValue(this) as IImpulseList;
		}

		public virtual IImpulseList GetDynamicImpulseList(ref int index, out ImpulseListMetadata listMetadata)
		{
			index -= FixedImpulseCount;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			for (int i = 0; i < metadata.DynamicImpulseCount; i++)
			{
				IImpulseList impulseList = GetImpulseList(i);
				if (index < impulseList.Count)
				{
					listMetadata = metadata.DynamicImpulses[i];
					return impulseList;
				}
				index -= impulseList.Count;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		public virtual string GetImpulseListName(int index)
		{
			return Metadata.DynamicImpulses[index].Name;
		}

		public virtual IOperation GetOperation(int index)
		{
			FieldInfo field = Metadata.FixedOperations[index].Field;
			if (field == null)
			{
				return this as IOperation;
			}
			return field.GetValue(this) as IOperation;
		}

		public virtual string GetOperationName(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOperationCount)
			{
				return metadata.FixedOperations[index].Name;
			}
			GetDynamicOperationList(ref index, out var listMetadata);
			return listMetadata.Name + $".[{index}]";
		}

		public virtual IOperationList GetDynamicOperationList(ref int index, out OperationListMetadata listMetadata)
		{
			index -= FixedOperationCount;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			NodeMetadata metadata = Metadata;
			for (int i = 0; i < metadata.DynamicOperationCount; i++)
			{
				IOperationList operationList = GetOperationList(i);
				if (index < operationList.Count)
				{
					listMetadata = metadata.DynamicOperations[i];
					return operationList;
				}
				index -= operationList.Count;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		public virtual bool IsOperationAsync(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOperationCount)
			{
				return metadata.FixedOperations[index].IsAsync;
			}
			GetDynamicOperationList(ref index, out var listMetadata);
			return GetOperationList(listMetadata.Index).IsOperationAsync(index);
		}

		public virtual bool CanOperationContinueTo(int index, string impulseName)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedOperationCount)
			{
				return (metadata.FixedOperations[index]?.PossibleContinuations?.CanContinueTo(impulseName)).GetValueOrDefault(true);
			}
			GetDynamicOperationList(ref index, out var listMetadata);
			return listMetadata.PossibleContinuations?.CanContinueTo(impulseName) ?? true;
		}

		public virtual bool CanOperationListContinueTo(int index, string impulseName)
		{
			return (Metadata.DynamicOperations[index]?.PossibleContinuations?.CanContinueTo(impulseName)).GetValueOrDefault(true);
		}

		public virtual IOperationList GetOperationList(int index)
		{
			return Metadata.DynamicOperations[index].Field.GetValue(this) as IOperationList;
		}

		public virtual string GetOperationListName(int index)
		{
			return Metadata.DynamicOperations[index].Name;
		}

		public virtual ImpulseType GetImpulseType(int index)
		{
			NodeMetadata metadata = Metadata;
			if (index < metadata.FixedImpulseCount)
			{
				return metadata.FixedImpulses[index].Type;
			}
			GetDynamicImpulseList(ref index, out var listMetadata);
			return GetImpulseList(listMetadata.Index).GetImpulseType(index);
		}

		public virtual bool OperationHasSingleContinuation(int index)
		{
			NodeMetadata metadata = Metadata;
			if (metadata.FixedContinuationCount == 1 && metadata.DynamicImpulseCount == 0)
			{
				for (int i = 0; i < metadata.FixedImpulseCount; i++)
				{
					if (metadata.FixedImpulses[i].Type == ImpulseType.Continuation)
					{
						if (GetImpulseTarget(i) == null)
						{
							return false;
						}
						return CanOperationContinueTo(index, metadata.FixedImpulses[i].Name);
					}
				}
				throw new Exception("This code should not be reachable, since the node indicated there's one fixed continuation");
			}
			bool flag = false;
			for (int j = 0; j < ImpulseCount; j++)
			{
				if (GetImpulseTarget(j) != null && GetImpulseType(j) == ImpulseType.Continuation && CanOperationContinueTo(index, GetImpulseName(j)))
				{
					if (flag)
					{
						return false;
					}
					flag = true;
				}
			}
			return flag;
		}

		public virtual bool OperationHasSyncAsyncTransition(int index)
		{
			_ = Metadata;
			bool flag = IsOperationAsync(index);
			for (int i = 0; i < ImpulseCount; i++)
			{
				if (GetImpulseType(i) != 0)
				{
					continue;
				}
				IOperation impulseTarget = GetImpulseTarget(i);
				if (impulseTarget != null && CanOperationContinueTo(index, GetImpulseName(i)))
				{
					if (impulseTarget is IAsyncOperation && !flag)
					{
						return true;
					}
					if (impulseTarget is ISyncOperation && flag)
					{
						return true;
					}
				}
			}
			return false;
		}

		public virtual string GetReferenceName(int index)
		{
			return Metadata.FixedReferences[index].Name;
		}

		public virtual Type GetReferenceType(int index)
		{
			return Metadata.FixedReferences[index].ReferenceType;
		}

		public virtual INode GetReferenceTarget(int index)
		{
			ReferenceMetadata referenceMetadata = Metadata.FixedReferences[index];
			object value = referenceMetadata.Field.GetValue(this);
			return (INode)referenceMetadata.Field.FieldType.GetField("Target").GetValue(value);
		}

		public virtual void SetReferenceTarget(int index, INode node)
		{
			if (!TrySetReferenceTarget(index, node))
			{
				throw new ArgumentException($"Target is not compatible with the reference type. Node Type: {node.GetType()}. " + $"ReferenceType: {Metadata.FixedReferences[index].ReferenceType}");
			}
		}

		public virtual bool TrySetReferenceTarget(int index, INode node)
		{
			ReferenceMetadata referenceMetadata = Metadata.FixedReferences[index];
			if (node != null && !referenceMetadata.ReferenceType.IsAssignableFrom(node.GetType()))
			{
				return false;
			}
			object value = referenceMetadata.Field.GetValue(this);
			referenceMetadata.Field.FieldType.GetField("Target").SetValue(value, node);
			referenceMetadata.Field.SetValue(this, value);
			return true;
		}

		public virtual string GetGlobalRefName(int index)
		{
			return Metadata.FixedGlobalRefs[index].Name;
		}

		public virtual Type GetGlobalRefValueType(int index)
		{
			return Metadata.FixedGlobalRefs[index].ValueType;
		}

		public virtual Global GetGlobalRefBinding(int index)
		{
			GlobalRefMetadata globalRefMetadata = Metadata.FixedGlobalRefs[index];
			object value = globalRefMetadata.Field.GetValue(this);
			return (Global)globalRefMetadata.Field.FieldType.GetProperty("Global").GetValue(value);
		}

		public virtual void SetGlobalRefBinding(int index, Global binding)
		{
			if (!TrySetGlobalRefBinding(index, binding))
			{
				throw new ArgumentException("Target is not compatible with the binding value type");
			}
		}

		public virtual bool TrySetGlobalRefBinding(int index, Global binding)
		{
			GlobalRefMetadata globalRefMetadata = Metadata.FixedGlobalRefs[index];
			if (binding != null && binding.ValueType != globalRefMetadata.ValueType)
			{
				return false;
			}
			object value = globalRefMetadata.Field.GetValue(this);
			globalRefMetadata.Field.FieldType.GetProperty("Global").SetValue(value, binding);
			return true;
		}

		public void CopyDynamicOutputLayout(INode node)
		{
			NodeMetadata metadata = node.Metadata;
			for (int i = 0; i < DynamicOutputCount; i++)
			{
				IOutputList outputList = GetOutputList(i);
				string outputListName = GetOutputListName(i);
				OutputListMetadata outputListByName = metadata.GetOutputListByName(outputListName);
				if (outputListByName == null)
				{
					continue;
				}
				IOutputList outputList2 = node.GetOutputList(outputListByName.Index);
				if (outputList is OutputList outputList3)
				{
					for (int j = 0; j < outputList2.Count; j++)
					{
						outputList3.AddOutputAuto(outputList2.GetOutputType(j));
					}
					continue;
				}
				if (outputList.Count > outputList2.Count)
				{
					outputList.Clear();
				}
				while (outputList.Count < outputList2.Count)
				{
					outputList.AddOutput();
				}
			}
		}

		public void CopyDynamicOperationLayout(INode node)
		{
			NodeMetadata metadata = node.Metadata;
			for (int i = 0; i < DynamicOperationCount; i++)
			{
				IOperationList operationList = GetOperationList(i);
				string operationListName = GetOperationListName(i);
				OperationListMetadata operationListByName = metadata.GetOperationListByName(operationListName);
				if (operationListByName != null)
				{
					IOperationList operationList2 = node.GetOperationList(operationListByName.Index);
					while (operationList.Count < operationList2.Count)
					{
						operationList.AddOperation();
					}
					while (operationList.Count > operationList2.Count)
					{
						operationList.RemoveOperation();
					}
				}
			}
		}

		public override string ToString()
		{
			return $"Node {GetType().Name} ({IndexInGroup}; {AllocationIndex}) (Instance: {GetHashCode()}) on Group {Runtime?.Group?.Name}";
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class NodeRuntime : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private DataImportNode importNode;

		private ImpulseExportNode exportNode;

		private List<IOutput> dataExports = new List<IOutput>();

		private OutputList dataImports;

		private List<ImpulseImport> impulseImports = new List<ImpulseImport>();

		private List<ImpulseExport> impulseExports = new List<ImpulseExport>();

		private List<Global> globals = new List<Global>();

		public NodeGroup Group { get; private set; }

		public abstract int NodeCount { get; }

		public int DataImportsCount => dataImports.Count;

		public int DataExportsCount => dataExports.Count;

		public IEnumerable<IOutput> DataExports => dataExports;

		public int ImpulseImportsCount => impulseImports.Count;

		public int ImpulseExportCount => impulseExports.Count;

		public int GlobalsCount => globals.Count;

		public abstract INode AddNode(Type type);

		public abstract bool RemoveNode(INode node);

		public abstract int RemoveNodes(Predicate<INode> predicate);

		public abstract INode GetNodeGeneric(int index);

		public abstract void TranslateInputs(INode target, INode source, Dictionary<INode, INode> nodeReplacements = null, List<InsertedConversion> insertedConversions = null);

		public abstract void TranslateImpulses(INode target, INode source, Dictionary<INode, INode> nodeReplcements = null);

		public abstract void TranslateReferences(INode target, INode source, Dictionary<INode, INode> nodeReplacements = null);

		public abstract void SortNodesByIndex();

		internal abstract int ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, bool cache) where T : INode;

		internal void Init(NodeGroup group)
		{
			Group = group;
			importNode = new DataImportNode();
			importNode.Initialize(this, group.GetNodeAllocationIndex());
			exportNode = new ImpulseExportNode();
			exportNode.Initialize(this, group.GetNodeAllocationIndex());
			dataImports = new OutputList(importNode);
		}

		public abstract Type GetCompatibleNodeType(Type type);

		public ValueOutput<T> AddValueImport<T>() where T : unmanaged
		{
			return dataImports.AddValueOutput<T>();
		}

		public ObjectOutput<T> AddObjectImport<T>()
		{
			return dataImports.AddObjectOutput<T>();
		}

		public ValueOutput<T> GetValueImport<T>(int index) where T : unmanaged
		{
			return dataImports.GetValueOutput<T>(index);
		}

		public ObjectOutput<T> GetObjectImport<T>(int index)
		{
			return dataImports.GetObjectOutput<T>(index);
		}

		public IOutput GetImport(int index)
		{
			return dataImports.GetOutput(index);
		}

		public Type GetImportType(int index)
		{
			return dataImports.GetOutputType(index);
		}

		public DataClass GetImportDataClass(int index)
		{
			return dataImports.GetOutputClass(index);
		}

		public IOutput GetValueExport(int index)
		{
			return dataExports[index];
		}

		public void SetValueExport(int index, IOutput source)
		{
			dataExports[index] = source;
		}

		public void AddExport(IOutput output)
		{
			dataExports.Add(output);
		}

		public void RemoveExport(IOutput output)
		{
			dataExports.Remove(output);
		}

		public void ClearValueExports()
		{
			dataExports.Clear();
		}

		public void AddImpulseImport(IOperation operation, bool isAsync = false)
		{
			if (!isAsync && operation is IAsyncOperation)
			{
				throw new ArgumentException("Cannot add async operation as sync impulse import");
			}
			impulseImports.Add(new ImpulseImport(operation, isAsync));
		}

		public void AddSyncImpulseImport(ISyncOperation operation)
		{
			AddImpulseImport(operation);
		}

		public void AddAsyncImpulseImport(IOperation operation)
		{
			AddImpulseImport(operation, isAsync: true);
		}

		public bool IsImpulseImportAsync(int index)
		{
			return impulseImports[index].isAsync;
		}

		public void RemoveImpulseImport(int index)
		{
			impulseImports.RemoveAt(index);
		}

		public void SetImpulseImport(int index, IOperation operation, bool isAsync)
		{
			impulseImports[index] = new ImpulseImport(operation, isAsync);
		}

		public void ClearImpulseImports()
		{
			impulseImports.Clear();
		}

		public IOperation GetImpulseImport(int index)
		{
			return impulseImports[index].target;
		}

		public ContinuationExport AddContinuationExport()
		{
			ContinuationExport continuationExport = new ContinuationExport(exportNode, impulseExports.Count);
			impulseExports.Add(continuationExport);
			return continuationExport;
		}

		public CallExport AddCallExport()
		{
			CallExport callExport = new CallExport(exportNode, impulseExports.Count);
			impulseExports.Add(callExport);
			return callExport;
		}

		public AsyncCallExport AddAsyncCallExport()
		{
			AsyncCallExport asyncCallExport = new AsyncCallExport(exportNode, impulseExports.Count);
			impulseExports.Add(asyncCallExport);
			return asyncCallExport;
		}

		public void ClearImpulseExports()
		{
			impulseExports.Clear();
		}

		public Global<T> AddGlobal<T>(string name)
		{
			Global<T> global = new Global<T>(this, globals.Count, name);
			globals.Add(global);
			return global;
		}

		public Global GetGlobal(int index)
		{
			return globals[index];
		}

		public Global<T> GetGlobal<T>(int index)
		{
			return (Global<T>)globals[index];
		}

		public void ClearGlobals()
		{
			globals.Clear();
		}

		public void RemapImportsAndExports(Dictionary<INode, INode> remappedNodes)
		{
			for (int i = 0; i < DataExportsCount; i++)
			{
				IOutput valueExport = GetValueExport(i);
				IOutput output = valueExport.RemapOutput(remappedNodes);
				if (output != valueExport)
				{
					SetValueExport(i, output);
				}
			}
			for (int j = 0; j < ImpulseImportsCount; j++)
			{
				IOperation impulseImport = GetImpulseImport(j);
				IOperation operation = impulseImport.RemapTarget(remappedNodes);
				if (operation != impulseImport)
				{
					SetImpulseImport(j, operation, IsImpulseImportAsync(j));
				}
			}
		}

		public static bool CanTargetRuntime(NodeRuntime ownerRuntime, CrossRuntimeInputAttribute inputCrossRuntime, IOutput source)
		{
			return CanTargetRuntime(ownerRuntime, inputCrossRuntime, source.OwnerNode.Runtime);
		}

		public static bool CanTargetRuntime(NodeRuntime ownerRuntime, CrossRuntimeInputAttribute inputCrossRuntime, NodeRuntime targetRuntime)
		{
			return inputCrossRuntime?.IsValidTargetRuntime(targetRuntime) ?? (targetRuntime == ownerRuntime);
		}

		public static bool AreSameRuntimeTypes(NodeRuntime ownerRuntime, IOutput source)
		{
			return AreSameRuntimeTypes(ownerRuntime, source?.OwnerNode?.Runtime);
		}

		public static bool AreSameRuntimeTypes(NodeRuntime ownerRuntime, NodeRuntime targetRuntime)
		{
			return ownerRuntime.GetType() == targetRuntime?.GetType();
		}

		public override string ToString()
		{
			return $"{GetType()} on {Group}";
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class NodeRuntime<N> : NodeRuntime, ResoniteBridge.ResoniteBridgeValueHolder where N : class, INode
	{
		private List<N> nodes = new List<N>();

		private ConcurrentDictionary<Type, IList> cachedNodeTypes = new ConcurrentDictionary<Type, IList>();

		private List<IExecutionNestedNode> cachedNestedNodes;

		public override int NodeCount => nodes.Count;

		public IEnumerable<N> Nodes => nodes;

		public static bool IsCompatibleNodeType(Type type)
		{
			return typeof(N).IsAssignableFrom(type);
		}

		public N GetNode(int index)
		{
			return nodes[index];
		}

		public override INode GetNodeGeneric(int index)
		{
			return nodes[index];
		}

		public void AddNode(N node)
		{
			if (node.Runtime != null)
			{
				throw new InvalidOperationException("Node already belongs to a runtime and cannot be added");
			}
			node.Initialize(this, base.Group.GetNodeAllocationIndex());
			nodes.Add(node);
		}

		public T AddNode<T>() where T : N, new()
		{
			T val = new T();
			AddNode((N)(object)val);
			return val;
		}

		public override INode AddNode(Type type)
		{
			type = GetCompatibleNodeType(type);
			if (type == null)
			{
				throw new ArgumentException($"Node of type {type} is not compatible with runtime {this}");
			}
			N val = (N)Activator.CreateInstance(type);
			val.Initialize(this, base.Group.GetNodeAllocationIndex());
			nodes.Add(val);
			return val;
		}

		public override bool RemoveNode(INode node)
		{
			if (nodes.Remove((N)node))
			{
				node.Dispose();
				return true;
			}
			return false;
		}

		public override int RemoveNodes(Predicate<INode> predicate)
		{
			foreach (N node in nodes)
			{
				if (predicate(node))
				{
					node.Dispose();
				}
			}
			return nodes.RemoveAll(predicate);
		}

		public override void SortNodesByIndex()
		{
			nodes.Sort((N a, N b) => a.IndexInGroup.CompareTo(b.IndexInGroup));
		}

		public override Type GetCompatibleNodeType(Type type)
		{
			if (IsCompatibleNodeType(type))
			{
				return type;
			}
			return null;
		}

		public ConnectionResult ConnectInput(INode node, string inputName, IOutput source, bool overload = true, bool explicitCast = false, bool allowMergingGroups = false)
		{
			InputMetadata inputByName = node.Metadata.GetInputByName(inputName);
			return ConnectInput(node, new ElementRef(inputByName.Index), source, overload, explicitCast, allowMergingGroups);
		}

		public ConnectionResult ConnectListInput(INode node, string listName, int inputIndex, IOutput source, bool overload = true, bool explicitCast = false, bool allowMergingGroups = false)
		{
			InputListMetadata inputListByName = node.Metadata.GetInputListByName(listName);
			return ConnectInput(node, new ElementRef(inputListByName.Index, inputIndex), source, overload, explicitCast, allowMergingGroups);
		}

		public ConnectionResult ConnectListInput(INode node, string listName, IOutput source, bool overload = true, bool explicitCast = false, bool allowMergingGroups = false)
		{
			InputListMetadata inputListByName = node.Metadata.GetInputListByName(listName);
			return ConnectInput(node, new ElementRef(inputListByName.Index, -1), source, overload, explicitCast, allowMergingGroups);
		}

		public ConnectionResult ConnectInput(INode node, ElementRef input, IOutput source, bool overload = true, bool explicitCast = false, bool allowMergingGroups = false)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (node.Runtime != this)
			{
				throw new InvalidOperationException($"Node {node} does not belong to runtime: {this}");
			}
			NodeMetadata metadata = node.Metadata;
			Type inputType;
			string name;
			CrossRuntimeInputAttribute crossRuntime;
			if (input.IsDynamic)
			{
				InputListMetadata inputListMetadata = metadata.DynamicInputs[input.listIndex];
				inputType = inputListMetadata.TypeConstraint;
				name = inputListMetadata.Name;
				crossRuntime = inputListMetadata.CrossRuntime;
			}
			else
			{
				InputMetadata inputMetadata = metadata.FixedInputs[input.index];
				inputType = inputMetadata.InputType;
				name = inputMetadata.Name;
				crossRuntime = inputMetadata.CrossRuntime;
			}
			if (inputType.IsInterface && inputType.GetInterface(typeof(INode).Name) != null && !typeof(INode).IsAssignableFrom(source.OutputType))
			{
				Node ownerNode = source.OwnerNode;
				Type type = ownerNode.GetType().GetInterfaces().FirstOrDefault(delegate(Type t)
				{
					if (t == inputType)
					{
						return true;
					}
					return inputType.IsGenericType && t.IsGenericType && t.GetGenericTypeDefinition() == inputType.GetGenericTypeDefinition();
				});
				if (type != null)
				{
					INode node2 = AddNode(typeof(ReferenceToOutput<>).MakeGenericType(type));
					ConnectionResult result = ConnectInput(node, input, (IOutput)node2, overload, explicitCast, allowMergingGroups);
					if (result.connected)
					{
						node2.SetReferenceTarget(0, ownerNode);
						return result.AddInsertedConversion(new InsertedConversion(node2, node, input));
					}
					RemoveNode(node2);
					return result;
				}
			}
			if (source.OutputType == inputType)
			{
				if (NodeRuntime.CanTargetRuntime(this, crossRuntime, source))
				{
					node.SetInputSource(input, source);
					return ConnectionResult.Success;
				}
				if (allowMergingGroups && NodeRuntime.AreSameRuntimeTypes(this, source))
				{
					node.SetInputSource(input, source);
					return ConnectionResult.Success;
				}
				return ConnectionResult.Failed("Target is in a different runtime that cannot be cross targetted.");
			}
			if (overload)
			{
				NodeConnections fromNode = NodeConnections.GetFromNode(node);
				fromNode.SetInput(input, name, source.OutputType, source.OwnerNode.Runtime);
				NodeOverloadContext nodeOverloadContext = new NodeOverloadContext(base.Group, this);
				OverloadResult overloadResult = nodeOverloadContext.TryOverload(node, fromNode, allowMergingGroups);
				if (overloadResult.IsSuccess)
				{
					if (nodeOverloadContext.OverloadedAnyNodes)
					{
						nodeOverloadContext.SwapNodes();
						node = nodeOverloadContext.GetSwappedNode(node);
					}
					ConnectionResult result2 = ((!input.IsDynamic) ? ConnectInput(node, name, source, overload: false, explicitCast, allowMergingGroups) : ConnectListInput(node, name, input.index, source, overload: false, explicitCast, allowMergingGroups));
					if (!result2.connected)
					{
						return result2;
					}
					if (nodeOverloadContext.OverloadedAnyNodes)
					{
						result2 = result2.Combine(ConnectionResult.Overload(nodeOverloadContext));
					}
					return result2;
				}
				ConnectionResult result3 = ConnectInput(node, input, source, overload: false, explicitCast, allowMergingGroups);
				if (result3.connected)
				{
					return result3;
				}
				return ConnectionResult.Failed("Failed to overload or connect directly.\nOverload failure reason: " + overloadResult.failReason + "\nDirect connection failure reason: " + result3.failReason);
			}
			if (TypeHelper.CanImplicitlyConvertTo(source.OutputType, inputType) || (explicitCast && TypeHelper.CanExplicitlyConvertTo(source.OutputType, inputType)))
			{
				Type castNode = CastHelper.GetCastNode(source.OutputType, inputType, this);
				if (castNode != null)
				{
					INode node3 = AddNode(castNode);
					node.SetInputSource(input, (IOutput)node3);
					node3.SetInputSource(0, source);
					return ConnectionResult.Conversion(new InsertedConversion((ICast)node3, node, input));
				}
			}
			return ConnectionResult.Failed($"Failed to find overload. Overload search enabled: {overload}");
		}

		public ConnectionResult SetReference(INode node, string referenceName, INode target, bool overload = true)
		{
			ReferenceMetadata referenceByName = node.Metadata.GetReferenceByName(referenceName);
			return SetReference(node, referenceByName.Index, target, overload);
		}

		public ConnectionResult SetReference(INode node, int referenceIndex, INode target, bool overload = true, bool allowMergingGroups = false)
		{
			ReferenceMetadata referenceMetadata = node.Metadata.FixedReferences[referenceIndex];
			if (node.TrySetReferenceTarget(referenceIndex, target))
			{
				return ConnectionResult.Success;
			}
			if (overload)
			{
				NodeConnections fromNode = NodeConnections.GetFromNode(node);
				fromNode.SetReference(referenceMetadata.Name, target.GetType(), target.Runtime);
				NodeOverloadContext nodeOverloadContext = new NodeOverloadContext(base.Group, this);
				OverloadResult overloadResult = nodeOverloadContext.TryOverload(node, fromNode, allowMergingGroups);
				if (overloadResult.IsSuccess)
				{
					nodeOverloadContext.SwapNodes();
					node = nodeOverloadContext.GetSwappedNode(node);
					ConnectionResult result = SetReference(node, referenceMetadata.Name, target, overload: false);
					if (nodeOverloadContext.OverloadedAnyNodes)
					{
						result = result.Combine(ConnectionResult.Overload(nodeOverloadContext));
					}
					return result;
				}
				return ConnectionResult.Failed("Failed to overload: " + overloadResult.failReason);
			}
			return ConnectionResult.Failed($"Failed overload. Overload enabled: {overload}");
		}

		public override void TranslateInputs(INode target, INode source, Dictionary<INode, INode> remappedNodes = null, List<InsertedConversion> insertedCasts = null)
		{
			NodeMetadata metadata = source.Metadata;
			NodeMetadata metadata2 = target.Metadata;
			for (int i = 0; i < metadata.FixedInputCount; i++)
			{
				IOutput inputSource = source.GetInputSource(i);
				if (inputSource == null)
				{
					continue;
				}
				string name = metadata.FixedInputs[i].Name;
				InputMetadata inputByName = metadata2.GetInputByName(name);
				if (inputByName != null)
				{
					inputSource = inputSource.RemapOutput(remappedNodes).SkipImplicitCasts();
					ConnectionResult connectionResult = ConnectInput(target, new ElementRef(inputByName.Index), inputSource, overload: false);
					if (connectionResult.conversions != null)
					{
						insertedCasts?.AddRange(connectionResult.conversions);
					}
				}
			}
			for (int j = 0; j < metadata.DynamicInputCount; j++)
			{
				IInputList inputList = source.GetInputList(j);
				string inputListName = source.GetInputListName(j);
				InputListMetadata inputListByName = metadata2.GetInputListByName(inputListName);
				if (inputListByName == null)
				{
					continue;
				}
				target.GetInputList(inputListByName.Index).Clear();
				for (int k = 0; k < inputList.Count; k++)
				{
					IOutput inputSource2 = inputList.GetInputSource(k);
					inputSource2 = inputSource2.RemapOutput(remappedNodes).SkipImplicitCasts();
					if (inputSource2 != null)
					{
						ConnectionResult connectionResult2 = ConnectInput(target, new ElementRef(inputListByName.Index, -1), inputSource2, overload: false);
						if (connectionResult2.conversions != null)
						{
							insertedCasts?.AddRange(connectionResult2.conversions);
						}
					}
					else
					{
						target.GetInputList(inputListByName.Index).AddInput(null);
					}
				}
			}
		}

		public override void TranslateImpulses(INode target, INode source, Dictionary<INode, INode> remappedNodes = null)
		{
			NodeMetadata metadata = source.Metadata;
			NodeMetadata metadata2 = target.Metadata;
			for (int i = 0; i < source.FixedImpulseCount; i++)
			{
				IOperation impulseTarget = source.GetImpulseTarget(i);
				if (impulseTarget != null)
				{
					string name = metadata.FixedImpulses[i].Name;
					ImpulseMetadata impulseByName = metadata2.GetImpulseByName(name);
					if (impulseByName != null)
					{
						impulseTarget = impulseTarget.RemapTarget(remappedNodes);
						target.SetImpulseTarget(impulseByName.Index, impulseTarget);
					}
				}
			}
			for (int j = 0; j < source.DynamicImpulseCount; j++)
			{
				IImpulseList impulseList = source.GetImpulseList(j);
				string impulseListName = source.GetImpulseListName(j);
				ImpulseListMetadata impulseListByName = metadata2.GetImpulseListByName(impulseListName);
				if (impulseListByName != null)
				{
					IImpulseList impulseList2 = target.GetImpulseList(impulseListByName.Index);
					impulseList2.Clear();
					for (int k = 0; k < impulseList.Count; k++)
					{
						IOperation impulseTarget2 = impulseList.GetImpulseTarget(k);
						impulseTarget2 = impulseTarget2.RemapTarget(remappedNodes);
						impulseList2.AddImpulse(impulseTarget2);
					}
				}
			}
		}

		public override void TranslateReferences(INode target, INode source, Dictionary<INode, INode> remappedNodes = null)
		{
			NodeMetadata metadata = target.Metadata;
			for (int i = 0; i < source.FixedReferenceCount; i++)
			{
				INode node = source.GetReferenceTarget(i);
				if (node != null)
				{
					string referenceName = source.GetReferenceName(i);
					ReferenceMetadata referenceByName = metadata.GetReferenceByName(referenceName);
					if (remappedNodes != null && remappedNodes.TryGetValue(node, out var value))
					{
						node = value;
					}
					target.TrySetReferenceTarget(referenceByName.Index, node);
				}
			}
		}

		public IEnumerable<IExecutionNestedNode> GetNestedNodes(bool cache)
		{
			if (cache)
			{
				if (cachedNestedNodes == null)
				{
					cachedNestedNodes = Nodes.OfType<IExecutionNestedNode>().ToList();
				}
				return cachedNestedNodes;
			}
			return Nodes.OfType<IExecutionNestedNode>();
		}

		public IEnumerable<T> GetNodesOfType<T>(bool cache) where T : INode
		{
			if (cache)
			{
				Type typeFromHandle = typeof(T);
				if (cachedNodeTypes.TryGetValue(typeFromHandle, out var value))
				{
					return (IEnumerable<T>)value;
				}
				List<T> list = Nodes.OfType<T>().ToList();
				cachedNodeTypes.TryAdd(typeFromHandle, list);
				return list;
			}
			return Nodes.OfType<T>();
		}

		internal override int ForeachNode<T>(NodeEnumerationAction<T> action, NodeEnumerationContext context, bool cache)
		{
			int num = 0;
			foreach (T item in GetNodesOfType<T>(cache))
			{
				action(item, context);
				num++;
			}
			foreach (IExecutionNestedNode nestedNode in GetNestedNodes(cache))
			{
				if (context.TryEnterNestedNode(nestedNode))
				{
					num += ((NodeRuntime)nestedNode.TargetRuntime).ForeachNode(action, context, cache);
					context.ExitNestedNode(nestedNode);
				}
			}
			return num;
		}

		protected void ClearQueryCaches()
		{
			cachedNodeTypes.Clear();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public struct ElementPath<E> : IEquatable<ElementPath<E>>, IComparable<ElementPath<E>>, ResoniteBridge.ResoniteBridgeValueHolder where E : class
	{
		public NodeContextPath path
		{
			get
			{
				return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "path"), typeof(NodeContextPath));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "path", value);
			}
		}

		public E element
		{
			get
			{
				return (E)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "element"), typeof(E));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "element", value);
			}
		}

		public ElementPath(E element)
		{
			this.element = element;
			path = default(NodeContextPath);
		}

		public ElementPath(E element, NodeContextPath path)
		{
			this.path = path;
			this.element = element;
		}

		public ElementPath(E element, params INode[] path)
		{
			this.element = element;
			this.path = new NodeContextPath(path);
		}

		public ElementPath<E> Nest(INode node)
		{
			return (ElementPath<E>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Nest", node), typeof(ElementPath<E>));
		}

		public bool Equals(ElementPath<E> other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public int CompareTo(ElementPath<E> other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ElementPath(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct NodeContextPath : IEquatable<NodeContextPath>, IComparable<NodeContextPath>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private INode[] path
		{
			get
			{
				return (INode[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "path"), typeof(INode[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "path", value);
			}
		}

		public int PathLength
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PathLength"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PathLength", value);
			}
		}

		public INode this[int index] => GetNode(index);

		public INode GetNode(int index)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNode", index), typeof(INode));
		}

		public NodeContextPath(INode[] path)
		{
			if (path != null && path.Length == 0)
			{
				this.path = null;
			}
			else
			{
				this.path = path;
			}
		}

		public NodeContextPath Nest(INode node)
		{
			return (NodeContextPath)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Nest", node), typeof(NodeContextPath));
		}

		public bool Equals(NodeContextPath other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public int CompareTo(NodeContextPath other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public int FindSharedRootLength(NodeContextPath other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindSharedRootLength", other), typeof(int));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeContextPath(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate void NodeEnumerationAction<T>(T node, NodeEnumerationContext context) where T : INode;
	public class NodeEnumerationContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<NodeGroup> enteredGroups
		{
			get
			{
				return (HashSet<NodeGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "enteredGroups"), typeof(HashSet<NodeGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "enteredGroups", value);
			}
		}

		private List<INestedNode> nodePath
		{
			get
			{
				return (List<INestedNode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "nodePath"), typeof(List<INestedNode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "nodePath", value);
			}
		}

		public int CurrentDepth => nodePath.Count;

		public INestedNode GetNodePath(int index)
		{
			return (INestedNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNodePath", index), typeof(INestedNode));
		}

		public void Begin(NodeGroup group)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Begin", group);
		}

		public void End()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "End");
		}

		public bool TryEnterNestedNode(INestedNode node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryEnterNestedNode", node), typeof(bool));
		}

		public void ExitNestedNode(INestedNode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExitNestedNode", node);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeEnumerationContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class NodeQueryAcceleration : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<INode, HashSet<INode>> evaluatingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "evaluatingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "evaluatingNodes", value);
			}
		}

		private Dictionary<INode, HashSet<INode>> impulsingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "impulsingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "impulsingNodes", value);
			}
		}

		private Dictionary<INode, HashSet<INode>> referencingNodes
		{
			get
			{
				return (Dictionary<INode, HashSet<INode>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "referencingNodes"), typeof(Dictionary<INode, HashSet<INode>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "referencingNodes", value);
			}
		}

		public NodeGroup Group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Group", value);
			}
		}

		public NodeQueryAcceleration(NodeGroup group)
		{
			Group = group;
			Build();
		}

		private void Build()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Build");
		}

		public IEnumerable<INode> GetEvaluatingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEvaluatingNodes", node), typeof(IEnumerable<INode>));
		}

		public IEnumerable<INode> GetImpulsingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetImpulsingNodes", node), typeof(IEnumerable<INode>));
		}

		public IEnumerable<INode> GetReferencingNodes(INode node)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetReferencingNodes", node), typeof(IEnumerable<INode>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeQueryAcceleration(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		public bool WalkEvaluationInputs
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkEvaluationInputs"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkEvaluationInputs", value);
			}
		}

		public bool WalkImpulseTargets
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkImpulseTargets"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkImpulseTargets", value);
			}
		}

		public bool WalkReferences
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkReferences"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkReferences", value);
			}
		}

		public bool WalkEvaluatingNodes
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkEvaluatingNodes"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkEvaluatingNodes", value);
			}
		}

		public bool WalkImpulsingNodes
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkImpulsingNodes"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkImpulsingNodes", value);
			}
		}

		public bool WalkReferencingNodes
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkReferencingNodes"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkReferencingNodes", value);
			}
		}

		public bool SkipWalkingBack
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SkipWalkingBack"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SkipWalkingBack", value);
			}
		}

		public NodeRuntime OnlyRuntime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OnlyRuntime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OnlyRuntime", value);
			}
		}

		public Predicate<INode> NodeFilter
		{
			get
			{
				return (Predicate<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "NodeFilter"), typeof(Predicate<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "NodeFilter", value);
			}
		}

		public Dictionary<INode, bool> WalkedNodes
		{
			get
			{
				return (Dictionary<INode, bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WalkedNodes"), typeof(Dictionary<INode, bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WalkedNodes", value);
			}
		}

		public HashSet<INode> LoopNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LoopNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LoopNodes", value);
			}
		}

		public NodeQueryAcceleration Acceleration
		{
			get
			{
				return (NodeQueryAcceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Acceleration"), typeof(NodeQueryAcceleration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Acceleration", value);
			}
		}

		public bool RequiresAcceleration
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RequiresAcceleration"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RequiresAcceleration", value);
			}
		}

		public bool DetectedAnyLoops
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DetectedAnyLoops"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DetectedAnyLoops", value);
			}
		}

		public void EnsureAllocatedStructures(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureAllocatedStructures", node);
		}

		public bool BeginWalkingNode(INode node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BeginWalkingNode", node), typeof(bool));
		}

		public void FinishWalkingNode(INode node)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishWalkingNode", node);
		}

		public void SetWalkAll()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetWalkAll");
		}

		public void SetWalkAllEvaluation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetWalkAllEvaluation");
		}

		public void SetWalkAllImpulses()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetWalkAllImpulses");
		}

		public void SetWalkAllReferences()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetWalkAllReferences");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeQueryContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class NodeQueryHelper
	{
		public static IEnumerable<INode> EnumerateNodes(this INode node, NodeQueryContext context, INode sourceNode = null, SourceElement sourceElementType = SourceElement.NONE, object sourceElement = null)
		{
			return (IEnumerable<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeQueryHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EnumerateNodes", node, context, sourceNode, sourceElementType, sourceElement), typeof(IEnumerable<INode>));
		}
	}
	public static class EvaluationValidator
	{
		public static bool IsSourceValid(this INode node, int inputIndex, IOutput source)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSourceValid", node, inputIndex, source), typeof(bool));
		}

		public static bool CanEvaluate(this INode node, int inputIndex, IOutput source)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanEvaluate", node, inputIndex, source), typeof(bool));
		}

		public static bool AreEvaluationConnectionsValid(this NodeGroup group)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", group), typeof(bool));
		}

		public static bool AreEvaluationConnectionsValid(this NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "EvaluationValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "AreEvaluationConnectionsValid", runtime), typeof(bool));
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
		public bool isAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isAsync", value);
			}
		}

		public bool isContinuation
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isContinuation"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isContinuation", value);
			}
		}

		public HashSet<IOperation> allWalkedOperations
		{
			get
			{
				return (HashSet<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "allWalkedOperations"), typeof(HashSet<IOperation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "allWalkedOperations", value);
			}
		}

		public HashSet<IOperation> continuationLoopOperations
		{
			get
			{
				return (HashSet<IOperation>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "continuationLoopOperations"), typeof(HashSet<IOperation>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "continuationLoopOperations", value);
			}
		}

		public void ClearContinuation()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearContinuation");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseFlowContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ImpulseSource : IEquatable<ImpulseSource>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode node
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "node"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "node", value);
			}
		}

		public int impulseIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "impulseIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "impulseIndex", value);
			}
		}

		public ImpulseSource(INode node, int impulseIndex)
		{
			this.node = node;
			this.impulseIndex = impulseIndex;
		}

		public bool Equals(ImpulseSource other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ImpulseValidationError : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract string Description { get; }

		public override string ToString()
		{
			return Description;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class InvalidImpulseTargetError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode SourceNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SourceNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SourceNode", value);
			}
		}

		public int ImpulseIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ImpulseIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation TargetOperation
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TargetOperation"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TargetOperation", value);
			}
		}

		public string Reason
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Reason"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Reason", value);
			}
		}

		public override string Description => $"InvalidTarget for Impulse {SourceNode.GetImpulseName(ImpulseIndex)} on {SourceNode}. Targetting: {TargetOperation}. Reason: {Reason}";

		public InvalidImpulseTargetError(INode sourceNode, int impulseIndex, IOperation targetOperation, string reason)
		{
			SourceNode = sourceNode;
			ImpulseIndex = impulseIndex;
			TargetOperation = targetOperation;
			Reason = reason;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InvalidImpulseTargetError(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ImpulseLoopError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode Node
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Node"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Node", value);
			}
		}

		public int ImpulseIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ImpulseIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ImpulseIndex", value);
			}
		}

		public bool IsAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "IsAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "IsAsync", value);
			}
		}

		public override string Description => $"Continuation Loop detected at impulse {Node.GetImpulseName(ImpulseIndex)} on node {Node}";

		public ImpulseLoopError(INode node, int impulseIndex, bool isAsync)
		{
			Node = node;
			ImpulseIndex = impulseIndex;
			IsAsync = isAsync;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseLoopError(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ImpulseFlowError : ImpulseValidationError, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode ReferencingNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ReferencingNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ReferencingNode", value);
			}
		}

		public int ImpulseIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ImpulseIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ImpulseIndex", value);
			}
		}

		public IOperation Target
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Target"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Target", value);
			}
		}

		public bool ContextIsAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ContextIsAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ContextIsAsync", value);
			}
		}

		public bool ContextIsContinuation
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ContextIsContinuation"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ContextIsContinuation", value);
			}
		}

		public string Reason
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Reason"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Reason", value);
			}
		}

		public IOperation Origin
		{
			get
			{
				return (IOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Origin"), typeof(IOperation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Origin", value);
			}
		}

		public bool OriginIsAsync
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OriginIsAsync"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OriginIsAsync", value);
			}
		}

		public bool OriginIsContinuation
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OriginIsContinuation"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OriginIsContinuation", value);
			}
		}

		public override string Description => $"InvalidImpulseFlow originating from {Origin} (Async: {OriginIsAsync}, Continuation: {OriginIsContinuation}). " + $"Impulse {ReferencingNode.GetImpulseName(ImpulseIndex)} (Async: {ContextIsAsync}, Continuation: {ContextIsContinuation}) on {ReferencingNode} is targetting: {Target}: {Reason}";

		public void SetOriginInfo(IOperation origin, bool originIsAsync, bool originIsContinuation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetOriginInfo", origin, originIsAsync, originIsContinuation);
		}

		public ImpulseFlowError(INode referencingNode, int impulseIndex, IOperation target, ImpulseFlowContext context, string reason)
			: this(referencingNode, impulseIndex, target, context.isAsync, context.isContinuation, reason)
		{
		}

		public ImpulseFlowError(INode referencingNode, int impulseIndex, IOperation target, bool contextIsAsync, bool contextIsContinuation, string reason)
		{
			ReferencingNode = referencingNode;
			ImpulseIndex = impulseIndex;
			Target = target;
			ContextIsAsync = contextIsAsync;
			ContextIsContinuation = contextIsContinuation;
			Reason = reason;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ImpulseFlowError(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class ImpulseValidator
	{
		public static InvalidImpulseTargetError ValidateTarget(this INode node, int impulseIndex, IOperation target)
		{
			return (InvalidImpulseTargetError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateTarget", node, impulseIndex, target), typeof(InvalidImpulseTargetError));
		}

		public static bool CanImpulse(this INode node, string impulseName, IOperation target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseName, target), typeof(bool));
		}

		public static bool CanImpulse(this INode node, int impulseIndex, IOperation target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImpulse", node, impulseIndex, target), typeof(bool));
		}

		public static bool WouldFormContinuationLoop(this INode node, int impulseIndex, IOperation target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "WouldFormContinuationLoop", node, impulseIndex, target), typeof(bool));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesForImpulse(this INode node, int impulseIndex)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesForImpulse", node, impulseIndex), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeNodeOperationInvokeSources(this INode node)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeNodeOperationInvokeSources", node), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromImpulseImport(NodeRuntime runtime, int importIndex, INode target)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromImpulseImport", runtime, importIndex, target), typeof(OperationInvokeSource));
		}

		public static OperationInvokeSource ComputeOperationInvokeSourcesFromSource(this INode node, INode target)
		{
			return (OperationInvokeSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeOperationInvokeSourcesFromSource", node, target), typeof(OperationInvokeSource));
		}

		public static bool ReachesAsyncOperation(this IOperation operation)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ReachesAsyncOperation", operation), typeof(bool));
		}

		public static ImpulseValidationError ValidateImpulseFlow(this IOperation targettedOperation, ImpulseFlowContext context)
		{
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseFlow", targettedOperation, context), typeof(ImpulseValidationError));
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
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", group), typeof(ImpulseValidationError));
		}

		public static ImpulseValidationError ValidateImpulseConnections(this NodeRuntime runtime)
		{
			return (ImpulseValidationError)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ImpulseValidator", ResoniteBridge.ResoniteBridgeValueType.Type), "ValidateImpulseConnections", runtime), typeof(ImpulseValidationError));
		}
	}
	public static class NodeHelper
	{
		public static int FindLinearOutputIndex(this IOutput output)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOutputIndex", output), typeof(int));
		}

		public static void FindOutputIndex(this IOutput output, out int index, out int listIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindOutputIndex", output, index, listIndex);
		}

		public static void FindOperationIndex(this IOperation operation, out int index, out int listIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindOperationIndex", operation, index, listIndex);
		}

		public static int FindLinearOperationIndex(this IOperation operation)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindLinearOperationIndex", operation), typeof(int));
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
		private Node _node;

		public Node OwnerNode => _node;

		public Type OutputType => typeof(T);

		public abstract DataClass OutputDataClass { get; }

		public Output(Node owner)
		{
			_node = owner;
		}

		public override string ToString()
		{
			if (OwnerNode is DataImportNode)
			{
				return $"Data Import ({typeof(T)}) on {OwnerNode?.Runtime?.Group?.Name}";
			}
			return $"Output<{typeof(T)}> ({OwnerNode.GetOutputName(this.FindLinearOutputIndex())} on {OwnerNode})";
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class OutputNode<T> : Node, IOutput<T>, IOutput, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Node OwnerNode => this;

		public int OutputIndex => 0;

		public Type OutputType => typeof(T);

		public abstract DataClass OutputDataClass { get; }

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class ValueOutputNode<T> : OutputNode<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override DataClass OutputDataClass => DataClass.Value;

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public struct InsertedConversion : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public INode conversion
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "conversion"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "conversion", value);
			}
		}

		public INode targetNode
		{
			get
			{
				return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "targetNode"), typeof(INode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "targetNode", value);
			}
		}

		public ElementRef targetInput
		{
			get
			{
				return (ElementRef)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "targetInput"), typeof(ElementRef));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "targetInput", value);
			}
		}

		public InsertedConversion(INode conversion, INode targetNode, ElementRef targetInput)
		{
			this.conversion = conversion;
			this.targetNode = targetNode;
			this.targetInput = targetInput;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InsertedConversion(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct ConnectionResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public bool connected
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "connected"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "connected", value);
			}
		}

		public string failReason
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "failReason"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "failReason", value);
			}
		}

		public List<InsertedConversion> conversions
		{
			get
			{
				return (List<InsertedConversion>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "conversions"), typeof(List<InsertedConversion>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "conversions", value);
			}
		}

		public NodeOverloadContext overload
		{
			get
			{
				return (NodeOverloadContext)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "overload"), typeof(NodeOverloadContext));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "overload", value);
			}
		}

		public static ConnectionResult Success => new ConnectionResult(connected: true);

		public ConnectionResult(bool connected, string failReason = null)
		{
			this.connected = connected;
			conversions = null;
			overload = null;
			this.failReason = failReason;
		}

		public ConnectionResult(InsertedConversion conversion)
		{
			if (conversion.conversion != null)
			{
				conversions = new List<InsertedConversion> { conversion };
			}
			else
			{
				conversions = null;
			}
			connected = true;
			overload = null;
			failReason = null;
		}

		public ConnectionResult(List<InsertedConversion> conversions)
		{
			this.conversions = conversions;
			connected = true;
			overload = null;
			failReason = null;
		}

		public ConnectionResult(NodeOverloadContext overload, List<InsertedConversion> conversions)
		{
			this.overload = overload;
			this.conversions = conversions;
			connected = true;
			failReason = null;
		}

		public ConnectionResult(NodeOverloadContext overload, InsertedConversion conversion = default(InsertedConversion))
		{
			this.overload = overload;
			if (conversion.conversion != null)
			{
				conversions = new List<InsertedConversion> { conversion };
			}
			else
			{
				conversions = null;
			}
			connected = true;
			failReason = null;
		}

		public ConnectionResult Combine(ConnectionResult other)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Combine", other), typeof(ConnectionResult));
		}

		public ConnectionResult AddInsertedConversion(InsertedConversion conversion)
		{
			return (ConnectionResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddInsertedConversion", conversion), typeof(ConnectionResult));
		}

		public static ConnectionResult Failed(string reason)
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

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ConnectionResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface ICast : INode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool IsImplicit { get; }

		Type InputType { get; }

		Type OutputType { get; }
	}
	public struct InputType : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Type type
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "type"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "type", value);
			}
		}

		public NodeRuntime runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "runtime", value);
			}
		}

		public InputType(Type type, NodeRuntime runtime)
		{
			this.type = type;
			this.runtime = runtime;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InputType(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class NodeConnections : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Dictionary<string, InputType> fixedInputs
		{
			get
			{
				return (Dictionary<string, InputType>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "fixedInputs"), typeof(Dictionary<string, InputType>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "fixedInputs", value);
			}
		}

		public Dictionary<string, List<InputType>> listInputs
		{
			get
			{
				return (Dictionary<string, List<InputType>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "listInputs"), typeof(Dictionary<string, List<InputType>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "listInputs", value);
			}
		}

		public Dictionary<string, InputType> fixedReferences
		{
			get
			{
				return (Dictionary<string, InputType>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "fixedReferences"), typeof(Dictionary<string, InputType>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "fixedReferences", value);
			}
		}

		public bool SetInput(ElementRef input, string name, Type type, NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetInput", input, name, type, runtime), typeof(bool));
		}

		public bool SetInput(string name, Type type, NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetInput", name, type, runtime), typeof(bool));
		}

		public bool SetReference(string name, Type type, NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetReference", name, type, runtime), typeof(bool));
		}

		public bool SetListInput(string name, int index, Type type, NodeRuntime runtime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetListInput", name, index, type, runtime), typeof(bool));
		}

		public static NodeConnections GetFromNode(INode node)
		{
			return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeConnections", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFromNode", node), typeof(NodeConnections));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeConnections(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeOverloadAttribute : Attribute
	{
		public string OverloadName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OverloadName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OverloadName", value);
			}
		}

		public NodeOverloadAttribute(string overloadName)
		{
			OverloadName = overloadName;
		}
	}
	public class NodeOverloadCollection : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<Type> _overloads
		{
			get
			{
				return (List<Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_overloads"), typeof(List<Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_overloads", value);
			}
		}

		public int Count => _overloads.Count;

		public IEnumerable<Type> Overloads => _overloads;

		internal void Add(Type type)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", type);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeOverloadCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct OverloadResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public string failReason
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "failReason"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "failReason", value);
			}
		}

		public bool IsSuccess => failReason == null;

		public static OverloadResult Success => new OverloadResult(null);

		private OverloadResult(string errorReason)
		{
			failReason = errorReason;
		}

		public static OverloadResult Fail(string reason)
		{
			return (OverloadResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "OverloadResult", ResoniteBridge.ResoniteBridgeValueType.Type), "Fail", reason), typeof(OverloadResult));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OverloadResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class NodeOverloadContext : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<INode, Type> overloads
		{
			get
			{
				return (Dictionary<INode, Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "overloads"), typeof(Dictionary<INode, Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "overloads", value);
			}
		}

		private Dictionary<INode, INode> swappedNodes
		{
			get
			{
				return (Dictionary<INode, INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "swappedNodes"), typeof(Dictionary<INode, INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "swappedNodes", value);
			}
		}

		private HashSet<INode> affectedEvaluatingNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "affectedEvaluatingNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "affectedEvaluatingNodes", value);
			}
		}

		private HashSet<INode> affectedImpulsingNodes
		{
			get
			{
				return (HashSet<INode>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "affectedImpulsingNodes"), typeof(HashSet<INode>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "affectedImpulsingNodes", value);
			}
		}

		private List<InsertedConversion> insertedCasts
		{
			get
			{
				return (List<InsertedConversion>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "insertedCasts"), typeof(List<InsertedConversion>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "insertedCasts", value);
			}
		}

		private NodeQueryAcceleration query
		{
			get
			{
				return (NodeQueryAcceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "query"), typeof(NodeQueryAcceleration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "query", value);
			}
		}

		public NodeGroup Group
		{
			get
			{
				return (NodeGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Group"), typeof(NodeGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Group", value);
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Runtime", value);
			}
		}

		public bool OverloadedAnyNodes => overloads.Count > 0;

		public IEnumerable<KeyValuePair<INode, Type>> Overloads => overloads;

		public IEnumerable<KeyValuePair<INode, INode>> SwappedNodes => swappedNodes;

		public IEnumerable<INode> AffectedEvaluatingNodes => affectedEvaluatingNodes;

		public IEnumerable<INode> AffectedImpulsingNodes => affectedImpulsingNodes;

		public List<InsertedConversion> InsertedCasts => insertedCasts;

		public INode GetSwappedNode(INode sourceNode)
		{
			return (INode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSwappedNode", sourceNode), typeof(INode));
		}

		public NodeOverloadContext(NodeGroup group, NodeRuntime runtime)
		{
			Group = group;
			Runtime = runtime;
		}

		public OverloadResult TryOverload(INode node, NodeConnections connections, bool allowMergingGroups = false)
		{
			return (OverloadResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryOverload", node, connections, allowMergingGroups), typeof(OverloadResult));
		}

		public void SwapNodes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SwapNodes");
		}

		private NodeConnections GetModifiedConnections(INode node)
		{
			return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetModifiedConnections", node), typeof(NodeConnections));
		}

		public Type GetOverloadedType(INode node)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOverloadedType", node), typeof(Type));
		}

		private Type GetOverloadedType(IOutput source)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOverloadedType", source), typeof(Type));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public NodeOverloadContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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

		private static object generationLock
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "generationLock", value);
			}
		}

		static NodeOverloadHelper()
		{
			generationLock = new object();
			AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
		}

		public static NodeOverloadCollection GetOverloads(string name)
		{
			return (NodeOverloadCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOverloads", name), typeof(NodeOverloadCollection));
		}

		public static Dictionary<string, NodeOverloadCollection> SearchOverloads()
		{
			return (Dictionary<string, NodeOverloadCollection>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SearchOverloads"), typeof(Dictionary<string, NodeOverloadCollection>));
		}

		private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CurrentDomain_AssemblyLoad", sender, args);
		}

		public static Type FindOverload(string name, Type currentType, OverloadSearchContext context)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FindOverload", name, currentType, context), typeof(Type));
		}

		public static int? RankOverload(Type overload, OverloadSearchContext context)
		{
			return (int?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "NodeOverloadHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankOverload", overload, context), typeof(int?));
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
				return (Dictionary<Type, Type>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "genericParameters"), typeof(Dictionary<Type, Type>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "genericParameters", value);
			}
		}

		public NodeConnections Connections
		{
			get
			{
				return (NodeConnections)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Connections"), typeof(NodeConnections));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Connections", value);
			}
		}

		public NodeRuntime Runtime
		{
			get
			{
				return (NodeRuntime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Runtime"), typeof(NodeRuntime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Runtime", value);
			}
		}

		public bool AllowMergingGroups
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AllowMergingGroups"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AllowMergingGroups", value);
			}
		}

		public OverloadSearchContext(NodeConnections connections, NodeRuntime runtime, bool allowMergingGroups)
		{
			Connections = connections;
			Runtime = runtime;
			AllowMergingGroups = allowMergingGroups;
		}

		public Type GetCompatibleNodeType(Type type)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCompatibleNodeType", type), typeof(Type));
		}

		public void BeginNewOverload()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BeginNewOverload");
		}

		public bool CanTargetRuntime(InputMetadataBase input, NodeRuntime targetRuntime)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CanTargetRuntime", input, targetRuntime), typeof(bool));
		}

		public bool CanAccomodate(Type source, Type target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CanAccomodate", source, target), typeof(bool));
		}

		private bool TryMatchGenericArguments(Type source, Type target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryMatchGenericArguments", source, target), typeof(bool));
		}

		public bool UpdateGenericParameter(Type generic, Type newType)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateGenericParameter", generic, newType), typeof(bool));
		}

		public Type InstanceType(Type type, Type currentType)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InstanceType", type, currentType), typeof(Type));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OverloadSearchContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
		public static int RankType(this Type type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RankType", type), typeof(int));
		}

		public static int GetPrimitiveRanking(this Type type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveRanking", type), typeof(int));
		}

		public static bool CanImplicitlyConvertTo(Type from, Type to)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanImplicitlyConvertTo", from, to), typeof(bool));
		}

		public static bool CanExplicitlyConvertTo(Type from, Type to)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanExplicitlyConvertTo", from, to), typeof(bool));
		}

		public static Type CombineTypes(Type a, Type b)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CombineTypes", a, b), typeof(Type));
		}

		public static Type AccomodatePrimitive(PrimitiveClass primitiveClass, Type target)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AccomodatePrimitive", primitiveClass, target), typeof(Type));
		}

		public static int GetPrimitiveClassRank(this Type type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassRank", type), typeof(int));
		}

		public static int GetPrimitiveClassMaxRank(this PrimitiveClass primitiveClass)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitiveClassMaxRank", primitiveClass), typeof(int));
		}

		public static Type GetPrimitive(this PrimitiveClass primitiveClass, int rank)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPrimitive", primitiveClass, rank), typeof(Type));
		}

		public static bool CanAccomodate(this PrimitiveClass source, PrimitiveClass target)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanAccomodate", source, target), typeof(bool));
		}

		public static PrimitiveClass ClassifyPrimitive(this Type type)
		{
			return (PrimitiveClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "TypeHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ClassifyPrimitive", type), typeof(PrimitiveClass));
		}
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class PossibleContinuationsAttribute : Attribute
	{
		private HashSet<string> continuations
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "continuations"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "continuations", value);
			}
		}

		public IEnumerable<string> Continuations => continuations;

		public bool CanContinueTo(string str)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CanContinueTo", str), typeof(bool));
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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public NodeCategoryAttribute(string name)
		{
			Name = name;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class NodeNameAttribute : Attribute
	{
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public bool SimpleView
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SimpleView"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SimpleView", value);
			}
		}

		public NodeNameAttribute(string name, bool simpleView = false)
		{
			Name = name;
			SimpleView = simpleView;
		}
	}
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class OldElementNameAttribute : Attribute
	{
		public string OldName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OldName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OldName", value);
			}
		}

		public OldElementNameAttribute(string oldName)
		{
			OldName = oldName;
		}
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class OldNodeNameAttribute : Attribute
	{
		public string OldName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OldName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OldName", value);
			}
		}

		public OldNodeNameAttribute(string oldName)
		{
			OldName = oldName;
		}
	}
	public class OrderedSet<T> : IEnumerable<T>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<T> list
		{
			get
			{
				return (List<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "list"), typeof(List<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "list", value);
			}
		}

		private HashSet<T> set
		{
			get
			{
				return (HashSet<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "set"), typeof(HashSet<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "set", value);
			}
		}

		public int Count => list.Count;

		public bool Add(T item)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", item), typeof(bool));
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public List<T>.Enumerator GetEnumerator()
		{
			return (List<T>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(List<T>.Enumerator));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return (IEnumerator<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<T>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public OrderedSet(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class ReflectionHelper
	{
		private static ConcurrentDictionary<Type, bool> cachedTypes
		{
			get
			{
				return (ConcurrentDictionary<Type, bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes"), typeof(ConcurrentDictionary<Type, bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "cachedTypes", value);
			}
		}

		public static bool IsUnmanaged(this Type type)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsUnmanaged", type), typeof(bool));
		}

		public static bool IsNullable(this Type type)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsNullable", type), typeof(bool));
		}

		public static string GetNiceTypeName(this Type type, string open = "<", string close = ">")
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "ProtoFlux.Core", "ReflectionHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetNiceTypeName", type, open, close), typeof(string));
		}

		public static MethodInfo FindMethodInHierarchy(this Type type, string name, BindingFlags flags)
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
		public Type From
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "From"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "From", value);
			}
		}

		public Type To
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "To"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "To", value);
			}
		}

		public ValueCastAttribute(Type from, Type to)
		{
			From = from;
			To = to;
		}
	}
}
internal class ProtoFluxCore_ProcessedByFody : ResoniteBridge.ResoniteBridgeValueHolder
{
	internal string FodyVersion
	{
		get
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FodyVersion"), typeof(string));
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FodyVersion", value);
		}
	}

	internal string NodeWeaver
	{
		get
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "NodeWeaver"), typeof(string));
		}
		set
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "NodeWeaver", value);
		}
	}

	private ResoniteBridge.ResoniteBridgeValue __backing;

	public ResoniteBridge.ResoniteBridgeValue __Backing
	{
		get
		{
			return this.__backing;
		}
		set
		{
			this.__backing = value;
		}
	}

	public ProtoFluxCore_ProcessedByFody(ResoniteBridge.ResoniteBridgeValue value)
	{
		this.__Backing = value;
	}
}
