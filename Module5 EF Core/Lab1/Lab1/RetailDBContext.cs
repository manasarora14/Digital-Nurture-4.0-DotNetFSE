﻿using Microsoft.EntityFrameworkCore;

public class RetailDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=RetailDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
