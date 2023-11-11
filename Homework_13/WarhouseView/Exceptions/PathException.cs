namespace WarhouseView.Exceptions
{
    [Serializable]
    public class PathException : Exception
    {
        public PathException(string message)
        : base(message) { }
    }
}
