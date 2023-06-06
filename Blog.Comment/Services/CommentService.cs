using Blog.Comment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Comment.Services;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;

    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public async Task<Entities.Comment?> GetCommentByIdAsync(int id)
    {
        return await _commentRepository.GetCommentByIdAsync(id);
    }

    public async Task CreateCommentAsync(Entities.Comment comment)
    {
        await _commentRepository.CreateCommentAsync(comment);
    }

    public async Task UpdateCommentAsync(Entities.Comment comment)
    {
        await _commentRepository.UpdateCommentAsync(comment);
    }

    public async Task DeleteCommentAsync(int id)
    {
        var comment = await _commentRepository.GetCommentByIdAsync(id);
        if (comment != null)
        {
            await _commentRepository.DeleteCommentAsync(comment);
        }
    }
}
