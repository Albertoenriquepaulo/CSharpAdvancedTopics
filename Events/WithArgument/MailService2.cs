﻿using System;

namespace Events
{
    class MailService2
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("SmsService: Sending an SMS..." + e.Video.Title);
        }
    }
}
