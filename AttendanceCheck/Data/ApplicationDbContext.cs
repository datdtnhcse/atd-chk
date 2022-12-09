﻿using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Models;
using System.Collections.Generic;

namespace AttendanceCheck.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<StudentCourseModel> StudentCourses { get; set; }
        public DbSet<TeacherCourseModel> TeacherCourses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}