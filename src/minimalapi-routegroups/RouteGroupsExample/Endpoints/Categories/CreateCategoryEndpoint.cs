using RouteGroupsExample.Common;

namespace RouteGroupsExample.Endpoints.Categories;

public class CreateCategoryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
         => app.MapPost("/", () => "Hello World");
}
