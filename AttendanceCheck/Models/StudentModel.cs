using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class StudentModel  
    {

        [DisallowNull, Key]
        public string Id { get; set; }
        [DisallowNull]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        [DisallowNull]
        public string ClassId1 { get; set; }
        public string ClassId2 { get; set; }
        public string ClassId3 { get; set; }
    }
}
