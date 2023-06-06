using Blog.User.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.User.Services;

public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Entities.User?> CreateUserAsync(Entities.User user)
    {
        return await _userRepository.CreateUserAsync(user);
    }

    public async Task DeleteUserAsync(string id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user != null)
        {
            await _userRepository.DeleteUserAsync(user);
        }
    }

    public async Task<Entities.User?> GetUserByIdAsync(string id)
    {
        return await _userRepository.GetUserByIdAsync(id);
    }

    public async Task UpdateUserAsync(Entities.User user)
    {
        await _userRepository.UpdateUserAsync(user);
    }
}
