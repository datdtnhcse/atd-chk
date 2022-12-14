using AttendanceCheck.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AttendanceCheck.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOut_AddStdModel : PageModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckOut_AddStdModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            StudentModel Student = new StudentModel();
            Student.Id = Id;
            Student.Username = Username;
            Student.Password = Password;
            Student.Name = Name;
            Student.PhoneNumber = Phonenumber;

            _context.Students.Add(Student);
            _context.SaveChanges();
        }
    }
}