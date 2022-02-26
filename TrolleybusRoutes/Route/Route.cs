namespace Routes
{
    public class Route
    {
        public int NumberOfRoute { get; set; }
        public List<Stop> Stops { get; private set; }

        public Route(int numOfRoute, List<Stop> stops)
        {
            NumberOfRoute = numOfRoute;
            Stops = stops;
        }
    }
}
