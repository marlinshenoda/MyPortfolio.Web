using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using MyPortfolio.Core.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyPortolioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyPortolioContext") ?? throw new InvalidOperationException("Connection string 'MyPortolioContext' not found.")));



// Add services to the container.
builder.Services.AddScoped(typeof(IunitOfWork<>),typeof(UnitOfWork<>));
builder.Services.AddControllersWithViews();
var app = builder.Build();

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
