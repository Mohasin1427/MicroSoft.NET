using System;

public delegate void mydel(string name, double sal, double bonus);
namespace Day12_6
{

    class Program
    {
        static void Main(string[] args)
            {
               
                Employee[] emp = new Employee[3];

                emp[0] = new PermanantEmployee("Ajay", 30000);
                emp[1] = new TemproryEmployee("Vijay", 20000);
                emp[2] = new TemproryEmployee("Sujay", 50000);

          //      Console.WriteLine("len= ", emp.Length);

                for (int i = 0; i < emp.Length; i++)
                {
                    emp[i].NewEvent +=(string name, double sal, double bonus)=> 
                        {
                           Console.WriteLine("SMS--Event--{0} your bonus is {1} on salary {2}", name, bonus, sal);   
                        };
                    emp[i].NewEvent +=(string name, double sal, double bonus)=> 
                         {
                             Console.WriteLine("Email--Event--{0} your bonus is {1} on salary {2}", name, bonus, sal);
                         };
                }
                emp[0].GiveBonus();
                emp[1].GiveBonus();
                emp[2].GiveBonus();

            }
        }
    
}
