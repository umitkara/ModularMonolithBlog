using System.Linq.Expressions;

namespace Blog.Category.Services;

public interface ICategoryService
{
    Task<List<Entities.Category>> GetAllAsync();
    Task<List<Entities.Category>> GetAllAsync(Expression<Func<Entities.Category, bool>> filter);
}