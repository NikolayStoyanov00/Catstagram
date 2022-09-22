using Catstagram.Infrastructure;

namespace Catstagram;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Configure services
        builder.Services
            .AddDatabase(builder.Configuration)
            .AddIdentity()
            .AddJwtAuthentication(builder.Services.GetAppSettings(builder.Configuration))
            .AddApplicationServices()
            .AddDatabaseDeveloperPageExceptionFilter()
            .AddSwagger()
            .AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }

        app
            .UseSwaggerUI()
            .UseRouting()
            .UseCors(options => options
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader())
            .UseAuthentication()
            .UseAuthorization()
            .UseEndpoints(endpoints => { endpoints.MapControllers(); });

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.ApplyMigrations();

        app.Run();
    }
}
