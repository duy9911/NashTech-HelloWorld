using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;


namespace ASPCORE
{
    public class SecondMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine(context.Request.Host);
            await next(context);
        }
    }
}