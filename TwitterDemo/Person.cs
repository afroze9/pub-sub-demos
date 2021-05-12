using System;

namespace TwitterDemo
{
    public class Person
    {
        private event EventHandler<Tweet> tweetEvent;
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void SendTweet(string message)
        {
            Tweet tweet = new Tweet(message);
            if (tweetEvent != null)
            {
                tweetEvent(this, tweet);
            }
        }

        public void Subscribe(Person person)
        {
            person.tweetEvent += ShowTweet;
        }
        public void UnSubscribe(Person person)
        {
            person.tweetEvent -= ShowTweet;
        }
        public void ShowTweet(object sender, Tweet tweet)
        {
            Person person = (Person)sender;
            Console.WriteLine($@"{Name} | {tweet.Time:dd/MM/yyyy hh:mm:ss.fff} | {person.Name} sent a tweet ""{tweet.Message}""");
        }
    }
}