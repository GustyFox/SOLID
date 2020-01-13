using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.OpenClosed.After
{
    public class SendId : ISendId
    {
        public string NotificationPreference { get; set; }

        public void Send(Employee employee)
        {
            if (NotificationPreference == "Email")
            {
                //Send the manager an email with new employee information.
            }
            if (NotificationPreference == "SMS")
            {
                //Send the manager a SMS with new employee information.
            }
        }
    }
}
