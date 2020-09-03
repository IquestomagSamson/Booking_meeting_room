using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    [Table("Room")]
    public class Rooms
    {
        [Key]
        [StringLength(10)]
        public string room_id { get; set; }

        [Required]
        [StringLength(50)]
        public string room_name { get; set; }

        public int capacity { get; set; }
    }
}
