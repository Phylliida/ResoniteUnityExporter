extern alias Froox;

using Froox::Elements.Core;
using Froox::FrooxEngine;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class OutputBytesHolder
    {
        public byte[] outputBytes;
    }

    public class ImportFromUnityUtils
    {
        public static bool AllowedToSpawn()
        {
            World focusedWorld = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld;
            if (focusedWorld.CanSpawnObjects())
            {
                return focusedWorld.LocalUser.CanEnableEditMode();
            }
            return false;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RefID_Example
        {
            public ulong id;
        }

        static void AddSlotFuncHelper(byte[] inputBytes, OutputBytesHolder outputBytes)
        {
            string slotName = SerializationUtils.DecodeString(inputBytes);
            Slot resultSlot = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.RootSlot.AddSlot(slotName);
            RefID_Example result = new RefID_Example()
            {
                id = (ulong)resultSlot.ReferenceID
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        public async Task<byte[]> AddSlotFunc(byte[] inputBytes)
        {
            OutputBytesHolder outputHolder = new OutputBytesHolder();
            await RunOnWorldThread(() => AddSlotFuncHelper(inputBytes, outputHolder));
            return outputHolder.outputBytes;
        }
        public static void SendCantSpawnMessage()
        {
            NotificationMessage.SpawnTextMessage("Permissions.NotAllowedToSpawn".AsLocaleKey(), colorX.Red);
        }

        public static bool NotEmpty<T>(T[] arr)
        {
            return arr != null && arr.Length > 0;
        }

        public static Slot GetAddingSlot()
        {
            return ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.LocalUserSpace;
        }

        public static IWorldElement LookupRefID(RefID_U2Res refID)
        {
            // need this bc the call below will throw an error
            if (refID.id == 0 || (RefID)refID.id == RefID.Null)
            {
                return null;
            }
            else
            {
                return ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.ReferenceController.GetObjectOrNull(refID.id);
            }
        }

        public static IWorldElement LookupRefID(RefID refID)
        {
            // need this bc the call below will throw an error
            if (refID == RefID.Null)
            {
                return null;
            }
            else
            {
                return ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.ReferenceController.GetObjectOrNull(refID);
            }
        }

        // Helper class to safely iterate without try-catch in iterator blocks
        class ExceptionSafeIterator
        {
            private readonly IEnumerator<Context> _innerEnumerator;
            public Context Current { get; private set; }
            public Exception CaughtException { get; private set; }
            public bool ExceptionOccurred { get; private set; }

            public ExceptionSafeIterator(IEnumerator<Context> innerEnumerator)
            {
                _innerEnumerator = innerEnumerator;
                Current = Context.ToWorld();
            }

            public bool MoveNext()
            {
                if (ExceptionOccurred)
                    return false;

                try
                {
                    if (_innerEnumerator.MoveNext())
                    {
                        Current = _innerEnumerator.Current;
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    ExceptionOccurred = true;
                    CaughtException = ex;
                    return false;
                }
            }
        }

        static IEnumerator<Context> CoroutineWrapper(IEnumerator<Context> action, TaskCompletionSource<object> completion)
        {
            // weird hack to let us try catch in a yield return (which c# by default doesn't allow)
            ExceptionSafeIterator iterator = new ExceptionSafeIterator(action);
            while (iterator.MoveNext())
            {
                yield return iterator.Current;
            }
            if (iterator.ExceptionOccurred)
            {
                completion.SetResult(iterator.CaughtException);
            }
            else
            {
                completion.SetResult(true);
            }
        }

        static Action ActionWrapper(Action action, TaskCompletionSource<object> completion)
        {
            return () =>
            {
                bool setResult = false;
                // weird hack to let us try catch in a yield return (which c# by default doesn't allow)
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    completion.SetResult(e);
                    setResult = true;
                }
                finally
                {
                    if (!setResult)
                    {
                        completion.SetResult(true);
                    }
                }
            };
        }

        public static async Task<bool> WaitForTaskCompletionSource(TaskCompletionSource<object> tcs)
        {
            var result = await tcs.Task;
            if (result.GetType() == typeof(bool)) // not an exception
            {
                return true;
            }
            else // exception
            {
                // this preserves stack trace through seperate threads
                // this also throws, tho it may not look like it. The return false below is just to make compiler happy
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((System.Exception)result).Throw();
                return false;
            }
        }

        public static async Task<bool> RunOnWorldThread(Action action)
        {
            TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
            ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.RunSynchronously(ActionWrapper(action, taskCompletionSource));
            return await WaitForTaskCompletionSource(taskCompletionSource);
        }

        public static async Task<bool> RunCoroutine(IEnumerator<Context> coroutine)
        {
            TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
            ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.RootSlot.StartCoroutine(CoroutineWrapper(coroutine, taskCompletionSource));
            return await WaitForTaskCompletionSource(taskCompletionSource);
        }
    }
}
