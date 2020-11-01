/* create class  Employee having member id, name, salary. Id should be autoincrement.
 *   Write getter setter for name and salary. Write abstract method givebonus.
 *  Create two child class Permanente employee and temporary employee. 
 * Create array of employee class store two object of class Permanente employee and temporary employee. 
 * As soon as you call givebonus it should send message stating total salary ,bonus and name. 
*/

using System;

public delegate void mydel(string name, double sal, double bonus);
namespace Day11_3
{
    
 
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            Employee[] emp = new Employee[3];

            emp[0] = new PermanantEmployee("Ajay", 30000);
            emp[1] = new TemproryEmployee("Vijay", 20000);
            emp[2] = new TemproryEmployee("Sujay", 50000);

            Console.WriteLine("len= ", emp.Length);
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].NewEvent += m.SendSms;
                emp[i].NewEvent += m.SendEmail;
            }
                emp[0].GiveBonus();
                emp[1].GiveBonus();
                emp[2].GiveBonus();
            
        }
    }
}
