using Microsoft.EntityFrameworkCore;

namespace AttendanceCheck.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class StudentCourseModel
    {
        public int StudentId { get; set; } = 0;
        public string CourseId { get; set; } = "NoId";
    }
}
