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
        public string Username { get; set; } = "NoUsername";
        public string Password { get; set; } = "12345";
        public string Name { get; set; } = "NoName";
        public string PhoneNumber { get; set; } = "0000";
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