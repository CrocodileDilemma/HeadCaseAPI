using Application.Abstractions;
using Application.Posts.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Posts.QueryHandlers
{
    public class GetHandler : IRequestHandler<Get, ICollection<Post>>
    {
        private readonly IPostRepository _repository;

        public GetHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Post>> Handle(Get request, CancellationToken cancellationToken)
        {
            return await _repository.Get();
        }
    }
}
