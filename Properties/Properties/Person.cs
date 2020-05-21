using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; } //here the c# compiler creates a private variable and creates get and set methods.

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            { 
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;
            }
        }
    }
}
