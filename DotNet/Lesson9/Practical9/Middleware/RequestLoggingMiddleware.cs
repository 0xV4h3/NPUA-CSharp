using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Practical9.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Request Path: {context.Request.Path}");
            await _next(context);
        }
    }
}