using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.User.Services;

public interface IUserService
{
    Task<Entities.User?> GetUserByIdAsync(string id);
    Task<Entities.User?> CreateUserAsync(Entities.User user);
    Task UpdateUserAsync(Entities.User user);
    Task DeleteUserAsync(string id);
}
