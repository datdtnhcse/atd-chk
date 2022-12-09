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
    public class IndexModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public IndexModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StudentModel> StudentModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                StudentModel = await _context.Students.ToListAsync();
            }
        }
    }
}
