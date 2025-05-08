




// Api/Endpoints/RootEndpoint.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace Clean.Architecture.WebApi.EndPoint
{
    public static class RootEndpoint
    {
        public static IEndpointRouteBuilder MapRoot(this IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");
            routes.MapGet("/", () => "Hello World!");




            return routes;
        }
    }
}
