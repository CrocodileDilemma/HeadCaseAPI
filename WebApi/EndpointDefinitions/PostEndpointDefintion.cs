using WebApi.Abstractions;
using WebApi.Endpoints.Post;

namespace WebApi.EndpointDefinitions
{
    public class PostEndpointDefintion : IEndpointDefinition
    {
        public void RegisterEndpoints(WebApplication app)
        {
            var group = app.MapGroup("/api/posts");

            group.MapGet("/", PostEndpoints.Get);
            group.MapGet("/{id}", PostEndpoints.GetById).WithName("GetPostById");
            group.MapPost("/", PostEndpoints.Post);
            group.MapPut("/{id}", PostEndpoints.Put);
            group.MapDelete("/{id}", PostEndpoints.Delete);
        }
    }
}
