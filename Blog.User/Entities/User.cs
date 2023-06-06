using Microsoft.AspNetCore.Identity;

namespace Blog.User.Entities;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
}