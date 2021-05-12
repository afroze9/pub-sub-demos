using System;

namespace TwitterDemo
{
    public class Tweet : EventArgs
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }

        public Tweet(string message)
        {
            Message = message;
            Time = DateTime.Now;
        }
    }
}