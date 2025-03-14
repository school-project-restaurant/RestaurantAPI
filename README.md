# RestaurantAPI

RestaurantAPI is a RESTful API designed as part of a school project to manage restaurant data. It provides endpoints for handling various restaurant-related operations, including creating, reading, updating, and deleting information about restaurants, menus, orders, reservations, and more.

## Features

- **CRUD Operations:** Easily create, read, update, and delete restaurant data.
- **Authentication:** Secure endpoints using JWT-based authentication.
- **Modular Structure:** Clean and scalable code structure following best practices.
- **Extensible:** Designed to be easily extended with additional features such as user management, order processing, and more.

## Technologies Used

- **Backend Framework:** C# with ASP.NET Core
- **Database:** PostgreSQL
- **Authentication:** JSON Web Tokens (JWT)
- **Development Tools:** Visual Studio, JetBrains Rider

## Getting Started

Follow these steps to set up the project locally.

### Prerequisites

- [PostgreSQL](https://www.postgresql.org/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/school-project-restaurant/Lume-Server.git
   cd Lume-Server
   ```

2. **Set up the database:**
   - Ensure PostgreSQL is running.
   - Update the `appsettings.json` file with your database connection string.

3. **Build and run the project:**

   ```bash
   dotnet build
   dotnet run
   ```

   The server should now be running on [http://localhost:5155](http://localhost:5155) or the configured port.

## API Endpoints
## TODO
Below is a brief overview of some key endpoints. For detailed API documentation, please refer to the [API documentation](./API_DOCUMENTATION.md) (if available) or check the code comments.

- **GET /restaurants**  
  Retrieve a list of all restaurants.

- **GET /restaurants/:id**  
  Retrieve detailed information about a specific restaurant.

- **POST /restaurants**  
  Create a new restaurant entry.

- **PUT /restaurants/:id**  
  Update an existing restaurant's details.

- **DELETE /restaurants/:id**  
  Remove a restaurant from the system.

## Database scheme
<p>
   <img src="assets/database-mode.png">
</p>

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

