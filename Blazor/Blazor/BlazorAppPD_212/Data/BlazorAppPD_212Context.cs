using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorPD_321.Models;

namespace BlazorAppPD_212.Data
{
    public class BlazorAppPD_212Context : DbContext
    {
        public BlazorAppPD_212Context (DbContextOptions<BlazorAppPD_212Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorPD_321.Models.Teacher> Teachers { get; set; } = default!;
    }
}
