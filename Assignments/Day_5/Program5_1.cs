/* Create a class Employee having member variable Firstname, Lastname, Middlename.
 * let your application create object even if user does not enter Middlename.
 * Create two constructor one take parameter for Firstname, Lastname and second constructor which will take all the parameter. 
 * Write display method which will display detail of the object */

using System;

namespace Day5_1
{
    public class Employee
    {
        public string firstName, middleName, lastName;

        public Employee(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }

        public Employee(string fname,string mname, string lname)
        {
            this.firstName = fname;
            this.middleName =mname;
            this.lastName = lname;
        }
        public void display()
        {
            Console.WriteLine("{0} {1} {2}",this.firstName,this.middleName, this.lastName);
        }
    }
    class Program5_1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Mohasin", "Awati");
            Employee e2 = new Employee("Mohasin", "Mahamadrafiq","Awati");
            e1.display();
            e2.display();

        }
    }
}
