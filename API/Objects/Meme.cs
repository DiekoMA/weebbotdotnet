namespace weebbot.API.Objects;

public class Meme
{
    [JsonProperty("postLink")]
    public string PostLink { get; set; }
    [JsonProperty("subreddit")]
    public string Subreddit { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("url")]
    public string url { get; set; }
    [JsonProperty("nsfw")]
    public bool NSFW { get; set; }
    [JsonProperty("spoiler")]
    public bool Spoiler { get; set; }
    [JsonProperty("author")]
    public string Author { get; set; }
}
