﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace PO.SignalR.Slim.Hubs.Lookup.Descriptors
{
    /// <summary>
    /// Holds information about a single hub method parameter.
    /// </summary>
    public class ParameterDescriptor
    {
        /// <summary>
        /// Parameter name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Parameter type.
        /// </summary>
        public virtual Type ParameterType { get; set; }
    }
}

