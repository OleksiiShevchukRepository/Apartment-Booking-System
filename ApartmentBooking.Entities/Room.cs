
namespace ApartmentBooking.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public string Number { get; set; }
        public int PlacesCount { get; set; }
        public decimal Rate { get; set; }

    }
}
