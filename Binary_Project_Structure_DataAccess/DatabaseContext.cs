using Binary_Project_Structure_DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Project_Structure_DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Pilot> Pilot { get; set; }
        public DbSet<Stewardess> Stewardess { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TypeAircraft> TypeAircraft { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirportDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AirportDBInitializer initializer = new AirportDBInitializer(modelBuilder);
            initializer.Initialize();
        }

        public async Task<List<TEntity>> SetAsync<TEntity>() where TEntity : class
        {
            if (Ticket is DbSet<TEntity>)
                return await (Ticket as DbSet<TEntity>).ToListAsync();

            if (Stewardess is DbSet<TEntity>)
                return await (Stewardess as DbSet<TEntity>).ToListAsync();

            if (Pilot is DbSet<TEntity>)
                return await (Pilot as DbSet<TEntity>).ToListAsync();

            if (Departure is DbSet<TEntity>)
                return await (Departure as DbSet<TEntity>).ToListAsync();

            if (Crew is DbSet<TEntity>)
                return await (Crew as DbSet<TEntity>).ToListAsync();

            if (TypeAircraft is DbSet<TEntity>)
                return await (TypeAircraft as DbSet<TEntity>).ToListAsync();
            
            if (Aircraft is DbSet<TEntity>)
                return await (Aircraft as DbSet<TEntity>).ToListAsync();

            if (Flight is DbSet<TEntity>)
                return await (Flight as DbSet<TEntity>).ToListAsync();

            return null;
        }
    }
}
