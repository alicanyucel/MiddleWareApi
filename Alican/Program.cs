namespace Alican;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        var app = builder.Build();


        app.UseCors(x=> x.AllowAnyOrigin());
        app.MapGet("/", () => "Hello World!");
        app.UseAuthorization();
        app.UseAuthentication();
        app.MapControllers();
        app.Run();
    }
}
