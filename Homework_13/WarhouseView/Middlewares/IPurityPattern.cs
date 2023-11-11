
public interface IPurityPattern
{
    string RedirectUrl { get; }
    string Message { get; }
    bool MatchFound(string path);
}

