# Task 3 - Web API with Custom Model and Filters

This project shows a simple custom `Employee` model, a custom auth filter, and a custom exception filter.

## What it covers

- Custom model classes: `Employee`, `Department`, `Skill`
- `FromBody` for POST and PUT
- `AllowAnonymous` on the GET action
- `ActionFilterAttribute` in `CustomAuthFilter`
- `IExceptionFilter` in `CustomExceptionFilter`
- Swagger for endpoint testing

## Endpoints

- `GET /api/employee`
- `GET /api/employee/{id}`
- `POST /api/employee`
- `PUT /api/employee/{id}`

## Notes

- Add `Authorization: Bearer demo-token` for the protected endpoints.
- `GET /api/employee?throwError=true` can be used to test the exception filter.
- The exception filter writes to `Logs/exceptions.txt`.

## How to run Task 3

1. Open the `Task3CustomModelWebAPI` folder.
2. Restore the project if needed.
3. Run the project.
4. Open `http://localhost:5166/swagger` or the URL shown in the console.
5. Call `GET /api/employee` with the header `Authorization: Bearer demo-token`.
6. Call `GET /api/employee?throwError=true` to test the exception filter.

## Screenshot to capture

- Screenshot 1: Swagger page showing the employee endpoints.
- Screenshot 2: GET employee list response with the Authorization header.
- Screenshot 3: bad request response when the header is missing.
- Screenshot 4: exception response for `throwError=true`.
- Screenshot 5: the log file or folder showing `Logs/exceptions.txt`.
