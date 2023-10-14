namespace JokesParser
{
    internal class JokesReciever
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task Recieve()
        {
            try
            {
                using HttpResponseMessage response = await _client.GetAsync("https://www.anekdot.ru/random/anekdot/");
                response.EnsureSuccessStatusCode();
                string htmlResult = await response.Content.ReadAsStringAsync();

                var result = Parser.RemoveExcessSymbols(htmlResult);
                                
                JokesViewer.View(result);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
