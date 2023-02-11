using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication117.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : 
            base(contextOptions) {}

        public DbSet<ProductModel> products {get; set;}
        public DbSet<PhotoModel> photos {get; set;}
        public DbSet<CallbackModel> callbacks {get; set;}
        public DbSet<UserModel> users {get; set; }
    }
}
