/*  a. factorial of a number
	b.  square of a number
    c.  cube of a number.
Solve the above code using lambda */

using System;

namespace Day12_2
{
    delegate void MyCal(int num);
    class Program
    {
        
        static void Main(string[] args)
        {
            MyCal cal =(n)=>
                            {
                                int f = 1;
                                for (int i = n; i >= 1; i--)
                                    f *= i;
                                Console.WriteLine("Factorial = " + f);
                            
                            };
            cal += n =>
                {
                    Console.WriteLine("Square = " + n * n);
                };

            cal += n =>
                {
                    Console.WriteLine("Cube = " + n * n *n );
                };

             Console.WriteLine("Enter the number ");
             int num1=int.Parse(Console.ReadLine());
          //  Console.WriteLine(" Factorial = {0} \n Square = {1} \n Cube = {2}", fact(n), Square(n), Cube(n));

             foreach (MyCal m in cal.GetInvocationList())
             {
                 Console.Write(m.Method + "    " );
                 m.Invoke(num1);
             }

        }
    }
}
