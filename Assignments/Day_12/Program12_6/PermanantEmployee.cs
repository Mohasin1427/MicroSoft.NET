using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_6
{
    class PermanantEmployee : Employee
    {
        public PermanantEmployee(string nm, double sal)
            : base(nm,sal)
        { }

        public  override void GiveBonus()
        {
            double bonus=(Salary*0.20)+10000;
            Console.WriteLine("{0} your bonus is {1} on salary {2}",Name,bonus,Salary  );
            OnBonus(Name,Salary,bonus);
        }
    }
}
