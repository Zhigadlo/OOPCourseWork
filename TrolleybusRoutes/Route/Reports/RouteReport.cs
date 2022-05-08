using RouteSystem.Routes;
using System.Xml;

namespace RouteSystem.Reports
{
    /// <summary>
    /// Class for creating reports
    /// </summary>
    public class RouteReport
    {
        public static void CreateRoutesReport(List<Route> routes, string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            path += "\\report.xml";
            XmlWriter writer = XmlWriter.Create(path, settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Routes");

            foreach(Route route in routes)
            {
                writer.WriteStartElement("Route");

                writer.WriteStartElement("NumberOfRoute");
                writer.WriteValue(route.NumberOfRoute);
                writer.WriteEndElement();

                writer.WriteStartElement("Stops");

                foreach(var stop in route.StopPoints)
                {
                    writer.WriteStartElement("Stop");
                    writer.WriteValue(stop.Stop.ToString());
                    writer.WriteEndElement();
                }    
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
        }
    }
}
