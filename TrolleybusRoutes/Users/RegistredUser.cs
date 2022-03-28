using Routes;

namespace Users
{
    public class RegistredUser : User
    {
        public RegistredUser(string Name, string Password) : base(Name, Password)
        {

        }

        public List<Route> GetRoutesBetweenStops(Stop startStop, Stop finalStop)
        {
            var routes = new List<Route>();
            return routes;
        }
    }
}
