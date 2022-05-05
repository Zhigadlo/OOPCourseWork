using ORMLibrary;
using RouteSystem.Routes;
using System.Collections.Generic;
using Xunit;
using RouteSystem.Users;
using MongoDB.Driver;

namespace RouteTests
{
    public class ActionWithMongoDBTests
    {
        
        private MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("TestDatabase", "Routes", new MongoClient("mongodb://localhost:27017"));
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops", new MongoClient("mongodb://localhost:27017"));
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users", new MongoClient("mongodb://localhost:27017"));
        
        [Fact]
        public void WriteAndReadTest()
        {
            List<Stop> stops = new List<Stop>
            {
                new Stop("Солнечная"),
                new Stop("ТЦ Речицкий"),
                new Stop("Площадь Ленина"),
                new Stop("Рынок Привоз"),
                new Stop("Школа 12"),
                new Stop("Спорткомлекс")
            };

            List<Time> schedule11 = new List<Time>
            {
                new Time(8, 45),
                new Time(8, 50),
                new Time(8, 53)
            };

            List<Time> schedule12 = new List<Time>
            {
                new Time(9, 0),
                new Time(9, 5),
                new Time(9, 8)
            };

            List<Time> schedule13 = new List<Time>
            {
                new Time(11, 25),
                new Time(11, 30),
                new Time(11, 33)
            };

            List<StopPoint> stopPoints1 = new List<StopPoint>
            {
                new StopPoint(schedule11, stops[0]),
                new StopPoint(schedule12, stops[1]),
                new StopPoint(schedule13, stops[2]),
            };

            List<Time> schedule21 = new List<Time>
            {
                new Time(22, 45),
                new Time(22, 50),
                new Time(22, 53)
            };

            List<Time> schedule22 = new List<Time>
            {
                new Time(23, 0),
                new Time(23, 5),
                new Time(23, 8)
            };

            List<Time> schedule23 = new List<Time>
            {
                new Time(0, 5),
                new Time(0, 10),
                new Time(0, 13)
            };

            List<StopPoint> stopPoints2 = new List<StopPoint>
            {
                new StopPoint(schedule21, stops[3]),
                new StopPoint(schedule22, stops[4]),
                new StopPoint(schedule23, stops[5]),
            };


            List<Route> routes = new List<Route>
            {
                new Route(23, stopPoints1),
                new Route(14, stopPoints2)
            };

            foreach(var stop in stops)
                _stopORM.Write(stop);

            foreach(var route in routes)
                _routeORM.Write(route);

            foreach(var stop in stops)
            {
                Assert.True(stop.Equals(_stopORM.Read("Name", stop.Name)));
            }
            foreach(var route in routes)
            {
                Assert.True(route.Equals(_routeORM.Read("NumberOfRoute", route.NumberOfRoute)));
            }

            for(int i = 0; i < stops.Count; i++)
            {
                _stopORM.Delete(i);
            }

            for (int i = 0; i < routes.Count; i++)
            {
                _routeORM.Delete(i);
            }
        }
        [Fact]
        public void UpdateTest()
        {
            Stop stop = new Stop("остановка");

            _stopORM.Write(stop);

            stop.Name = "новая остановка";

            _stopORM.Update(0, stop);

            Assert.True(stop.Equals(_stopORM.Read("Name", "новая остановка")));

            _stopORM.Delete(0);
        }
    }
}