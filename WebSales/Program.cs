using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebSales.Data;
using WebSales.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebSalesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebSalesContext") ?? throw new InvalidOperationException("Connection string 'WebSalesContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<DepartmentService>();
builder.Services.AddScoped<SellerService>();

var app = builder.Build();

// Data seeding
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seedingService = services.GetRequiredService<SeedingService>();

    var env = services.GetRequiredService<IWebHostEnvironment>();
    if (env.IsDevelopment())
    {
        seedingService.Seed();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
