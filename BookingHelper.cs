using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP02
{
    #region part 2 question 4
    public static class BookingHelper
    {
        private static int counter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets >= 5)
            {
                double discountprice = pricePerTicket * numberOfTickets - (pricePerTicket * numberOfTickets) * 0.1;
                return discountprice;
            }
            else
            {
                return pricePerTicket * numberOfTickets;
            }
        }

        public static string GenerateBookingReference()
        {
            counter++;
            return "BK-" + counter;
        }
        #endregion
    }
}