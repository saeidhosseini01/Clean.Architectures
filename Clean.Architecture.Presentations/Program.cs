using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infrastructure.Repositories;
using Clean.Architecture.Persistence.ApiDbContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);







builder.Services.AddAutoMapper(typeof(MappingsProfile));

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=.;Database=MyCacheDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;")));



var app = builder.Build();
app.UseStaticFiles();
app.UseStatusCodePages();
app.UseDeveloperExceptionPage();


app.MapGet("/", () => "Hello World!");

app.Run();

