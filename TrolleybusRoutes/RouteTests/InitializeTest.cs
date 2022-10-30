using Xunit;

namespace RouteTests
{
    public class InitializeTest
    {
        // Запускать первым
        [Fact]
        public void InitializeUsers()
        {
           DbInitializer.UsersCollectionInitialize();
        }

        //запускать вторым
        [Fact]
        public void InitializeStops()
        {
            DbInitializer.StopCollectionInitialize();
        }

        //запускать третьим
        [Fact]
        public void InitializeRoutes()
        {
            DbInitializer.RoutesCollectionInitialize();
        }
    }
}
