/* Accept data in 3*3matrix and print row wise sum */

using System;

namespace Day6_2
{
    class Program6_2
    {
        static void Main(string[] args)
        {
            int temp, sum = 0;
            int[,] arr = new int[3,3];
            Console.WriteLine("Enter the 3x3 matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp = int.Parse(Console.ReadLine());
                    arr[i, j] = temp;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    sum += arr[i, j];
                }
                Console.WriteLine("Row wise sum = "+sum);
                sum = 0;
            }

        }
    }
}
