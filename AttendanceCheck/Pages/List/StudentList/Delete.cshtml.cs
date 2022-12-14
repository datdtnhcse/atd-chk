using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_StudentList
{
    public class DeleteModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DeleteModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public StudentModel StudentModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentmodel = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (studentmodel == null)
            {
                return NotFound();
            }
            else 
            {
                StudentModel = studentmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }
            var studentmodel = await _context.Students.FindAsync(id);

            if (studentmodel != null)
            {
                StudentModel = studentmodel;
                _context.Students.Remove(StudentModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
