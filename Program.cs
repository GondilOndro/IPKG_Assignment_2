namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMessage message = new MessageA();
            IMessage message = new MessageB();
            //IMessage message = new MessageC();

            switch (message)
            {
                case MessageA messageA:
                    {
                        messageA.ProcessMessage();
                        break;
                    }
                case MessageB messageB:
                    {
                        messageB.ProcessMessage();
                        messageB.ProcessMessageAlt();
                        break;
                    }
                case MessageC messageC:
                    {
                        messageC.ProcessMessage();
                        break;
                    }
            }

            //alternatively
            //if (message is MessageA messageA)
            //{
            //    messageA.ProcessMessage();
            //}
            //else if (message is MessageB messageB)
            //{
            //    messageB.ProcessMessage();
            //    messageB.ProcessMessageAlt();
            //}
            //else if (message is MessageC messageC)
            //{
            //    messageC.ProcessMessage();
            //}
        }
    }
}
