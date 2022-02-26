namespace Routes
{
    public class Stop
    {
        public string Name { get; set; }
        private StopSchedule _weekdaySchedule;
        private StopSchedule _weekendsSchedule;


        public Stop(string Name, StopSchedule WeekdaySchedule, StopSchedule WeekendsSchedule)
        {
            this.Name = Name;
            _weekdaySchedule = WeekdaySchedule;
            _weekendsSchedule = WeekendsSchedule;
        }

        public string GetWeekdaySchedule()
        {
            return _weekdaySchedule.ToString();
        }

        public string GetWeekendsSchedule()
        {
            return _weekendsSchedule.ToString();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
