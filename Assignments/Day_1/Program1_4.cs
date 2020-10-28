/*  create a class demomaths having method Square , cube which will take float value and return square and cube of a number*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class DemoMaths 
    {   

        public float sqr(float num)
        {
            return (num * num);
        }
        public float cube(float num)
        {
            return (num * num *num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoMaths d = new DemoMaths();
            Console.WriteLine("Enter float numbers to get Square & cube");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine("Square is {0}",d.sqr(num));
            Console.WriteLine("Cube is {0}",d.cube(num));
        }
    }
}
