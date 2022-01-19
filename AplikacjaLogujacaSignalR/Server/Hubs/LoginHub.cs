using Microsoft.AspNetCore.SignalR;

namespace AplikacjaLogujacaSignalR.Server.Hubs
{
    public class LoginHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Users users = new Users();
            List<User> usersList = users.getUsers();
            //await Clients.All.SendAsync("ReceiveMessage", usersList[0].Login, message);
            await Clients.Caller.SendAsync("ReceiveMessage", usersList[0].Login, message);
        }
    }
}
