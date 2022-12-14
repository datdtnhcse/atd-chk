using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_TeacherList
{
    public class DetailsModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DetailsModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
