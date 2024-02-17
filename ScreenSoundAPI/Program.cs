using ScreenSoundAPI.Filters;
using ScreenSoundAPI.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        //LinqFilter.FilterAllGenres(musics);
        //LinqOrder.OrderArtistName(musics);
        //LinqFilter.FilterArtistsByGenre(musics, "hip hop");
        LinqFilter.FilterMusicsByArtist(musics, "Imagine Dragons");
    } catch (Exception error)
    {
        Console.WriteLine($"Error Message: {error.Message}");
    }
}