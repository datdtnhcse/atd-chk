using AttendanceCheck.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AttendanceCheck.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOut_AddTeacherModel : PageModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckOut_AddTeacherModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            TeacherModel Teacher = new TeacherModel();
            Teacher.Id = Id;
            Teacher.Username = Username;
            Teacher.Password = Password;
            Teacher.Name = Name;
            Teacher.PhoneNumber = Phonenumber;

            _context.Teachers.Add(Teacher);
            _context.SaveChanges();
        }
    }
}