using Microsoft.EntityFrameworkCore;

namespace Blog.Post.Data;

public sealed class PostDbContext : DbContext
{
    public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Entities.Post> Posts { get; set; }
}