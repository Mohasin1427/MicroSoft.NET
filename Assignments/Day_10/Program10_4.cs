/* Create a class employee having member name and salary, 
 * it has reference of address class which display location name[eg. vile-parle] 
 * Create a duplicate object using clone method. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_4
{
    public class Employee: ICloneable
    {
        public string Name {get; set;}
        public double Salary { get; set; }
        SetAddress getAddress = new SetAddress();
        public Employee(string nm, double sal, string add)
        {
            Name = nm;
            Salary = sal;
            getAddress.Address = add;
        }

        public override string ToString()
        {
            return string.Format("{0} from {1} having salary {2}", this.Name, getAddress.Address, this.Salary);
        }



        public Object Clone()       //Deep Copy
        {
            Employee ee = (Employee)this.MemberwiseClone();
            SetAddress currentAddress = new SetAddress();
            currentAddress.Address=this.getAddress.Address;
            ee.getAddress = currentAddress;
            return ee;
        }
    }

    public class SetAddress
    {
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ajay", 60000, "Mumbai");
            Console.WriteLine(e1.ToString());
            Employee e2 = null;
            e2 = (Employee)e1.Clone();
            Console.WriteLine(e1.ToString());
            
        }
    }
}
