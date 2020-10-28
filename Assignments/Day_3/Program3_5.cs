/* Accept a number from user and display its type and parent class */

using System;


namespace Day3_5
{
    class Program3_5
    {
        static void Main(string[] args)
        {
            int i = 50;
            Console.WriteLine("Type is " + i.GetType());
            Console.WriteLine("Parent is "+ i.GetType().BaseType);
            Console.ReadLine();
        }
    }
}
