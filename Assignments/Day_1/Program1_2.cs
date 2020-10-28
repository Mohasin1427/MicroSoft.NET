/* Q2. Declare 2  variable of a type byte and print product of it.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers for multiplication");
            byte num1 = byte.Parse(Console.ReadLine());
            byte num2 = byte.Parse(Console.ReadLine());
            int prod = (int)(num1 * num2);
            Console.WriteLine("Product is {0}", prod);
        }
    }
}
