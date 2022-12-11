using Domain.Entities;

namespace Application.Abstractions
{
    public interface IPostRepository
    {
        Task<ICollection<Post>> Get();
        Task<Post?> GetById(int id);
        Task<Post> Create(Post post);
        Task<Post?> Update(string? content, int id);
        Task<bool> Delete(int id);
    }
}
