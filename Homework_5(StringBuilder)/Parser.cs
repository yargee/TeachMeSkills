using System.Text;
using System.Text.RegularExpressions;

namespace JokesParser
{
    internal class Parser
    {
        public static IReadOnlyList<string> RemoveExcessSymbols(string s)
        {
            var sb = new StringBuilder();
            var jokePattern = @"<div class=""text"">(.*?)</div>";
            var tagPattern = "<.*?>";
            var result = new List<string>();

            MatchCollection matches = Regex.Matches(s, jokePattern);

            foreach ( Match match in matches )
            {
                result.Add(Regex.Replace(match.Value, tagPattern, ""));
            }

            return result;
        }
    }
}
