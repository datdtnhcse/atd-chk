using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class CourseModel
    {
        [Key]
        public string Id { get; set; } = "NoId";
        [DisallowNull]
        public string Name { get; set; }
        public virtual ICollection<ClassModel> Classes { get; set; }
        public virtual ICollection<RoomModel> Rooms { get; set; }
        public virtual ICollection<StudentModel> Students { get; set; }
        public virtual ICollection<TeacherModel> Teachers { get; set; }

    }
}
