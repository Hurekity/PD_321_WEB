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
    public class DeleteModel : PageModel
    {
        private readonly BlazorPD_321.Data.BlazorPD_321Context _context;

        public DeleteModel(BlazorPD_321.Data.BlazorPD_321Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Teacher Teacher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.Id == id);

            if (teacher == null)
            {
                return NotFound();
            }
            else 
            {
                Teacher = teacher;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }
            var teacher = await _context.Teacher.FindAsync(id);

            if (teacher != null)
            {
                Teacher = teacher;
                _context.Teacher.Remove(Teacher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
