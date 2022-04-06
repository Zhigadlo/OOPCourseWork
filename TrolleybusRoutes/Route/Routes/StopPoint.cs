using ORMLibrary.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RouteSystem.Routes
{
    public class StopPoint : Entity
    {
        [BsonElement("Hour")]
        public int Hour { get; }
        [BsonElement("Minutes")]
        public int Minutes { get; }
        [BsonElement("Stop")]
        public Stop Stop { get; }
        public StopPoint(int Hour, int Minutes, Stop Stop)
        {
            this.Hour = Hour;
            this.Minutes = Minutes;
            this.Stop = Stop;
        }

        public override string ToString()
        {
             return Stop.ToString() + ": " + Hour.ToString() + ":" + Minutes.ToString();
        }
        public override int GetHashCode()
        {
            return Hour.GetHashCode() + Stop.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not StopPoint)
                return false;
            else
            {
                StopPoint newObj = obj as StopPoint;
                return newObj.Hour == Hour && newObj.Stop == Stop;
            }
        }
    }
}