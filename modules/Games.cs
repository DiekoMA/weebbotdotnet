namespace weebbot.modules;

public class Games : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("ny23", "...")]
    public async Task NewYears()
    {

        if (DateTime.Now != new DateTime(2023, 1, 1))
        {
            var message = await Context.Channel.SendMessageAsync("3");
            await message.ModifyAsync(msg => msg.Content = "2");
            await message.ModifyAsync(msg => msg.Content = "1");
            await message.ModifyAsync(msg => msg.Content = "Happy New Years!!!");
            await Context.Interaction.RespondWithFileAsync(@"C:\Users\dieko\Documents\Projects\Discord Bot Projects\weebbot\assets\ny-278.gif");
        }
        else
        {

        }
    }
}
