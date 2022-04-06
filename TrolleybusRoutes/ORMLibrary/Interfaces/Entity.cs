using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ORMLibrary.Interfaces
{
    public abstract class Entity
    {
        [BsonId]
        [JsonProperty("_id")]
        internal int Id
        {
            get
            {
                return GetHashCode();
            }
        }
    }
}
