using Application.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _db;

        public PostRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Post> Create(Post post)
        {
            post.DateCreated = DateTime.Now;
            post.LastModified = DateTime.Now;

            await _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();

            return post;
        }

        public async Task<ICollection<Post>> Get()
        {
            return await _db.Posts.ToListAsync();
        }

        public async Task<Post?> Update(string? content, int Id)
        {
            var post = await _db.Posts.FirstOrDefaultAsync(x => x.Id == Id);

            if (post is null)
            {
                return null;
            }

            post.Content = content;
            post.LastModified = DateTime.Now;
            
            await _db.SaveChangesAsync();
            return post;
        }

        public async Task<bool> Delete(int id)
        {
            var post = await _db.Posts.FirstOrDefaultAsync(x => x.Id == id);

            if (post is null)
            {
                return false;
            }

            _db.Posts.Remove(post);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Post?> GetById(int id)
        {
            return await _db.Posts.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
