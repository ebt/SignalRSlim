﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using PO.SignalR.Slim.Infrastructure;

namespace PO.SignalR.Slim.Hosting
{
    public static class HostDependencyResolverExtensions
    {
        public static void InitializeHost(this IDependencyResolver resolver, string instanceName, CancellationToken hostShutdownToken)
        {
            if (resolver == null)
            {
                throw new ArgumentNullException("resolver");
            }

            if (String.IsNullOrEmpty(instanceName))
            {
                throw new ArgumentNullException("instanceName");
            }

            // Performance counters are broken on mono so just skip this step
            if (!MonoUtility.IsRunningMono)
            {
                // Initialize the performance counters
                resolver.InitializePerformanceCounters(instanceName, hostShutdownToken);
            }

            // Dispose the dependency resolver on host shut down (cleanly)
            resolver.InitializeResolverDispose(hostShutdownToken);
        }

        private static void InitializePerformanceCounters(this IDependencyResolver resolver, string instanceName, CancellationToken hostShutdownToken)
        {
            var counters = resolver.Resolve<IPerformanceCounterManager>();
            if (counters != null)
            {
                counters.Initialize(instanceName, hostShutdownToken);
            }
        }

        private static void InitializeResolverDispose(this IDependencyResolver resolver, CancellationToken hostShutdownToken)
        {
            // TODO: Guard against multiple calls to this

            // When the host triggers the shutdown token, dispose the resolver
            hostShutdownToken.SafeRegister(state =>
            {
                ((IDependencyResolver)state).Dispose();
            },
            resolver);
        }
    }
}
