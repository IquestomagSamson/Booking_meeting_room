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
    public class DetailsModel : PageModel
    {
        private readonly BookingRoom.Data.BookingContext _context;

        public DetailsModel(BookingRoom.Data.BookingContext context)
        {
            _context = context;
        }

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
    }
}
