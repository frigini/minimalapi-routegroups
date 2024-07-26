namespace RouteGroupsExample.Common;

public interface IEndpoint
{
    static abstract void Map(IEndpointRouteBuilder app);
}
