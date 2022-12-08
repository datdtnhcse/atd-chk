using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class AdminModel
    {
        [DisallowNull, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [DisallowNull]
        public string Username { get; set; }
        [DisallowNull]
        public string Password { get; set; }

    }
}
