using System;

namespace NamedPipeIPC
{ 
    public struct IpcServerInfo {
        public long timeOfLastUpdate;
        public string baseKey;
        public Guid guid;
        public int processId;
        public IpcUtils.ConnectionStatus connectionStatus;
    }
}