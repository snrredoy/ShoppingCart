﻿using Microsoft.EntityFrameworkCore;
using ShopingCart.Models;
using ShoppingCart.Models;
using System.Security.Cryptography.X509Certificates;

namespace ShopingCart.infostructure
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
            public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        
        
    }
}
