using ItClubs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItClubs.Services
{
    class DataStorage : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DataStorage(DbContextOptions<DataStorage> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
