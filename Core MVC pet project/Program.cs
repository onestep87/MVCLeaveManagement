using Core_MVC_pet_project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Core_MVC_pet_project.Configurations;
using Core_MVC_pet_project.Contracts;
using Core_MVC_pet_project.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Core_MVC_pet_project.Data.ILeaveTypeRepository>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Core_MVC_pet_project.Data.ILeaveTypeRepository>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<Core_MVC_pet_project.Contracts.ILeaveTypeRepository, LeaveTypeRepository>();
builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
