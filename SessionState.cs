public class SessionState
{
    public string? UserName { get; set; }
    public string? Email { get; set; }

    public bool IsRegistered => !string.IsNullOrWhiteSpace(Email);
}
