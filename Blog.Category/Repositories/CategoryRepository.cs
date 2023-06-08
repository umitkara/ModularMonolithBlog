using System.Linq.Expressions;
using Blog.Category.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Blog.Category.Repositories;

public sealed class CategoryRepository : ICategoryRepository
{
    private readonly CategoryDbContext _context;
    private readonly ILogger<CategoryRepository> _logger;

    public CategoryRepository(CategoryDbContext context, ILogger<CategoryRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<Entities.Category>> GetAllAsync() => await _context.Categories.ToListAsync();

    public async Task<List<Entities.Category>> GetAllAsync(Expression<Func<Entities.Category, bool>> filter) =>
        await _context.Categories.Where(filter).ToListAsync();
}