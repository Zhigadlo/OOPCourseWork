namespace RouteSystem.Routes
{
    public class StopPoint
    {
        public DateTime ArriveTime { get; }
        public Stop CurrentStop { get; }
        public StopPoint(DateTime ArriveTime, Stop CurrentStop)
        {
            this.ArriveTime = ArriveTime;
            this.CurrentStop = CurrentStop;
        }

        public override string ToString()
        {
             return CurrentStop.ToString() + ": " + ArriveTime.ToShortTimeString();
        }
        public override int GetHashCode()
        {
            return ArriveTime.GetHashCode() + CurrentStop.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not StopPoint)
                return false;
            else
            {
                StopPoint newObj = obj as StopPoint;
                return newObj.ArriveTime == ArriveTime && newObj.CurrentStop == CurrentStop;
            }
        }
    }
}