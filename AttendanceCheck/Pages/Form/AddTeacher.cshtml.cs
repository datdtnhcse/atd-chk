using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Pages.Forms
{
    public class AddTeacherModel : PageModel
    {
        [BindProperty]
        public TeacherModel Teacher { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Username = Teacher.Username;
            Password = Teacher.Password;
            Name = Teacher.Name;
            PhoneNumber = Teacher.PhoneNumber;

            return RedirectToPage("/CheckOut/CheckOut_AddTeacher", new { Username, Password, Name, PhoneNumber });
        }
    }
}