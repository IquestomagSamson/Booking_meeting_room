using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Booking.Models;
using BookingRoom.Data;

namespace BookingRoom.Pages.Room
{
    public class CreateModel : PageModel
    {
        private readonly BookingRoom.Data.RoomContext _context;

        public CreateModel(BookingRoom.Data.RoomContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rooms Rooms { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rooms.Add(Rooms);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}