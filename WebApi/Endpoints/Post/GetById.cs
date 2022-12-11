using Application.Posts.Queries;
using MediatR;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> GetById(int id, IMediator mediator)
        {
            var query = new GetById { PostId = id };
            var result = await mediator.Send(query);
            if (result == null)
            {
                return Results.NotFound();
            }

            return TypedResults.Ok(result);
        }
    }
}
