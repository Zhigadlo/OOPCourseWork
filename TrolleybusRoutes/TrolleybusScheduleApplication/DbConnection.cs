using MongoDB.Driver;

namespace TrolleybusScheduleApplication
{
    public class DbConnection
    {
        private MongoClient _mongoClient;
        private static DbConnection _instance;

        public static DbConnection Instance
        {
            get { return _instance; }
        }
        
        static DbConnection()
        {
            _instance = new DbConnection();
        }

        private DbConnection()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
        }

        public MongoClient GetClient()
        {
            return _mongoClient;
        }
    }
}
