using System.Collections.Generic;
using ApartmentBooking.Entities;
using System.Data.SqlClient;
using System.Data;
using ApartmentBooking.Repositories.Interfaces;

namespace ApartmentBooking.Repositories.Repositories
{
    public class SqlPriceListRepository : SqlBaseRepository, IPriceListRepository
    {
        #region Constructors
        public SqlPriceListRepository(string connectionString) : base(connectionString)
        {

        }
        #endregion

        #region Methods
        public IEnumerable<PriceList> GetPriceList()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetPriceList;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<PriceList> priceListCollection = new List<PriceList>();
                        while (reader.Read())
                        {
                            priceListCollection.Add(new PriceList()
                            {
                                TypeOfRoom = reader["TypeOfRoom"].ToString(),
                                Rate = (decimal)reader["Rate"],
                                PlacesCount = (int)reader["PlacesCount"]
                            });
                        }

                        return priceListCollection;
                    }
                }

            }
        }
        #endregion
    }
}
