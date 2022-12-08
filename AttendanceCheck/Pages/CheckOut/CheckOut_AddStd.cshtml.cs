using AttendanceCheck.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AttendanceCheck.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AttendanceCheck.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOutModel : PageModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string ClassId1 { get; set; }
        public string ClassId2 { get; set; }
        public string ClassId3 { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckOutModel(ApplicationDbContext context)
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
            Student.ClassId1 = ClassId1;
            Student.ClassId2 = ClassId2;
            Student.ClassId3 = ClassId3;

            _context.Students.Add(Student);
            _context.SaveChanges();
        }
    }
}