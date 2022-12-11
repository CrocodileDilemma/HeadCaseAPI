using Application.Abstractions;
using Application.Posts.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Posts.QueryHandlers
{
    public class GetByIdHandler : IRequestHandler<GetById, Post?>
    {
        private readonly IPostRepository _repository;

        public GetByIdHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Post> Handle(GetById request, CancellationToken cancellationToken)
        {
            return await _repository.GetById(request.PostId);
        }
    }
}
