using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookTheShowEntity
{
    public class Booking
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BookingId { get; set; }

        [ForeignKey("userv")]
        public int UservId { get; set; }
        public Userv userv { get; set; }


        [ForeignKey("showTimev")]
        public int showId { get; set; }
        public ShowTimev showTimev{ get; set; }

        public int BookingQuantity { get; set; }






    }
}
