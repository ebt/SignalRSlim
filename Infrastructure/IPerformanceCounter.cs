﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace PO.SignalR.Slim.Infrastructure
{
    public interface IPerformanceCounter
    {
        string CounterName { get; }
        long Decrement();
        long Increment();
        long IncrementBy(long value);
        long RawValue { get; set; }
        void Close();
        void RemoveInstance();
    }
}
