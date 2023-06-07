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
    }
}