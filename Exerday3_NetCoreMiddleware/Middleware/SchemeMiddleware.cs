using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;


namespace ASPCORE
{
    public class ThirdMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine(context.Request.Scheme);
            await next(context);
        }
    }
}