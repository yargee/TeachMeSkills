using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    internal class Test
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("https://www.anekdot.ru/best/anekdot/1013/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                var sb = new StringBuilder(responseBody);
                string remove = "";
                
                foreach(var c in sb.ToString())
                {
                    if (c == '<')
                    {
                        remove = "";
                        remove += c;
                    }
                    else if(c == '>')
                    {
                        remove += c;
                        sb.Replace(remove, "");
                        remove = "";
                    }
                    else
                    {
                        remove += c;                        
                        continue;
                    }

                    if ((c >= 'a') && (c <= 'z') || (c >= 'A') && (c <= 'Z'))
                    {
                        sb.Replace(c, ' ');
                    }
                }

                Console.WriteLine(sb.ToString());
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
