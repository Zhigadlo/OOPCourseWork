namespace RouteSystem.Users
{
    public class RegistredUser : User
    {
        public RegistredUser(string Name, string Password) : base(Name, Password)
        {
            Role = Roles.User;
        }
    }
}
