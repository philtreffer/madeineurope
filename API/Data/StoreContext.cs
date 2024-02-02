using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entitites;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {       //Add, change, update Products - DB access code
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // Setting a Property "Product" will generate Columns in DbSet. Columns equal the properties of the class Product 
        public DbSet<Product> Products { get; set; }

    }
}