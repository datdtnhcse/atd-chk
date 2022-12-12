using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class StudentModel 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = "NoUsername";
        public string Password { get; set; } = "NoPassword";
        public string Name { get; set; } = "Anonymous";
        public string PhoneNumber { get; set; } = "NoPhone";
        public virtual ICollection<CourseModel> Courses { get; set; }
    }
}
