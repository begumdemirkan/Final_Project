using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project_Admin.Models
{
    public class ToyContext : IdentityDbContext<Tuser>
    {
        public ToyContext(DbContextOptions<ToyContext> options)
               : base(options)
        {

        }

        public DbSet<Tuser> Tusers {get; set;}

        public DbSet<Category> Categories { get; set; }

        public DbSet<UserAddress> Addresses { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Statu> Status { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }






    }
}
