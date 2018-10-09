 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace computer285.Models
{
    public class OurDbContext : DbContext
    {
        public OurDbContext()
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Test> Test { get; set; }
    }
}