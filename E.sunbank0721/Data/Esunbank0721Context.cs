using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E.sunbank0721.Models;

namespace E.sunbank0721.Data
{
    public class Esunbank0721Context : DbContext
    {
        public Esunbank0721Context (DbContextOptions<Esunbank0721Context> options)
            : base(options)
        {
        }

        public DbSet<E.sunbank0721.Models.Product> Product { get; set; } = default!;

        public DbSet<E.sunbank0721.Models.Order>? Order { get; set; }
    }
}
