using Application.Posts.Commands;
using MediatR;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Delete(int id, IMediator mediator)
        {
            var command = new Delete { PostId = id };
            var result = await mediator.Send(command);
            if (result == false)
            {
                return Results.BadRequest();
            }

            return TypedResults.NoContent();
        }
    }
}
