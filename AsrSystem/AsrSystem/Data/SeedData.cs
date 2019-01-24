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
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var userManager = serviceProvider.GetRequiredService<UserManager<User>>())
            using (var context = new AsrSystemContext(serviceProvider.GetRequiredService<DbContextOptions<AsrSystemContext>>()))
            {
                InitiliseUsers(userManager);
                InitialiseAsrData(context, userManager);
            }
        }

        private static void InitiliseUsers(UserManager<User> userManager)
        {
            if (userManager.Users.Any())
            {
                return;
            }

            CreateUser(userManager, "e12345@rmit.edu.au");
            CreateUser(userManager, "e56789@rmit.edu.au");
            CreateUser(userManager, "s1234567@student.rmit.edu.au");
            CreateUser(userManager, "s4567890@student.rmit.edu.au");
        }

        private static void CreateUser(UserManager<User> userManager, string userName) => userManager.CreateAsync(new User
        {
            UserName = userName,
            Email = userName
        }, "abc123").Wait();

        private static void InitialiseAsrData(AsrSystemContext context, UserManager<User> userManager)
        {
            if (context.Room.Any())
                return;
            context.Room.AddRange(
                new Room { RoomID = "A" },
                new Room { RoomID = "B" },
                new Room { RoomID = "C" },
                new Room { RoomID = "D" }
            );

            CreateStaff(context, "e12345", "Matt");
            CreateStaff(context, "e56789", "Matt");

            CreateStudent(context, "s1234567", "Kevin");
            CreateStudent(context, "s4567890", "Olivier");

            context.Slot.AddRange(
                new Slot
                {
                    RoomID = "A",
                    StartTime = new DateTime(2019, 1, 30),
                    StaffID = "e12345"
                },
                new Slot
                {
                    RoomID = "B",
                    StartTime = new DateTime(2019, 1, 30),
                    StaffID = "e56789",
                    StudentID = "s1234567"
                },
                new Slot
                {
                    RoomID = "C",
                    StartTime = new DateTime(2019, 1, 30),
                    StaffID = "e12345",
                }
            );
            context.SaveChanges();

            UpdateUser(userManager, "e12345@rmit.edu.au", "e12345");
            UpdateUser(userManager, "e56789@rmit.edu.au", "e56789");
            UpdateUser(userManager, "s1234567@student.rmit.edu.au", "s1234567");
            UpdateUser(userManager, "s4567890@student.rmit.edu.au", "s4567890");
        }


        private static void CreateStaff(AsrSystemContext context, string id, string name)
        {
            context.Staff.Add(new Staff
            {
                StaffID = id,
                Email = id + "@rmit.edu.au",
                Name = name
            });
        }

        private static void CreateStudent(AsrSystemContext context, string id, string name)
        {
            context.Student.Add(new Student
            {
                StudentID = id,
                Email = id + "@student.rmit.edu.au",
                Name = name
            });
        }

        private static void UpdateUser(UserManager<User> userManager, string userName, string id)
        {
            var user = userManager.FindByNameAsync(userName).Result;
            if (user.UserName.StartsWith('e'))
                user.StaffID = id;
            if (user.UserName.StartsWith('s'))
                user.StudentID = id;

            userManager.UpdateAsync(user).Wait();
        }
    }
}
