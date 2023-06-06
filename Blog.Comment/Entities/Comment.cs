using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Comment.Entities;

public sealed class Comment
{
    [Key]
    public int CommentId { get; set; }

    [Required]
    public string Content { get; set; }

    public DateTime CreatedAt { get; set; }

    [Required]
    public int PostId { get; set; }

    [Required]
    public string UserId { get; set; } 
}
