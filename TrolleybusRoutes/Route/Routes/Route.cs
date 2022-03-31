namespace RouteSystem.Routes
{
    public class Route
    {
        public int NumberOfRoute { get; set; }
        public List<StopPoint> StopPoints { get; }

        public Route(int numberOfRoute, List<StopPoint> stops)
        {
            NumberOfRoute = numberOfRoute;
            StopPoints = stops;
        }

        public override string ToString()
        {
            return NumberOfRoute.ToString();
        }
        public override int GetHashCode()
        {
            return NumberOfRoute.GetHashCode() + StopPoints.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not Route)
                return false;
            else
            {
                Route newObj = obj as Route;
                return newObj.NumberOfRoute == NumberOfRoute && StopPoints.SequenceEqual(newObj.StopPoints);
            }    
        }
    }
}
