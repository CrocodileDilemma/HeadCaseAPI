using Application.Posts.Commands;
using MediatR;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Put(int id, string comment, IMediator mediator)
        {
            var command = new Update { PostId = id, PostContent = comment };
            var result = await mediator.Send(command);
            if (result == null)
            {
                return Results.BadRequest();
            }

            return TypedResults.Ok(result);
        }
    }
}
