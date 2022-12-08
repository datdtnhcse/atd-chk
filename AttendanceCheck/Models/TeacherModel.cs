using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class TeacherModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = "usr";
        public string Password { get; set; } = "pwd";
        public string Name { get; set; } = "Anonymous";
        public string PhoneNumber { get; set; } = "0000000000";
        
    }
}
