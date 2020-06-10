﻿using P4Project2.Models;
using Microsoft.EntityFrameworkCore;

namespace P4Project2.DBContext
{
    public class Context : DbContext
    {
        public DbSet<Gladiator> Gladiators { get; set; }
        public DbSet<PrimaryClass> PrimaryClasses { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=gladiatorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
