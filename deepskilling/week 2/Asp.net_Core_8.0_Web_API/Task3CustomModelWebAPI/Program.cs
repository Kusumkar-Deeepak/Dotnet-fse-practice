using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<Task3CustomModelWebAPI.Filters.CustomExceptionFilter>();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee API",
        Version = "v1",
        Description = "Task 3 Web API"
    });
});
builder.Services.AddScoped<Task3CustomModelWebAPI.Filters.CustomExceptionFilter>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();