using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Comment.Data;

public sealed class CommentDbContext : DbContext
{
    public CommentDbContext(DbContextOptions<CommentDbContext> options) : base(options)
    {
    }

    public DbSet<Entities.Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
