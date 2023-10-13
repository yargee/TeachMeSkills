namespace JokesParser
{
    internal class JokesViewer
    {
        public static void View(IReadOnlyList<string> jokes)
        {
            var rnd = new Random(); 

            Console.WriteLine("\n" + jokes[rnd.Next(0, jokes.Count)] + "\n");
        }
    }
}
