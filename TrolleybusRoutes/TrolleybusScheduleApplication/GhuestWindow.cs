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
    public partial class GhuestWindow : Form
    {
        protected Form _startWindow;
        protected MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        protected List<Route> _routes;
        public GhuestWindow(Form startWindow)
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
        }

        protected void RouteBox_Click(object sender, EventArgs e)
        {
            var route = RouteBox.SelectedItem as Route;
            if (route != null)
            {
                StopBox.Visible = true;
                StopBox.Items.Clear();
                StopBox.Items.AddRange(route.StopPoints.ToArray());
            }
        }
        protected void FindButton_Click(object sender, EventArgs e)
        {
            if(BoxForNumbers.SelectedItem != null)
            {
                int number = Convert.ToInt32(BoxForNumbers.SelectedItem);

                Route route = _routes.Find(x => x.NumberOfRoute == number);
                StopBox.Visible = true;
                StopBox.Items.Clear();
                StopBox.Items.AddRange(route.StopPoints.ToArray());
            }
            else
            {
                MessageBox.Show("Нет такого маршрута", "Ошибка");
            }
        }
        protected void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _startWindow.Show();
                Close();
            }
        }

        private void StopBox_Click(object sender, EventArgs e)
        {
            var stopPoint = StopBox.SelectedItem as StopPoint;
            if(stopPoint != null)
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
    }
}
