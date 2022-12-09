using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    [PrimaryKey(nameof(TeacherId), nameof(CourseId))]
    public class TeacherCourseModel
    {
        public int TeacherId { get; set; } = 0;
        public string CourseId { get; set; } = "NoId";
    }
}
