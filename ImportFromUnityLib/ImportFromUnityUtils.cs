using Elements.Core;
using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
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

        static IEnumerator<FrooxEngine.Context> AddSlotFuncHelper(byte[] inputBytes, OutputBytesHolder outputBytes)
        {
            // move to background thread (optional, useful if you are doing heavy stuff)
            yield return FrooxEngine.Context.ToBackground();
            // move to world thread (necessary if we want to modify the world at all)
            yield return Context.ToWorld();
            string slotName = ResoniteBridgeUtils.DecodeString(inputBytes);
            Slot resultSlot = Engine.Current.WorldManager.FocusedWorld.RootSlot.AddSlot(slotName);
            RefID_Example result = new RefID_Example()
            {
                id = (ulong)resultSlot.ReferenceID
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(result);
        }

        public byte[] AddSlotFunc(byte[] inputBytes)
        {
            OutputBytesHolder outputHolder = new OutputBytesHolder();
            RunOnWorldThread(AddSlotFuncHelper(inputBytes, outputHolder));
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
            return Engine.Current.WorldManager.FocusedWorld.LocalUserSpace;
        }

        public static IWorldElement LookupRefID(RefID_U2Res refID)
        {
            return Engine.Current.WorldManager.FocusedWorld.ReferenceController.GetObjectOrNull(refID.id);
        }

        static IEnumerator<Context> ActionWrapper(IEnumerator<Context> action, TaskCompletionSource<bool> completion)
        {
            try
            {
                yield return Context.WaitFor(action);
            }
            finally
            {
                completion.SetResult(result: true);
            }
        }

        public static bool RunOnWorldThread(IEnumerator<Context> action)
        {
            TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
            Engine.Current.WorldManager.FocusedWorld.RootSlot.StartCoroutine(ActionWrapper(action, taskCompletionSource));
            return taskCompletionSource.Task.GetAwaiter().GetResult();
        }
    }
}
