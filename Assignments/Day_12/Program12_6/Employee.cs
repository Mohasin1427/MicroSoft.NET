using System;


namespace Day12_6
{
    abstract class Employee
    {
        public event mydel NewEvent;
 
       static int ID;
       private int _id;
       private string _name;
       private double _salary;

       static Employee() { Console.WriteLine("\tWelcome to HP World \n\n "); }

       public Employee(string nm, double sal)
       {
           _id = ++ID;
           Name=nm;
           Salary=sal;
           
       }
       public string Name
       {
           get {    return _name;   }
           set {     _name = value;  }
       }
       public double Salary
       {
           get { return _salary; }
        protected  set { _salary = value; }
       }

       public abstract void GiveBonus();

       public void OnBonus(string name, double sal, double bonus)
       {
           if (NewEvent != null)
               NewEvent(name,  sal, bonus);
       }
    }
}
