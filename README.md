# Identity Server for TAL Cloud-Based File Storage System

This repository contains the Identity Server microservice for the TAL Cloud-Based File Storage System. The service is responsible for user authentication and authorization. It is built with **.NET 9 Web API**, uses **EF Core** with **Identity**, and **PostgreSQL** as its database, and is containerized for easy deployment.

## Features

- **User Registration:** Allows users to register new accounts.
- **User Login:** Enables users to authenticate using their credentials.
- **User Management:** Provides a list of registered users (accessible only with the required permissions).

## Tech Stack

- **.NET 9 Web API**
- **Entity Framework Core** with **Identity**
- **PostgreSQL**
- **Docker** (for containerization)

## Prerequisites

- [Docker](https://www.docker.com/) installed
- [.NET SDK 9](https://dotnet.microsoft.com/download/dotnet/9.0)
- PostgreSQL database (if not using Docker Compose for setup)

## Setup Instructions

### Clone the Repository

```bash
git clone https://github.com/your-username/identity-server.git
cd identity-server
```

### Configure Environment Variables

Create an `.env` file in the root of the project with the following variables:

```env
DB_HOST=your-database-host
DB_PORT=5432
DB_NAME=your-database-name
DB_USER=your-database-user
DB_PASSWORD=your-database-password
JWT_SECRET=your-jwt-secret
```

### Build and Run with Docker

1. Build the Docker image:

   ```bash
   docker build -t identity-server .
   ```

2. Run the container:

   ```bash
   docker run -p 5000:5000 --env-file .env identity-server
   ```

### Running with Docker Compose

For a simplified setup using Docker Compose:

1. Ensure `docker-compose.yml` is configured with appropriate environment variables.

2. Run the application:

   ```bash
   docker-compose up
   ```

## API Endpoints

### Public Endpoints

- **POST /api/auth/register**: Register a new user
- **POST /api/auth/login**: Authenticate a user and get a JWT token

### Protected Endpoints

- **GET /api/users**: Get a list of registered users (requires appropriate permissions)

## Development

### Run Locally

1. Install dependencies:

   ```bash
   dotnet restore
   ```

2. Update `appsettings.json` or `appsettings.Development.json` with your PostgreSQL configuration.

3. Run database migrations:

   ```bash
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

### Run Tests

1. Build the project:

   ```bash
   dotnet build
   ```

2. Run tests:

   ```bash
   dotnet test
   ```
