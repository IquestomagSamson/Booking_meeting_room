using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Models;

namespace BookingRoom.Data
{
    public class RoomContext : DbContext
    {
        public RoomContext (DbContextOptions<RoomContext> options)
            : base(options)
        {
        }

        public DbSet<Booking.Models.Rooms> Rooms { get; set; }
    }
}
