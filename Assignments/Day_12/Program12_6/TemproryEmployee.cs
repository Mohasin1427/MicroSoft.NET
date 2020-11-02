using System;


namespace Day12_6
{
    class TemproryEmployee : Employee
    {
        public TemproryEmployee(string nm, double sal)
            : base(nm,sal)
        { }

        public sealed override void GiveBonus()
        {
            double bonus=(this.Salary*0.10)+5000;
            Console.WriteLine("{0} your bonus is {1} on salary {2}", this.Name, bonus, this.Salary);
            OnBonus(Name, Salary, bonus);
        }
    }
    
}
