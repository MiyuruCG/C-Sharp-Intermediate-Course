using System;
using System.Collections.Generic;

namespace LearnConstructors
{
    public class Customer
    {
        public int Id;
        public String Name;

        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()    //whenever this constructor is called the constructor with no parameters will also be called
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
