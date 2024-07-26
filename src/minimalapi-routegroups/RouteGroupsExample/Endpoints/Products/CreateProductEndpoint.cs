using RouteGroupsExample.Common;

namespace RouteGroupsExample.Endpoints.Products;

public class CreateProductEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
         => app.MapPost("/", HandleAsync);

    private static async Task<IResult> HandleAsync()
    {
        //implements CreateProduct, create a Handler i.e.
        var result = await Task.Run(() => "Hello world!");
        return Results.Ok(result);
    }
}
