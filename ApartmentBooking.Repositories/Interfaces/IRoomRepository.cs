using System;
using System.Collections.Generic;
using ApartmentBooking.Entities;

namespace ApartmentBooking.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();
        Room GetRoomInformation(string roomNumber);
        IEnumerable<Room> GetAvailableRoomsByDate(DateTime date);
    }
}
