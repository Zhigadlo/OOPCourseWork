using ORMLibrary.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;

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

            foreach (Route route in routes)
            {
                foreach (StopPoint stopPoint in route.StopPoints)
                {
                    if (!stopList.Contains(stopPoint.Stop))
                    {
                        stopList.Add(stopPoint.Stop);
                    }
                }
            }

            return stopList;
        }
        public static List<Route> FindRoutesBetweenStops(Stop stop1, Stop stop2, List<Route> listOfRoutes)
        {
            List<Route> routes = new List<Route>();

            foreach (Route route in listOfRoutes)
            {
                bool first = false;
                bool second = false;
                foreach (StopPoint stopPoint in route.StopPoints)
                {

                    if (stopPoint.Stop.Name == stop1.Name && second == false)
                        first = true;

                    if (stopPoint.Stop.Name == stop2.Name && first == true)
                        second = true;
                }

                if (first && second)
                    routes.Add(route);
            }

            return routes;
        }
        public static void DeleteStopFromRoutes(List<Route> routes, Stop stop)
        {
            foreach(Route route in routes)
            {
                route.StopPoints.Where(x => x.Stop.Equals(stop)).ToList().ForEach(x => route.StopPoints.Remove(x));

                //foreach(StopPoint stopPoint in route.StopPoints)
                //{
                //    if(stopPoint.Stop.Equals(stop))
                //    {
                //        route.StopPoints.Remove(stopPoint);
                //    }
                //}
            }
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
