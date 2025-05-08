using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infrastructure.Repositories;
using Clean.Architecture.Persistence.ApiDbContext;
using Clean.Architecture.WebApi.EndPoint;
using MediatR;
using Microsoft.EntityFrameworkCore;
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

    services.AddMediatR(cfg =>
        cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

    services.AddScoped<IUserRepository, UserRepository>();

    services.AddDbContext<ApiDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
}

void ConfigureMiddleware(WebApplication app)
{
    app.UseStaticFiles();
    app.UseStatusCodePages();
    app.UseDeveloperExceptionPage();

   

}
