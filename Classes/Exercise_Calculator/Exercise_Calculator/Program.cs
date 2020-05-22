using System;

namespace Exercise_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            var x = 0;

            var stopwatch = new Stopwatch();

            while(val != 0)
            {
                Console.WriteLine("Press 1 to start the watch ... ");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    stopwatch.Start();
                Console.WriteLine("Press 2 to stop the watch ... ");
                x = int.Parse(Console.ReadLine());
                if (x == 2)
                    stopwatch.Stop();
                Console.WriteLine(stopwatch.GetDuration());

                Console.WriteLine("To end enter 0 ... ");
                x = int.Parse(Console.ReadLine());


            }

            
        }
    }
}
