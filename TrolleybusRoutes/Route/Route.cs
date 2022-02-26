namespace Routes
{
    public class Route
    {
        public int NumberOfRoute { get; set; }
        private List<Stop> _stops;

        public Route(int numOfRoute, List<Stop> stops)
        {
            NumberOfRoute = numOfRoute;
            _stops = stops;
        }

        public string GetStops()
        {
            string ListOfStops = "";
            foreach (Stop stop in _stops)
            {
                ListOfStops += stop.ToString() + "\n";
            }

            return ListOfStops;
        }
    }
}
