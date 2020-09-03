using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking.Models.Entities;
using BookingRoom.Data;

namespace BookingRoom.Pages.Booking
{
    public class EditModel : PageModel
    {
        private readonly BookingRoom.Data.BookingContext _context;

        public EditModel(BookingRoom.Data.BookingContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bookings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingsExists(Bookings.Booking_id))
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

        private bool BookingsExists(string id)
        {
            return _context.Bookings.Any(e => e.Booking_id == id);
        }
    }
}
