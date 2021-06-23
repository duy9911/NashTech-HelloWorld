using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Abstractions;
namespace ASPCORE
{
    public class MiddleWare
    {
        private readonly RequestDelegate _next;

        public MiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }
}