using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Pages.Forms
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public StudentModel Student { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Id = 1;
            Username = Student.Username;   
            Password = Student.Password;
            Name = Student.Name;
            PhoneNumber = Student.PhoneNumber;

            return RedirectToPage("/CheckOut/CheckOut_AddStd", new { Username, Password, Name, PhoneNumber });
        }
    }
}