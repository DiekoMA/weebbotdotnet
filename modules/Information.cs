using RequireOwner = Discord.Interactions.RequireOwnerAttribute;

namespace weebbot.modules;

public class Information : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("serverinfo", "Gives information about the server")]
    public async Task GetServerInfo()
    {
        var serverEmbed = new EmbedBuilder()
        {
            Title = Context.Guild.Name,
            Description = Context.Guild.Description,
            ThumbnailUrl = Context.Guild.IconUrl,
            Author = new EmbedAuthorBuilder { Name = Context.User.Username },
            Fields = new List<EmbedFieldBuilder>()
            {
                new EmbedFieldBuilder{Name = "Created at", Value = Context.Guild.CreatedAt.Date},
                new EmbedFieldBuilder{Name = "Server ID", Value = Context.Guild.Id},
                new EmbedFieldBuilder{Name = "Users", Value = String.Join(separator: ", ", values: Context.Guild.Users.Select( u => u.Mention))},
                new EmbedFieldBuilder{Name = "Roles", Value = String.Join(separator: ", ", values: Context.Guild.Roles.Select( r => r.Mention))}
            }
        };
        await Context.Interaction.RespondAsync(embed: serverEmbed.Build());
    }

    [SlashCommand("userinfo", "Gives information about a specific user")]
    public async Task GetUserInfo(SocketGuildUser user)
    {
        var userEmbed = new EmbedBuilder()
        {
            Title = "User Info",
            ThumbnailUrl = user.GetAvatarUrl(),
            Author = new EmbedAuthorBuilder { Name = user.Username },
            Fields = new List<EmbedFieldBuilder>()
            {
                new EmbedFieldBuilder{Name = "Created at", Value = user.CreatedAt.Date},
                new EmbedFieldBuilder{Name = "User ID", Value = user.Id},
                new EmbedFieldBuilder{Name = "Roles", Value = String.Join(separator: ", ", values: user.Roles.Select( r => r.Mention))}
            }
        };

        await Context.Interaction.RespondAsync(embed: userEmbed.Build());
    }

    [SlashCommand("league", "...")]
    public async Task BanLeaguePlayers()
    {
        foreach (var user in Context.Guild.Users)
        {
            foreach (var activity in user.Activities)
            {
                if (activity.Type == ActivityType.Playing && activity.Details == "Spelunky 2")
                {
                    await Context.Interaction.RespondAsync("This is a test command to show that Mayo is playing code");
                }
            }
        }
    }

    [RequireOwner]
    [SlashCommand("encrypt", "...")]
    public async Task EncryptWithCipher(string text)
    {
        var encryptedtext = Util.encrypt(text, 4);
        await Context.Interaction.RespondAsync($"{encryptedtext}");
    }
}
