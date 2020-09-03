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
    public class IndexModel : PageModel
    {
        private readonly BookingRoom.Data.BookingContext _context;

        public IndexModel(BookingRoom.Data.BookingContext context)
        {
            _context = context;
        }

        public IList<Bookings> Bookings { get;set; }

        public async Task OnGetAsync()
        {
            Bookings = await _context.Bookings.ToListAsync();
        }
    }
}
