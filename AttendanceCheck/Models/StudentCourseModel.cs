﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    [Keyless]
    public class StudentCourseModel
    {
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual StudentModel StudentModel { get; set; }

        public string? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseModel CourseModel { get; set; }
    }
}
