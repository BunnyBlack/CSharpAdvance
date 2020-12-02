using System;

namespace CSharpAdvance
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an email... {0}", e.Video.Title);
        }
    }
}