/*  Declare a variable of a type float and print square of it after storing it in to a variable.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Float number for Square");
            float num1 = float.Parse(Console.ReadLine());
            float Square = (num1 * num1);
            Console.WriteLine("Square is {0}", Square);
        }
    }
}
