namespace RouteSystem.Users
{
    public class Admin : User
    {
        public Admin(string Name, string Password) : base(Name, Password)
        {
            Role = Roles.Admin;
        }

        public void ChangeUserPassword(User user, string newPassword)
        {
            user.Password = newPassword;
        }

        public void ChangeUserRole(User user, Roles newRole)
        {
            user.Role = newRole;
        }
    }
}
