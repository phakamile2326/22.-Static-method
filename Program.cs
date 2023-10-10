using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_method
{
    internal class Program
    {
        static void Main(string[] args)
        {//static method is about the class itself, no need to create objects to get the class itself
         //C# already has ,amy prelude classes like math class that we can call upon whenever without having to make objects

            Console.WriteLine(Math.Sqrt(144));

            //UsefulTools tools = new UseFullTools(), if you make class static as well, you will only access it with direct methods,
            //no objects just like you can't make an object of a Math class

            UseFullTools.sayHi("Phaka");
            Console.ReadLine();
        }
    }
}
