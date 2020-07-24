﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PO.SignalR.Slim.Hubs.Lookup.Descriptors
{
    /// <summary>
    /// Holds information about a single hub method.
    /// </summary>
    public class MethodDescriptor : Descriptor
    {
        /// <summary>
        /// The return type of this method.
        /// </summary>
        public virtual Type ReturnType { get; set; }

        /// <summary>
        /// Hub descriptor object, target to this method.
        /// </summary>
        public virtual HubDescriptor Hub { get; set; }

        /// <summary>
        /// Available method parameters.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "This is supposed to be mutable")]
        public virtual IList<ParameterDescriptor> Parameters { get; set; }

        public Type ProgressReportingType { get; set; }

        /// <summary>
        /// Method invocation delegate.
        /// Takes a target hub and an array of invocation arguments as it's arguments.
        /// </summary>
        public virtual Func<IHub, object[], object> Invoker { get; set; }

        /// <summary>
        /// Attributes attached to this method.
        /// </summary>
        public virtual IEnumerable<Attribute> Attributes { get; set; }
    }
}

