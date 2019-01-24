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
            await CreateUserAndEnsureUserHasRole(userManager, "s1234567@student.rmit.edu.au", Constants.StudentRole);
            await CreateUserAndEnsureUserHasRole(userManager, "e56789@rmit.edu.au", Constants.StaffRole);
            await CreateUserAndEnsureUserHasRole(userManager, "e12345@rmit.edu.au", Constants.StaffRole);
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
            
            // Seed rooms
            if (!await context.Room.AnyAsync())
            {
                await context.Room.AddRangeAsync(
                new Room { RoomID = "A" },
                new Room { RoomID = "B" },
                new Room { RoomID = "C" },
                new Room { RoomID = "D" }
                );
            }

            //Seed Staff
            if (!await context.Staff.AnyAsync())
            {
                await context.Staff.AddAsync(new Staff
                {
                    StaffID = "e12345",
                    Name = "Johnny",
                    Email = "e12345@rmit.edu.au"
                });
                await context.Staff.AddAsync(new Staff
                {
                    StaffID = "e56789",
                    Name = "Mathew",
                    Email = "e56789@rmit.edu.au"
                });
            }

            //Seed Student
            if (!await context.Student.AnyAsync())
            {
                await context.Student.AddAsync(new Student
                {
                    StudentID = "s1234567",
                    Name = "Lukia",
                    Email = "s1234567@student.rmit.edu.au"
                });
            }
            
            //Seed Slot
            if (!await context.Slot.AnyAsync())
            {
                await context.Slot.AddAsync(new Slot
                {
                    RoomID = "A",
                    StartTime = new DateTime(2019, 1, 30, 9, 00, 00),
                    StaffID = "e12345"
                });
                await context.Slot.AddAsync(new Slot
                {
                    RoomID = "B",
                    StartTime = new DateTime(2019, 1, 30, 10, 00, 00),
                    StaffID = "e12345"
                });
            }

            context.SaveChanges();
            await UpdateUserAsync(userManager, "e12345@rmit.edu.au", "e12345");
            await UpdateUserAsync(userManager, "e56789@rmit.edu.au", "e56789");
            await UpdateUserAsync(userManager, "s1234567@student.rmit.edu.au", "s1234567");

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
