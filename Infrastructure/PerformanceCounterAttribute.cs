﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace PO.SignalR.Slim.Infrastructure
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=false)]
    internal sealed class PerformanceCounterAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
