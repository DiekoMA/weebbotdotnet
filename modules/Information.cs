namespace weebbot.modules;

public class Information : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("hello", "responds to you")]
    public async Task SayHI()
    {
        await Context.Interaction.RespondAsync("Hi");
    }

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
}
