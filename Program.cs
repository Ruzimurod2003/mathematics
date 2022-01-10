using Mathematics.Models;
using Microsoft.EntityFrameworkCore;

var connectionstring = "Data Source=Data/Math.db";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option=>option.EnableEndpointRouting=false);
builder.Services.AddDbContext<ApplicationDBContext>(option => option.UseSqlite(connectionstring));

var app = builder.Build();
app.UseStaticFiles();

app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Administrator}/{action=Index}/{id?}");
});

//app.UseMvcWithDefaultRoute();

//app.MapGet("/", () => "Hello World!");

app.Run();
