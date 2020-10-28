/* Create struct emp having member name and salary, using constructor initialized member. Write display method which will display name and salary */

using System;

namespace Day3_3
{
    struct emp
    {
        string name;
        double salary;
        public emp(string nm, double sal)
        {
            this.name = nm;
            this.salary = sal;            
        }
        public void display()
        {
            Console.WriteLine("{0}  {1}", name, salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp("Anil", 50000);
            e.display();
            emp e1 = new emp("Ajay", 70000);
            e1.display();

        }
    }
}
