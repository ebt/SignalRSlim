﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace PO.SignalR.Slim.Hubs.Pipeline
{
    /// <summary>
    /// A collection of modules that can intercept and customize various stages of hub processing such as connecting,
    /// reconnecting, disconnecting, invoking server-side hub methods, invoking client-side hub methods, authorizing
    /// hub clients and rejoining hub groups.
    /// </summary>
    public interface IHubPipeline
    {
        /// <summary>
        /// Adds an <see cref="IHubPipelineModule"/> to the hub pipeline. Modules added to the pipeline first will wrap
        /// modules that are added to the pipeline later. All modules must be added to the pipeline before any methods
        /// on the <see cref="IHubPipelineInvoker"/> are invoked.
        /// </summary>
        /// <param name="pipelineModule">
        /// A module that may intercept and customize various stages of hub processing such as connecting,
        /// reconnecting, disconnecting, invoking server-side hub methods, invoking client-side hub methods, authorizing
        /// hub clients and rejoining hub groups.
        /// </param>
        /// <returns>
        /// The <see cref="IHubPipeline"/> itself with the newly added module allowing
        /// <see cref="IHubPipeline.AddModule"/> calls to be chained.
        /// This method mutates the pipeline it is invoked on so it is not necessary to store its result.
        /// </returns>
        IHubPipeline AddModule(IHubPipelineModule pipelineModule);
    }
}
