using Microsoft.EntityFrameworkCore;
using app.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // 1

//رجبستر کردن دی بی کانتکس
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConStr")));

var app = builder.Build();
app.UseStaticFiles();  // 2

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(  // 3
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
