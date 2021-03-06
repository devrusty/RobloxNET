<img src="/resources/logo.png" align="center">
<hr>

version: 3.2.1-a
<br>
Roblox.NET is a C# package that helps you work with the <a href="https://api.roblox.com/docs">Roblox API</a>. It is a recreated and improved version of <a href="https://github.com/REdgars/Roblox.NET">REdgars's Roblox.NET</a>.

## Features
* Roblox friends API
* Roblox groups API
* Roblox marketplace API
* Roblox users API
* Roblox badges API

## Examples
Getting the friends of a user
```cs
using RobloxNET;
using Newtonsoft.Json;

RobloxUser[] Friends = await RobloxFriendsAPI.GetUsersFriendsAsync(1);
```

Getting the product info of a hat
```cs
using RobloxNET;
using Newtonsoft.Json;

RobloxAsset DominoCrown = await RobloxMarketplaceAPI.GetProductInfoAsync(1031429);
```