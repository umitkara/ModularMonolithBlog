using Blog.Post.Repositories;
using System.Linq.Expressions;

namespace Blog.Post.Services;

public sealed class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<Entities.Post?> CreatePostAsync(Entities.Post post) => await _postRepository.CreatePostAsync(post);

    public async Task<List<Entities.Post>> GetPosts() => await _postRepository.GetPostsAsync();

    public async Task<List<Entities.Post>> GetPosts(Expression<Func<Entities.Post, bool>> filter) => await _postRepository.GetPostsAsync(filter);

    public async Task<Entities.Post?> GetPostByIdAsync(int id) => await _postRepository.GetAsync(id);

    public async Task<Entities.Post?> GetPostByFilter(Expression<Func<Entities.Post, bool>> filter) => await _postRepository.GetAsync(filter);

    public async Task<Entities.Post?> UpdatePostAsync(Entities.Post post) => await _postRepository.UpdatePostAsync(post);

    public async Task DeletePostAsync(int id)
    {
        var post = await _postRepository.GetAsync(id);
        if (post != null)
        {
            await _postRepository.DeleteAsync(post);
        }
    }
}