﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eventHadler
{
    public class MailService
    {

        public void onVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }

    }
}
