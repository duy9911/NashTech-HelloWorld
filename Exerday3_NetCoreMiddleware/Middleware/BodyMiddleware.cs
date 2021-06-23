using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;


namespace ASPCORE
{
    public class FiveMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine(context.Request.Body);
            await next(context);
        }
    }
}