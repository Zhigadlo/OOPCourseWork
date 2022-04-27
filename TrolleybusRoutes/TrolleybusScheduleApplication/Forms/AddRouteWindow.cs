using ORMLibrary;
using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class AddRouteWindow : Form
    {
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        protected MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        private List<Stop> _stops;
        protected RouteManageWindow _startWindow;
        public AddRouteWindow(RouteManageWindow window)
        {
            _startWindow = window;
            InitializeComponent();
            _stops = _stopORM.ReadAll();
            AddStopControl();
        }

        private void AddStopControl()
        {
            AddStopControl stopControl = new AddStopControl();
            stopControl.StopComboBox.Items.AddRange(_stops.ToArray());
            PanelForControls.Controls.Add(stopControl);
            stopControl.OnRemoveButtonClick += () =>
            {
                PanelForControls.Controls.Remove(stopControl);
            };
            stopControl.OnAddScheduleButtonClick += () =>
            {
                AddSchedule(stopControl);
            };
        }
        private void AddControlButton_Click(object sender, EventArgs e)
        {
            AddStopControl();
        }
        protected void AddSchedule(AddStopControl control)
        {
            try
            {
                int routeCount = int.Parse(RouteCountBox.Text);
                AddScheduleWindow scheduleWindow = new AddScheduleWindow(routeCount, control);
                scheduleWindow.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Введите количество поездок", "Ошибка");
            }
        }
        protected virtual void AddRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int routeNumber = int.Parse(RouteNumberBox.Text);
                int routeCount = int.Parse(RouteCountBox.Text);
                List<StopPoint> stopPoints = new List<StopPoint>();
                foreach (AddStopControl stopControl in PanelForControls.Controls)
                {
                    if (routeCount != stopControl.StopSchedule.Count || stopControl.Stop == null)
                        throw new Exception();

                    stopPoints.Add(new StopPoint(stopControl.StopSchedule, stopControl.Stop));
                }
                Route route = new Route(routeNumber, stopPoints);
                _routeORM.Write(route);
                _startWindow.RouteList.Add(route);
                _startWindow.PanelForControls.Controls.Add(new RouteControl(route));
                MessageBox.Show("Маршрут номер " + routeNumber + " добавлен.", "Успех");
                Close();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RouteCountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(RouteCountBox.Text);
                foreach (AddStopControl stopControl in PanelForControls.Controls)
                {
                    if (stopControl.StopSchedule.Count < count)
                    {
                        stopControl.ErrorLabel.Visible = true;
                        stopControl.ErrorLabel.Text = "Дополните расписание";
                        stopControl.ErrorLabel.ForeColor = Color.Red;
                    }
                    else if (stopControl.StopSchedule.Count >= count)
                    {
                        stopControl.ErrorLabel.Visible = true;
                        stopControl.ErrorLabel.Text = "Расписание добавлено";
                        stopControl.ErrorLabel.ForeColor = Color.Green;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
