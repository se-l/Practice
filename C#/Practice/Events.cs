using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Couple lines regardig event based processing
    /// </summary>
    internal class Events
    {
        public class Publisher
        {
            public event EventHandler OnEvent;

            public void TriggerEvent()
            {
                OnEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        public class Subscriber
        {
            public string ID;
            public void HandleEvent(object sender, EventArgs e)
            {
                Console.WriteLine($"Subscriber {ID}: HandleEventEvent handled");
            }
        }

        public static void Run()
        {
            Console.WriteLine("Events.Run()");

            var publisher = new Publisher();
            Subscriber subscriber1 = new () { ID = "Sub1"};
            Subscriber subscriber2 = new () { ID = "Sub2"};

            publisher.OnEvent += subscriber1.HandleEvent;
            publisher.OnEvent += subscriber2.HandleEvent;

            publisher.TriggerEvent();
        }
    }
}
