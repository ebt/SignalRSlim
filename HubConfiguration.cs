﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace PO.SignalR.Slim
{
    public class HubConfiguration : ConnectionConfiguration
    {
        /// <summary>
        /// Determines whether JavaScript proxies for the server-side hubs should be auto generated at {Path}/hubs or {Path}/js.
        /// Defaults to true.
        /// </summary>
        public bool EnableJavaScriptProxies { get; set; }

        /// <summary>
        /// Determines whether detailed exceptions thrown in Hub methods get reported back the invoking client.
        /// Defaults to false.
        /// </summary>
        public bool EnableDetailedErrors { get; set; }

        public HubConfiguration()
        {
            EnableJavaScriptProxies = true;
        }
    }
}
