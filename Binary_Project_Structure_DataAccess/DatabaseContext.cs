using Binary_Project_Structure_DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirportDb;Trusted_Connection=True;");
        }

        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Pilot> Pilot { get; set; }
        public DbSet<Stewardess> Stewardess { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TypeAircraft> TypeAircraft { get; set; }
    }
}
