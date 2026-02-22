using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP02
{
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }
   public struct Seat
    {
        public char Row;
        public int Number;

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }
    }
}
