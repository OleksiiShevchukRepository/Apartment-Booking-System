using System;

namespace ApartmentBooking.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public decimal Cost { get; set; }


    }
}
