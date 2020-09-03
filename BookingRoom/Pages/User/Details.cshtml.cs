using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Booking.Models.Entities;
using BookingRoom.Data;

namespace BookingRoom.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly BookingRoom.Data.UserContext _context;

        public DetailsModel(BookingRoom.Data.UserContext context)
        {
            _context = context;
        }

        public Users Users { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Users = await _context.Users.FirstOrDefaultAsync(m => m.User_id == id);

            if (Users == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
