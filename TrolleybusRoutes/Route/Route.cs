namespace Routes
{
    public class Route
    {
        public int NumberOfRoute { get; set; }
        public Stop FirstStop { get; }
        public Stop LastStop { get; }

        public Route(int numberOfRoute, Stop firstStop, Stop lastStop)
        {
            NumberOfRoute = numberOfRoute;
            FirstStop = firstStop;
            LastStop = lastStop;
        }

        public override string ToString()
        {
            return NumberOfRoute.ToString();
        }
    }
}
