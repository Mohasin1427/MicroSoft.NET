/* 5. create a two partial Account class.
 * In one class write only methods and another class write constructor and getter setter. 
 * Use this in your existing account application.*/

using System;

namespace Day12_5
{
    //partial keyword is used when you want to split class implementation within same namespace or Assembly.
    //Access modifier must be same 
     public partial class Account
    {
        //private int _id;
        //private string _name;
        //private double _balance;

        public int ID { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(int id, string nm, double bal)
        {
            ID = id;
            Name = nm;
            Balance = bal;
        }

    }

     public partial class Account
    {
        public override string ToString()
        {
    	 return string.Format(this.Name +"\t"+ this.Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account MyAccount = new Account(1,"Mohasin",50000);
            Console.WriteLine(MyAccount);
        }
    }
}
