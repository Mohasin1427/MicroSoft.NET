/* Create a class Account having private instance member Id, Name Balanceamt.
 * Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder.
 * Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder.
 * Write method display which will display name and Balanceamt. This application will be classlibrary.
Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.
*/

using System;


namespace AccountLib1
{
   public class Account
    {
        private int id;
        private string name;
        private double balanceamt;

        public Account(int id, String nm, double bal)
        {
            this.id = id;
            this.name = nm;
            this.balanceamt = bal;
        }

        public void Deposite(int amt)
        {
            this.balanceamt += amt;
            Console.WriteLine("Successfully added to balance " + amt);
        }

        public void Withdraw(int amt)
        {
            if (balanceamt - amt < 1000)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                this.balanceamt -= amt;
                Console.WriteLine("Successfully Withdraw " + amt);
            }
        }
        public void display()
        {
            Console.WriteLine("{0} your Account Balance is {1}", this.name,this.balanceamt);
        }
    }
}
