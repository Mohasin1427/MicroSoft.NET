/* Create array of anonymous object displaying name and salary. Print all detail */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new[] { new { Name = "Ajay", Salary = 60000 }, new { Name = "Vijay", Salary = 65000 }, new { Name = "Sujay", Salary = 25000 } };
            foreach (var vs in v)
            {
                Console.WriteLine("{0} {1}", vs.Name, vs.Salary);
            }
        }
    }
}
