namespace SimpleChatBot.options;

public class SimpleChatBotHistoryDataServiceConfig
{
    public const string SectionName = "SimpleChatBotHistoryDataServiceConfig";
    public string ConnectionString { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
    public string CollectionName { get; set; } = string.Empty;
}
