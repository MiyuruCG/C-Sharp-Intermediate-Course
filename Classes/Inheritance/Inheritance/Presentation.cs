using System;

namespace Inheritance
{
    public class Presentation
    {
        public int width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object duplicates ..");
        }
    }
}
