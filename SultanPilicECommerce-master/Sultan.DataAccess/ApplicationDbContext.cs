﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sultan.Models;

namespace Sultan.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       public DbSet<Category> Categories { get; set; }
       public DbSet<ChickType> ChickTypes { get; set; }
       public DbSet<Product> Products { get; set; }
    }
}
