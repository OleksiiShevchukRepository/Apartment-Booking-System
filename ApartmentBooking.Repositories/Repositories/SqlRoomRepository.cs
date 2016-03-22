using System;
using System.Collections.Generic;
using ApartmentBooking.Entities;
using System.Data;
using System.Data.SqlClient;
using ApartmentBooking.Repositories.Interfaces;

namespace ApartmentBooking.Repositories.Repositories
{
    public class SqlRoomRepository : SqlBaseRepository, IRoomRepository
    {
        #region Constructors

        public SqlRoomRepository(string connectionString) : base(connectionString)
        { }

        #endregion

        #region Methods

        public Room GetRoomInformation(string roomNumber)
        {
            if (roomNumber != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spGetRoomInformation;
                        command.Parameters.AddWithValue("@roomNumber", roomNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Room room = null;
                            if (reader.Read())
                            {
                                room = new Room()
                                {
                                    Id = (int)reader["Id"],
                                    Number = reader["Number"].ToString(),
                                    PlacesCount = (int)reader["PlacesCount"],
                                    Rate = (decimal)reader["Rate"],
                                    RoomType = new RoomType()
                                    {
                                        Id = (int)reader["Id"],
                                        TypeOfRoom = reader["TypeOfRoom"].ToString(),
                                        RoomCount = (int)reader["RoomCount"]
                                    }
                                };
                            }

                            return room;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Some parameters equal null");
            }
        }

        public IEnumerable<Room> GetAvailableRoomsByDate(DateTime date)
        {
            if (date != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spGetAvailableRoomsByDate;
                        command.Parameters.AddWithValue("@date", date);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Room> roomCollection = new List<Room>();
                            while (reader.Read())
                            {
                                roomCollection.Add(new Room()
                                {
                                    Id = (int)reader["Id"],
                                    Number = reader["Number"].ToString(),
                                    Rate = (decimal)reader["Rate"],
                                    PlacesCount = (int)reader["PlacesCount"],
                                    RoomType = new RoomType()
                                    {
                                        Id = (int)reader["Id"],
                                        TypeOfRoom = reader["TypeOfRoom"].ToString(),
                                        RoomCount = (int)reader["RoomCount"]
                                    }
                                });
                            }

                            return roomCollection;
                        }
                    }

                }
            }
            else
            {
                throw new ArgumentNullException("Some parameters equal null");
            }
            
        }

        public IEnumerable<Room> GetAllRooms()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAllHotelRoomsInformation;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Room> roomCollection = new List<Room>();
                        while (reader.Read())
                        {
                            roomCollection.Add(new Room()
                            {
                                Id = (int)reader["Id"],
                                Number = reader["Number"].ToString(),
                                PlacesCount = (int)reader["PlacesCount"],
                                Rate = (decimal)reader["Rate"],
                                RoomType = new RoomType()
                                {
                                    Id = (int)reader["Id"],
                                    TypeOfRoom = reader["TypeOfRoom"].ToString(),
                                    RoomCount = (int)reader["RoomCount"]
                                }
                            });
                        }

                        return roomCollection;
                    }
                }

            }
        }

        #endregion
    }
}
