
using System.Collections.Generic;

using ApartmentBooking.Entities;

namespace ApartmentBooking.Repositories.Interfaces
{
    public interface IPriceListRepository
    {
        IEnumerable<PriceList> GetPriceList();
    }
}
