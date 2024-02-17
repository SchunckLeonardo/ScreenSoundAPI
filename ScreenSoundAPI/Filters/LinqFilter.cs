using ScreenSoundAPI.Models;
using System.Xml.Linq;

namespace ScreenSoundAPI.Filters;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var allGenres = musics.Select(music => music.Genre).Distinct().ToList();
        foreach (var genre in allGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistsByGenre(List<Music> musics, string genre)
    {
        var artistByGenre = musics
                                .Where(musics => musics.Genre!.Contains(genre))
                                .OrderBy(music => music.Artist)
                                .Select(music => music.Artist)
                                .Distinct()
                                .ToList();
        Console.WriteLine($"Artists with genre {genre}");
        foreach (var artist in artistByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicsByArtist(List<Music> musics, string artist)
    {
        var allMusicArtist = musics
                                .Where(music => music.Artist!.Equals(artist))
                                .OrderBy(music => music.Name)
                                .Select(music => music.Name)
                                .Distinct()
                                .ToList();
        Console.WriteLine($"All musics by {artist}");
        foreach (var music in allMusicArtist)
        {
            Console.WriteLine($"- {music}");
        }
    }

    public static Music FilterMusicsByName(List<Music> musics, string name)
    {
        var musicName = musics
                            .Where(music => music.Name!.Equals(name))
                            .First();
        return musicName;
    }

    public static void FilterMusicsByTone(List<Music> musics)
    {
        var musicTone = musics
                            .Where(music => music.Key.Equals(1))
                            .Distinct()
                            .ToList();
        Console.WriteLine($"All Musics with C# tone");
        foreach (var music in musicTone)
        {
            Console.WriteLine(music.Name);
            Console.WriteLine(music.Artist);
            Console.WriteLine(music.Tone + "\n");
        }
    }
}
