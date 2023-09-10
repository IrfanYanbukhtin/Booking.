using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Areas.AdminPanel.Data;
using BOOking.MVC.Data;
using BOOking.MVC.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using IMailService = BOOking.MVC.Services.IMailService;

var builder = WebApplication.CreateBuilder(args);

Constants.ImagePath = Path.Combine(builder.Environment.WebRootPath, "/image");

builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), builder => builder.MigrationsAssembly("BOOking.DAL"));
});

builder.Services.Configure<MailSetting>(builder.Configuration.GetSection("MailSettings"));

builder.Services.AddTransient<IMailService, GmailManager>();

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = true;

    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.AllowedForNewUsers = true;

}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    var dataInitializer = new DataInitializer(userManager, roleManager, dbContext);
    await dataInitializer.SeedData();
};

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
          );

    endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
});

app.MapRazorPages();

app.Run();