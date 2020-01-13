using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.OpenClosed.After
{
    public class UsingTheNewClasses
    {
        public void Notify()
        {
            ISendId mailSender = new SendIdLetter();
            ISendId sender = new SendId();

            mailSender.Send(new Employee());
            sender.Send(new Employee());
        }
    }
}
