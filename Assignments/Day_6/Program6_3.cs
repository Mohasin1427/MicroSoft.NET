/*  Accept data in an array and print sum  also store square of each element in new array.  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_3
{
    class Program
    {
        static void Main(string[] args)
        {
             int temp, sum = 0;
           
            Console.WriteLine("Enter how many elements you wants");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num], square = new int[num];

            Console.WriteLine("Enter Elements in Array");

           
                for (int j = 0; j < num; j++)
                {
                    arr[j] = int.Parse(Console.ReadLine());
                    sum+=arr[j];
                    square[j] = arr[j] * arr[j];
                }
                Console.WriteLine("Row wise sum = " + sum);

                Console.WriteLine("Square array is\t");

            for (int i = 0; i < num; i++)
                {
                    Console.Write(square[i] + "\t");
                }
                Console.WriteLine();
                
            }

        }

      }


