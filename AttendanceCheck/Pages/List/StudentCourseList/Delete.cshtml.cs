using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_StudentCourseList
{
    public class DeleteModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DeleteModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public StudentCourseModel StudentCourseModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StudentCourses == null)
            {
                return NotFound();
            }

            var studentcoursemodel = await _context.StudentCourses.FirstOrDefaultAsync(m => m.StudentId == id);

            if (studentcoursemodel == null)
            {
                return NotFound();
            }
            else 
            {
                StudentCourseModel = studentcoursemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.StudentCourses == null)
            {
                return NotFound();
            }
            var studentcoursemodel = await _context.StudentCourses.FindAsync(id);

            if (studentcoursemodel != null)
            {
                StudentCourseModel = studentcoursemodel;
                _context.StudentCourses.Remove(StudentCourseModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
