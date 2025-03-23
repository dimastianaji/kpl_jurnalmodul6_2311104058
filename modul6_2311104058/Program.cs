using modul6_2311104058;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();
        SayaTubeUser user = new SayaTubeUser(username);

        List<string> filmTitles = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Masukkan judul film ke-{i + 1}: ");
            string filmTitle = Console.ReadLine();
            filmTitles.Add($"Review Film {filmTitle} oleh {username}");
        }

        foreach (string title in filmTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
