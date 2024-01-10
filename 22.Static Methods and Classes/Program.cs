using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _22.Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static already has many pread classes te the at class hate can eat un chenever without having to make objects
            Console.WriteLine(Math.Sqrt(144));
            //useFullTools tools = new UseFullTools();
            //if u make the class static as well, you will only access it with direct methods,
            //no more objects , Just like u cant make an object of the math class 
            UseFullTools.sayHi("Evans"); //no need to make objects of the say Hi class sincewe have a static method in there
            //freeze
            Console.ReadLine();
        }
    }
}
