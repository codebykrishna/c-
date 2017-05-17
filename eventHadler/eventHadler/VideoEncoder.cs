﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace eventHadler
{

    public class VideoEventArgs : EventArgs
    {

        public Video Video { get; set; }
    }

    class VideoEncoder
    {

        //1. Define a delegate

        //2. Define an event based on that delegate

        //3. Raise the event

      //  public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;


        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {

            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {

            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video=video});
        }
    }
}
