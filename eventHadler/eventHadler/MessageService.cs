using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eventHadler
{
    public class MessageService
    {

        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message..."+e.Video.Title);
        }

    }
}
