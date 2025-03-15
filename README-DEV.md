Developer Guide - RestaurantAPI

This document provides instructions and guidelines for developers contributing to the RestaurantAPI project.

1. Project Structure

/RestaurantAPI
│── /Controllers       # API controllers
│── /Models            # Database models
│── /Data              # Database context and migrations
│── /Services          # Business logic services
│── /Repositories      # Data access layer
│── /Middlewares       # Custom middlewares
│── /DTOs              # Data Transfer Objects
│── /Utils             # Utility classes/helpers
│── Program.cs         # Main entry point
│── appsettings.json   # Configuration file
│── README.md          # General project information
│── README-DEV.md      # Developer guide (this file)

2. Getting Started

Prerequisites

.NET SDK 6.0+ - Download

SQL Server - Download

Visual Studio / JetBrains Rider / VS Code

Postman / Swagger for API testing

Setup Instructions

Clone the repository:

git clone https://github.com/school-project-restaurant/RestaurantAPI.git
cd RestaurantAPI

Configure Environment Variables:
Create a .env file or update appsettings.json with:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=RestaurantDB;User Id=sa;Password=yourpassword;"
  },
  "JwtSettings": {
    "Secret": "YourSuperSecretKey",
    "Issuer": "RestaurantAPI",
    "Audience": "RestaurantUsers"
  }
}

Run Database Migrations:

dotnet ef database update

Start the API:

dotnet run

The API should now be running on http://localhost:5000 (default ASP.NET port).

3. API Development Guidelines

Coding Standards

Follow C# naming conventions.

Use dependency injection instead of static classes.

Separate business logic (Services) from data access (Repositories).

Always return DTOs instead of direct database models.

API Documentation

Swagger UI is available at /swagger.

Use XML Comments in controller methods for API documentation.

Error Handling

Use middleware for global exception handling.

Return appropriate HTTP status codes (e.g., 400 Bad Request, 500 Internal Server Error).

4. Contributing

Branching Strategy

main → Production-ready code

dev → Ongoing development

feature/{feature-name} → New features

bugfix/{issue-name} → Bug fixes

Commit Message Convention

Follow this format:

feat: Add reservation endpoint
fix: Correct SQL query in restaurant service
refactor: Optimize authentication logic

Pull Requests

Create a new branch before working on an issue.

Ensure code is formatted and unit tests pass.

Add a detailed PR description.

5. Testing

Unit Tests

Located in /Tests folder.

Run tests with:

dotnet test

Postman Collection

Import the provided Postman collection (docs/Postman_Collection.json).

Test endpoints before merging changes.

6. Deployment

Docker (Optional)

Build and run using Docker:

docker build -t restaurant-api .
docker run -p 5000:5000 restaurant-api

CI/CD

GitHub Actions is configured for automatic builds.

Merging into main triggers an automated deployment.

7. Contact & Support

For any questions, reach out via:

GitHub Issues

Project Slack/Discord Channel

Email: team-email@example.com