# Events and Delegates

The concepts of events and delegates are a little bit confusing.

## Events

* A mechanism for communication between objects
* Used in building _Loosely Coupled applications_
* Helps extending applications

That means when something happens inside an object, it can notify other objects about that.

### Steps to configure/code an Event

To give the class the ability to publish an event, there are three steps we need to follow:

* First, we need to define a delegate, that is the contract or the agreement between the publisher and the subscriber. Delegate determine the signature of the method and the subscriber that will be called when the publisher publishes and event.

* Second, we need to define an event based on that delegate

* And third, we need to raise or publish the event


  ```c#
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
              VideoEncoded(this, EventArgs.Empty);
          }
      }
  }
  ```

## Easiest Way to Set up an Event

/NEt to make our life easier say that we don't have to create a new delegate every time we want to declare an event. .NET offer us a delegate type called        EventHandler and it comes in two forms:

* EventHandler, _normal form_

* EventHandler<TEventArgs>, _generic form_

We can use those delegates instead of creating our own. We do not have to create a delegate explicitly.



```c#
    public class VideoEncoder3
    {
    //.NEt to make our life easier say, ok, we don't have to create a new delegate 
    //every time we want to declare an event, so .NET offer us a delegate type called
    //EventHandler and it comes in two forms:
    // 1- EventHandler, normal form
    // 2- EventHandler<TEventArgs>, Generic form
    //So, we can use that delegate instead of creating our own. We do not have to create a delegate explicitly

	//Equivalent to this + the event "public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);"
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
```






