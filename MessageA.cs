using System;

namespace Assignment_2
{
    public class MessageA : IMessage
    {
        public void ProcessMessage()
        {
            Console.WriteLine("I'm MessageA.");
        }
    }
}
