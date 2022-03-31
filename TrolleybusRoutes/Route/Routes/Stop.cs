namespace RouteSystem.Routes
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
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not Stop)
                return false;
            else
            {
                Stop newObj = obj as Stop;
                return newObj.Name == Name;
            }
        }
    }

}
