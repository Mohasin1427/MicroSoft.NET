﻿/* Create Account class having instance member 
1. id- id should be generated by application, it is readonly property
2. name – write getter setter 
3. balance- Write getter setter 
It has deposit method who’s job is to increase the balance.
Declare static float Interestrate=0.07.
It has withdraw method who’s job is to reduce balance.
Declare conts float minbal=1000. When user withdraw money your application should ensure that minimum balance is maintain. 
Give appropriate validation like user can not deposit or withdraw 0 or negative. user can not open account with 0 amount
When you run your application at the beginning it should print name of bank and copy right detail.
It has static method which will calculate and return  interest amount for each account holder and increase the balance.
Write display method who’s job is to display Id name and balance and interest received.
If you are comfortable the exception try to use it and handle it also.

*/

using System;

namespace Day6_1
{

    public class Account
    {
        private int _id;
        private string _name;
        private double _balance;
        const float minBal=1000.00f;
        static float Interestrate=0.07f;
        public static int ID=0;

        static Account()
        {
            Console.WriteLine("Welcome to State Bank Of India");
        }
        public Account(string nm, double bal)
        {
                this._id = ++ID;
                Name = nm;
                Balance= bal;
        }

        public int Id
        {
            get {   return _id; }
        }
        public String Name
        {
        get {  return _name;   }
        set {
                if(value.Length>=4)
                {
                    _name=value;
                }
                else
                    throw new Exception("Name must be having atleast 4 char");
            }
        }
        public double Balance
        {
        get {   return _balance;}
        set {
                if(value>=minBal)
                {
                    _balance=value;
                }
                else
                    throw new Exception("Minimum 1000 balance required");
            }
        }

        public void deposite(int amt)
        {
            if(amt>0)
            {
            Balance +=  amt;
            Console.WriteLine("Successfully deposited Rs. " + amt);
            }
            else
                throw new Exception("Please Enter valid amount");
        }

        public void withdraw(int amt)
        {
            if ((Balance - amt) > minBal)
            {
                Balance -= amt;
                Console.WriteLine("Successfully Deducted Rs. " + amt);
            }
            else
                throw new Exception("Insufficient balance in Account");
        }

        public void display()
        {
            Console.WriteLine("{0} your account balance is {1}",Name,Balance);
        }

        static double CalInterest(Account obj)
        {
            double d= obj.Balance * Interestrate;
            obj.Balance+=d;
            return d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Ajay", 5000);
            a1.display();
            a1.deposite(400);
            Account a2 = new Account("Vijay", 8000);
            a2.display();
            a2.deposite(500);
            try
            {
                Account a3 = new Account("Maddy", 0);
            }
            catch
            {
                Console.WriteLine("In Catch");
            }
         //   a2.withdraw(8000);
        }
    }
}

