﻿using ORMLibrary;
using RouteSystem.Routes;
using System.Data;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms.GuestWindows
{
    public partial class GhuestWindow : Form
    {
        private Form _startWindow;
        protected MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        protected List<Route> _routes;
        public GhuestWindow(Form startWindow)
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
                FromRoutePanelToStopPanel(route);
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
                Close();
            }
        }
        private void GhuestWindow_FormClosed(object sender, FormClosedEventArgs e)
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
        private void AddStopControl(Stop stop)
        {
            StopControl control = new StopControl(stop);
            control.ChangeButton.Visible = false;
            control.DeleteButton.Visible = false;
            PanelForControls.Controls.Add(control);
        }
        private void AddStopControlsFromRoute(Route route)
        {
            foreach (StopPoint stopPoint in route.StopPoints)
                AddStopControl(stopPoint.Stop);
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
            //_routes = (from x in _routeORM.ReadAll().AsEnumerable()
            //           orderby x.NumberOfRoute
            //           select x).ToList();
        }
        private void ShowAllRoutesButton_Click(object sender, EventArgs e)
        {
            ShowAllRoutes();
        }
    }
}
