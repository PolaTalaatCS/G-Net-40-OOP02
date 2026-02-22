using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP02
{
    #region part 2 question 3 
    public class Cinema
    {
        private Movieticket[] tickets = new Movieticket[20];
        public Movieticket this[int index]
        {
            get
            {
                if (index < 0 || index >= tickets.Length)
                {
                    return null;
                }
                return tickets[index];
            }
            set
            {
                if (index < 0 || index >= tickets.Length) { 
                return; }
                tickets[index] = value;
            }
        }
        public bool AddTicket(Movieticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        #endregion

    }
}
