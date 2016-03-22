using ApartmentBooking.Entities;
using ApartmentBooking.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentBooking.Repositories.Repositories
{
    public class SqlUserRepository : SqlBaseRepository, IUserRepository
    {
        #region Constructors

        public SqlUserRepository(string connectionString) : base(connectionString)
        {

        }

        #endregion

        #region Methods

        public User GetUserByLogin(string login, string password)
        {
            if (login != null)
            {
                EncryptionProvider encryptor = new EncryptionProvider();
                string encryptedPassword = encryptor.EncryptPassword(password);

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spGetUserByLogin;
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", encryptedPassword);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            User user = null;
                            if (reader.Read())
                            {
                                user = new User()
                                {
                                    Id = (int)reader["Id"],
                                    FirstName = reader["FirstName"].ToString(),
                                    SecondName = reader["SecondName"].ToString(),
                                    Login = reader["Login"].ToString(),
                                    Disabled = (bool)reader["Disabled"]
                                };
                            }

                            return user;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Some parameters equal null");
            }
        }

        #endregion
    }
}
