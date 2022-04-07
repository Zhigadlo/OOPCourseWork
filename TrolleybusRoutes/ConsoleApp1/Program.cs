using ORMLibrary;
using RouteSystem.Routes;
using RouteSystem.Users;


List<Stop> stops = new List<Stop>
{
    new Stop("Солнечная"),
    new Stop("ТЦ Речицкий"),
    new Stop("Площадь Ленина")
};

//List<StopPoint> stopPoints = new List<StopPoint>
//{
//    new StopPoint(12, 11, stops[0]),
//    new StopPoint(12, 20, stops[1]),
//    new StopPoint(12, 35, stops[2])
//};

//var newRoute = new Route(23, stopPoints);
//var newRoute2 = new Route(24, stopPoints);
//var admin = new User("Zhigadlo", "MyPassword");
//admin.Role = Roles.Admin;
//var user = new User("DolbaebVitalya", "IamDolbaeb");
//user.Role = Roles.User;
//var routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
var stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
Stop newStop = new Stop("Хуй");
//stopORM.Write(stops[0]);
stopORM.Update(1, newStop);
Console.WriteLine();
//Route route = routeORM.Read(1);

//Console.WriteLine(route.NumberOfRoute);
//foreach (var stopPoint in route.StopPoints)
//{
//    Console.WriteLine("\t" + stopPoint.Stop);
//    Console.WriteLine("\t" + stopPoint.Hour + ":" + stopPoint.Minutes);
//}