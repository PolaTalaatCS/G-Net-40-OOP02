using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
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
}
    }
}
