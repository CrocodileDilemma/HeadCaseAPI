using Application.Abstractions;
using Application.Posts.Commands;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class DeleteHandler : IRequestHandler<Delete, bool>
    {
        private readonly IPostRepository _repository;

        public DeleteHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(Delete request, CancellationToken cancellationToken)
        {
            return await _repository.Delete(request.PostId);
        }
    }
}
