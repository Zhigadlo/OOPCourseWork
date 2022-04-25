using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteSystem.Routes;
using ORMLibrary;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class DeleteStopWindow : Form
    {
        private MongoDBORM<Route> _routesORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        public DeleteStopWindow()
        {
            InitializeComponent();
            List<Stop> stops = Route.FindAllStops(_routesORM.ReadAll());
            StopsComboBox.Items.AddRange(stops.ToArray());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StopsComboBox.SelectedItem != null)
            {
                Stop stop = StopsComboBox.SelectedItem as Stop;
                _stopORM.Delete(stop.Id);
                List<Route> routes = _routesORM.ReadAll();
                foreach (Route route in routes)
                {
                    foreach (StopPoint stopPoint in route.StopPoints)
                    {
                        if (stopPoint.Stop.Equals(stop))
                        {
                            int id = route.Id;
                            route.StopPoints.Remove(stopPoint);
                            _routesORM.Update(id, route);
                            break;
                        }
                    }
                }

                MessageBox.Show("Остановка удалена", "Успех");
                Close();

            }
            else
                ErrorLabel.Visible = true;
        }
    }
}
