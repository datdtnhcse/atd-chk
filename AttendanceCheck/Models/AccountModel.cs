using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AttendanceCheck.Models
{
    public class AccountModel
    {
        [DisallowNull, Key]
        public string  Username { get; set; }
        [DisallowNull]
        public string Password { get; set; }
        [DisallowNull]
        public string Id { get; set; }
    }
}
