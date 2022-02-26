namespace Routes
{
    public class StopSchedule
    {
        public List<DateTime> ListOfArriveTime { get; private set; }
        public List<DateTime> ReverseListOfArriveTime { get; private set; }
        public StopSchedule(List<DateTime> ListOfArriveTime)
        {
            this.ListOfArriveTime = ListOfArriveTime;
            ReverseListOfArriveTime = this.ListOfArriveTime;
            ReverseListOfArriveTime.Reverse();
        }

    }
}