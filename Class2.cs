using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP02
{
    #region part 2 question 1
    internal class Movieticket
    {
        private string moviename;
        private double price;

        public string Moviename
        {
            get { return moviename; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    moviename = value;
            }
        }

        public TicketType Type { get; set; }
        public Seat Seat { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public double PriceAfterTax
        {
            get { return price + (price * 14 / 100); }
        }
    }
    #endregion
}
