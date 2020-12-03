using System;

namespace CSharpAdvance
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}