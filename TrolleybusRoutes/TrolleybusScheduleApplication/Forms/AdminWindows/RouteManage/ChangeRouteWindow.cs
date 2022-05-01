using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage
{
    public partial class ChangeRouteWindow : AddRouteWindow
    {
        private Route _routeToChange;
        public ChangeRouteWindow(RouteManageWindow window, Route route) : base(window)
        {
            _routeToChange = route;
            AddRouteButton.Text = "Изменить маршрут";
            List<Stop> listOfStops = _stopORM.ReadAll();
            RouteCountBox.Text = _routeToChange.StopPoints[0].Schedule.Count.ToString();
            RouteNumberBox.Text = _routeToChange.NumberOfRoute.ToString();
            PanelForControls.Controls.Clear();
            foreach (StopPoint stopPoint in route.StopPoints)
            {
                AddStopPointControl control = new AddStopPointControl();
                control.OnAddScheduleButtonClick += () =>
                {
                    AddSchedule(control);
                };
                control.OnRemoveButtonClick += () =>
                {
                    PanelForControls.Controls.Remove(control);
                };
                control.StopComboBox.Text = stopPoint.Stop.ToString();
                control.StopComboBox.Items.AddRange(listOfStops.ToArray());
                control.StopSchedule = stopPoint.Schedule;
                PanelForControls.Controls.Add(control);
            }
        }

        protected override void AddRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int routeNumber = int.Parse(RouteNumberBox.Text);
                int routeCount = int.Parse(RouteCountBox.Text);
                List<StopPoint> stopPoints = new List<StopPoint>();
                foreach (AddStopPointControl stopControl in PanelForControls.Controls)
                {
                    if (routeCount != stopControl.StopSchedule.Count || stopControl.Stop == null)
                        throw new Exception();

                    stopPoints.Add(new StopPoint(stopControl.StopSchedule, stopControl.Stop));
                }
                Route newRoute = new Route(routeNumber, stopPoints);
                _routeORM.Update(_routeToChange.Id, newRoute);
                _startWindow.RouteList.Remove(_startWindow.RouteList.Find(x => x.Id == _routeToChange.Id));
                _startWindow.RouteList.Add(newRoute);
                _startWindow.PanelForControls.Controls.Remove(new RouteControl(_routeToChange));
                _startWindow.PanelForControls.Controls.Add(new RouteControl(newRoute));


                MessageBox.Show("Маршрут номер " + routeNumber + " изменен.", "Успех");
                Close();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
        }
    }
}
