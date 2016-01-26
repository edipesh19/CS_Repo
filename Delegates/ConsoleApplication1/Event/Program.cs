using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    delegate void MyHandler();

    class MyEvent
    {
        public event MyHandler myEvent;
        public void RaiseMyEvent()
        {
            if (myEvent != null)
            {
                myEvent();
            }
        }
    }

    class EventDemo
    {
        static void Handler()
        {
            Console.WriteLine("Event Raised");
        }

        static void Main(string[] args)
        {
            MyEvent ev = new MyEvent();
            ev.myEvent += Handler;
            ev.RaiseMyEvent();
        }
    }
}
