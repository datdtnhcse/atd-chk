using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_RoomClassList
{
    public class DeleteModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public DeleteModel(AttendanceCheck.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public RoomClassModel RoomClassModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RoomClasses == null)
            {
                return NotFound();
            }

            var roomclassmodel = await _context.RoomClasses.FirstOrDefaultAsync(m => m.RoomClassId == id);

            if (roomclassmodel == null)
            {
                return NotFound();
            }
            else 
            {
                RoomClassModel = roomclassmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.RoomClasses == null)
            {
                return NotFound();
            }
            var roomclassmodel = await _context.RoomClasses.FindAsync(id);

            if (roomclassmodel != null)
            {
                RoomClassModel = roomclassmodel;
                _context.RoomClasses.Remove(RoomClassModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
