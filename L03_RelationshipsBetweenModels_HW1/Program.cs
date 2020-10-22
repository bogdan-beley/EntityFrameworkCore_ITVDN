using Microsoft.EntityFrameworkCore;
using System;

namespace L03_RelationshipsBetweenModels_HW1
{
    // One-to-Many relationship
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {
                // Eager loading
                var countries = db.Countries.Include(c => c.Cities);

                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.Name}:");

                    foreach (var city in country.Cities)
                    {
                        Console.WriteLine($"* {city.Name}");
                    }
                }
            }
        }
    }
}
