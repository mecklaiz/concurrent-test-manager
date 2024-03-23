namespace manager_service.Models;

public class LogMessage
{
    public string Timestamp { get; set; } = DateTimeOffset.Now.ToString("u");
    public string Message { get; set; } = "Default";
}

