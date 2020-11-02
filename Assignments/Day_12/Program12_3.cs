/* create class  Employee having member id, name, salary write ToString() method..
Create a object of employee class and store it in var ,Object and dynamic variable.
Call tostring method to display data.
*/

using System;

namespace Day12_3
{
    class Employee
    { 
        public int id;
        public string name;
        public double salary;

        public override string ToString()
        {
            return String.Format(this.name + "\t" + this.salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() {id=1,name="Ajay", salary=20000 };
            var v = Emp1;       //further we can't change to other Data Type
            Object obj = Emp1;  //further we can change to other Data Type
            dynamic d = Emp1;   //further we can change to other Data Type But it will @ Runtime only

            Console.WriteLine(v + "\n" + obj + "\n" + d);
        }
    }
}
