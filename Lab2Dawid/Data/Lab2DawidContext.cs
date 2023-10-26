using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab2Dawid.Models;

namespace Lab2Dawid.Data
{
    public class Lab2DawidContext : DbContext
    {
        public Lab2DawidContext (DbContextOptions<Lab2DawidContext> options)
            : base(options)
        {
        }

        public DbSet<Lab2Dawid.Models.Hotel> Hotel { get; set; } = default!;
    }
}
