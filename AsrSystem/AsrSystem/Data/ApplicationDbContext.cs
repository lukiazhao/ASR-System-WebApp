﻿using System;
using System.Collections.Generic;
using System.Text;
using AsrSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AsrSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Slot> Slot { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slot>().HasKey(x => new { x.RoomID, x.StartTime });
        }
    }
}
