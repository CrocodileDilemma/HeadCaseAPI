using MediatR;

namespace Application.Posts.Commands
{
    public class Delete : IRequest<bool>
    {
        public int PostId { get; set; }
    }
}
