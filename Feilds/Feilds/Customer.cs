using System.Collections.Generic;

namespace Feilds
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); //need to initialize this always 
        /*
         this will make sure that this wont be initialized again by another methood
         can only initialize direcly in the class or in the constructor
             */

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {

            //..
        }
    }
}
