namespace AplikacjaLogujacaSignalR.Shared
{
    public class User
    {
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string login, string pass)
        {
            this.login = login;
            this.password = pass;
        }
    }
}
