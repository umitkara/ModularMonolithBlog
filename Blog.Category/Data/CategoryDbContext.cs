using Microsoft.EntityFrameworkCore;

namespace Blog.Category.Data;

public sealed class CategoryDbContext : DbContext
{
    public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Entities.Category> Categories { get; set; }
}