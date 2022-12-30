using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Showroom.Models;

namespace Showroom.Data
{
    public class ShowroomContext : DbContext
    {
        public ShowroomContext (DbContextOptions<ShowroomContext> options)
            : base(options)
        {
        }

        public DbSet<Showroom.Models.Car> Car { get; set; } = default!;

        public DbSet<Showroom.Models.Service> Service { get; set; } = default!;
    }
}
