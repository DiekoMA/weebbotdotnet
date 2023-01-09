namespace weebbot;

class Bot
{
    public static Task Main() => new Bot().MainAsync();

    public async Task MainAsync()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddYamlFile("config.yml")
            .Build();

        IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            services
            .AddSingleton(config)
            .AddSingleton(x => new DiscordSocketClient(new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.AllUnprivileged,
                AlwaysDownloadUsers = true
            }))
            .AddSingleton(x => new InteractionService(x.GetRequiredService<DiscordSocketClient>()))
            .AddSingleton<InteractionHandler>())
            .Build();

        await RunAsync(host);

    }

    public async Task RunAsync(IHost host)
    {
        IServiceScope serviceScope = host.Services.CreateScope();
        IServiceProvider provider = serviceScope.ServiceProvider;

        var _client = provider.GetRequiredService<DiscordSocketClient>();
        var sCommands = provider.GetRequiredService<InteractionService>();
        await provider.GetRequiredService<InteractionHandler>().InitializeAsync();
        var config = provider.GetRequiredService<IConfigurationRoot>();

        _client.Log += async (LogMessage msg) => { Console.WriteLine(msg.Message); };
        sCommands.Log += async (LogMessage msg) => { Console.WriteLine(msg.Message); };

        _client.Ready += async () =>
        {
            Console.WriteLine("Bot Ready");
            await sCommands.RegisterCommandsGloballyAsync();

            //This is just for style.
            var commandTable = new Table();
            commandTable.AddColumn("Command Name");
            commandTable.AddColumn(new TableColumn("Description").Centered());
            commandTable.AddColumn(new TableColumn("Module/Group").Centered());
            foreach (var slashCommand in sCommands.SlashCommands)
            {
                commandTable.AddRow(slashCommand.Name, slashCommand.Description, slashCommand.Module.Name);
            }
            AnsiConsole.Write(commandTable);
            //await sCommands.RegisterCommandsToGuildAsync(UInt64.Parse(config["Guild"]));
        };

        await _client.LoginAsync(TokenType.Bot, config["tokens:discord"]);
        await _client.StartAsync();

        await Task.Delay(-1);
    }
}