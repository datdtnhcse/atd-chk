using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class AdminModel
    {
        [DisallowNull, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = "0";
        [DisallowNull]
        public string Username { get; set; } = "NoUsername";
        [DisallowNull]
        public string Password { get; set; } = "NoPassword";

    }
}
