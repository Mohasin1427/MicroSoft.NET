/* . Create a class having instance member salary. Create a object of a class. Print data type of reference of a class also print parent class name.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_6
{
    class Myclass
    {
        double salary;
    }
    class Program3_6
    {
        
        static void Main(string[] args)
        {
            Myclass m1 = new Myclass();
            Console.WriteLine("Data Type is " + m1.GetType());
            Console.WriteLine("Parent class is " + m1.GetType().BaseType);
        }
    }
}
