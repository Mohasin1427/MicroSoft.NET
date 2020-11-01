/* create  a  class having instance  method to find
	a.  factorial of a number
	b.  square of a number
    c.  cube of a number.
Using delegate  call this method.
 */

using System;


namespace Day11_2
{
    delegate int Mymath(int n);
    public class MyCalci
    {
        public int factorial(int num)
        {
            int fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        public int Square(int num)
        { return (num * num); }

        public int Cube(int num)
        { return (num * num * num); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCalci cal = new MyCalci();

            // By Delegate (single)
            //
            //Mymath find = new Mymath(cal.Square);
            //Mymath find1 = cal.factorial;
            //Mymath find2 = cal.Cube;
            //Console.WriteLine("Square of {0} is {1}", 5, find(5));
            //Console.WriteLine("factorial of {0} is {1}", 5, find1(5));
            //Console.WriteLine("Cube of {0} is {1}", 5, find2(5));

            //By MulticastDelegate
            Mymath find = new Mymath(cal.Square);
            find += new Mymath(cal.factorial);
            find += new Mymath(cal.Cube);

            foreach (Mymath m in find.GetInvocationList())
            {
                Console.WriteLine(m.Method + "    " + m.Invoke(5));
            }
        }
    }
}
