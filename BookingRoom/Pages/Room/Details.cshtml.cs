using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Booking.Models;
using BookingRoom.Data;

namespace BookingRoom.Pages.Room
{
    public class DetailsModel : PageModel
    {
        private readonly BookingRoom.Data.RoomContext _context;

        public DetailsModel(BookingRoom.Data.RoomContext context)
        {
            _context = context;
        }

        public Rooms Rooms { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rooms = await _context.Rooms.FirstOrDefaultAsync(m => m.room_id == id);

            if (Rooms == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
