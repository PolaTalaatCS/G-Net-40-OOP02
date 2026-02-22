using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_Net_40_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 (therotical)
           //a) anyone can change the data directly and there are no validation or control over how the data is modified
           //b) make attributes private and use properties(get/set) to control access and add validations
         //c) because they break encapsulation so any code can change the data freely that make the programs unsafe and harder to control and harder to maintain
            #endregion
            #region Question 2 (therotical)
            // field  direct data storage and no validation but property controlled access and can validate , yes can contain logic
            // Example
            //class rectangle {
            //private double width;
            //private double height;
            //public Rectangle(double w, double h)
            //    {
            //        width = w;
            //        height = h;
            //        }
            // public double Area
            // {
            // get { return width * height; }  
            //
            //}
            #endregion
            #region Question 3 (therotical)
            //a)it is called an indexer it make you use the object like an array with[]
            //b) it throws an error(out of range) To make it safer check the index before using it
            //c)yes we can overload indexers
            #endregion
            #region Question 4 (therotical)
            // a)static means it belongs to the clas not each object.TotalOrders is shared but item is different for every object
            //b)no because item belongs to an object and static methods don’t have an object
            #endregion
            #region part 2 question 5
            Cinema cinema = new Cinema();
            for (int i = 1; i < 4; i++)
            {
                Movieticket ticket = new Movieticket();

                Console.Write($"enter data for Ticket {i} \n");

                Console.Write("Movie Name :");
                ticket.Moviename = Console.ReadLine();

                Console.Write("Ticket Type (0= Standard , 1 = VIP , 2 = IMAX) :");
                if (int.TryParse(Console.ReadLine(), out int x) && Enum.IsDefined(typeof(TicketType), x))
                    ticket.Type = (TicketType)x;

                Console.Write("Seat Row[A-Z] :");
                string rowInput = Console.ReadLine();
                char row = 'A';
                if (!string.IsNullOrWhiteSpace(rowInput))
                    row = char.ToUpper(rowInput.Trim()[0]);

                Console.Write("Seat Number :");
                int.TryParse(Console.ReadLine(), out int number);
                ticket.Seat = new Seat(row, number);

                Console.Write("Price : ");
                if (double.TryParse(Console.ReadLine(), out double price))
                    ticket.Price = price;

                cinema.AddTicket(ticket);
            }

            Console.WriteLine("========================All ticket======================\n\n");
            for (int i = 0; i < 20; i++)
            {
                var t = cinema[i];
                if (t == null)
                {
                    continue;
                }

                Console.WriteLine($"Ticket #{i + 1} | {t.Moviename} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax}");
            }
            Console.WriteLine($"==========Search by Movie==========\n\n");
            Console.Write("Enter movie name to search: ");
            string searchMovie = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                var t2 = cinema[i];
                if (searchMovie == t2.Moviename)
                {
                    Console.WriteLine($"Ticket #{i + 1} | {t2.Moviename} | {t2.Type} | Seat: {t2.Seat} | Price: {t2.Price} | After Tax: {t2.PriceAfterTax}");
                }
            }
                #endregion

            }
    }
}