using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_StudentCourseList
{
    public class EditModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public EditModel(AttendanceCheck.Data.ApplicationDbContext context)
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

            var studentcoursemodel =  await _context.StudentCourses.FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentcoursemodel == null)
            {
                return NotFound();
            }
            StudentCourseModel = studentcoursemodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentCourseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentCourseModelExists(StudentCourseModel.StudentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentCourseModelExists(int id)
        {
          return (_context.StudentCourses?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}
