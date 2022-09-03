using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ORMLibrary.Abstract
{
    public abstract class Entity
    {
        [BsonId]
        [JsonProperty("_id")]
        public int Id { get; internal set; }
    }
}
