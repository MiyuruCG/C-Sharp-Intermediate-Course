using System;

namespace Constructors
{
    public class Car : Vehical
    {
        public Car(string registrationNo)
            :base(registrationNo)
        {
            Console.WriteLine("Car is initialize...{0}",registrationNo);
        }
    }
}
