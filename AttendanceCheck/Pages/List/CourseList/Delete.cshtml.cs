using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_CourseList
{
    public class DeleteModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DeleteModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CourseModel CourseModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var coursemodel = await _context.Courses.FirstOrDefaultAsync(m => m.Id == id);

            if (coursemodel == null)
            {
                return NotFound();
            }
            else 
            {
                CourseModel = coursemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            var coursemodel = await _context.Courses.FindAsync(id);

            if (coursemodel != null)
            {
                CourseModel = coursemodel;
                _context.Courses.Remove(CourseModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
