using AplikacjaLogujacaSignalR.Shared;
using Microsoft.AspNetCore.SignalR;

namespace AplikacjaLogujacaSignalR.Server.Hubs
{
    public class LoginHub : Hub
    {
        public async Task SendMessage(string Login, string Password)
        {
            Users users = new Users();
            List<User> usersList = users.getUsers();
            List<Tuple<string, string>> toSend = new List<Tuple<string, string>>();
            bool userExist = false;

            foreach (User user in usersList)
            {
                toSend.Add(new Tuple<string, string>(user.Login, user.Password));
            }
            
            User checkUser = new User(Login, Password);

            Console.WriteLine(checkUser.Login);
            Console.WriteLine(checkUser.Password);
            foreach(User user in usersList)
            {
                if (user.Login == Login && user.Password == Password)
                {
                    userExist = true;
                }
            }

            if (userExist)
            {
                await Clients.Caller.SendAsync("ReceiveMessage", toSend);
                //await Clients.Caller.SendAsync("SendUsers", usersList);
            }
            else
            {
                await Clients.Caller.SendAsync("WrongCredentials", userExist);
            }
        }
    }
}
//await Clients.Caller.SendAsync("ReceiveMessage", usersList[0].Login, message);
