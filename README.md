# ASP.NET Core 6 Blog Application

This is a simple Blog application built with ASP.NET Core 6. The application allows users to create, read, update, and delete blog posts. It uses Microsoft SQL Server as the database to store blog data.

## Features

- **User Authentication**: Secure login and registration system.
- **CRUD Operations**: Create, Read, Update, and Delete blog posts.
- **Category Management**: Organize blog posts into categories.
- **Comment Section**: Users can leave comments on blog posts.
- **Responsive Design**: The application is responsive and works well on various devices.
- **RESTful API**: The application exposes a RESTful API for accessing blog data.

## Technologies Used

- **ASP.NET Core 6**: The web framework used for building the application.
- **Entity Framework Core**: For database operations and migrations.
- **Microsoft SQL Server**: The database used to store the blog posts and user information.
- **Bootstrap**: For styling and responsive layout.
- **Font Awesome**: For icons.

## Prerequisites

Before running the application, ensure you have the following installed:

- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or any preferred IDE)

## Getting Started

1. **Clone the repository**:

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name

##Setup the Database:

Open SQL Server Management Studio.
Create a new database named BlogDb.
Update the connection string in appsettings.json to match your database configuration:

```bash
"ConnectionStrings": {
    "SqlServerDB": "Server=YOUR_SERVER_NAME;Database=BlogDb;Trusted_Connection=True;"
}

