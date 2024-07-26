using RouteGroupsExample.Common;

namespace RouteGroupsExample.Endpoints.Categories;

public class GetCategoryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
         => app.MapGet("/", () => "Hello World");
}
