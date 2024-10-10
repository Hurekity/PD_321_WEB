using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorPD_321.Data;
using BlazorPD_321.Models;

namespace BlazorPD_321
{
    public class IndexModel : PageModel
    {
        private readonly BlazorPD_321.Data.BlazorPD_321Context _context;

        public IndexModel(BlazorPD_321.Data.BlazorPD_321Context context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Teacher != null)
            {
                Teacher = await _context.Teacher.ToListAsync();
            }
        }
    }
}
