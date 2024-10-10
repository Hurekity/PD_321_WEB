using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorPD_321.Models;

namespace BlazorPD_321.Data
{
    public class BlazorPD_321Context : DbContext
    {
        public BlazorPD_321Context (DbContextOptions<BlazorPD_321Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorPD_321.Models.Teacher> Teacher { get; set; } = default!;
    }
}
