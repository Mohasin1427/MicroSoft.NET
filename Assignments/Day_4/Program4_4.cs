/* Create a class Printer with a private constructor.
 * Your application should give only one reference of the printer object.*/

using System;


namespace Day4_4
{
    class Sinlgletone
    {
        static Sinlgletone mysingletone=null;
        private Sinlgletone() { }
              
        public static Sinlgletone getSingletone()
        {
            if (mysingletone == null)
            {
                mysingletone = new Sinlgletone();
                return mysingletone;
            }
            else
                return mysingletone;
        }
    }

    class Program4_4
    {
        static void Main(string[] args)
        {
            Sinlgletone s1 = Sinlgletone.getSingletone();
            Sinlgletone s2 = Sinlgletone.getSingletone();
            if (s1 == s2)
                Console.WriteLine("Both are refering to single instance");
            else
                Console.WriteLine("Both are refering to diferent instance");

        }
    }
}
