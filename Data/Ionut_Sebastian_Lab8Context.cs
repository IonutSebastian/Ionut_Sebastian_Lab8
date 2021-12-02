using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionut_Sebastian_Lab8.Models;

namespace Ionut_Sebastian_Lab8.Data
{
    public class Ionut_Sebastian_Lab8Context : DbContext
    {
        public Ionut_Sebastian_Lab8Context (DbContextOptions<Ionut_Sebastian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ionut_Sebastian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ionut_Sebastian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ionut_Sebastian_Lab8.Models.Category> Category { get; set; }
    }
}
