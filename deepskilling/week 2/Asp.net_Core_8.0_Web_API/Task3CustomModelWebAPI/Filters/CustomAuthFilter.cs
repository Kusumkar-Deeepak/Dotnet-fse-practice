using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Task3CustomModelWebAPI.Filters;

public class CustomAuthFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var hasAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
        if (hasAnonymous)
        {
            return;
        }

        if (!context.HttpContext.Request.Headers.TryGetValue("Authorization", out var authHeader))
        {
            context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
            return;
        }

        if (!authHeader.ToString().Contains("Bearer", StringComparison.OrdinalIgnoreCase))
        {
            context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
        }
    }
}