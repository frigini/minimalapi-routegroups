using RouteGroupsExample.Endpoints.Categories;
using RouteGroupsExample.Endpoints.Products;

namespace RouteGroupsExample.Common.Extensions.Endpoint
{
    public static class Endpoint
    {
        public static void MapEndpoints(this WebApplication app)
        {
            var endpoints = app.MapGroup("");

            endpoints.MapGroup("/")
                .WithTags("Health Check")
                .MapGet("/", () => new { message = "Ok" });

            endpoints.MapGroup("/categories")
                .WithTags("Categories")
                .RequireAuthorization()
                .MapEndpoint<CreateCategoryEndpoint>()
                .MapEndpoint<GetCategoryEndpoint>();

            endpoints.MapGroup("/products")
                .WithTags("Products")
                .MapEndpoint<CreateProductEndpoint>()
                .MapEndpoint<GetProductEndpoint>();
        }

        private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app)
            where TEndpoint : IEndpoint
        {
            TEndpoint.Map(app);
            return app;
        }
    }
}
