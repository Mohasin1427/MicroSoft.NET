using System;
using Mylib1;

namespace Day2_Task2_Impl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for sqr & Cube");
            int num =int.Parse(Console.ReadLine());
            Mathclass m1 = new Mathclass();
            Console.WriteLine("Sqr of number ="+ m1.Sqr(num));
            Console.WriteLine("Cube of number =" + m1.Cube(num));
            Console.ReadLine();


        }
    }
}
