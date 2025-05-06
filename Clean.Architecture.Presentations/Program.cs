using MediatR;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);







builder.Services.AddAutoMapper();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});





var app = builder.Build();
app.UseStaticFiles();
app.UseStatusCodePages();
app.UseDeveloperExceptionPage();


app.MapGet("/", () => "Hello World!");

app.Run();

