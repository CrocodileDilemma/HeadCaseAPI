using Application.Posts.Commands;
using MediatR;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Post(string comment, IMediator mediator)
        {
            var command = new Create { PostContent = comment };
            var result = await mediator.Send(command);
            if (result == null)
            {
                return Results.BadRequest();
            }

            return TypedResults.Ok(result);
        }
    }
}
