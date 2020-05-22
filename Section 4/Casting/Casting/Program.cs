using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      ::DownCasting*/

            Shape shape = new Text();
            Text text = (Text)shape; //downcast




            /*  :: Upcasting
            //StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Text");
            list.Add(new Text());

            var anotherList = new List<Shape>();      //Generic List: here we can only save the data from the specified data type
            */
        }
    }
}
