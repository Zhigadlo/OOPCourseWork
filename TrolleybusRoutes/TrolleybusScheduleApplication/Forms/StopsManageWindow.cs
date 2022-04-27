using ORMLibrary;
using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;


namespace TrolleybusScheduleApplication.Forms
{
    public partial class StopsManageWindow : RouteManageWindow
    {
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        public List<Stop> StopList = new List<Stop>();
        protected override void WindowInitialize()
        {
            StopList = _stopORM.ReadAll();
            label1.Text = "Остановки";
            foreach (Stop stop in StopList)
            {
                StopControl stopControl = new StopControl(stop);
                stopControl.OnChangeButtonClick += () =>
                {

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
        }

        private void DeleteStopFromDB(Stop stop)
        {
            _stopORM.Delete(stop.Id);
        }
    }
}
