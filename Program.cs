using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given the radius of a circle, calculate and print its area.
            //The area of a circle can be computed using the following formula:A=πr^2. For pi, you can use 3.141592653589793,
            float a =float.Parse(Console.ReadLine());
            Console.WriteLine(a*a*3.1416);
        }
    }
}
