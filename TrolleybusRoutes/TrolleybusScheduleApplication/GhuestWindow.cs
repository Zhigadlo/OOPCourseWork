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
        private StartWindow _startWindow;
        private MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        private List<Route> _routes;
        public GhuestWindow(StartWindow startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();

            _routes = _routeORM.ReadAll();
            RouteBox.Items.AddRange(_routes.ToArray());

            var numbers = (from x in _routes.AsQueryable()
                           select x.NumberOfRoute.ToString()).ToArray();
            BoxForNumbers.Items.AddRange(numbers);
        }

        private void RouteBox_Click(object sender, EventArgs e)
        {
            var route = RouteBox.SelectedItem as Route;
            if (route != null)
            {
                StopBox.Visible = true;
                StopBox.Items.Clear();
                StopBox.Items.AddRange(route.StopPoints.ToArray());
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
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
    }
}
