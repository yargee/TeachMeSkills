namespace JokesParser
{
    internal class Program
    {
        static async Task Main()
        {
            await JokesReciever.Recieve();

            Menu.Start();
        }
    }
}
