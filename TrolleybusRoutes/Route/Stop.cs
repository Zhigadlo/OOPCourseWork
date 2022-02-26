namespace Routes
{
    public class Stop
    {
        public string Name { get; private set; }
        public StopSchedule Schedule { get; private set; }

        public Stop(string Name, StopSchedule Schedule)
        {
            this.Name = Name;
            this.Schedule = Schedule;
        }
    }
}
