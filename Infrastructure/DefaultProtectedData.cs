﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Security.Cryptography;
using System.Text;

namespace PO.SignalR.Slim.Infrastructure
{
    public class DefaultProtectedData : IProtectedData
    {
        private static readonly UTF8Encoding _encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public string Protect(string data, string purpose)
        {
            byte[] purposeBytes = _encoding.GetBytes(purpose);

            byte[] unprotectedBytes = _encoding.GetBytes(data);

            byte[] protectedBytes = ProtectedData.Protect(unprotectedBytes, purposeBytes, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(protectedBytes);
        }

        public string Unprotect(string protectedValue, string purpose)
        {
            byte[] purposeBytes = _encoding.GetBytes(purpose);

            byte[] protectedBytes = Convert.FromBase64String(protectedValue);

            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, purposeBytes, DataProtectionScope.CurrentUser);

            return _encoding.GetString(unprotectedBytes);
        }
    }
}