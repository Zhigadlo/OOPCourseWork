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
            WindowInitialize();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DeleteRouteFromDB(Route route)
        {
            _routeORM.Delete(route.Id);
        }

        protected virtual void AddRouteButton_Click(object sender, EventArgs e)
        {
            AddRouteWindow window = new AddRouteWindow(this);
            window.ShowDialog();
        }
        protected virtual void WindowInitialize()
        {
            RouteList = _routeORM.ReadAll();
            foreach (Route route in RouteList)
            {
                RouteControl routeControl = new RouteControl(route);
                routeControl.OnChangeButtonClick += () =>
                {
                    ChangeRouteWindow changeRouteWindow = new ChangeRouteWindow(this, route);
                    changeRouteWindow.ShowDialog();
                };
                routeControl.OnDeleteButtonClick += () =>
                {
                    if (MessageBox.Show("Вы точно хотите удалить " + routeControl.Route.NumberOfRoute
                        + " маршрут?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        PanelForControls.Controls.Remove(routeControl);
                        DeleteRouteFromDB(routeControl.Route);
                    }
                };
                PanelForControls.Controls.Add(routeControl);
            }
        }
    }
}
