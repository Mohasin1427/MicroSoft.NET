using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_1
{
    abstract class account
    {
        static int gid;
        int Id;
        string Name;
        double Balanceamt;

        static account()
        {
            Console.WriteLine("\tWelcome to State Bank of India\n");
        }
        public account()
        {
            this.Id = ++gid;
        }
        public int id
        {
            get { return this.Id; }
        }
        public string name
        {
            get { return this.Name; }
            set
            {
                if (value.Length < 15)
                {
                    this.Name = value;
                }
                else
                {
                    throw new Exception("name cannot be more than 15 chars");
                }
            }
        }
        public double balance
        {
            get { return this.Balanceamt; }
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("balance can not be zero");
                }
                else
                {
                    this.Balanceamt = value;
                }
            }
        }
        public void deposit(int no)
        {
            balance += no;
        }
        public abstract void withdraw(int no);

        public override string ToString()
        {
            return "\t\t\t" + this.Id + "\t" + this.Name + "\t" + this.Balanceamt;
        }
    }

    class saving : account
    {
        public saving(string nm, double bal)
        {
            name = nm;
            balance = bal;
        }
        public override void withdraw(int no)
        {
            if (no < 0 && (balance - no) >= 1000)
            {
                balance -= no;
            }
            else
            {
                throw new Exception("cannot withdraw less than one and can not withdraw bcoz ur balance is not suff ");
            }
        }
    }

    class current : account
    {
        public current(string nm, double bal)
        {
            name = nm;
            balance = bal;
        }
        public override void withdraw(int no)
        {
            if (no > 0)
            {
                balance -= no;
            }
            else
            {
                throw new Exception("cannot withdraw less than one ");
            }
        }
    }

    class sort : IComparer
    {
        public int Compare(object x, object y)
        {

            account t1 = x as account;
            account t2 = y as account;
                
            if (t1 != null && t2 != null)
                return String.Compare(t1.name, t2.name);
            else
                throw new ArgumentException("Parameter is not of account type!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            account[] arr = new account[3];
            arr[0] = new saving("Ajay", 50000);
            arr[1] = new current("Vijay", 20000);
            arr[2] = new saving("Jay", 65000);
           // arr = null;

            Array.Sort(arr, new sort());

            foreach (account acc in arr)
                Console.WriteLine("{0} your balance is {1}", acc.name,acc.balance);
            Console.ReadKey();
            

        }
    }
}
