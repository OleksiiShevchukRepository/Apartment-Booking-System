namespace ApartmentBooking.Repositories.Repositories
{
    public abstract class SqlBaseRepository
    {
        #region Queries

        protected const string spGetPriceList = "spGetPriceList";
        protected const string spGetUserByLogin = "spGetUserByLogin";
        protected const string spGetRoomInformation = "spGetRoomInformation";
        protected const string spGetAllHotelRoomsInformation = "spGetAllHotelRoomsInformation";
        protected const string spGetAvailableRoomsByDate = "spGetAvailableRoomsByDate";
        protected const string spMakeOrder = "spMakeOrder";
        protected const string spExtendOrder = "spExtendOrder";
        protected const string spGetAllBookings = "spGetAllBookings";

        #endregion

        #region Protected Fields

        protected readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlBaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion
    }
}
