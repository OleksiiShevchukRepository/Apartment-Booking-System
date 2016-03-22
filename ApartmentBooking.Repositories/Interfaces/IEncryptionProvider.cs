
namespace ApartmentBooking.Repositories.Interfaces
{
    public interface IEncryptionProvider
    {
        string EncryptPassword(string password);
    }
}
