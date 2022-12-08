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
        public string Username { get; set; }
        [DisallowNull]
        public string Password { get; set; }
        [DisallowNull]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [DisallowNull]
        public string ClassId1 { get; set; }
        public string ClassId2 { get; set; }
        public string ClassId3 { get; set; }
    }
}
