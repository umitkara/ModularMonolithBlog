using Microsoft.EntityFrameworkCore;
using Blog.User.Entities;
using Blog.Comment.Entities;
using Blog.Post.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Blog.User.Data.UserDbContext>(options =>
                    options.UseInMemoryDatabase("UserDb"));

builder.Services.AddDbContext<Blog.Post.Data.PostDbContext>(options =>
                    options.UseInMemoryDatabase("PostDb"));

builder.Services.AddDbContext<Blog.Comment.Data.CommentDbContext>(options =>
                    options.UseInMemoryDatabase("CommentDb"));

builder.Services.AddScoped<Blog.User.Repositories.IUserRepository, Blog.User.Repositories.UserRepository>();
builder.Services.AddScoped<Blog.Post.Repositories.IPostRepository, Blog.Post.Repositories.PostRepository>();
builder.Services.AddScoped<Blog.Comment.Repositories.ICommentRepository, Blog.Comment.Repositories.CommentRepository>();

builder.Services.AddScoped<Blog.User.Services.IUserService, Blog.User.Services.UserService>();
builder.Services.AddScoped<Blog.Post.Services.IPostService, Blog.Post.Services.PostService>();
builder.Services.AddScoped<Blog.Comment.Services.ICommentService, Blog.Comment.Services.CommentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
