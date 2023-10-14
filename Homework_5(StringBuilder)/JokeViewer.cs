namespace JokesParser
{
    internal class JokesViewer
    {
        public static void View(IReadOnlyList<string> jokes)
        {
            var rnd = new Random(); 
            Joke.SetValue(jokes[rnd.Next(0, jokes.Count)]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + Joke.Value + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
