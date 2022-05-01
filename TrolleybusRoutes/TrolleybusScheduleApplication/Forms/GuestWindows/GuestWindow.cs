using ORMLibrary;
using RouteSystem.Routes;
using System.Data;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms.GuestWindows
{
    public partial class GuestWindow : Form
    {
        protected Form _startWindow;
        protected MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        protected List<Route> _routes;
        public GuestWindow(Form startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();

            _routes = _routeORM.ReadAll().OrderBy(x => x.NumberOfRoute).ToList();
            foreach(Route route in _routes)
                BoxForNumbers.Items.Add(route.NumberOfRoute);
            ShowAllRoutes();
        }

        protected void FindButton_Click(object sender, EventArgs e)
        {
            if (BoxForNumbers.SelectedItem != null)
            {
                int number = Convert.ToInt32(BoxForNumbers.SelectedItem);

                Route route = _routes.Find(x => x.NumberOfRoute == number);
                PanelForControls.Controls.Clear();
                AddRouteControl(route);
            }
            else
            {
                MessageBox.Show("Нет такого маршрута", "Ошибка");
            }
        }
        protected virtual void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        protected virtual void GhuestWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startWindow.Close();
        }
        private void AddRouteControl(Route route)
        {
            RouteControl control = new RouteControl(route);
            control.ChangeButton.Visible = false;
            control.DeleteButton.Visible = false;
            control.Click += (o, e) =>
            {
                FromRoutePanelToStopPanel(route);
            };
            PanelForControls.Controls.Add(control);

        }
        protected virtual void AddStopControl(StopPoint stopPoint)
        {
            StopControl control = new StopControl(stopPoint.Stop);
            control.ChangeButton.Visible = false;
            control.DeleteButton.Visible = false;
            PanelForControls.Controls.Add(control);
        }
        private void AddStopControlsFromRoute(Route route)
        {
            foreach (StopPoint stopPoint in route.StopPoints)
                AddStopControl(stopPoint);
        }
        private void FromRoutePanelToStopPanel(Route route)
        {
            PanelForControls.Controls.Clear();
            AddStopControlsFromRoute(route);
            TitleLabel.Text = "Остановки маршрута " + route.NumberOfRoute;
        }
        private void ShowAllRoutes()
        {
            PanelForControls.Controls.Clear();
            foreach (var route in _routes)
            {
                AddRouteControl(route);
            }
            TitleLabel.Text = "Список всех маршрутов";
        }
        private void ShowAllRoutesButton_Click(object sender, EventArgs e)
        {
            ShowAllRoutes();
        }
        private void FindRoutesBetweenStopsButton_Click(object sender, EventArgs e)
        {
            if (FirstStopBox.SelectedItem == null || LastStopBox.SelectedItem == null)
                MessageBox.Show("Вы не выбрали остановок");
            else
            {
                Stop stop1 = FirstStopBox.SelectedItem as Stop;
                Stop stop2 = LastStopBox.SelectedItem as Stop;
                var routes = Route.FindRoutesBetweenStops(stop1, stop2, _routes);
                if (routes.Count != 0 && stop1 != null && stop2 != null)
                {
                    if (stop1.Name == stop2.Name)
                    {
                        MessageBox.Show("Выберете разные остановки", "Ошибка");
                    }
                    else
                    {
                        PanelForControls.Controls.Clear();
                        foreach (var route in routes)
                            AddRouteControl(route);
                        TitleLabel.Text = stop1.ToString() + " - " + stop2.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Нет таких маршрутов", "Ошибка");
                }
            }
        }
    }
}
