using Clean.Architecture.Application.Handlers.QuerisHandler.User;
using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infrastructure.Repositories;
using Clean.Architecture.Persistence.ApiDbContext;
using Clean.Architecture.WebApi.EndPoint;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Configure Services
ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure Middleware
ConfigureMiddleware(app);

// Run Application
app.MapRoot();
app.Run();

// ---------------------------------
// Methods

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllers();
    services.AddAutoMapper(typeof(MappingsProfile));
    builder.Services.AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(GetAllUsersQueryHandler).Assembly)
 );
    services.AddScoped<IUserRepository, UserRepository>();

    services.AddDbContext<ApiDbContexts>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),sqlpots=>sqlpots.EnableRetryOnFailure()));
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
    });
    //services.AddSpaStaticFiles(configuration =>
    //{
    //    configuration.RootPath = "ClientApp/dist";
    //});



}

void ConfigureMiddleware(WebApplication app)
{
    app.UseStaticFiles();
    app.MapFallbackToFile("index.html");
    app.UseStatusCodePages();
    app.UseDeveloperExceptionPage();
    app.UseCors();
    //app.UseSpa(spa =>
    //{
    //    spa.Options.SourcePath = "ClientApp";

    //    if (app.Environment.IsDevelopment())
    //    {
    //        // ?? ???? ?????? ?? ng serve ??? ????
    //        spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
    //    }
    //});

}
