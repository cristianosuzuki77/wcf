﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using WcfTestBridgeCommon;

namespace WcfService.TestResources
{
    internal abstract class HttpResource : EndpointResource<WcfService, IWcfService>
    {
        protected override string Protocol { get { return BaseAddressResource.Http; } }

        protected override int GetPort(ResourceRequestContext context)
        {
            return context.BridgeConfiguration.BridgeHttpPort;
        }
    }
}
