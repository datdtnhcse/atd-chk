using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    [Keyless]
    public class CourseClassModel
    {
        public string? CourseId { get; set; } 
        [ForeignKey("CourseId")]
        public virtual CourseModel CourseModel { get; set; }

        [NotMapped]
        public ClassModel? Class { get; set; }
    }
}
