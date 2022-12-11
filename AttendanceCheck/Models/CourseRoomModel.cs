using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceCheck.Models
{
    [Keyless]
    public class CourseRoomModel
    {
        public string? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseModel CourseModel { get; set; }

        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual RoomModel RoomModel { get; set; }
    }
}
