using System.ComponentModel.DataAnnotations;

namespace Blog.Post.Entities;

public sealed class Post
{
    [Key]
    public int PostId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
    [Required]
    public DateTime PublishDate { get; set; }
    [Required]
    public string PublishedById { get; set; }
    public string PublishedByName { get; set; }
    //public List<string> Tags { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    // Comments
}