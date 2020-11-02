﻿/* Create class  Employee having member id, name, salary write ToString() method..
Create 100000 object of employee class. Call Collect method to for force GC. 
 * Also print generation of object.
*/

using System;


namespace Day12_4
{
    class employee
    {
        int _id;

        public int Id
        {
            get { return _id; }
        }

        public String Name
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee[] e = new employee[100000];

            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new employee();
                Console.WriteLine("in {0} th generation", GC.GetGeneration(e[i]));
            }

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("sweept from 0 gen {0}", GC.CollectionCount(0));
            Console.WriteLine("sweept from 1 gen {0}", GC.CollectionCount(1));
            Console.WriteLine("sweept from 2 gen {0}", GC.CollectionCount(2));
        }
    }
}
