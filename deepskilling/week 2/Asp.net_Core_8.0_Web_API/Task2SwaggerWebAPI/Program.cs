using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo
	{
		Title = "Swagger Demo",
		Version = "v1",
		Description = "Task 2 Web API",
		TermsOfService = new Uri("https://example.com/terms"),
		Contact = new OpenApiContact
		{
			Name = "John Doe",
			Email = "john@xyzmail.com",
			Url = new Uri("https://example.com")
		},
		License = new OpenApiLicense
		{
			Name = "License Terms",
			Url = new Uri("https://example.com/license")
		}
	});
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();