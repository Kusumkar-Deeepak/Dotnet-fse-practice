using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Task3CustomModelWebAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {context.Exception.Message}";
        var folderPath = Path.Combine(AppContext.BaseDirectory, "Logs");
        var filePath = Path.Combine(folderPath, "exceptions.txt");

        Directory.CreateDirectory(folderPath);
        File.AppendAllText(filePath, logLine + Environment.NewLine);

        context.Result = new ObjectResult("Something went wrong. Check the log file.")
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };
        context.ExceptionHandled = true;
    }
}