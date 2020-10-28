/*  Accept data in an array pass it to static method let this method store cube of each element , modify original array */

using System;

namespace Day6_4
{
    class Program6_4
    {
        static void cube(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i] * arr[i];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter how many elements you want");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            cube(arr);
            Console.WriteLine("Cube of array is");
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

    }
}

