using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using MainLayer.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MainLayer.Data;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MainLayerContextConnection") ?? throw new InvalidOperationException("Connection string 'MainLayerContextConnection' not found.");

builder.Services.AddDbContext<MainLayerContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MainLayerUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MainLayerContext>();

builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();


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
/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=About}/{action=Index}/{id?}");
*/
app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=AdminAbout}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
