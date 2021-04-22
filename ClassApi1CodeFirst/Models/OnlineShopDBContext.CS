using BroadwaysApiApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApi1CodeFirst.Models
{
    public class OnlineShopDBContext : DbContext
    {
     

        //public OnlineShopDBContext(DbContextOptions<OnlineShopDBContext> options) : base(options)
        //{

        //}
        public OnlineShopDBContext(DbContextOptions options)
    : base(options)
        {
        }
        public OnlineShopDBContext()
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categorires { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

    
    

      
    }


}
