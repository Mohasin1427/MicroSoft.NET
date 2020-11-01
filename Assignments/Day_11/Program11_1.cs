/* create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
    c.  cube of a number.
Using delegate  call this method.
 */

using System;

namespace Day11_1
{
    delegate int Mymath(int n);
   public class MyCalci
    {
        public static int factorial(int num)
        {
            int fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static int Square(int num)
        {    return (num * num);  }

        public static int Cube(int num)
        {   return (num * num * num);    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // By Delegate (single)
            Mymath find = new Mymath(MyCalci.Square);
            Mymath find1 = MyCalci.factorial;
            Mymath find2 = MyCalci.Cube;
            Console.WriteLine("Square of {0} is {1}",5,find(5) );
            Console.WriteLine("factorial of {0} is {1}", 5, find1(5));
            Console.WriteLine("Cube of {0} is {1}", 5, find2(5));

            //By MulticastDelegate
            //Mymath find = new Mymath(MyCalci.Square);
            //find += new Mymath(MyCalci.factorial);
            //find += new Mymath(MyCalci.Cube);

            //foreach (Mymath m in find.GetInvocationList())
            //{
            //    Console.WriteLine(m.Method + "    " + m.Invoke(5));
            //}
        }
    }
}
