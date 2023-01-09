namespace weebbot.utils;

public sealed class Util
{
    private Util()
    {

    }
    private static readonly Lazy<Util> lazy = new Lazy<Util>(() => new Util());
    public static Util Instance
    {
        get
        {
            return lazy.Value;
        }
    }
    public static StringBuilder encrypt(String text, int s)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                char ch = (char)(((int)text[i] +
                                s - 65) % 26 + 65);
                result.Append(ch);
            }
            else
            {
                char ch = (char)(((int)text[i] +
                                s - 97) % 26 + 97);
                result.Append(ch);
            }
        }
        return result;
    }
}

