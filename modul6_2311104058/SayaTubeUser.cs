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
            if (string.IsNullOrEmpty(username)) throw new ArgumentException("Username tidak boleh null atau kosong");
            if (username.Length > 100) throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null) throw new ArgumentNullException("Video tidak boleh null");
            if (video.GetPlayCount() >= int.MaxValue) throw new ArgumentException("Play count video melebihi batas integer");
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
                if (index > 8) break;
                Console.WriteLine($"Video {index} judul: {video.GetTitle()}");
                index++;
            }
        }
    }
}
