using MongoDB.Driver;
using MongoDB.Bson;
using ORMLibrary.Abstract;
using Newtonsoft.Json;
using MongoDB.Driver.Linq;

namespace ORMLibrary
{
    /// <summary>
    /// class for CRUD operation with mongodb
    /// </summary>
    public class MongoDBORM<T> where T : Entity
    {
        private static int _maxId;
        private IMongoDatabase _db;
        private string _collectionName;
        public MongoDBORM(string databaseName, string collectionName)
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            _db = mongoClient.GetDatabase(databaseName);
            _collectionName = collectionName;
            List<T> objects = ReadAll();
            foreach (var item in objects)
            {
                if(item.Id >= _maxId)
                    _maxId = item.Id;
            }
        }

        /// <summary>
        /// Write one object to database collection
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="obj"></param>
        /// <param name="database"></param>
        /// <param name="collectionName"></param>
        public void Write(T obj)
        {
            var collection = _db.GetCollection<T>(_collectionName);

            var items = ReadAll();
            if (items.Count == 0 && obj.Id != 0 || obj.Id != 0)
            {

            }
            else if (items.Count == 0)
            {
                obj.Id = 0;
            }
            else
            {
                obj.Id = _maxId + 1;
            }
            _maxId = obj.Id;
            
            collection.InsertOne(obj);
        }
        /// <summary>
        /// Read one object by id from database collection
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="id"></param>
        /// <param name="database"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public T Read(int id)
        {
            var collection = _db.GetCollection<BsonDocument>(_collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var doc = collection.Find(filter).First();
            var json = doc.ToJson();
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
        /// <summary>
        /// Read one object by propery value from database collection
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public T Read<TValue>(string property, TValue value)
        {
            var collection = _db.GetCollection<BsonDocument>(_collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(property, value);
            var doc = collection.Find(filter).First();
            var json = doc.ToJson();
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
        public bool Contains(string property, string value)
        {
            var collection = _db.GetCollection<BsonDocument>(_collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(property, value);
            try
            {
                var doc = collection.Find(filter).First();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        /// Read all objects from database collection
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="database"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public List<T> ReadAll()
        {
            List<T> list = new List<T>();
            var collection = _db.GetCollection<BsonDocument>(_collectionName);
            var documents = collection.Find(x => true).ToList();

            foreach (var doc in documents)
            {
                var json = doc.ToJson();
                list.Add(JsonConvert.DeserializeObject<T>(json));
            }

            return list;
        }
        /// <summary>
        /// Update object by id in database collection
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newObj"></param>
        public void Update(int id,T newObj)
        {
            newObj.Id = id;
            Delete(id);
            Write(newObj);
        }
        /// <summary>
        /// Delete one object by id from database collection
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="id"></param>
        /// <param name="database"></param>
        /// <param name="collectionName"></param>
        public void Delete(int id)
        {
            var collection = _db.GetCollection<T>(_collectionName);
            var filter = Builders<T>.Filter.Where(x => x.Id == id);
            collection.DeleteOne(filter);
        }

    }
}