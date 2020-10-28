using System;

using EmployeeLib4_2;



namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Ajay", 20000);
            e1.Netsal();
            e1.display();

            Employee e2 = new Employee(2, "Vijay", 30000);
            e2.Netsal();
            e2.display();
        }
    }
        
    
}
