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
        [DisallowNull]
        public string ClassId1 { get; set; }
        public string ClassId2 { get; set; }
        public string ClassId3 { get; set; }
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
            ClassId1 = Student.ClassId1;
            ClassId2 = Student.ClassId2;
            ClassId3 = Student.ClassId3;

            return RedirectToPage("/CheckOut/CheckOut_AddStd", new { Username, Password, Name, PhoneNumber, ClassId1, ClassId2, ClassId3 });
        }
    }
}