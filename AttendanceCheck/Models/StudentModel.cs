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
        [DisallowNull]
        public string Username { get; set; } = "NoUsername";
        [DisallowNull]
        public string Password { get; set; } = "NoPassword";
        [DisallowNull]
        public string Name { get; set; } = "Anonymous";
        public string PhoneNumber { get; set; } = "NoPhone";
    }
}
