using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace ASPCORE
{
    public class ThirdMiddleware
    {
        private readonly RequestDelegate _next;
        public ThirdMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, string sss)
        {
           sss = context.Request.Path;
           await _next(context);
        }
    }
}