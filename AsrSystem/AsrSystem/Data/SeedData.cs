using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsrSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AsrSystem.Data
{
    public class SeedData
    {
        public static async Task Initialise(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // ADD role to roleManager
            var roles = new[] { Constants.StudentRole, Constants.StaffRole };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }

            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            await CreateUserAndEnsureUserHasRole(userManager, "s1234567@example.com", Constants.StudentRole);
            await CreateUserAndEnsureUserHasRole(userManager, "e12345@example.com", Constants.StaffRole);
            //await EnsureUserHasRole(userManager, "matthew.bolger@rmit.edu.au", Constants.StaffRole);

            var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            await InitiailiseAsrDataAsync(context, userManager);
        }   

        public static async Task InitiailiseAsrDataAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            //await context.Student.AddAsync(new Student
            //{
            //    StudentID = "s123",
            //    Name = "Naaaaame"
            //});

            if (await context.Staff.FindAsync("e12345") == null)
            {
                await context.Staff.AddAsync(new Staff
                {
                    StaffID = "e12345",
                    Name = "Johnny",
                    Email = "e12345@staff.rmit.edu.au"
                });
            }

            if (await context.Student.FindAsync("s1234567") == null)
            {
                await context.Student.AddAsync(new Student
                {
                    StudentID = "s1234567",
                    Name = "Lukia"
                });
            }

            context.SaveChanges();
            //await UpdateUserAsync(userManager, "student@example.com", "s123");
            //await UpdateUserAsync(userManager, "e12345@example.com", "e12345");
            //await UpdateUserAsync(userManager, "s1234567@example.com", "s1234567");

        }

        public static async Task UpdateUserAsync(UserManager<ApplicationUser> userManager, string userName, string userId)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user.UserName.StartsWith('e'))
            {
                user.StaffID = userId;
            }

            if (user.UserName.StartsWith('s'))
            {
                user.StudentID = userId;
            }
            await userManager.UpdateAsync(user);
        }

        private static async Task CreateUserAndEnsureUserHasRole(
            UserManager<ApplicationUser> userManager, string userName, string role)
        {
            if (await userManager.FindByNameAsync(userName) == null)
                await userManager.CreateAsync(new ApplicationUser { UserName = userName, Email = userName }, "abc123");
            await EnsureUserHasRole(userManager, userName, role);
        }

        private static async Task EnsureUserHasRole(UserManager<ApplicationUser> userManager, string userName, string role)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null && !await userManager.IsInRoleAsync(user, role))
                await userManager.AddToRoleAsync(user, role);
        }
    }
}
