using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models.Entities
{
    [Table("Booking")]
    public class Bookings
    {
        [Key]
        [StringLength(10)]
        public string Booking_id { get; set; }

        [Required]
        public string booking_title { get; set; }

        [Required]
        public DateTime start_time { get; set; }

        [Required]
        public DateTime end_time { get; set; }

        public string participants { get; set; }

        public string note { get; set; }

        [Required]
        [StringLength(10)]
        public string room_id { get; set; }

        [Required]
        [StringLength(10)]
        public string users_id { get; set; }

    }
}
