using ORMLibrary.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RouteSystem.Routes
{
    public class Route : Entity
    {
        [BsonElement("NumberOfRoute")]
        public int NumberOfRoute { get; set; }
        [BsonElement("StopPoints")]
        public List<StopPoint> StopPoints { get; }

        public Route(int NumberOfRoute, List<StopPoint> StopPoints)
        {
            this.NumberOfRoute = NumberOfRoute;
            this.StopPoints = StopPoints;
        }

        public static List<Stop> FindAllStops(List<Route> routes)
        {
            List<Stop> stopList = new List<Stop>();

            foreach(Route route in routes)
            {
                foreach(StopPoint stopPoint in route.StopPoints)
                {
                    if (!stopList.Contains(stopPoint.Stop))
                    {
                        stopList.Add(stopPoint.Stop);
                    }
                }
            }

            return stopList;
        }
        public static List<Route> FindRoutesBetweenStops(Stop stop1, Stop stop2)
        {
            List<Route> routes = new List<Route>();

            foreach(Route route in routes)
            {
                Stop s1 = null;
                Stop s2 = null;
                foreach(StopPoint stopPoint in route.StopPoints)
                {
                    if (stopPoint.Stop.Equals(stop1))
                        s1 = stopPoint.Stop;

                    if (stopPoint.Stop.Equals(stop2))
                        s2 = stopPoint.Stop;
                }

                if (s1 != null && s2 != null)
                    routes.Add(route);
            }

            return routes;
        }
        public override string ToString()
        {
            return NumberOfRoute.ToString() + ":" + StopPoints[0].Stop.Name + "-" + StopPoints.Last().Stop.Name;
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
                if (newObj.NumberOfRoute != NumberOfRoute)
                    return false;

                if (!StopPoints.SequenceEqual(newObj.StopPoints))
                    return false;

                return  true;
            }    
        }
    }
}
