using ApartmentBooking.Entities;
using ApartmentBooking.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentBooking.Repositories.Repositories
{
    public class SqlBookingRepository : SqlBaseRepository, IBookingRepository
    {
        #region Constructors
        public SqlBookingRepository(string connectionString) : base(connectionString)
        { }

        #endregion

        #region Methods

        public int MakeOrder(string firstName, string secondName, string roomNumber, DateTime dateIn, DateTime dateOut)
        {
            if (firstName != null || secondName != null
                || roomNumber != null || dateIn != null || dateOut != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spMakeOrder;
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@secondName", secondName);
                        command.Parameters.AddWithValue("@roomNumber", roomNumber);
                        command.Parameters.AddWithValue("@dateIn", dateIn);
                        command.Parameters.AddWithValue("@dateOut", dateOut);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Some arguments equal null");
            }

        }
        public int ExtendOrder(string roomNumber, DateTime newDateOut, string guestFirstName, string guestSecondName)
        {
            if (roomNumber != null || newDateOut != null
                || guestFirstName != null || guestSecondName != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spExtendOrder;
                        command.Parameters.AddWithValue("@roomNumber", roomNumber);
                        command.Parameters.AddWithValue("@newDateOut", newDateOut);
                        command.Parameters.AddWithValue("@guestName", guestFirstName);
                        command.Parameters.AddWithValue("@guestSurname", guestSecondName);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Some arguments equal null");
            }
        }
        public IEnumerable<Booking> GetAllBookings()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAllBookings;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Booking> bookingCollection = new List<Booking>();
                        while (reader.Read())
                        {
                            bookingCollection.Add(new Booking()
                            {
                                Guest = new Guest()
                                {
                                    FirstName = reader["FirstName"].ToString(),
                                    SecondName = reader["SecondName"].ToString()
                                },
                                Room = new Room()
                                {
                                    Number = reader["Number"].ToString()
                                },
                                DateIn = (DateTime)reader["DateIn"],
                                DateOut = (DateTime)reader["DateOut"],
                                Cost = (decimal)reader["Cost"]
                            });
                        }

                        return bookingCollection;

                    }
                }
            }
        }

        #endregion
    }
}