using System;

namespace Task4_1
{
    //
    //class Account
    //{
    //    private int id;
    //    private string name;
    //    private double balanceamt;

    //    public Account(int id, String nm, double bal)
    //    {
    //        this.id = id;
    //        this.name = nm;
    //        this.balanceamt = bal;
    //    }
    //    public void Deposite(int amt)
    //    {
    //        this.balanceamt += amt;
    //        Console.WriteLine("Successfully added to balance " + amt);
    //    }

    //    public void Withdraw(int amt)
    //    {
    //        if (balanceamt - amt < 1000)
    //        {
    //            Console.WriteLine("Insufficient Balance");
    //        }
    //        else
    //        {
    //            this.balanceamt -= amt;
    //            Console.WriteLine("Successfully Withdraw " + amt);
    //        }
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine("{0} your Account Balance is {1}", this.name, this.balanceamt);
    //    }
    //}
    using AccountLib1;

    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1, "Ajay", 20000);
            a1.Deposite(5000);
            a1.display();
            a1.Withdraw(5000);
            a1.display();
            a1.Withdraw(20000);
            a1.display();

            Account a2 = new Account(2, "Vijay", 30000);
            a2.Deposite(5000);
            a2.display();
            a2.Withdraw(5000);
            a2.display();
            a2.Withdraw(20000);
            a2.display();
        }
    }
}
