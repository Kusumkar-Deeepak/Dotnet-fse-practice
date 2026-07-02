# Task 1 - First Web API using .NET Core

This folder is the first sample project. It keeps the code simple and adds Swagger so the endpoints can be viewed neatly in the browser.

## Covers

- RESTful web service basics
- Web API and microservice idea
- HttpRequest and HttpResponse
- Action verbs: `HttpGet`, `HttpPost`, `HttpPut`, `HttpDelete`
- Status codes through action results: `Ok`, `BadRequest`, `Unauthorized`, `InternalServerError`
- Basic read and write actions using `ValuesController`

## Swagger

- Swagger is enabled in `Program.cs`.
- Open `/swagger` after running the app to see the controller actions.

## How to run Task 1

1. Open the `FirstWebAPI` folder.
2. Restore the project if needed.
3. Run the project.
4. Open `http://localhost:5164/swagger` or the URL shown in the console.
5. Test `GET /api/values` first.

## Files

- `Program.cs` for startup and Swagger.
- `Controllers/ValuesController.cs` for the CRUD sample.
- `Models/ValueModels.cs` for the request and response types.
- `FirstWebAPI.http` for quick endpoint tests.

## Notes

- `Startup.cs` is from older ASP.NET Core versions.
- `appsettings.json` and `launchSettings.json` are the main configuration files here.
- `Route.config` and `WebAPI.config` belong to older .NET Framework Web API projects.
