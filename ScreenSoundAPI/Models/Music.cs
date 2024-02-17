using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Music
{
    private List<string> tones = new()
    {
        "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
    };
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tone
    {
        get
        {
            return this.tones[this.Key];
        }
    }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Music: {this.Name}");
        Console.WriteLine($"Artist: {this.Artist}");
        Console.WriteLine($"Duration: {this.Duration / 1000 / 60}");
        Console.WriteLine($"Genre: {this.Genre}");
        Console.WriteLine($"Tone: {this.Tone}");
    }

}
