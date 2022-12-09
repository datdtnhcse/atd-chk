using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_StudentCourseList
{
    public class CreateModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public CreateModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StudentCourseModel StudentCourseModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.StudentCourses == null || StudentCourseModel == null)
            {
                return Page();
            }

            _context.StudentCourses.Add(StudentCourseModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
