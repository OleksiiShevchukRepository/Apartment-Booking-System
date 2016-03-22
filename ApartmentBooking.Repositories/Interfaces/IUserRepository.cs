
using ApartmentBooking.Entities;

namespace ApartmentBooking.Repositories.Interfaces
{
    public interface IUserRepository 
    {
        User GetUserByLogin(string login, string password);   
    }
}
