using Application.Abstractions;
using Application.Posts.Commands;
using Domain.Entities;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class CreateHandler : IRequestHandler<Create, Post>
    {
        private readonly IPostRepository _repository;

        public CreateHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Post> Handle(Create request, CancellationToken cancellationToken)
        {
            var post = new Post(request.PostContent);
            return await _repository.Create(post);
        }
    }
}
