using System;

namespace Events
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("SmsService: Sending an SMS...");
        }
    }
}
