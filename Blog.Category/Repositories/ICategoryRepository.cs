using System.Linq.Expressions;

namespace Blog.Category.Repositories;

public interface ICategoryRepository
{
    Task<List<Entities.Category>> GetAllAsync();
    Task<List<Entities.Category>> GetAllAsync(Expression<Func<Entities.Category, bool>> filter);
}