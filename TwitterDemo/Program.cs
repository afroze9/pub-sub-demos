using System;
using System.Threading;

namespace TwitterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("P1");
            Person p2 = new Person("P2");
            Person p3 = new Person("P3");

            p2.Subscribe(p1);
            p3.Subscribe(p1);
            p1.SendTweet("Hello!");


            p2.UnSubscribe(p1);
            p1.SendTweet("Oh no i lost a sub! :(");
        }
    }
}
