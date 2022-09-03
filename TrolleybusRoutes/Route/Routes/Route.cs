using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ORMLibrary.Abstract;

namespace RouteSystem.Routes
{
    /// <summary>
    /// Class for trolleybus routes
    /// </summary>
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

        /// <summary>
        /// Finds routes between two stops
        /// </summary>
        /// <param name="stop1"></param>
        /// <param name="stop2"></param>
        /// <param name="listOfRoutes">list of routes to search</param>
        /// <returns></returns>
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
            if (obj == null || obj is not Route)
                return false;
            else
            {
                Route newObj = obj as Route;
                if (newObj.NumberOfRoute != NumberOfRoute)
                    return false;

                if (!StopPoints.SequenceEqual(newObj.StopPoints))
                    return false;

                return true;
            }
        }
    }
}
