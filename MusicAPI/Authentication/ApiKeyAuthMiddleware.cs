namespace MusicAPI.Authentication;

public class ApiKeyAuthMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public ApiKeyAuthMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        //Checks if there is a key
        if (!context.Request.Headers.TryGetValue(AuthContants.ApiKeyHeaderName, out var extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API Key is missing");
            return;
        }

        //Validates the API key
        var apiKey = _configuration.GetValue<string>(AuthContants.ApiKeySectionName);
        if (string.IsNullOrEmpty(apiKey) || !apiKey.Equals(extractedApiKey, StringComparison.OrdinalIgnoreCase))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid API Key");
            return;
        }

        await _next(context);
    }
}