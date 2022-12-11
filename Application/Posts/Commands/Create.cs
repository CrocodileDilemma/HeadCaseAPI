using Domain.Entities;
using MediatR;

namespace Application.Posts.Commands
{
    public class Create : IRequest<Post>
    {
        public string? PostContent { get; set; }
    }
}
