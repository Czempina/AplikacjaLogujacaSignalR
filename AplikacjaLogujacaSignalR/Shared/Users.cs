namespace AplikacjaLogujacaSignalR.Server
{
    public class Users
    {
        public List<User> users = new List<User>()
        {
            new User("pierwszy", "1"),
            new User("drugi", "1"),
            new User("trzeci", "1"),
            new User("czwarty", "1"),
        };

        public List<User> getUsers()
        {
            return users;
        }
    }
}
