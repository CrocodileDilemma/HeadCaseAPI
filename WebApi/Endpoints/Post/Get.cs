using Application.Posts.Queries;
using MediatR;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Get(IMediator mediator)
        {
            var query = new Get();
            var result = await mediator.Send(query);
            return TypedResults.Ok(result);
        }
    }
}
