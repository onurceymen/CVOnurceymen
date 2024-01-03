using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using MainProject.Data;
using MainProject.Areas.Identity.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CvProjectDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CvProjectDbContext")));

builder.Services.AddDbContext<CvProjectDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainProjectContext")));


builder.Services.AddDefaultIdentity<MainProjectUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MainProjectContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();

builder.Services.AddScoped<IBookcaseService, BookcaseManager>();
builder.Services.AddScoped<IBookcaseDal, EfBookcaseDal>();

builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<IEducationDal, EfEducation>();

builder.Services.AddScoped<IProjectService, ProjectManager>();
builder.Services.AddScoped<IProjectDal, EfProjectDal>();

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


app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}",
    defaults: new { area = "Admin" }
);

app.Run();