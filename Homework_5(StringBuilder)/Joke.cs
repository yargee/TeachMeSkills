namespace JokesParser
{
    internal static class Joke
    {
        public static string? Value { get; private set; }

        public static void SetValue(string? value)
        {
            Value = value;
        }        
    }
}
