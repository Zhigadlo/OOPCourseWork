using MongoDB.Bson.Serialization.Attributes;
using ORMLibrary.Abstract;

namespace RouteSystem.Routes
{
    /// <summary>
    /// Class for time of trolleybus arrive
    /// </summary>
    public class Time : Entity
    {
        [BsonElement("Hour")]
        public int Hour { get; set; }
        [BsonElement("Minute")]
        public int Minute { get; set; }

        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public static bool operator ==(Time time1, Time time2)
        {
            return time1.Equals(time2);
        }
        public static bool operator !=(Time time1, Time time2)
        {
            return !time1.Equals(time2);
        }
        public static bool operator >(Time time1, Time time2)
        {
            int minutes1 = time1.Minute + time1.Hour * 60;
            int minutes2 = time2.Minute + time2.Hour * 60;
            return minutes1 > minutes2;
        }
        public static bool operator <(Time time1, Time time2)
        {
            int minutes1 = time1.Minute + time1.Hour * 60;
            int minutes2 = time2.Minute + time2.Hour * 60;
            return minutes1 < minutes2;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Time)
                return false;
            else
            {
                var newObj = obj as Time;
                if (newObj.Hour != Hour)
                    return false;

                if (newObj.Minute != Minute)
                    return false;

                return true;
            }
        }
        public override int GetHashCode()
        {
            return Hour.GetHashCode() + Minute.GetHashCode();
        }
        public override string ToString()
        {
            string hour = Hour.ToString();
            string minute = Minute.ToString();
            if (Hour < 10)
                hour = "0" + hour;

            if (Minute < 10)
                minute = "0" + minute;

            return hour + ":" + minute;
        }
    }
}
