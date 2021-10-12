using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesSchool.Data
{
    public class RazorPagesSchoolContext : DbContext
    {
        public RazorPagesSchoolContext (DbContextOptions<RazorPagesSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.School> School { get; set; }
    }
}
