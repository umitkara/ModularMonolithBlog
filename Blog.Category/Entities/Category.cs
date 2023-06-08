using System.ComponentModel.DataAnnotations;

namespace Blog.Category.Entities;

public sealed class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string CategoryName { get; set; }
}