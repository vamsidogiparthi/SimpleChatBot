namespace SimpleChatBot.options;

public class OpenAIConfiguration
{
    public const string SectionName = "OpenAIConfiguration";
    public string ApiKey { get; set; } = string.Empty;
    public string ApiUrl { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int MaxTokens { get; set; } = 1000;
    public double Temperature { get; set; } = 0.7;
    public double TopP { get; set; } = 1.0;
    public int N { get; set; } = 1;
    public bool Stream { get; set; } = false;
}
