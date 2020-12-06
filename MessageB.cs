using System;

namespace Assignment_2
{
    public class MessageB : IMessage
    {
        public void ProcessMessage()
        {
            Console.WriteLine("I'm MessageB.");
        }

        public void ProcessMessageAlt()
        {
            Console.WriteLine("Alternative MessageB.");
        }
    }
}
