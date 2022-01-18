using Microsoft.AspNetCore.SignalR;

namespace AplikacjaLogujacaSignalR.Server.Hubs
{
    public class LoginHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
