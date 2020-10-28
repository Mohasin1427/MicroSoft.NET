﻿/* Create a class Employee having private instance member Id, Name Salary, netsalary. 
 * Id should be generated by application.
 * Create method calculate_netsalary who’s job is to deduct 10% of TDS.
 * Declare TDS as static variable. Write method display which will display name and netsalary. 
 * This application will be classlibrary. Declare const int maxemp=3 ie. You can have only 3 employee.
 * Also declare const int maxsal=50000. 
 * Use this for validation in constructor if you try to create object with salary 80000 it should display error
Create console application and use this class library.
 * Create at least two object of Employee class 
*/

using System;

namespace EmployeeLib5_3
{
    public class Employee
    {
        public static int getID = 0;
        public const int maxEmp = 3;
        public static readonly double TDS = 0.1;
        static Employee()
        {
            Console.WriteLine("Welcome to MicroSoft ");
        }
        private int _id;
        private string _name;
        private double _salary;
        private double _netSalary;

        public Employee(string nm,double sal)
        {
            Id = ++getID;
           Name=nm;
           Salary = sal;
           _netSalary = netSalary();
        }
        public int Id
        {
            private set {
                if (value <= maxEmp)
                {
                    _id =value;
                    Console.WriteLine("id =" + _id);
                }
                else
                    throw new Exception("Only 3 Employees are Allowed");
            }
            get { return _id; }
        }
        public String Name
        {
            set {  _name = value;    }
            get { return _name; }
        }
        public double Salary
        {
            
            set {
                const Double maxSal = 50000;
                if(value<=maxSal)
                     _salary = value;
                else
                    throw new Exception("Error: Max Salary limit is 50000");
                }
            get { return _salary; }
        }

        public double netSalary()
        { 
                return (_salary - (_salary * TDS));
        }

        public void display()
        {
            Console.WriteLine("{0} your net salary is {1} ",this._name, this._netSalary);
        }
    }
}
