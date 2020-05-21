using System;

namespace Methord
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
        static void UaeParams()
        {
            var cal = new Calculator();
            Console.WriteLine(cal.Add(1, 2));
            Console.WriteLine(cal.Add(1, 2, 3));
            Console.WriteLine(cal.Add(1, 2, 3, 4));
            Console.WriteLine(cal.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Pointer is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Pointer is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {

                Console.WriteLine("Unexpected error occurd");
            }
        }
    }
}
