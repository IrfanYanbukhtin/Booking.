using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.Data
{
    public class DataInitializer
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext;

        public DataInitializer(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public async Task SeedData()
        {
            await _dbContext.Database.MigrateAsync();

            var roles = new List<string> { RoleConstants.AdminRole, RoleConstants.UserRole };

            foreach (var role in roles)
            {
                var existRole = await _roleManager.FindByNameAsync(role);

                if (existRole != null)
                    continue;

                var roleResult = await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = role
                });
            }

            var existUser = await _userManager.FindByNameAsync("Admin");

            if (existUser != null)
            {
                return;
            }

            var Admin = new AppUser
            {
                UserName = "Admin",
                Fullname = "Admin",
                Email = "irfanfy@code.edu.az",
                EmailConfirmed = true,
            };

            var result = await _userManager.CreateAsync(Admin, "18071998");

            result = await _userManager.AddToRoleAsync(Admin, RoleConstants.AdminRole);
        }
    }
}
