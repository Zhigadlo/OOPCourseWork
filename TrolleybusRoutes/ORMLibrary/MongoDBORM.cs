using MongoDB.Driver;
using MongoDB.Bson;
using ORMLibrary.Interfaces;
using Newtonsoft.Json;
using MongoDB.Driver.Linq;

namespace ORMLibrary
{
    public class MongoDBORM
    {
        public static void WriteData<T>(T obj, string database, string collectionName) where T : Entity
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");

            var db = mongoClient.GetDatabase(database);

            var collection = db.GetCollection<T>(collectionName);

            collection.InsertOne(obj);
        }

        public static T Read<T>(int id, string database, string collectionName) where T: Entity
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase(database);

            var collection = db.GetCollection<T>(collectionName);

            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            var doc = collection.Find(filter);
            
            var json = doc.ToJson();
            T obj = JsonConvert.DeserializeObject<T>(json);

            return obj;
        }

        public static List<T> ReadAll<T>(string database, string collectionName)
        {
            List<T> list = new List<T>();

            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase(database);

            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);

            var documents = collection.Find(x => true).ToList();

            foreach (var doc in documents)
            {
                var json = doc.ToJson();
                list.Add(JsonConvert.DeserializeObject<T>(json));
            }

            return list;
        }

        public static void Update<T>(int id, T newObj, string database, string collectionName) where T : Entity
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase(database);
            var collection = db.GetCollection<T>(collectionName);
        }

    }
}