using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Application.Users.Handlers.QueryHandler;
using Clean.Architecture.Application.Users.Valodattions;
using Clean.Architecture.Domain.Interfaces.Auth;
using Clean.Architecture.Domain.Interfaces.Consts;
using Clean.Architecture.Domain.Interfaces.Users;
using Clean.Architecture.Infrastructure.BackGroundJob.Authentication;
using Clean.Architecture.Infrastructure.Repositories.Auth;
using Clean.Architecture.Infrastructure.Repositories.Consts;
using Clean.Architecture.Infrastructure.Repositories.Users;
using Clean.Architecture.Persistence.ApiDbContext;
using Clean.Architecture.WebApi.EndPoint;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json;

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
    services.AddScoped<IConstTypeRepository, ConstTypeRepository>();
    services.AddScoped<IConstRepository, ConstRepository>();
    services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
    services.AddScoped<IJwtService, JwtService>();
    services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });
    services.AddSwaggerGen();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Clean.Architecture API",
            Version = "v1",
            Description = "Explanation about API",
            Contact = new OpenApiContact
            {
                Name = "saeed hosseini",
                Email = "SeyedSaeisHosseini1990@Gmail.com",
                Url = new Uri("https://xxxx.com")
            }
        });
    });

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
    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    services.AddValidatorsFromAssemblyContaining<CreateUserValidator>();
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(options =>
     {
         var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();
         options.TokenValidationParameters = new TokenValidationParameters
         {
             ValidateIssuer = true,
             ValidateAudience = true,
             ValidateLifetime = true,
             ValidateIssuerSigningKey = true,
             ValidIssuer = jwtSettings.Issuer,
             ValidAudience = jwtSettings.Audience,
             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key))
         };
     });

    builder.Services.AddAuthorization();




}

void ConfigureMiddleware(WebApplication app)
{
    app.UseStaticFiles();
    app.MapFallbackToFile("index.html");
    app.UseStatusCodePages();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseDeveloperExceptionPage();
    app.UseCors();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
   
}
