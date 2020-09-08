using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define a event based on that delegate
        // 3- Raise the event, we need a method that is responsible for that 


        //-1) First Step
        // It is a convention that the first parameter of the event handler to be an object, 
        // This object is the source of the event or the class that is publishing or sending the event
        // The second parameter is basically any aditional data we want to send when the event.
        //
        // Why this delegate is named like that? it is a .NET convention:
        //  Is the name of our event is going to be VideoEncoded, we use that and then append EventHandler
        //  as the name of the delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //-2) Second Step
        // Noticed that we call the event using past tense, to indicate something has happened or finished.
        // Sometimes in .NET you may see an event referring to present tense like Same VideoEncoding, in that
        // case that event should be fire or published before the encoding is started 
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            //-3) Third Step
            OnVideoEncoded();
        }

        //-3) Third Step
        // .NET suggest that your event publisher method should be protected, virtual an void
        // and in terms of naiming they should start with the word On and then the name of the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null) // if it is not empty someone has subscribed to the event
            {
                VideoEncoded(this, EventArgs.Empty); // En este caso no enviamos ninguna data con el evento, por eso el empty
            }
        }
    }
}
