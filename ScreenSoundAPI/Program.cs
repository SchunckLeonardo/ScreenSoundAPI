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
        //LinqFilter.FilterMusicsByArtist(musics, "Justin Bieber");

        FavoriteMusic leoAlbum = new("Leo");
        leoAlbum.AddFavoriteMusic(LinqFilter.FilterMusicsByName(musics, "Believer"));
        leoAlbum.AddFavoriteMusic(LinqFilter.FilterMusicsByName(musics, "Demons"));
        leoAlbum.AddFavoriteMusic(LinqFilter.FilterMusicsByName(musics, "Natural"));
        leoAlbum.AddFavoriteMusic(LinqFilter.FilterMusicsByName(musics, "Mockingbird"));
        leoAlbum.AddFavoriteMusic(LinqFilter.FilterMusicsByName(musics, "Love Yourself"));

        leoAlbum.ShowFavoritesMusics();

        LinqFilter.FilterMusicsByTone(musics);

    } catch (Exception error)
    {
        Console.WriteLine($"Error Message: {error.Message}");
    }
}