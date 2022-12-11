using Application.Abstractions;
using Application.Posts.Commands;
using Domain.Entities;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class UpdateHandler : IRequestHandler<Update, Post>
    {
        private readonly IPostRepository _repository;

        public UpdateHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Post?> Handle(Update request, CancellationToken cancellationToken)
        {
            return await _repository.Update(request.PostContent, request.PostId);
        }
    }
}
