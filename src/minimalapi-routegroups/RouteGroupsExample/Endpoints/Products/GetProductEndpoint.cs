using RouteGroupsExample.Common;

namespace RouteGroupsExample.Endpoints.Products;

public class GetProductEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
         => app.MapGet("/", () => "Hello World");
}
