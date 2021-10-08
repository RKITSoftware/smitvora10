using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_and_delegates
{
    class MailServices
    {
        //the method in which event is raised (virtual) is implemented here for it's function
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail Service: Sending an email...");

        }
    }
}
