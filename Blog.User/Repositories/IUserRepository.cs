namespace Blog.User.Repositories;

public interface IUserRepository
{
    Task<Entities.User?> GetUserByIdAsync(string id);
    Task<Entities.User?> CreateUserAsync(Entities.User user);
    Task UpdateUserAsync(Entities.User user);
    Task DeleteUserAsync(Entities.User user);
}
