using WebApi.DTOs;

namespace WebApi.Filters
{
    public class PostValidationFilter : IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var post = context.GetArgument<PostDTO>(02);
            if (string.IsNullOrEmpty(post.Content))
            {
                return await Task.FromResult(Results.BadRequest("A Post must contain Content!"));
            }

            return await next(context);
        }
    }
}
