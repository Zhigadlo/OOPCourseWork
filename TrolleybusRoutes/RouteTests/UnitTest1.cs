using Xunit;
using RouteSystem.Routes;
using ORMLibrary;
using System.Collections.Generic;

namespace RouteTests
{
    public class UnitTest1
    {
        private MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");

        [Fact]
        public void Test1()
        {
            List<Stop> stops1 = new List<Stop>
            {
                new Stop("���������"),
                new Stop("�� ��������"),
                new Stop("������� ������")
            };
            
            List<Stop> stops2 = new List<Stop>
            {
                new Stop("����� ������"),
                new Stop("����� 12"),
                new Stop("������������")
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
                new StopPoint(schedule11, stops1[0]),
                new StopPoint(schedule12, stops1[1]),
                new StopPoint(schedule13, stops1[2]),
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
                new StopPoint(schedule21, stops2[0]),
                new StopPoint(schedule22, stops2[1]),
                new StopPoint(schedule23, stops2[2]),
            };

            Route route1 = new Route(23, stopPoints1);
            Route route2 = new Route(14, stopPoints2);
            Route expectedRoute1 = _routeORM.Read(0);
            Route expectedRoute2 = _routeORM.Read(1);
            Assert.True(route1.Equals(expectedRoute1));
            Assert.True(route2.Equals(expectedRoute2));
            
        }
    }
}