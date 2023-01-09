namespace weebbot.API;

public class MemeClient
{
    const string apiBaseUrl = "https://meme-api.com/";

    private RestClient rstClient;

    public MemeClient()
    {
        rstClient = new RestClient();
    }

    public Meme GetMeme()
    {
        var request = new RestRequest(apiBaseUrl + "gimme", Method.Get);

        var response = rstClient.Execute(request);
        var MemeResponse = JsonConvert.DeserializeObject<Meme>(response.Content);
        return MemeResponse;
    }

    public Meme GetMemeFrom(string subreddit)
    {
        var request = new RestRequest(apiBaseUrl + $"gimme/{subreddit}", Method.Get);

        var response = rstClient.Execute(request);
        var MemeResponse = JsonConvert.DeserializeObject<Meme>(response.Content);
        return MemeResponse;
    }
}

public class AnimeImageClient
{
    const string apiBaseUrl = "https://api.waifu.pics/";

    private RestClient rstClient;

    public AnimeImageClient()
    {
        rstClient = new RestClient();
    }

    public AnimeImage GetAnimeImage(AnimeImageCategories category)
    {
        AnimeImage animeImage = null;
        RestResponse response = null;
        RestRequest request = null;
        switch (category)
        {
            case AnimeImageCategories.waifu:
                request = new RestRequest(apiBaseUrl + "sfw/" + "waifu", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.neko:
                request = new RestRequest(apiBaseUrl + "sfw/" + "neko", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.bully:
                request = new RestRequest(apiBaseUrl + "sfw/" + "bully", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.cuddle:
                request = new RestRequest(apiBaseUrl + "sfw/" + "cuddle", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.cry:
                request = new RestRequest(apiBaseUrl + "sfw/" + "cry", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.hug:
                request = new RestRequest(apiBaseUrl + "sfw/" + "hug", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.wink:
                request = new RestRequest(apiBaseUrl + "sfw/" + "wink", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.kiss:
                request = new RestRequest(apiBaseUrl + "sfw/" + "kiss", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.lick:
                request = new RestRequest(apiBaseUrl + "sfw/" + "lick", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.pat:
                request = new RestRequest(apiBaseUrl + "sfw/" + "pat", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.smug:
                request = new RestRequest(apiBaseUrl + "sfw/" + "smug", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.bonk:
                request = new RestRequest(apiBaseUrl + "sfw/" + "bonk", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.yeet:
                request = new RestRequest(apiBaseUrl + "sfw/" + "yeet", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.blush:
                request = new RestRequest(apiBaseUrl + "sfw/" + "blush", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.smile:
                request = new RestRequest(apiBaseUrl + "sfw/" + "smile", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.wave:
                request = new RestRequest(apiBaseUrl + "sfw/" + "wave", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.highfive:
                request = new RestRequest(apiBaseUrl + "sfw/" + "highfive", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.poke:
                request = new RestRequest(apiBaseUrl + "sfw/" + "poke", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.nom:
                request = new RestRequest(apiBaseUrl + "sfw/" + "nom", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.bite:
                request = new RestRequest(apiBaseUrl + "sfw/" + "bite", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.glomp:
                request = new RestRequest(apiBaseUrl + "sfw/" + "glomp", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.slap:
                request = new RestRequest(apiBaseUrl + "sfw/" + "slap", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.kill:
                request = new RestRequest(apiBaseUrl + "sfw/" + "kill", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.kick:
                request = new RestRequest(apiBaseUrl + "sfw/" + "kick", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;
            case AnimeImageCategories.happy:
                request = new RestRequest(apiBaseUrl + "sfw/" + "happy", Method.Get);

                response = rstClient.Execute(request);
                animeImage = JsonConvert.DeserializeObject<AnimeImage>(response.Content);
                break;

        }
        return animeImage;
    }
}

public enum AnimeImageCategories
{
    waifu,
    neko,
    bully,
    cuddle,
    cry,
    hug,
    awoo,
    kiss,
    lick,
    pat,
    smug,
    bonk,
    yeet,
    blush,
    smile,
    wave,
    highfive,
    handhold,
    nom,
    bite,
    glomp,
    slap,
    kill,
    kick,
    happy,
    wink,
    poke,
    dance,
    cringe
}