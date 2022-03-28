namespace Routes
{
    public class StopPoint
    {
        public DateTime ListOfArriveTime { get; }
        public Stop CurrentStop { get; }
        public Stop NextStop { get; }
        public Route Route { get; }
        public StopPoint(DateTime ListOfArriveTime, Stop CurrentStop, Stop NextStop, Route Route)
        {
            this.ListOfArriveTime = ListOfArriveTime;
            this.CurrentStop = CurrentStop;
            this.NextStop = NextStop;
            this.Route = Route;
        }


    }
}