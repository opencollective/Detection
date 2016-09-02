// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Wangkanai.Browser.Depreciated
{
    internal interface IDeviceBrowser
    {
        DeviceInfoDepreciated DeviceInfoDepreciated { get; }
        bool IsValid(HttpRequest request);
    }
}