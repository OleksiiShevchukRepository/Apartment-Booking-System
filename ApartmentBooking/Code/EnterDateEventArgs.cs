using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBooking
{
    public class EnterDateEventArgs : EventArgs // DateEventArgs
    {
        private readonly DateTime _date;

        public EnterDateEventArgs(DateTime date)
        {
            _date = date;
        }
        public DateTime Date
        {
            get { return _date; }
        }

    }
}
