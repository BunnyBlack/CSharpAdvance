using System;

namespace CSharpAdvance
{
    public class MessageService
    {
        public void VideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message... {0}", e.Video.Title);
        }
    }
}