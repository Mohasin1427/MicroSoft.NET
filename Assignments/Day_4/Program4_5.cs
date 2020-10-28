/* Create a class calculator having  static method square, cube, absolute, floor,ceil
 * who’s job is to 
 * find square, cube, absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class Calculator
    { 
        public static int square(int num)
        {
            return num * num;
        }
        public static int cube(int num)
        {
            return num * num *num;
        }
        public static int Ceil(double num)
        {
            int i=(int)num;
            return i;
        }
         public static int Floor(double num)
        {
            int i = (int)num;
            double sub = num - i;
            double sum = num + (1-sub);
            return (int)(sum);
        }    
    }
    class Program4_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceil of 3.6= "+Calculator.Ceil(3.6));
            Console.WriteLine("Floor of 3.6= "+Calculator.Floor(3.6));
            Console.WriteLine("square of 5= "+Calculator.square(5));
            Console.WriteLine("Cube of 5= "+Calculator.cube(5)); 
        }
    }
}
