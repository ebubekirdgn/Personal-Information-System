using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PersonalInformationSystem.Business.Contracts;
using PersonalInformationSystem.Business.Implementation;
using PersonalInformationSystem.Common.Mappings;
using PersonalInformationSystem.Data.Contracts;
using PersonalInformationSystem.Data.DataContext;
using PersonalInformationSystem.Data.Implementation;
using PersonalInformationSystem.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


builder.Services.AddDbContext<PersonalInformationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPersonalLeaveTypesBusiness, PersonalLeaveTypesBusiness>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(Maps));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();