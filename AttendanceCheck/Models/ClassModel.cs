using Microsoft.EntityFrameworkCore;

namespace AttendanceCheck.Models
{

    public enum Day { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    [Keyless]
    public class ClassModel
    {
        
        public Day? Day { get; set; } 
        public int Start { get; set; } = 1;
        public int End { get; set; } = 5; 
    }
}
