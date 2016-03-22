using System;
using ApartmentBooking.Entities;

namespace ApartmentBooking.UI.Code
{
    public class CurrentUser
    {
        #region Private Fields

        private static User _currentUser;

        #endregion

        #region Construtors

        public static void Initialize(User user)
        {
            if (_currentUser != null)
            {
                throw new InvalidOperationException("This user has already logged in");
            }
            _currentUser = user;
        }

        #endregion

        #region Properties

        public static string Login
        {
            get { return _currentUser.Login; }
        }
        public static string FirstName
        {
            get { return _currentUser.FirstName; }
        }
        public static string SecondName
        {
            get { return _currentUser.SecondName; }
        }

        #endregion
    }
}
