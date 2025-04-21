using System.Text.Json.Serialization;

namespace MonkeyFinder.Model;

public class Monkey
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Location")]
    public string Location { get; set; }

    [JsonPropertyName("Details")]
    public string Details { get; set; }

    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [JsonPropertyName("Population")]
    public int Population { get; set; }

    [JsonPropertyName("Latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("Longitude")]
    public double Longitude { get; set; }
}
