 /* Create a interface Itaxtogov with method void paytax(double amt) 
  * create a class myindia, myeurope let this class implement this interface.
  * In class myindia  paytax method will print tax amount which is 40% of the data passed in method.
  * In class myeurope  paytax method will print tax amount which is 30% of the data passed in method. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_5
{
    interface Itaxtogov
    {
        void paytax(double amt);
    }
    class MyIndia : Itaxtogov
    {
        public void paytax(double amt)
        {
            double MyTax = amt - (amt * 0.4);
            Console.WriteLine("In India Paying tax=" + MyTax);
        }
    }

    class MyEurope : Itaxtogov
    {
        public void paytax(double amt)
        {
            double MyTax = amt - (amt * 0.3);
            Console.WriteLine("In Europe Paying tax=" + MyTax);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Itaxtogov t1 = new MyEurope();
            t1.paytax(10000);

            Itaxtogov t2 = new MyIndia();
            t2.paytax(10000);
        }
    }
}
