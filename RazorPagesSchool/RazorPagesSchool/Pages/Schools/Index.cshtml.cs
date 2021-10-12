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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSchool.Data.RazorPagesSchoolContext _context;

        public IndexModel(RazorPagesSchool.Data.RazorPagesSchoolContext context)
        {
            _context = context;
        }

        public IList<School> School { get;set; }

        public async Task OnGetAsync()
        {
            School = await _context.School.ToListAsync();
        }
    }
}
