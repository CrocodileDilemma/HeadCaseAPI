using WebApi.Abstractions;
using WebApi.Endpoints.Post;
using WebApi.Filters;

namespace WebApi.EndpointDefinitions
{
    public class PostEndpointDefintion : IEndpointDefinition
    {
        public void RegisterEndpoints(WebApplication app)
        {
            var group = app.MapGroup("/api/posts");

            group.MapGet("/", PostEndpoints.Get);
            
            group.MapGet("/{id}", PostEndpoints.GetById)
                .WithName("GetPostById");
            
            group.MapPost("/", PostEndpoints.Post)
                .AddEndpointFilter<PostValidationFilter>();
            
            group.MapPut("/{id}", PostEndpoints.Put)
                .AddEndpointFilter<PostValidationFilter>();
            
            group.MapDelete("/{id}", PostEndpoints.Delete);
        }
    }
}
