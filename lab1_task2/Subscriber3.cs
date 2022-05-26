using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_task2
{
    public class Subscriber3 : IEventSubscribers
    {
        private string login;
        public Subscriber3(string login)
        {
            this.login = login;
        }

        public string Login { get { return login; } }

        public void SubMessage(string mess)
        {
            Console.WriteLine("Subscriber3(" + login + "): " + mess);
        }
    }
}
