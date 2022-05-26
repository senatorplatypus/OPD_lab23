namespace lab1_task2
{
    public static class Program
    {
        static void Main()
        {
            Subscriber1 sub1 = new Subscriber1("Dima");
            Subscriber2 sub2 = new Subscriber2("Ilya");
            Subscriber3 sub3 = new Subscriber3("Ivan");

            Countdown countdown = new Countdown();

            countdown.Subscription(sub1);
            countdown.Subscription(sub2);
            countdown.Subscription(sub3);

            Console.WriteLine("Set notification time: ");
            int time = Convert.ToInt32(Console.ReadLine());
            countdown.SubNotification(time);
        }
    }
}
