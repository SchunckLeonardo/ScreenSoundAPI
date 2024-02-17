using System.Text.Json;

namespace ScreenSoundAPI.Models;

internal class FavoriteMusic
{
    public string? Name { get; set; }
    public List<Music> MusicList {  get; }

    public FavoriteMusic(string? name)
    {
        this.Name = name;
        this.MusicList = new();
    }

    public void AddFavoriteMusic(Music music)
    {
        this.MusicList.Add(music);
    }

    public void ShowFavoritesMusics()
    {
        Console.WriteLine($"{this.Name}'s Favorites Musics");
        foreach (Music music in this.MusicList)
        {
            Console.WriteLine($"- {music.Name} by {music.Artist}");
        }
    }

    public void GenerateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = this.Name,
            musics = this.MusicList
        });
        string fileName = $"favorite-musics-{this.Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"Succesfully file created! {Path.GetFullPath(fileName)}");
    }
}
