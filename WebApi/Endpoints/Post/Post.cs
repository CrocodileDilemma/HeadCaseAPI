using Application.Posts.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Endpoints.Post
{
    public partial class PostEndpoints
    {
        public static async Task<IResult> Post(PostDTO post, IMediator mediator)
        {
            var command = new Create { PostContent = post.Content };
            var result = await mediator.Send(command);
            if (result == null)
            {
                return Results.BadRequest();
            }

            return TypedResults.Ok(result);
        }
    }
}
