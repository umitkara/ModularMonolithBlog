# Modular Monolith Blog Backend Project

This project is a backend implementation of a modular monolith blog using .NET 6 and Entity Framework Core. The project consists of the following layers: Blog.Category, Blog.Comment, Blog.Post, Blog.User, and Blog.UI.

## Technologies Used

- .NET 6
- Entity Framework Core
- In-Memory SQL Server

## Prerequisites

Make sure you have the following software installed on your machine:

- .NET 6 SDK
- Visual Studio 2022 or any other code editor of your choice

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/hakannyucel/ModularMonolithBlog.git
```

2. Build the solution to restore NuGet packages.

3. Run the following command in the Package Manager Console to apply the database migrations:

```bash
Update-Database
```

4. Start the application by running the Blog.UI project.

## Project Structure

The project is organized into the following folders:

- **Blog.Category**: Contains the logic and data access code related to blog categories.
- **Blog.Comment**: Contains the logic and data access code related to comments on blog posts.
- **Blog.Post**: Contains the logic and data access code related to blog posts.
- **Blog.User**: Contains the logic and data access code related to user management.
- **Blog.UI**: Contains the user interface and web API controllers.

Each folder contains its own set of models, services, repositories, and controllers.

## Contributing

Contributions are welcome! If you want to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make the necessary changes and commit them.
4. Push your branch to your forked repository.
5. Submit a pull request with a detailed description of your changes.
