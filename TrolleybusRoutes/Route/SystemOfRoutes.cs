using RouteSystem.Routes;

namespace RouteSystem
{
    public class SystemOfRoutes
    {
        public List<Route> Routes { get; set; }
        public List<Stop> Stops { get; set; }

        public SystemOfRoutes(List<Stop> stops, List<Route> routes)
        {
            Routes = routes;
            Stops = stops;
        }

        public List<int> GetRouteNumbersFromStop(Stop stop)
        {
            List<int> routeNumbers = new List<int>();
            foreach (Route route in Routes)
            {
                foreach (StopPoint stopPoints in route.StopPoints)
                {
                    if (stopPoints.Stop.Name == stop.Name)
                        routeNumbers.Add(route.NumberOfRoute);
                }
            }
            
            return routeNumbers;
        }
        public List<int> GetRoutesBetweenStops(Stop firstStop, Stop secondStop)
        {
            List<int> routeNumbers = new List<int>();

            foreach(Route route in Routes)
            {
                bool isFirstStop = false;
                bool isSecondStop = false;
                foreach(StopPoint stopPoint in route.StopPoints)
                {
                    if(stopPoint.Stop.Equals(firstStop) && !isSecondStop && !isFirstStop)
                    {
                        isFirstStop = true;
                    }

                    if(stopPoint.Stop.Equals(secondStop) && isFirstStop && !isSecondStop)
                    {
                        isSecondStop = true;
                    }

                    if (isFirstStop && isSecondStop)
                        routeNumbers.Add(route.NumberOfRoute);
                }
            }

            return routeNumbers;
        }
        

        public override string ToString()
        {
            return "SystemOfRoutes";
        }
        public override int GetHashCode()
        {
            return Routes.GetHashCode() + Stops.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not SystemOfRoutes)
                return false;
            else
            {
                SystemOfRoutes newObj = obj as SystemOfRoutes;
                return Stops.SequenceEqual(newObj.Stops) && Routes.SequenceEqual(newObj.Routes);
            }    
        }
    }
}
