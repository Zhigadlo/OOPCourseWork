using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMLibrary;
using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class RouteManageWindow : Form
    {
        private MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        public List<Route> RouteList = new List<Route>();
        public RouteManageWindow()
        {
            InitializeComponent();
            RouteList = _routeORM.ReadAll();
            foreach(Route route in RouteList)
            {
                RouteControl routeControl = new RouteControl(route);
                routeControl.OnChangeButtonClick += () =>
                {
                    ChangeRouteWindow changeRouteWindow = new ChangeRouteWindow(this, route);
                    changeRouteWindow.ShowDialog();
                };
                routeControl.OnDeleteButtonClick += () =>
                {
                    if (MessageBox.Show("Вы точно хотите удалить "+ routeControl.Route.NumberOfRoute 
                        + " маршрут?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        PanelOfRoutes.Controls.Remove(routeControl);
                        DeleteRouteFromDB(routeControl.Route);
                    }
                };
                PanelOfRoutes.Controls.Add(routeControl);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DeleteRouteFromDB(Route route)
        {
            _routeORM.Delete(route.Id);
        }

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            AddRouteWindow window = new AddRouteWindow(this);
            window.ShowDialog();
        }
    }
}
