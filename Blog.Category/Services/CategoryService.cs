using System.Linq.Expressions;
using Blog.Category.Repositories;

namespace Blog.Category.Services;

public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Entities.Category>> GetAllAsync() => await _categoryRepository.GetAllAsync();
    public async Task<List<Entities.Category>> GetAllAsync(Expression<Func<Entities.Category, bool>> filter) => await _categoryRepository.GetAllAsync(filter);
}