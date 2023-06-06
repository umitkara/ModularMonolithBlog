using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Comment.Services;

public interface ICommentService
{
    Task<Entities.Comment?> GetCommentByIdAsync(int id);
    Task CreateCommentAsync(Entities.Comment comment);
    Task UpdateCommentAsync(Entities.Comment comment);
    Task DeleteCommentAsync(int id);
}
