﻿using System;
using APiRepository.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APiRepository.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DBConnection"));
        }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}

