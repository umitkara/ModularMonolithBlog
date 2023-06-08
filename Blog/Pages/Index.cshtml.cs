using Blog.Category.Services;
using Blog.Post.Services;
using Blog.User.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        public List<Post.Entities.Post> Posts;
        public List<Category.Entities.Category> Categories;

        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public IndexModel(IUserService userService, IPostService postService, ICategoryService categoryService)
        {
            _userService = userService;
            _postService = postService;
            _categoryService = categoryService;
            GetPosts().GetAwaiter().GetResult();
            GetCategories().GetAwaiter().GetResult();
        }

        public void OnGet()
        {

        }

        private async Task GetPosts()
        {
            Posts = await _postService.GetPostsAsync();
        }

        private async Task GetCategories()
        {
            Categories = await _categoryService.GetAllAsync();
        }
    }
}