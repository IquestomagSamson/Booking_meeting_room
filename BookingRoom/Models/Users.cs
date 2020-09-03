using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Entities
{
    [Table("Room")]
    public class Users
    {
        [Key]
        [StringLength(10)]
        public string User_id { get; set; }

        [Required]
        [StringLength(50)]
        public string User_name { get; set; }


    }
}
