[![Nuget](https://img.shields.io/nuget/v/AO.HttpRequestExtensions)](https://www.nuget.org/packages/AO.HttpRequestExtensions/)

This is a really small .NET Standard library for deserializing objects from `HttpRequest` in .NET Core 3. I feel like this is pretty basic, and maybe this is built-in functionality somewhere that I'm missing. It wouldn't be the first time, since I think some of these extension method packages aren't very discoverable. Anyway, I find myself copying and pasting this code in different projects, so I figured I would make a package.

# AO.Extensions.RequestExtensions [HttpRequestExtensions.cs](https://github.com/adamfoneil/RequestExtensions/blob/master/RequestExtensions/HttpRequestExtensions.cs#L9)
## Methods
- Task\<(string Json, T Item)\> [DeserializeWithJsonAsync](https://github.com/adamfoneil/RequestExtensions/blob/master/RequestExtensions/HttpRequestExtensions.cs#L11)
 (this HttpRequest request)
- Task\<T\> [DeserializeAsync](https://github.com/adamfoneil/RequestExtensions/blob/master/RequestExtensions/HttpRequestExtensions.cs#L28)
 (this HttpRequest request)
