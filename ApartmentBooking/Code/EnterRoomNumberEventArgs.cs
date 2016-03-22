using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBooking
{
    public class EnterRoomNumberEventArgs : EventArgs //RoomNumberEventArgs
    {
        private readonly string _roomNumber;
        public EnterRoomNumberEventArgs(string roomNumber)
        {
            _roomNumber = roomNumber;
        }
        public string RoomNumber
        {
            get { return _roomNumber; }
        }


    }
}
