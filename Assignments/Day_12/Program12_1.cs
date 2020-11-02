/* . create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
    c.  cube of a number.
Using  Anonymous  method.
 */

using System;
// MyCal takes one int argument and returns an int result. 
delegate int MyCal(int num);

class Day12_1
{
    static void Main()
    {
        MyCal fact = delegate(int num)
                    {
                        int f = 1;
                        for(int i=num;i>=1;i--)
                            f*=i;
                        return f;
                    };
        MyCal Square = delegate(int num)
                    {
                        return num * num;
                    };
        MyCal Cube = delegate(int num)
                       {
                         return num * num * num;
                       };
        
        Console.WriteLine("Enter the number ");
       int n=int.Parse(Console.ReadLine());
       Console.WriteLine(" Factorial = {0} \n Square = {1} \n Cube = {2}", fact(n), Square(n), Cube(n));
    }
}

