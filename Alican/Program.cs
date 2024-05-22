using Alican.Middleware;
using static System.Net.Mime.MediaTypeNames;

namespace Alican;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddTransient<ExampleMiddleWare>();
        var app = builder.Build();


        app.UseCors(x => x.AllowAnyOrigin());
        app.MapGet("/", () => "Hello World!");
        app.UseAuthorization();
        app.UseAuthentication();

        app.MapControllers();
        app.UseMiddleware<ExampleMiddleWare>();
        //app.Use(async (context, next) =>
        //{
        //    //context.Request.QueryString = QueryString.Create("age", "10");
        //    //context.Response.StatusCode = 200;
        //    try
        //    {
        //        await next(context);
        //    }
        //    catch (Exception ex)
        //    {
        //        context.Response.StatusCode = 500;
        //        await context.Response.WriteAsync(ex.StackTrace!);
               
        //    }
        //    await next(context);
        //});
        app.Run();
    }
}
