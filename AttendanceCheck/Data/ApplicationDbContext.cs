using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Models;
using System.Collections.Generic;

namespace AttendanceCheck.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<AdminModel> Admins { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}