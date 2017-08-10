using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callbacks_With_Delegates_Example
{
    //The Delegate Type is declared in the namespace level so it is accessible from both,
    //MyClass & HerClass.
    //Any method that have the same signature as this type can be assigned to the,
    //variables created by this Type.
    public delegate void CallBackType();

    class MyClass
    {
        public void MyMethod()
        {
            //Create a delegate variable from the above declared type
            //Assinging the callback method with the same signature of the type, in to that variable
            CallBackType callBackType = this.CallBackMethodInMyClass;

            //Create an object of HerClass
            HerClass herClass = new HerClass();

            Console.WriteLine("MyMethod is calling HerTimeTakingMethod...");
            //Calling her time taking method
            //CallBackMethodInMyClass method is passed via a delegate.
            herClass.HerTimeTakingMethod(callBackType);
        }

        /// <summary>
        /// This is the method which is passed by assigning into a delegate.
        /// By calling the delegate, this method can be triggered.
        /// </summary>
        public void CallBackMethodInMyClass()
        {
            //This will be called after the time taking execution is completed
            Console.WriteLine("CallBackMethodInMyClass method in MyClass called.");

            Console.WriteLine("Application Finished. Press any key to exit");
        }
    }
}
