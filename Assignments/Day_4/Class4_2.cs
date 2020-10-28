/* Create a class Employee having private instance member Id, Name Salary, netsalary. 
 * Create method calculate_netsalary who’s job is to deduct 10% of TDS.
 * Write method display which will display name and netsalary. 
 * This application will be classlibrary.
Create console application and use this class library. Create at least two object of Employee class 
*/

using System;

namespace EmployeeLib4_2
{
    public class Employee
    {
        private int id;
        private String name;
        private double salary;
        private double netsalary;

        public Employee(int id, string nm, double sal)
        {
            this.id = id;
            this.name = nm;
            this.salary = sal;
        }

        public void Netsal()
        { 
            this.netsalary=salary-(salary*0.10);
        }

        public void display()
        {
            Console.WriteLine("{0} your netSalary is {1} ", this.name, this.netsalary);
        }
    }
}
