using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_task2
{
    public class Countdown
    {
        private List<IEventSubscribers> subscribers;

        public Countdown()
        {
            subscribers = new List<IEventSubscribers>();
        }

        public List<IEventSubscribers> Subscribers
        {
            
            get {return subscribers; }
        }

        public void Subscription(IEventSubscribers subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscription(IEventSubscribers subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SubNotification(int time)
        {
            foreach (IEventSubscribers subscriber in subscribers)
            {
                Thread.Sleep(time);
                Console.WriteLine("Time delay " + time.ToString() + " ms");
                subscriber.SubMessage("Time out!");
            }
        }

         
    }


}
