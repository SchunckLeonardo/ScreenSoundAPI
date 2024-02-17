using ScreenSoundAPI.Models;

namespace ScreenSoundAPI.Filters;

internal class LinqOrder
{
    public static void OrderArtistName(List<Music> musics)
    {
        var allArtists = musics.OrderBy(music => music.Artist).Select(artist => artist.Artist).Distinct().ToList();
        Console.WriteLine("Artist's List Ordered");
        foreach (var artist in allArtists) 
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
