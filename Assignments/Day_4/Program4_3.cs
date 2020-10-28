/* . Create a class customer having member Id, name, billamount. 
 * When you create a object allow to have default vale.
 * Print default value of id,name, billamount.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_3
{
    public class Customer
    {
        public int id;
        public string name;
        public double billamount;
    }
    class Program4_3
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            Console.WriteLine( "Default value of id={0} name={1} Billamount={2}",c.id,c.name,c.billamount);
        }
    }
}
