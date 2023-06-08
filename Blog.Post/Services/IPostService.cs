using System.Linq.Expressions;

namespace Blog.Post.Services;

public interface IPostService
{
    Task<Entities.Post?> CreatePostAsync(Entities.Post post);
    Task DeletePostAsync(int id);
    Task<Entities.Post?> GetPostByFilter(Expression<Func<Entities.Post, bool>> filter);
    Task<Entities.Post?> GetPostByIdAsync(int id);
    Task<List<Entities.Post>> GetPostsAsync();
    Task<List<Entities.Post>> GetPostsAsync(Expression<Func<Entities.Post, bool>> filter);
    Task<Entities.Post?> UpdatePostAsync(Entities.Post post);
}