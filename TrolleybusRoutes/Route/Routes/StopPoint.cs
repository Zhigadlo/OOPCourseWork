using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RouteSystem.Routes
{
    /// <summary>
    /// Class that contains stop and its schedule
    /// </summary>
    public class StopPoint
    {
        [BsonElement("Schedule")]
        public List<Time> Schedule { get; set; }
        [BsonElement("Stop")]
        public Stop Stop { get; }
        public StopPoint(List<Time> Schedule, Stop Stop)
        {
            this.Schedule = Schedule;
            this.Stop = Stop;
        }

        public override string ToString()
        {
            return Stop.ToString();
        }
        public override int GetHashCode()
        {
            return Schedule.GetHashCode() + Stop.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not StopPoint)
                return false;
            else
            {
                StopPoint newObj = obj as StopPoint;
                if (!Schedule.SequenceEqual(newObj.Schedule))
                    return false;

                if (!newObj.Stop.Equals(Stop))
                    return false;

                return true;
            }
        }
    }
}