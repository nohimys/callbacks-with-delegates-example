using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callbacks_With_Delegates_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Started.");
            
            MyClass myClass = new MyClass();
            myClass.MyMethod();
            
            Console.ReadKey();
        }
    }
}
