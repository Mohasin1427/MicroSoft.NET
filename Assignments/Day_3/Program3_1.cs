using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_1
{
    struct struct3_1
    {
        public static int Square(int num)
        {
            return num * num;
        }
        public static int Cube(int num)
        {
            return num * num *num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to calulate Square & Cube");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Square is {0}", struct3_1.Square(n));
            Console.WriteLine("Cube is {0}", struct3_1.Cube(n));
        }
    }
}
