using System;

namespace Constructors
{
    public class Vehical
    {
        private readonly string registrationNo;

       /* public Vehical()
        {
            Console.WriteLine("vehical initialize...");
        }*/

        public Vehical(string registrationNo)
        {
            this.registrationNo = registrationNo;

            Console.WriteLine("Vehical is being initialized {0}", registrationNo);
        }
    }
}
