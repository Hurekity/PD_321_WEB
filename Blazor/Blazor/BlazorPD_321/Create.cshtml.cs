using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlazorPD_321.Data;
using BlazorPD_321.Models;

namespace BlazorPD_321
{
    public class CreateModel : PageModel
    {
        private readonly BlazorPD_321.Data.BlazorPD_321Context _context;

        public CreateModel(BlazorPD_321.Data.BlazorPD_321Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Teacher == null || Teacher == null)
            {
                return Page();
            }

            _context.Teacher.Add(Teacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
