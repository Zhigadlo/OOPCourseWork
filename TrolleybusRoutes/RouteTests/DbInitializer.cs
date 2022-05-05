using ORMLibrary;
using RouteSystem.Routes;
using RouteSystem.Users;
using System.Collections.Generic;
using System;
using System.Threading;

namespace RouteTests
{
    public class DbInitializer
    {
        public static void StopCollectionInitialize()
        {
            List<string> stopsName = new List<string>()
            {
                "Школа №55",
                "Красное", 
                "ОАО Гомельхимторг",
                "Улица Оськина",
                "Улица Ленинградская",
                "Школа №54",
                "КУП Горэлектротранспорт",
                "Костюковский лицей",
                "Жемчужная улица",
                "Улица Максима",
                "Улица Кунцевича",
                "Улица Серёгина",
                "Агрогородок Ерёмино",
                "Поворот на Большевик",
                "Пакалюбічы-пераезд",
                "Старое Село",
                "Давыдовка",
                "Торгово-экономический университет",
                "Улица Джураева",
                "Корпус литья",
                "Мотороремонтный завод",
                "Улица Полукруглая",
                "Улица Каленикова",
                "Колледж художественных промыслов",
                "Улица Бабушкина",
                "ГЗЛиН",
                "Улица Чернышевского",
                "Поворот на Большевик",
                "Улица Осипова",
                "ОАО Спецпромавтоматика",
                "Уза Беларусь",
                "Остановка Дорожник",
                "Весенняя улица",
                "Улица Нагорная",
                "Улица Малайчука",
                "Улица Оськина",
                "Завод Кристалл",
                "Газетный комплекс",
                "Улица Иванова",
                "Романовичи - Школа",
                "Радиозавод",
                "Храм Преображения",
                "Автовокзал",
                "Улица Головацкого",
                "Церковь",
                "Улица Чкалова",
                "Улица Нагорная",
                "Торговый дом Речицкий",
                "Полесская улица",
                "Переезд",
                "Гаражный кооператив №27",
                "Технический университет",
                "Улица Головацкого",
                "Гипермаркет",
                "Микрорайон Химы",
                "Поворот на ТЭЦ-2",
                "Переезд",
                "Рынок Заводской",
                "Улица Карбышева",
                "Вокзал",
                "Завод Гомельстройматериалы",
                "Сады Ромашка",
                "Технический университет",
                "Цирк",
                "Фабрика 8 Марта",
                "Универмаг",
                "Университет имени Франциска Скорины",
                "Гостиница Турист",
                "Рембыттехника",
                "Улица Тимофеенко",
                "Улица Чонгарской Дивизии",
                "КУП Горэлектротранспорт",
                "Завод Электроаппаратура",
                "БелГУТ",
                "Посёлок Юбилейный",
                "Остановка Улица Чонгарской дивизии",
                "Торгово-экономический университет",
                "Фабрика 8 Марта",
                "Универсам",
                "Молодёжная",
                "Нефтебаза",
                "Улица Федосеенко",
                "БелГУТ",
                "Микрорайон Старая Волотова",
                "Деревня Костюковка",
                "Улица Жукова",
                "Остановка Микрорайон Клёнковский",
                "Предприятие Салео-Гомель",
                "УП Белстеклопром",
                "Торговый центр ОМА",
                "Остановка общественного транспорта",
                "Улица Чечерская",
                "Лицей МЧС",
                "Улица Сурганова",
                "Улица Бакунина",
                "Центр радиационной медицины",
                "Приволье",
                "Госпиталь",
                "Остановка Улица Крупской",
                "Сосновка-2",
                "Улица Давыдовская",
                "Завод Центролит",
                "Улица Войсковая",
                "Улица Гагарина",
                "Центр радиационной медицины",
                "Улица Лазурная",
                "Остановка общественного транспорта",
                "Поворот на Прибор",
                "Улица Будённого",
                "Улица Свиридова",
                "Третья школа",
                "Улица Склезнёва",
                "Улица 70 лет БССР",
                "Деревня Костюковка",
                "Деревня Уза",
                "МЖК Солнечный",
                "По требованию",
                "Улица Чапаева",
                "Остановка ГБК",
                "Проспект Победы",
                "Микрорайон Давыдовка",
                "ОАО СтанкоГомель",
                "Ледовый дворец",
                "Посёлок Юбилейный",
                "Улица Пугачёва",
                "Остановка Гидропривод",
                "Улица Калача",
                "Медицинский колледж",
                "Лесная улица",
                "Лопатино-1",
                "Улица Ефремова",
                "Машиностроительный колледж",
                "Улица Луначарского",
                "Кореневка",
                "Университет имени Франциска Скорины",
                "Торговый центр Секрет",
                "Автоцентр Рено",
                "Технический университет им. П.О. Сухого"
            };

            MongoDBORM<Stop> stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");

            foreach(string stopName in stopsName)
                stopORM.Write(new Stop(stopName));
        }
        public static void UsersCollectionInitialize()
        {
            MongoDBORM<User> userORM = new MongoDBORM<User>("RouteSystem", "Users");

            int countOfUsers = 200;

            List<string> logins = new List<string>
            {
                "donovan",
                "Jotaro",
                "YourMom",
                "Tazik",
                "dedInside",
                "AUUUUGHHHH",
                "fortinaiti",
                "babidgi",
                "user",
                "KlimSanich",
                "maksim",
                "dhcxhjzdf",
                "bogUsop",
                "Gigached",
                "Suchoy",
                "jesus",
                "ben",
                "transformer"
            };

            List<string> passwords = new List<string>
            {
                "Abcde32443_",
                "Aboba&32782",
                "4522566@sobaka",
                "2j1jK5*f360fd"
            };

            Random random = new Random();
            int i = 0;
            while(i < countOfUsers)
            {
                Thread.Sleep(1);
                int loginId = random.Next(0, logins.Count - 1);
                int passwordId = random.Next(0, passwords.Count - 1);
                string newLogin = logins[loginId] + random.Next(0, 1000);

                if (userORM.Contains("Login", newLogin))
                    continue;

                userORM.Write(new User(newLogin, passwords[passwordId]));
                i++;
            }

        }
        public static void RoutesCollectionInitialize()
        {
            Thread.Sleep(1);
            MongoDBORM<Route> routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
            MongoDBORM<Stop> stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
            int routeCount = 20;
            List<Stop> stopList = stopORM.ReadAll();
            Random random = new Random();
            int j = 0;
            while(j < routeCount)
            {
                List<StopPoint> stopPoints = new List<StopPoint>();
                Thread.Sleep(1);
                int countOfStopPoints = random.Next(5, 20);

                for(int i = 0; i < countOfStopPoints; i++)
                {
                    Thread.Sleep(1);
                    List<Time> times = new List<Time>();
                    int countOfRoutes = random.Next(3, 10);
                    for(int z = 0; z < countOfRoutes; z++)
                    {
                        Thread.Sleep(1);
                        int hour = random.Next(0, 24);
                        Thread.Sleep(1);
                        int minute = random.Next(0, 60);
                        times.Add(new Time(hour, minute));
                    }
                    Thread.Sleep(1);
                    
                    stopPoints.Add(new StopPoint(times, stopList[random.Next(0, stopList.Count-1)]));
                }

                Route route = new Route(j+1, stopPoints);
                routeORM.Write(route);
                j++;
            }
        }
    }
}
