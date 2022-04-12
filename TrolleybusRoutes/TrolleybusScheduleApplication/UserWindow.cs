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

namespace TrolleybusScheduleApplication
{
    public partial class UserWindow : Form
    {
        protected StartWindow _startWindow;
        protected MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        protected List<Route> _routes;
        public UserWindow(StartWindow startWindow) 
        {
            _startWindow = startWindow;
            InitializeComponent();

            _routes = (from x in _routeORM.ReadAll().AsEnumerable()
                       orderby x.NumberOfRoute
                       select x).ToList();
            RouteBox.Items.AddRange(_routes.ToArray());

            var numbers = (from x in _routes.AsQueryable()
                           select x.NumberOfRoute.ToString()).ToArray();
            BoxForNumbers.Items.AddRange(numbers);
            List<Stop> stopList = Route.FindAllStops(_routes);

            StopComboBox1.Items.AddRange(stopList.ToArray());
            StopComboBox2.Items.AddRange(stopList.ToArray());
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _startWindow.Show();
                Close();
            }
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (BoxForNumbers.SelectedItem != null)
            {
                int number = Convert.ToInt32(BoxForNumbers.SelectedItem);

                Route route = _routes.Find(x => x.NumberOfRoute == number);
                ResultBox.Visible = true;
                ResultBox.Items.Clear();
                ResultBox.Items.AddRange(route.StopPoints.ToArray());
            }
            else
            {
                MessageBox.Show("Нет такого маршрута", "Ошибка");
            }
        }
        private void RouteBox_Click(object sender, EventArgs e)
        {
            var route = RouteBox.SelectedItem as Route;
            if (route != null)
            {
                ResultBox.Visible = true;
                ResultBox.Items.Clear();
                ResultBox.Items.AddRange(route.StopPoints.ToArray());
            }
        }

        private void ResultBox_Click(object sender, EventArgs e)
        {
            var stopPoint = ResultBox.SelectedItem as StopPoint;
            if (stopPoint != null)
            {
                string time = "";
                for (int i = 0; i < stopPoint.Schedule.Count; i++)
                {
                    if ((i + 1) % 4 == 0)
                        time += "\n";

                    time += stopPoint.Schedule[i].ToString() + " ";
                }

                MessageBox.Show(time, stopPoint.Stop.ToString());
            }
        }

        private void FindButton2_Click(object sender, EventArgs e)
        {
            Stop stop1 = StopComboBox1.SelectedItem as Stop;
            Stop stop2 = StopComboBox2.SelectedItem as Stop;
            var routes = Route.FindRoutesBetweenStops(stop1, stop2, _routes);
            if (routes.Count != 0 && stop1 != null && stop2 != null)
            {
                if (stop1.Name == stop2.Name)
                {
                    MessageBox.Show("Выберете разные остановки", "Ошибка");
                }
                else
                {
                    ResultBox.Visible = true;
                    ResultBox.Items.Clear();
                    ResultBox.Items.AddRange(routes.ToArray());
                }
            }
            else
            {
                MessageBox.Show("Нет таких маршрутов", "Ошибка");
            }
        }
    }
}
