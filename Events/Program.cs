namespace Events
{
    internal class Program
    {

        //VideoEncoder do not use data to send
        //VideoEncoder do use data to send
        // I keep the two classes to see the differences, jus with educative purpose
        private static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };

            var videoEncoder = new VideoEncoder(); //Publisher
            var mailSender = new MailService(); //Subscriber
            var smsSender = new SmsService(); //Subscriber

            //Before we call the encode method we need to do the subscription
            //need to use "+=" operator that is to register a handler for that event
            //Who is the handler?, the method in MailService "OnVideoEncoded"
            //"VideoEncoded event, behind the scene is a list of pointer to methods
            videoEncoder.VideoEncoded += mailSender.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsSender.OnVideoEncoded;

            videoEncoder.Encode(video);

            System.Console.WriteLine("------------------------");

            var videoEncoder2 = new VideoEncoder2(); //Publisher
            var mailSender2 = new MailService2(); //Subscriber
            var smsSender2 = new SmsService2(); //Subscriber

            videoEncoder2.VideoEncoded += mailSender2.OnVideoEncoded;
            videoEncoder2.VideoEncoded += smsSender2.OnVideoEncoded;

            videoEncoder2.Encode(video);


            System.Console.WriteLine("------------------------");

            var videoEncoder3 = new VideoEncoder3(); //Publisher
            var mailSender3 = new MailService3(); //Subscriber
            var smsSender3 = new SmsService3(); //Subscriber

            videoEncoder3.VideoEncoded += mailSender3.OnVideoEncoded;
            videoEncoder3.VideoEncoded += smsSender3.OnVideoEncoded;

            videoEncoder3.Encode(video);
        }
    }
}