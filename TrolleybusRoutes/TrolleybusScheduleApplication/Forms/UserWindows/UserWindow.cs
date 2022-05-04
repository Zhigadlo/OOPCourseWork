using RouteSystem.Routes;
using TrolleybusScheduleApplication.Controls;
using TrolleybusScheduleApplication.Forms.GuestWindows;
using ORMLibrary;

namespace TrolleybusScheduleApplication.Forms.UserWindows
{
    public partial class UserWindow : GuestWindow
    {
        private MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        public UserWindow(Form startWindow) : base(startWindow)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            FindRoutesBetweenStopsButton.Visible = true;
            FirstStopBox.Visible = true;
            LastStopBox.Visible = true;
            List<Stop> stopList = _stopORM.ReadAll();
            FirstStopBox.Items.AddRange(stopList.ToArray());
            LastStopBox.Items.AddRange(stopList.ToArray());
        }

        protected override void QuitButton_Click(object sender, EventArgs e)
        {
            base.QuitButton_Click(sender, e);
        }

        protected override void GhuestWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startWindow.Close();
        }

        protected override void AddStopControl(StopPoint stopPoint)
        {
            StopControl control = new StopControl(stopPoint.Stop);
            control.ChangeButton.Visible = false;
            control.DeleteButton.Visible = false;
            control.Click += (s, e) =>
            {
                MessageBox.Show(GetScheduleFromStop(stopPoint), stopPoint.Stop.ToString());
            };
            control.StopName.Click += (s, e) =>
            {
                MessageBox.Show(GetScheduleFromStop(stopPoint), stopPoint.Stop.ToString());
            };
            PanelForControls.Controls.Add(control);
        }

        private string GetScheduleFromStop(StopPoint stopPoint)
        {
            string schedule = "";
            for(int i = 0; i < stopPoint.Schedule.Count; i++)
            {
                schedule += stopPoint.Schedule[i] + " ";
                if ((i + 1 % 5) == 0)
                    schedule += "\n";
            }

            return schedule;
        }

    }
}
