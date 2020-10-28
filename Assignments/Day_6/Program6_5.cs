/* Accept data in an array and print average. */

using System;

namespace Day6_5
{
    class Program6_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many elements you want");
            int num, sum = 0;
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("average is " + sum / num);
        }
    }
}
