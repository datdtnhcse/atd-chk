using AttendanceCheck.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages
{
    public class StudentListModel : PageModel
    {
        public List<StudentModel> Students = new List<StudentModel>();

        private readonly ApplicationDbContext _context;
        public StudentListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Students = _context.Students.ToList();
        }
    }
}