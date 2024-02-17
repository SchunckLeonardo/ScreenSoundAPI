using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Music
{
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Music: {this.Name}");
        Console.WriteLine($"Artist: {this.Artist}");
        Console.WriteLine($"Duration: {this.Duration / 1000 / 60}");
        Console.WriteLine($"Genre: {this.Genre}");
    }

}
