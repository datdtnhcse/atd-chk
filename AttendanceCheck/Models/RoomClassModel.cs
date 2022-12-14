using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public enum Day { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class RoomClassModel
    {
        [Key]
        public int RoomClassId { get; set; } // Useless
        public Day Day { get; set; } = Day.Monday;
        public int Start { get; set; } = 1;
        public int End { get; set; } = 5;
        public int Room { get; set; }
        public virtual ICollection<CourseModel> Courses { get; set; }

    }
}

