# Task 2 - Web API with Swagger

This project shows Swagger with a simple `EmployeeController` so the API endpoints appear neatly in the browser.

## What it covers

- `Swashbuckle.AspNetCore`
- `AddSwaggerGen`
- `UseSwaggerUI`
- `ProducesResponseType`
- Route name usage with `api/Emp`
- Basic Postman testing with headers and JSON body

## Endpoints

- `GET /api/Emp`
- `GET /api/Emp/{id}`
- `POST /api/Emp`
- `PUT /api/Emp/{id}`
- `DELETE /api/Emp/{id}`

## Notes

- Swagger is available at `/swagger`.
- `Name` on the GET actions is used for route naming.
- If needed, the route can be changed from `api/Emp` to another friendly name.

## How to run Task 2

1. Open the `Task2SwaggerWebAPI` folder.
2. Restore the project if needed.
3. Run the project.
4. Open `http://localhost:5165/swagger` or the URL shown in the console.
5. Test the `EmployeeController` actions from Swagger.
6. Use Postman to send the same requests with JSON body.

## Screenshot to capture

- Screenshot 1: Swagger home page showing `EmployeeController`.
- Screenshot 2: expanded GET action in Swagger with Try it out.
- Screenshot 3: Postman GET response showing the employee list and status code.
- Screenshot 4: Postman request or Swagger showing the route name `api/Emp`.
