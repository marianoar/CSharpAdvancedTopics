using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("lanzo exception");
            } catch (Exception ex) 
            {
                throw new YouTubeException("error carga videos", ex);
            }
            return new List<Video>();
        }
    }
}
