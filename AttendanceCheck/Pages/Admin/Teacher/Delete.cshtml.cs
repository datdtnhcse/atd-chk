using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_Admin_Student
{
    public class DeleteModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DeleteModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TeacherModel TeacherModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }

            var teachermodel = await _context.Teachers.FirstOrDefaultAsync(m => m.Id == id);

            if (teachermodel == null)
            {
                return NotFound();
            }
            else 
            {
                TeacherModel = teachermodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }
            var teachermodel = await _context.Teachers.FindAsync(id);

            if (teachermodel != null)
            {
                TeacherModel = teachermodel;
                _context.Teachers.Remove(TeacherModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
