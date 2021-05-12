using System;

namespace SimplePubSubDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub1 = new Publisher();
            pub1.Name = "Pub 1";

            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();

            sub1.Subscribe(pub1);
            sub2.Subscribe(pub1);
            sub3.Subscribe(pub1);

            pub1.Notify("Hello there!");

            sub2.UnSubscribe(pub1);

            pub1.Notify("Hello again!");
        }
    }
}
