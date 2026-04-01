using Scalar.AspNetCore;
using StaySphere.Application;
using StaySphere.Infrastructure;

namespace StaySphere.API;

public class Startup
{

    private IConfiguration configuration { get; }

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddInfrastructure(configuration)
                .AddApplication();
        services.AddControllers();
        services.AddOpenApi();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseRouting();
        if (env.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference();
        }
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }

}
