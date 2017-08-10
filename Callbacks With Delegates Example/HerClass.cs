using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Callbacks_With_Delegates_Example
{
    class HerClass
    {
        //An instance variable to store the passed delegate,
        //so that it can be called after the time taking task is finished.
        private CallBackType _callBackType;

        //To do the time taking event
        private Timer _timer;
        private int _timerCount;

        public HerClass()
        {
            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Elapsed += _timer_Elapsed;
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //This is to demonstrate the time taking event

            if (_timerCount >= 20)
            {                
                _timer.Stop();
                Console.WriteLine();
                Console.WriteLine("Her time taking task finished.");
                //Notifying about the completion
                this.herTimeTakingMethodCompletionEvent();
            }
            else
            {
                Console.Write(".");
                _timerCount++;
            }
        }

        /// <summary>
        /// This represent her time taking method
        /// </summary>
        /// <param name="callBackType">A callback method is pass via this delegate type</param>
        public void HerTimeTakingMethod(CallBackType callBackType)
        {
            //Assign the passed delegate to the instance varialbe,
            //so it can be called after the completion of the time taking task
            this._callBackType = callBackType;

            Console.WriteLine("She's starting the time taking task.");  
            //A timer is used to demonstrate the time taking task
            _timer.Start();
        }

        /// <summary>
        /// At the end of the time taking task, this method is called
        /// </summary>
        private void herTimeTakingMethodCompletionEvent()
        {
            if (this._callBackType != null)
            {
                //When the delegate type is invoked, actually the method assigned to this,
                //will be invoked
                this._callBackType();
            }
        }
    }
}
