﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using PO.SignalR.Slim.Hubs;

namespace PO.SignalR.Slim
{
    /// <summary>
    /// Provides methods that communicate with SignalR connections that connected to a <see cref="Hub"/>.
    /// </summary>
    public abstract class Hub : HubBase
    {
        public IHubCallerConnectionContext<dynamic> Clients
        {
            get
            {
                return HubClients;
            }
            set
            {
                HubClients = value;
            }
        }
    }
}
