/*   Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.*/

using System;

namespace Day3_2
{

    struct calculator
    {
        public static void factor(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }  
            }
        }
    }
    class Program3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to find factors ");
            int n = int.Parse(Console.ReadLine());
            calculator.factor(n);
            Console.ReadLine();
        }
    }
}
