namespace weebbot.modules;

public class Moderation : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("ban", "Bans the selected user from the server.")]
    [Discord.Commands.RequireUserPermission(GuildPermission.BanMembers)]
    public async Task BanUser(SocketGuildUser user, string banReason, int banTime)
    {
        var banEmbed = new EmbedBuilder
        {
            Title = $"{user.Username}#{user.Discriminator} has been banned",
            ImageUrl = user.GetAvatarUrl(),
            Description = $"{user.Username}#{user.Discriminator} has been banned for {banReason} by {Context.Interaction.User.Username}#{Context.Interaction.User.Discriminator}",
        };
        await Context.Interaction.RespondAsync(embed: banEmbed.Build());
        await user.BanAsync(banTime);
    }

    [SlashCommand("kick", "Kicks the selected user from the server.")]
    public async Task KickUser(SocketGuildUser user, string kickReason)
    {
        var kickEmbed = new EmbedBuilder
        {
            Title = $"{user.Username}#{user.Discriminator} has been kicked",
            ImageUrl = user.GetAvatarUrl(),
            Description = $"{user.Username}#{user.Discriminator} has been kicked for {kickReason} by {Context.Interaction.User.Username}#{Context.Interaction.User.Discriminator}",
        };
        await Context.Interaction.RespondAsync(embed: kickEmbed.Build());
        await user.KickAsync(kickReason);
    }

    [SlashCommand("prune", "Clears text from a text channel")]
    public async Task PruneContent(int amount)
    {
        var messages = await Context.Interaction.Channel.GetMessagesAsync(amount + 1).FlattenAsync();
        await ((SocketTextChannel)Context.Interaction.Channel).DeleteMessagesAsync(messages);

        await Context.Interaction.RespondAsync($"{amount} messages have been deleted from {Context.Channel.Name}.");
    }

    [SlashCommand("prune-channel", "Removes the selected channel and all of it's content")]
    public async Task RemoveChannel(SocketGuildChannel channel)
    {
        await Context.Interaction.RespondAsync($"{channel.Name} has been deleted");
        await channel.DeleteAsync();
    }

}
