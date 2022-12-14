using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AttendanceCheck.Data;
using AttendanceCheck.Models;

namespace AttendanceCheck.Pages_List_RoomClassList
{
    public class EditModel : PageModel
    {
        private readonly AttendanceCheck.Data.ApplicationDbContext _context;

        public EditModel(AttendanceCheck.Data.ApplicationDbContext context)
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

            var roomclassmodel =  await _context.RoomClasses.FirstOrDefaultAsync(m => m.RoomClassId == id);
            if (roomclassmodel == null)
            {
                return NotFound();
            }
            RoomClassModel = roomclassmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }
            */

            _context.Attach(RoomClassModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomClassModelExists(RoomClassModel.RoomClassId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RoomClassModelExists(int id)
        {
          return (_context.RoomClasses?.Any(e => e.RoomClassId == id)).GetValueOrDefault();
        }
    }
}
