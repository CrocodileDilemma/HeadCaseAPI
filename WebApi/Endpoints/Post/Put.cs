using Application.Posts.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Put([FromBody]PostDTO post, int id, IMediator mediator)
        {
            var command = new Update { PostId = id, PostContent = post.Content };
            var result = await mediator.Send(command);
            if (result == null)
            {
                return Results.BadRequest();
            }

            return TypedResults.Ok(result);
        }
    }
}
