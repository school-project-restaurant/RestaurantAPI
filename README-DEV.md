# Developer Guide - Lume-Server

This document provides instructions and guidelines for developers contributing to the **Lume-Server** project.

## 1. Project Structure

```markdown
/Lume.API              # Handles API endpoints and request routing
│── /Controllers       # API controllers managing requests and responses
│── Program.cs         # Main entry point of the application
│── appsettings.json   # Configuration file for the API settings
│── Lume.http          # Collection of mock HTTP requests for testing

/Lume.Application      # Contains business logic, use cases, and service interfaces
│── /Prenotations      # Manages prenotation services and related DTOs
│   │── IPrenotationService.cs  # Interface defining prenotation service methods
│   │── PrenotationService.cs  # Implementation of prenotation services
│── /Extensions        # Application-level extensions for dependency injection
│   │── ServiceCollectionExtensions.cs  # Service registrations and configurations

/Lume.Domain           # Core domain models and business rules
│── /Repositories      # Defines repository interfaces for database interactions
│   │── IPrenotationRepository.cs  # Interface for prenotation data access

/Lume.Infrastructure   # Implementation of data persistence and external service integrations
│── /Extensions        # Infrastructure-level extensions
│   │── ServiceCollectionExtensions.cs  # Registers infrastructure services
│── /Persistence       # Database access and repository implementations
│   │── /Repositories  # Implements repository interfaces
│   │   │── PrenotationRepository.cs  # Concrete repository for prenotations
│   │── RestaurantDbContext.cs  # Database context handling entity mappings
```

## 2. Getting Started

### Prerequisites

- **.NET SDK 9.0+** - [Download](https://dotnet.microsoft.com/download)
- **PostgreSQL** - [Download](https://www.postgresql.org/download/)
- **Visual Studio / JetBrains Rider**

### Setup Instructions

1. **Clone the repository:**

   ```bash
   git clone https://github.com/school-project-restaurant/Lume-Server.git
   cd Lume-Server
   ```

2. **Run Database Migrations:**

   ```bash
   dotnet ef database update
   ```

3. **Start the API:**

   ```bash
   dotnet run
   ```

   The API should now be running on **[http://localhost:5155](http://localhost:5155)**

## 3. API Development Guidelines

### Coding Standards

- Follow **C# naming conventions**.
- Use **dependency injection** instead of static classes.
- Separate **business logic (Services)** from **data access (Repositories)**.
- Always return **DTOs** instead of direct database models.

### API Documentation

- **Swagger UI** is available at **`/swagger`**.

### Error Handling

- Use **middleware** for **global exception handling**.
- Return appropriate **HTTP status codes** (e.g., `400 Bad Request`, `500 Internal Server Error`).

## 4. Contributing

### Branching Strategy

- `master` → Production-ready code
- `dev` → Ongoing development
- `feature/{feature-name}` → New features
- `bugfix/{issue-name}` → Bug fixes
- `docs` → Documentation

### Commit Message Convention

Follow this format:

```bash
feat: Add reservation endpoint
fix: Correct SQL query in restaurant service
refactor: Optimize authentication logic
```

### Pull Requests

- **Create a new branch** before working on an issue.
- Ensure **code is formatted** and **unit tests pass**.

## 5. Testing (TODO)

## 6. Deployment (TODO)

