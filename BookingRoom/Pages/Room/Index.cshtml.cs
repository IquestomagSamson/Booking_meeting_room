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
    public class IndexModel : PageModel
    {
        private readonly BookingRoom.Data.RoomContext _context;

        public IndexModel(BookingRoom.Data.RoomContext context)
        {
            _context = context;
        }

        public IList<Rooms> Rooms { get;set; }

        public async Task OnGetAsync()
        {
            Rooms = await _context.Rooms.ToListAsync();
        }
    }
}
