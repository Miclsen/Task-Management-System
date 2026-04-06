# Task Management System

This repository implements a Task Management System built on .NET 10.

## What the program does

The Task Management System helps teams create, organize, assign, and track work items (tasks). At a high level the system provides:

- CRUD operations for tasks (create, read, update, delete)
- Task metadata: title, description, priority, status, due date, tags
- Assignment of tasks to users and basic user management
- Task lifecycle tracking (e.g., Todo -> In Progress -> Done)
- Search and filtering by status, assignee, tag, priority, and date ranges
- Persistence of tasks to a configurable data store (database or in-memory for development)
- A programmatic surface (API or library) that other components or UIs can consume

Depending on the projects present in this solution, the system may expose:

- A Web API (REST endpoints for managing tasks)
- A console or background service for scheduled jobs/notifications
- Unit and integration tests validating business rules and data access

## High-level architecture

- Presentation/API layer: exposes endpoints or command interfaces used by clients
- Application layer: contains business logic and use cases (task creation, assignment, status transitions)
- Data access layer: repository/EF Core or other provider that persists tasks and users
- Tests: unit tests for business logic, integration tests for data access and end-to-end flows

## How to run

1. Restore dependencies:

   `dotnet restore`

2. Build the solution:

   `dotnet build`

3. Pick the project you want to run (API, service, or console) and start it. Example:

   `dotnet run --project .\src\YourProjectName\YourProjectName.csproj`

4. If an API project is started, use an HTTP client (browser, curl, Postman) to call the endpoints. Check that project for the exact base URL and routes.

## Configuration and data

- Configuration is held in each project (appsettings.json, environment variables, or secrets).
- By default a development configuration may use an in-memory store. For production, configure a relational database (SQL Server, PostgreSQL, etc.) and update the connection string in the relevant project configuration.

## Tests

Run all tests:

`dotnet test`

Run a single test project:

`dotnet test .\tests\YourTestProject\YourTestProject.csproj`

## Where to look in the solution

- `src/` — application and service projects (API, worker, library code)
- `tests/` — unit and integration tests
- Open the `.sln` in Visual Studio 2026 to view project relationships and run/debug the solution.

## Contributing

Follow these steps to contribute:

1. Create a branch for your change.
2. Add or update tests for your change.
3. Build and run tests locally: `dotnet build` && `dotnet test`.
4. Open a pull request describing the change.

If you want, provide the names of the main projects (API, service, tests) and I can update this README with exact run commands and endpoint examples.
