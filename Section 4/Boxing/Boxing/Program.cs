using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new ArrayList();// can add any object 
            list.Add(1); // here boxing happes this effect the run time
            list.Add("String");
            list.Add(DateTime.Today);

            // var number = (int)list[1]; //gets error

            var anotherList = new List<int>(); // generic list
            anotherList.Add(1);// type safe

            var nameList = new List<string>();
            nameList.Add("hi");
        }
    }
}
