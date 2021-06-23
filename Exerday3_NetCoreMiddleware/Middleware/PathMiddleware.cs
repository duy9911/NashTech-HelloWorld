using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace ASPCORE
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;
        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine(context.Request.Path);
           await _next(context);
        }
    }
}