using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class VideoEncoder3
    {
        //.NEt to make our life easier say, ok, we don't have to create a new delegate 
        //every time we want to declare an event, so .NET offer us a delegate type called
        //EventHandler and it comes in two forms:
        // 1- EventHandler, normal form
        // 2- EventHandler<TEventArgs>, Generic form
        //So, we can use that delegate instead of cxeating our own. We do not have to create a delegate explicitly

        // equivalent to this + the event "public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);"
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //If we do not send any data we can use the normal form like this
        //public event EventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) // if it is not empty someone has subscribed to the event
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
