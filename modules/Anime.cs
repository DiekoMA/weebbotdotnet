namespace weebbot.modules;

public class Anime : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("anime", "Searches for a specific anime an returns results")]
    public async Task SearchAnime(string Name)
    {
        IJikan jikan = new Jikan();

        var results = await jikan.SearchAnimeAsync(Name);
        var components = new ComponentBuilder()
            .WithButton("1")
            .WithButton("2")
            .WithButton("3")
            .WithButton("4")
            .WithButton("5")
            .WithButton("6")
            .WithButton("7")
            .WithButton("8")
            .WithButton("9")
            .WithButton("10")
            .WithButton("11")
            .WithButton("12");
        await Context.Interaction.RespondAsync($"``` {String.Join(separator: "\n ", values: results.Data.Select(a => a.Title))}```", components: components.Build());
    }
}
