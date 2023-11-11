namespace WarhouseView.Exceptions
{
    [Serializable]
    public class PurityException : Exception
    {
        public PurityException(string message)
        : base(message) { }
    }
}
