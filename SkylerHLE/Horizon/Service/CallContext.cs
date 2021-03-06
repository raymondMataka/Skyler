﻿using SkylerCommon.Debugging;
using SkylerCommon.Memory;
using SkylerHLE.Horizon.IPC;
using SkylerHLE.Horizon.Service.Sessions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylerHLE.Horizon.Service
{
    public class CallContext //TODO: Come up with a better name.
    {
        public KSession session     { get; set; }
        public IPCCommand request   { get; set; }
        public IPCCommand response  { get; set; }
        public MemoryReader Reader  { get; set; }
        public BinaryWriter Writer  { get; set; }

        public ServiceCall Call     { get; set; }
        public ulong CommandID      { get; set; }
        public object Data          { get; set; }
        public bool Ignore          { get; set; }

        public void PrintStubbed(bool Crash = false)
        {
            if (Crash)
            {
                Debug.LogError($"Call Stubbed: {session.Name} {CommandID} {Call.Method.Name}",true);
            }
            else
            {
                Debug.LogWarning($"Call Stubbed: {session.Name} {CommandID} {Call.Method.Name}");
            }
        }
    }
}
