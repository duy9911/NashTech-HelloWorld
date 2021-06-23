
using Microsoft.AspNetCore.Builder;

namespace ASPCORE
{
public static class UseFirstMiddleWareMethod
{
    public static void UseFirstMiddleWare(this IApplicationBuilder app)
    {
        app.UseMiddleware<FirstMiddleware>();
    }
}
}