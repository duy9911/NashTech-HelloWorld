using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Web;

public class MyStartUp
{
    //dang ky cac dich vu
    public void ConfigureServices(IServiceCollection services)
    {

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        //add statuscodepage to pipeline if 
        app.UseStatusCodePages();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async (context) =>
            {
                await context.Response.WriteAsync("Home");
            });
            endpoints.MapGet("/about", async (context) =>
             {
                 await context.Response.WriteAsync("Trang lien he");
             });
            endpoints.MapGet("/contact", async (context) =>
            {
                await context.Response.WriteAsync("Trang contact");
            });
        });

        app.Map("/abc", app1 =>
        {
            app1.Run(async (context) =>
            {
                await context.Response.WriteAsync("Day la middleware 2 ");
            });
        });
        //terminate middleware

    }
}