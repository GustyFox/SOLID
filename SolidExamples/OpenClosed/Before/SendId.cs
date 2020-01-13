using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.OpenClosed.Before
{
    /// <summary>
    /// That is the
    /// </summary>
    public class SendId
    {
        public string CommunicationPreference { get; set; }

        public void SendId(Employee employee)
        {
            if (CommunicationPreference == "Email")
            {
                //Send the employee id through email.
            }
            if (CommunicationPreference == "SMS")
            {
                //Send the emplyee id through SMS.
            }
        }
    }
}
