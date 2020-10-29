using Microsoft.AspNetCore.Http;
using System.Net;

namespace AO.Extensions
{
    public static partial class RequestExtensions
    {
        /// <summary>
        /// based on https://www.strathweb.com/2016/04/request-islocal-in-asp-net-core/
        /// </summary>
        public static bool IsLocal(this HttpRequest request) => request.Host.Value.StartsWith("localhost:");        
    }
}
