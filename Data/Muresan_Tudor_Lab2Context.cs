using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Tudor_Lab2.Models;

namespace Muresan_Tudor_Lab2.Data
{
    public class Muresan_Tudor_Lab2Context : DbContext
    {
        public Muresan_Tudor_Lab2Context (DbContextOptions<Muresan_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Tudor_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Muresan_Tudor_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
