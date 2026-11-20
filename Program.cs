using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NguyenDucThang_Day6.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<NguyenDucThang_Day6Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NguyenDucThang_Day6Context") ?? throw new InvalidOperationException("Connection string 'HoangVanMinh_Day6Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();
