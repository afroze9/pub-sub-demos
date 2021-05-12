using System;

namespace SimplePubSubDemo
{
    class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.MyEvent += Update;
        }

        public void UnSubscribe(Publisher publisher)
        {
            publisher.MyEvent -= Update;
        }

        public void Update(object sender, EventArguments args)
        {
            Publisher publisher = (Publisher)sender;
            Console.WriteLine($"{publisher.Name} sent a message: {args.Message}");
        }
    }
}