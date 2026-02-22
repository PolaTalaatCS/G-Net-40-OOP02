using System.ComponentModel;
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
            //a) anyone can change the data directly and there is no validation or control over how the data is modified
            //b) make attributes private and use properties(get/set) to control access and add validation
            //c) because they break encapsulation so any code can change the data freely that make the program unsafe and harder to control and harder to maintain
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
        }
    }
}
