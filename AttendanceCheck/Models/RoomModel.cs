using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class RoomModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<CourseModel> Courses { get; set; }
    }

}
