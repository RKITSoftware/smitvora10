using System;

namespace events_and_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var videoEncoder = new VideoEncoder();//publisher
            var mailServices = new MailServices();//subscriber
            var messageServices = new MessageServices();//subscriber
            

            videoEncoder.VideoEncoded += mailServices.OnVideoEncoded;//subscription by MailServices class
            videoEncoder.VideoEncoded += messageServices.OnVideoEncoded;//subscription by MessageServices class
            //Calling method which contains all logic including virtual method call which contains event
            videoEncoder.Encode();

            //output-
            //Encoding video...

            //Mail Service: Sending an email...
            //Message is sent...

        }
    }
}
