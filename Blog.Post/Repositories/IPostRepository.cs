using System.Linq.Expressions;

namespace Blog.Post.Repositories;

public interface IPostRepository
{
    Task<Entities.Post> CreatePostAsync(Entities.Post post);
    Task DeleteAsync(int id);
    Task DeleteAsync(Entities.Post post);
    Task<Entities.Post> GetAsync(int id);
    Task<Entities.Post> GetAsync(Expression<Func<Entities.Post, bool>> filter);
    Task<List<Entities.Post>> GetPostsAsync(Expression<Func<Entities.Post, bool>> filter = null);
    Task<Entities.Post> UpdatePostAsync(Entities.Post post);
}