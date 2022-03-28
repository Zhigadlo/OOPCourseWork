using Routes;

namespace Users
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            Role = Roles.User;
        }
        public List<Stop> GetListOfStopsByNumberOfRoute(int numberOfRoute)
        {
            List<Stop> stops = new List<Stop>();
            return stops;
        }
    }
}