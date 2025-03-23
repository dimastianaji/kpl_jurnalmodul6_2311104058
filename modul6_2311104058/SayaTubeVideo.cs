using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2311104058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentException("Judul video tidak boleh null atau kosong");
            if (title.Length > 200) throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000) throw new ArgumentException("Play count harus antara 0 dan 25.000.000");
            checked
            {
                try
                {
                    playCount += count;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
