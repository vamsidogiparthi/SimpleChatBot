namespace SimpleChatBot.hubs;

using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

public interface IChatClient
{
    Task ReceiveMessage(string user, string message);
}

public class ChatHub(ILogger<ChatHub> logger) : Hub<IChatClient>
{
    public async Task SendMessage(string user, string message)
    {
        logger.LogInformation("Received message from {User}: {Message}", user, message);

        // Process the message using the brain

        // Send the response back to the client
        await Clients.All.ReceiveMessage(user, "Message received: " + message);
    }
}
