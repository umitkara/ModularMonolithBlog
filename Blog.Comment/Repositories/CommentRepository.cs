using Blog.Comment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Comment.Repositories;

public sealed class CommentRepository : ICommentRepository
{
    private readonly CommentDbContext _context;

    public CommentRepository(CommentDbContext context)
    {
        _context = context;
    }

    public async Task<Entities.Comment?> GetCommentByIdAsync(int id)
    {
        return await _context.Comments.FindAsync(id);
    }

    public async Task CreateCommentAsync(Entities.Comment comment)
    {
        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCommentAsync(Entities.Comment comment)
    {
        _context.Comments.Update(comment);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCommentAsync(Entities.Comment comment)
    {
        _context.Comments.Remove(comment);
        await _context.SaveChangesAsync();
    }
}
