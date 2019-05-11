﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Admin.Models;

namespace Project_Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext<Tuser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Tuser> Tusers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<UserAddress> Addresses { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Statu> Status { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }


    }
}
