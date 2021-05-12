using System;

namespace SimplePubSubDemo
{
    class EventArguments : EventArgs
    {
        public string Message { get; set; }

        public EventArguments(string message)
        {
            Message = message;
        }
    }
}