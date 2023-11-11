namespace WarhouseView.Middlewares
{
    public class PurityPattern : IPurityPattern
    {
        public string[] BadWords = { "porn", "xxx", "nudity" };
        public string RedirectUrl => "https://www.christianity.com/";
        public string Message => "Watching porn is a sin, but Jesus still loves you!";

        public bool MatchFound(string path)
        {
            bool found = false;

            foreach(var word in BadWords)
            {
                if (path.ToLower().Contains(word))
                {
                    found = true;
                }
            }

            return found;
        }
    }
}