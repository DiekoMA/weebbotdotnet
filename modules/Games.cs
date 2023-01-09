namespace weebbot.modules;


public class MessageTimer
{
    public static System.Timers.Timer? messageTimer;
    private static SocketInteractionContext _Context;

    public static void StartTimer(SocketInteractionContext context)
    {
        _Context = context;

        messageTimer = new System.Timers.Timer(10000);
        messageTimer.Elapsed += OnTimerElapsed;
        messageTimer.AutoReset = true;
        messageTimer.Enabled = true;
    }

    public static void StopTimer()
    {
        messageTimer?.Stop();
    }

    public static void OnTimerElapsed(object source, ElapsedEventArgs e)
    {
        _Context.Channel.SendMessageAsync("Time Up, you failed");
        Console.WriteLine("Test Message");
        StopTimer();
    }
}
public class Games : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("game-quiz", "A quiz game"), Alias("")]
    public async Task GameQuiz(GameAction game, QuizDifficulties difficulty)
    {
        switch (game)
        {
            case GameAction.Valorant:
                switch (difficulty)
                {
                    case QuizDifficulties.Easy:
                        await Context.Interaction.RespondAsync("Where is the eiffel towr located (You have 10 seconds.)");
                        MessageTimer.StartTimer(Context);
                        await Context.Interaction.RespondAsync("Easy");
                        break;

                    case QuizDifficulties.Normal:
                        await Context.Interaction.RespondAsync("Normal");
                        break;

                    case QuizDifficulties.Hard:
                        await Context.Interaction.RespondAsync("Hard");
                        break;

                    case QuizDifficulties.Extreme:
                        await Context.Interaction.RespondAsync("Extreme");
                        break;
                }
                break;

            case GameAction.Minecraft:
                switch (difficulty)
                {
                    case QuizDifficulties.Easy:
                        await Context.Interaction.RespondAsync("Easy");
                        break;

                    case QuizDifficulties.Normal:
                        await Context.Interaction.RespondAsync("Normal");
                        break;

                    case QuizDifficulties.Hard:
                        await Context.Interaction.RespondAsync("Hard");
                        break;

                    case QuizDifficulties.Extreme:
                        await Context.Interaction.RespondAsync("Extreme");
                        break;
                }
                break;
        }
    }

    [SlashCommand("anime-quiz", "An anime game quiz")]
    public async Task AnimeQuiz(QuizDifficulties difficulty)
    {
        switch (difficulty)
        {
            case QuizDifficulties.Easy:
                // IJikan jikan = new Jikan();
                // Random rnd = new Random();

                // var randomAnime = await jikan.GetAnimeAsync(rnd.Next(100));
                // await Context.Interaction.RespondAsync(randomAnime.Data.Title);

                // await Context.Interaction.RespondAsync(QuizHelper.Instance.GetRandomQuizQuestion().Question);
                break;

            case QuizDifficulties.Normal:

                await Context.Interaction.RespondAsync("Normal");
                break;

            case QuizDifficulties.Hard:
                await Context.Interaction.RespondAsync("Hard");
                break;

            case QuizDifficulties.Extreme:
                await Context.Interaction.RespondAsync("Extreme");
                break;
        }
    }
}

public enum GameAction
{
    [ChoiceDisplay("Valorant")]
    Valorant = 0,
    [ChoiceDisplay("Minecraft")]
    Minecraft = 1
}

public enum QuizDifficulties
{
    [ChoiceDisplay("Easy")]
    Easy = 0,
    [ChoiceDisplay("Normal")]
    Normal = 1,
    [ChoiceDisplay("Hard")]
    Hard = 2,
    [ChoiceDisplay("Extreme")]
    Extreme = 3
}
