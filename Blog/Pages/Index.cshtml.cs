using Blog.User.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;

        public IndexModel(Blog.User.Services.IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            
        }

        public async Task Test()
        {
            var newUser = new Blog.User.Entities.User
            {
                Email = "test@test.com",
                FullName = "Test User",
                BirthDate = DateTime.Now,
                PhoneNumber = "1234567890",
                UserName = "testuser"
            };
            var usr = await _userService.CreateUserAsync(newUser);
            var asd = await _userService.GetUserByIdAsync(usr?.Id);
        }
    }
}