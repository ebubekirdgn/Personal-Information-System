using Microsoft.AspNetCore.Identity;
using PersonalInformationSystem.Common.ConstantsModels;
using PersonalInformationSystem.Data.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PersonalInformationContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddTransient<SeedData>();


//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
//  .AddEntityFrameworkStores<PersonalInformationContext>();

builder.Services.AddDefaultIdentity<Personal>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<PersonalInformationContext>();


builder.Services.AddRazorPages();


builder.Services.AddScoped<IPersonalLeaveTypesBusiness, PersonalLeaveTypesBusiness>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(Maps));

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddMvc();


builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(3600);
});

var app = builder.Build();


var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

using (var scope = scopedFactory.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Personal>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    SeedData.Seed(userManager, roleManager);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
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
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();