namespace weebbot.utils;

public sealed class QuizHelper
{
    private QuizHelper()
    {

    }
    private static readonly Lazy<QuizHelper> lazy = new Lazy<QuizHelper>(() => new QuizHelper());
    public static QuizHelper Instance
    {
        get
        {
            return lazy.Value;
        }
    }
    // public QuizQuestion GetRandomQuizQuestion()
    // {
    //     var config = new ConfigurationBuilder()
    //                 .SetBasePath(AppContext.BaseDirectory)
    //                 .AddYamlFile("config.yml")
    //                 .Build();

    //     var client = new MongoClient(config["MongoDB:connectionString"]);

    //     var database = client.GetDatabase("quizdb");
    //     var collection = database.GetCollection<BsonDocument>("valorant-easy");


    //     // var question = new QuizQuestion
    //     // {
    //     //     Question = document.ToString(),
    //     //     Answer = ""
    //     // };
    //     return question;
    // }
}
