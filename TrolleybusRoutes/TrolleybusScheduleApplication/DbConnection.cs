using MongoDB.Driver;
using System.Configuration;

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
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            _mongoClient = new MongoClient(settings["mongodb"].ConnectionString);
        }

        public MongoClient GetClient()
        {
            return _mongoClient;
        }
    }
}
