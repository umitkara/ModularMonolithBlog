
using Blog.Post.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Blog.Post.Repositories;

public sealed class PostRepository : IPostRepository
{
    private readonly PostDbContext _context;
    private readonly ILogger<PostRepository> _logger;

    public PostRepository(PostDbContext context, ILogger<PostRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<Entities.Post> CreatePostAsync(Entities.Post post)
    {
        try
        {
            await _context.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }
        catch (Exception e)
        {
            _logger.LogError($"Error an occured: {e.Message} - {e.InnerException}");
            return null;
        }
    }

    public async Task<Entities.Post> UpdatePostAsync(Entities.Post post)
    {
        try
        {
            var dbPost = await _context.Posts.FirstOrDefaultAsync(x => x.PostId == post.PostId);

            if (dbPost is null)
            {
                throw new Exception($"Post not found ({post.PostId})");
            }

            _context.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }
        catch (Exception e)
        {
            _logger.LogError($"Error an occured: {e.Message} - {e.InnerException}");
            return null;
        }
    }

    public async Task<List<Entities.Post>> GetPostsAsync(Expression<Func<Entities.Post, bool>> filter = null)
    {
        return filter == null
            ? await _context.Posts.ToListAsync()
            : await _context.Posts.Where(filter).ToListAsync();
    }

    public async Task<Entities.Post> GetAsync(int id)
    {
        return await _context.Posts.FirstOrDefaultAsync(x => x.PostId == id);
    }

    public async Task<Entities.Post> GetAsync(Expression<Func<Entities.Post, bool>> filter)
    {
        return await _context.Posts.FirstOrDefaultAsync(filter);
    }

    public async Task DeleteAsync(int id)
    {
        var post = await GetAsync(id);
        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteAsync(Entities.Post post)
    {
        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
    }
}