using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_and_delegates
{
    public class VideoEncoder
    {
        //Define a delegate
        //Define an event based on delegate
        //raise the event

        //delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //EventHandler<TEventArgs>

        public event EventHandler<EventArgs> VideoEncoded;

        public void Encode()
        {
            Console.WriteLine("Encoding video...");
            Console.WriteLine();
            //(virtual) method in which event is raised
            OnVideoEncoded();
        }

        public virtual void OnVideoEncoded()
        {
            //if event is raised or if this method is subscribed by any other class than it is executed
            if(VideoEncoded!=null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
