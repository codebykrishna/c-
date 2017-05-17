using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eventHadler
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title= "Video 1" };

            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService(); //subcriber
            var messageservice =new MessageService();//subcriber
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageservice.onVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadKey();

        }
    }

   
}
