using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cwiczenia10.Models;

namespace Cwiczenia10.Data
{
    public class Cwiczenia10Context : DbContext
    {
        public Cwiczenia10Context (DbContextOptions<Cwiczenia10Context> options)
            : base(options)
        {
        }

        public DbSet<Cwiczenia10.Models.Movie> Movie { get; set; }
    }
}
