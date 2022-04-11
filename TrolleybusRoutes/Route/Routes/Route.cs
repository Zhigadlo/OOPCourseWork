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
                return newObj.NumberOfRoute == NumberOfRoute && StopPoints.SequenceEqual(newObj.StopPoints);
            }    
        }
    }
}
