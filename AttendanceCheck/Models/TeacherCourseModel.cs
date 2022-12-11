using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    [Keyless]
    public class TeacherCourseModel
    {
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual TeacherModel TeacherModel { get; set; }


        public string? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseModel CourseModel { get; set; }
    }
}
