using System;
using System.Collections;

namespace Exercise_Section4
{
    public class stack
    {
        private Stack stc = new Stack();
        public stack()
        {

        }
        
        public void Push(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Cannot publish a Null value here...");
                throw new InvalidOperationException();
            }

            stc.Push(obj);
        }

        public object Pop()
        {
            object ob = stc.Pop();
            if (ob == null)
            {
                throw new InvalidOperationException();
            }

            return ob;
        }

        public void Clear()
        {
            stc.Clear();
        }
    }
}
