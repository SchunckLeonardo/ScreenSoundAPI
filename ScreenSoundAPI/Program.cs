using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
    } catch (Exception error)
    {
        Console.WriteLine($"Error Message: {error.Message}");
    }
}