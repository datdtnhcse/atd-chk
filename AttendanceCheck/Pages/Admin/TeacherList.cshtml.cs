using AttendanceCheck.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages
{
    public class TeacherListModel : PageModel
    {
        public List<TeacherModel> Teachers = new List<TeacherModel>();

        private readonly ApplicationDbContext _context;
        public TeacherListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Teachers = _context.Teachers.ToList();
        }
    }
}