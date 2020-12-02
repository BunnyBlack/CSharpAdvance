using System;
using System.Threading;

namespace CSharpAdvance
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs {Video = video});
        }
    }
}