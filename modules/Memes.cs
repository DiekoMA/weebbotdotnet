namespace weebbot.modules;

public class Memes : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("meme", "Gets a random meme")]
    public async Task GetMeme()
    {
        var mclient = new MemeClient();
        var meme = mclient.GetMeme();
        var memeEmbed = new EmbedBuilder()
        {
            Title = meme.Title,
            Description = $"From r/{meme.Subreddit}",
            Url = meme.PostLink,
            ImageUrl = meme.url,
            Footer = new EmbedFooterBuilder
            {
                Text = "Powered by meme-api.com"
            },
        };
        await Context.Interaction.RespondAsync(embed: memeEmbed.Build());
    }
    [SlashCommand("meme-from", "Gets a random meme")]
    public async Task GetMemeFrom(string subreddit)
    {
        var mclient = new MemeClient();
        var meme = mclient.GetMeme();
        var memeEmbed = new EmbedBuilder()
        {
            Title = meme.Title,
            Description = $"From r/{meme.Subreddit}",
            Url = meme.PostLink,
            ImageUrl = meme.url,
            Footer = new EmbedFooterBuilder
            {
                Text = "Powered by meme-api.com"
            },
        };
        await Context.Interaction.RespondAsync(embed: memeEmbed.Build());
    }

    [SlashCommand("animegif", "Gets a random meme")]
    public async Task GetAnimeGif(Categories category)
    {
        AnimeImageClient? aclient = null;
        AnimeImage? animeImage = null;
        switch (category)
        {
            case Categories.waifu:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.waifu);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.neko:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.neko);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.bully:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.bully);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.cuddle:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.cuddle);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.cry:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.cry);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.hug:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.hug);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.wink:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.wink);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.kiss:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.kiss);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.lick:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.lick);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.pat:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.pat);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.smug:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.smug);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.bonk:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.bonk);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.yeet:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.yeet);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.blush:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.blush);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.smile:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.smile);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.wave:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.wave);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.highfive:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.highfive);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.poke:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.poke);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.nom:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.nom);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.bite:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.bite);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.glomp:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.glomp);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.kill:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.kill);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.kick:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.kick);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
            case Categories.happy:
                aclient = new AnimeImageClient();
                animeImage = aclient.GetAnimeImage(AnimeImageCategories.happy);

                await Context.Interaction.RespondAsync(animeImage.Url);
                break;
        }

    }
}

public enum Categories
{
    [ChoiceDisplay("waifu")]
    waifu = 0,
    [ChoiceDisplay("neko")]
    neko = 1,
    [ChoiceDisplay("bully")]
    bully = 2,
    [ChoiceDisplay("cuddle")]
    cuddle = 3,
    [ChoiceDisplay("cry")]
    cry = 4,
    [ChoiceDisplay("hug")]
    hug = 5,
    [ChoiceDisplay("wink")]
    wink = 6,
    [ChoiceDisplay("kiss")]
    kiss = 7,
    [ChoiceDisplay("lick")]
    lick = 8,
    [ChoiceDisplay("pat")]
    pat = 9,
    [ChoiceDisplay("smug")]
    smug = 10,
    [ChoiceDisplay("bonk")]
    bonk = 11,
    [ChoiceDisplay("yeet")]
    yeet = 12,
    [ChoiceDisplay("blush")]
    blush = 13,
    [ChoiceDisplay("smile")]
    smile = 14,
    [ChoiceDisplay("wave")]
    wave = 15,
    [ChoiceDisplay("highfive")]
    highfive = 16,
    [ChoiceDisplay("poke")]
    poke = 17,
    [ChoiceDisplay("nom")]
    nom = 18,
    [ChoiceDisplay("bite")]
    bite = 19,
    [ChoiceDisplay("glomp")]
    glomp = 20,
    [ChoiceDisplay("slap")]
    slap = 21,
    [ChoiceDisplay("kill")]
    kill = 22,
    [ChoiceDisplay("kick")]
    kick = 23,
    [ChoiceDisplay("happy")]
    happy = 24,

}