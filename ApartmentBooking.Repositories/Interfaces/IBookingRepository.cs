using ApartmentBooking.Entities;
using System;
using System.Collections.Generic;


namespace ApartmentBooking.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
        int MakeOrder(string firstName, string secondName, string roomNumber, DateTime dateIn, DateTime dateOut);
        int ExtendOrder(string roomNumber, DateTime newDateOut, string guestFirstName, string guestSecondName);
    }
}
