using System;

namespace Methord
{
    class Program
    {
        static void Main(string[] args)
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
