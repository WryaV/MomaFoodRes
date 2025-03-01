using Microsoft.EntityFrameworkCore;
using MomaFoodRes.Data;
using MomaFoodRes.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

// Register DbSeeder as a transient service
builder.Services.AddTransient<DbSeeder>();

var app = builder.Build();

// Seed database with initial data if necessary
using (var scope = app.Services.CreateScope())
    {
    var seeder = scope.ServiceProvider.GetRequiredService<DbSeeder>();
    await seeder.SeedDataAsync();  // Seed the data asynchronously
    }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
    app.UseMigrationsEndPoint();
    }
else
    {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    }

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
