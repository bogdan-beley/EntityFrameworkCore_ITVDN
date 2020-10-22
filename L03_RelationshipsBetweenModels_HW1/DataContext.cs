using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace L03_RelationshipsBetweenModels_HW1
{
    class DataContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=L03_HW1db; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CountrySeed
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Ukraine" },
                new Country { Id = 2, Name = "Poland" },
                new Country { Id = 3, Name = "Italy" },
                new Country { Id = 4, Name = "Canada"}
                );
            #endregion

            #region CitySeed
            modelBuilder.Entity<City>().HasData(
                new City { CountryId = 1, Id = 1, Name = "Kyiv" },
                new City { CountryId = 1, Id = 2, Name = "Lviv" },
                new City { CountryId = 1, Id = 3, Name = "Dnipro" },
                new City { CountryId = 1, Id = 4, Name = "Rivne" },
                new City { CountryId = 2, Id = 5, Name = "Zakopane" },
                new City { CountryId = 2, Id = 6, Name = "Gdynia" },
                new City { CountryId = 2, Id = 7, Name = "Wroclaw" },
                new City { CountryId = 3, Id = 8, Name = "Rome" },
                new City { CountryId = 3, Id = 9, Name = "Milan" },
                new City { CountryId = 3, Id = 10, Name = "Turin" },
                new City { CountryId = 3, Id = 11, Name = "Naples" },
                new City { CountryId = 4, Id = 12, Name = "Toronto" },
                new City { CountryId = 4, Id = 13, Name = "Montreal" },
                new City { CountryId = 4, Id = 14, Name = "Ottawa" }
                );
            #endregion
        }
    }
}
