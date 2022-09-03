using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ORMLibrary.Abstract;

namespace RouteSystem.Routes
{
    /// <summary>
    /// Class for stop
    /// </summary>
    public class Stop : Entity
    {
        [BsonElement("Name")]
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
            char[] charArray = Name.ToCharArray();

            int hashCode = 0;
            foreach (char c in charArray)
            {
                hashCode += Convert.ToInt32(c);
            }

            return hashCode;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Stop)
                return false;
            else
            {
                Stop newObj = obj as Stop;

                if (newObj.Name != Name)
                    return false;
                else
                    return true;
            }
        }
    }

}
