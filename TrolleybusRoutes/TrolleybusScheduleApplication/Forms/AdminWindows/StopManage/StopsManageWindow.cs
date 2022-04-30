using ORMLibrary;
using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;
using TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage;

namespace TrolleybusScheduleApplication.Forms.AdminWindows.StopManage
{
    public partial class StopsManageWindow : RouteManageWindow
    {
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        private MongoDBORM<Route> _routesORM = new MongoDBORM<Route>("RouteSystem", "Routes");
        public List<Stop> StopList = new List<Stop>();
        protected override void WindowInitialize()
        {
            Text = "Управление остановками";
            StopList = _stopORM.ReadAll();
            label1.Text = "Остановки";
            AddRouteButton.Text = "Добавить остановку";
            foreach (Stop stop in StopList)
            {
                AddNewControl(stop);
            }
        }

        public void AddNewControl(Stop stop)
        {
            StopControl stopControl = new StopControl(stop);
            stopControl.OnChangeButtonClick += () =>
            {
                TextBox textBox = new TextBox()
                {
                    Location = stopControl.StopName.Location,
                    Name = "TextBox",
                    Size = new Size(200, stopControl.StopName.Size.Height),
                    Font = stopControl.StopName.Font,
                    ForeColor = stopControl.StopName.ForeColor,
                    Text = stopControl.StopName.Text
                };

                textBox.KeyPress += (s, e) =>
                {
                    if (e.KeyChar == (int)Keys.Enter)
                    {
                        if (textBox.Text == "")
                        {
                            MessageBox.Show("Вы ничего не ввели", "Ошибка");
                        }
                        else if (_stopORM.Contains("Name", textBox.Text))
                        {
                            stopControl.StopName.Text = textBox.Text;
                            stopControl.StopName.Visible = true;
                            textBox.Dispose();
                        }
                        else
                        {
                            stopControl.StopName.Text = textBox.Text;
                            stopControl.StopName.Visible = true;
                            stopControl.Controls.Remove(textBox);
                            stopControl.Stop.Name = textBox.Text;
                            ChangeStopInDB(stopControl.Stop.Id, stopControl.Stop);
                            textBox.Dispose();
                        }
                    }
                };
                stopControl.StopName.Visible = false;
                stopControl.Controls.Add(textBox);

            };
            stopControl.OnDeleteButtonClick += () =>
            {
                if (MessageBox.Show("Вы точно хотите удалить остановку " + stopControl.Stop.Name,
                    "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PanelForControls.Controls.Remove(stopControl);
                    DeleteStopFromDB(stopControl.Stop);
                }
            };
            PanelForControls.Controls.Add(stopControl);
        }
        private void DeleteStopFromDB(Stop stop)
        {
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
        }
        private void ChangeStopInDB(int id, Stop newStop)
        {
            _stopORM.Update(id, newStop);
            List<Route> routes = _routesORM.ReadAll();
            foreach (Route route in routes)
            {
                foreach (StopPoint stopPoint in route.StopPoints)
                {
                    if (stopPoint.Stop.Id == id)
                    {
                        route.StopPoints.Remove(stopPoint);
                        _routesORM.Update(id, route);
                        break;
                    }
                }
            }
        }
        protected override void AddRouteButton_Click(object sender, EventArgs e)
        {
            AddStopWindow addStopWindow = new AddStopWindow(this);
            addStopWindow.ShowDialog();
        }
    }
}
