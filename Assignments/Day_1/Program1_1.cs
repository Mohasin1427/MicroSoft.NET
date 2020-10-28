using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Enter two numbers for add");
            short num1=short.Parse(Console.ReadLine());
            short num2=short.Parse(Console.ReadLine());
            int sum=(int)(num1+num2);
            Console.WriteLine("Addition is {0}",sum);

        }
    }
}
