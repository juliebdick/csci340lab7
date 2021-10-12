using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesSchool.Data;

namespace RazorPagesSchool.Pages.Schools
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesSchool.Data.RazorPagesSchoolContext _context;

        public DeleteModel(RazorPagesSchool.Data.RazorPagesSchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public School School { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            School = await _context.School.FirstOrDefaultAsync(m => m.ID == id);

            if (School == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            School = await _context.School.FindAsync(id);

            if (School != null)
            {
                _context.School.Remove(School);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
