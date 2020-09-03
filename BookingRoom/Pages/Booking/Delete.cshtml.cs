using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Booking.Models.Entities;
using BookingRoom.Data;

namespace BookingRoom.Pages.Booking
{
    public class DeleteModel : PageModel
    {
        private readonly BookingRoom.Data.BookingContext _context;

        public DeleteModel(BookingRoom.Data.BookingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bookings Bookings { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bookings = await _context.Bookings.FirstOrDefaultAsync(m => m.Booking_id == id);

            if (Bookings == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bookings = await _context.Bookings.FindAsync(id);

            if (Bookings != null)
            {
                _context.Bookings.Remove(Bookings);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
