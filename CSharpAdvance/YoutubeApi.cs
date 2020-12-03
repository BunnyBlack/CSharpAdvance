using System;
using System.Collections.Generic;

namespace CSharpAdvance
{
    public class YoutubeApi
    {
        public List<Video> GetVideos()
        {
            try
            {
                throw new Exception("Oops, some low level Youtube error.");
            }
            catch (Exception e)
            {
                
                throw new YoutubeException("Could not fetch videos from Youtube.", e);
            }
            
            return new List<Video>();
        }
    }
}