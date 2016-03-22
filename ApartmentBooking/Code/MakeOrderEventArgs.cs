using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBooking
{
    public class MakeOrderEventArgs
    {
        private readonly string _firstName;
        private readonly string _secondName;
        private readonly string _roomNumber;
        private readonly DateTime _dateIn;
        private readonly DateTime _dateOut;

        public MakeOrderEventArgs(string firstName, string secondName, string roomNumber, DateTime dateIn, DateTime dateOut)
        {
            _firstName = firstName;
            _secondName = secondName;
            _roomNumber = roomNumber;
            _dateIn = dateIn;
            _dateOut = dateOut;
        }

        public string FirstName
        {
            get { return _firstName; }
        }
        public string SecondName
        {
            get { return _secondName; }
        }
        public string RoomNumber
        {
            get { return _roomNumber; }
        }
        public DateTime DateIn
        {
            get { return _dateIn; }
        }
        public DateTime DateOut
        {
            get { return _dateOut; }
        }

    }
}
