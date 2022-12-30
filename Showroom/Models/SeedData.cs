using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Showroom.Data;
using System;
using System.Linq;

namespace Showroom.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShowroomContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShowroomContext>>()))
            {
                // Look for any movies.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }
                context.Car.AddRange(
                    new Car
                    {
                        name = "Car 1",
                        exterior_color = "white",
                        work_productivity = "1.500cm3",
                        cylinder_number = 4,
                        year = DateTime.Parse("2022-4-15"),
                        length = 4800,
                        width = 1437,
                        height = 1437,
                        weight = 1650,
                        maximum_weight = "2265kg",
                        top_speed = 246,
                        interior_color = "black",
                        number_of_seat = 4,
                        price = 5000
                    }

                );
                context.SaveChanges();
            }
        }
    }
}


