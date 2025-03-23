using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2311104058
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (var video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            int index = 1;
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine($"Video {index} judul: {video.GetTitle()}");
                index++;
            }
        }
    }
}
