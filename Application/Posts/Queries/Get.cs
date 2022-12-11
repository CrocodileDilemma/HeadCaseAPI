using Domain.Entities;
using MediatR;

namespace Application.Posts.Queries
{
    public class Get : IRequest<ICollection<Post>>
    {
    }
}
