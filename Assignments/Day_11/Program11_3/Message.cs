using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_3
{
    class Message
    {
        public void SendSms(string name,double salary, double bonus)
        {
            Console.WriteLine("Event--{0} your bonus is {1} on salary {2}", name, bonus, salary);   
        }
        public void SendEmail(string name, double salary, double bonus)
        {
            Console.WriteLine("Event--{0} your bonus is {1} on salary {2}", name, bonus, salary);
        }
    }
}
