using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    public class ClassModel
    {
        [Key]
        public int ClassId { get; set; }
        public Day Day { get; set; } = Day.Monday;
        public int Start { get; set; } = 1;
        public int End { get; set; } = 5;
        public virtual CourseModel Courses { get; set; }
    }
}

