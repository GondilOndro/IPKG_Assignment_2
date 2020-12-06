using System;

namespace Assignment_2
{
    public class MessageC : IMessage
    {
        public void ProcessMessage()
        {
            Console.WriteLine("I'm MessageC.");
        }
    }
}
