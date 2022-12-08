using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class StudyhModel
    {
        public int StudentId { get; set; } = 0;
        public string Course { get; set; } = "";
    }
}
