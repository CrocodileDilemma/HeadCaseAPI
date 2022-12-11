using Domain.Entities;
using MediatR;

namespace Application.Posts.Queries
{
    public class GetById : IRequest<Post?>
    {
        public int PostId { get; set; }
    }
}
