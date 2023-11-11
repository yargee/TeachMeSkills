namespace WarhouseView.Middlewares
{
    public interface IPurityPattern
    {
        public string RedirectUrl { get; set; }
        public string Message { get; set; }
        public bool MatchFound(string path);
    }
}
