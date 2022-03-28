namespace Routes
{
    public class Stop
    {
        public string Name { get; set; }

        public Stop(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
