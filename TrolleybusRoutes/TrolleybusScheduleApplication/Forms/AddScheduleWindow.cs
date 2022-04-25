using RouteSystem.Routes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class AddScheduleWindow : Form
    {
        private AddStopControl _stopControl;
        private int _routeCount;
        public AddScheduleWindow(int routeCount, AddStopControl stopControl)
        {
            _stopControl = stopControl;
            _routeCount = routeCount;   
            InitializeComponent();
            for(int i = 0; i < routeCount; i++)
            {
                AddTimeControl timeControl = new AddTimeControl();
                PanelForTime.Controls.Add(timeControl);
                if (i < stopControl.StopSchedule.Count && stopControl.StopSchedule.Count > 0)
                {
                    timeControl.HourBox.Text = stopControl.StopSchedule[i].Hour.ToString();
                    timeControl.MinuteBox.Text = stopControl.StopSchedule[i].Minute.ToString();
                }
            }
        }
        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (AddTimeControl control in PanelForTime.Controls)
                {
                    int hour = int.Parse(control.HourBox.Text);
                    int minutes = int.Parse(control.MinuteBox.Text);
                    _stopControl.StopSchedule.Add(new Time(hour, minutes));
                }
                Close();
                _stopControl.ErrorLabel.Visible = true;
                _stopControl.ErrorLabel.Text = "Расписание заполнено";
                _stopControl.ErrorLabel.ForeColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Ошибка");
            }
        }
        private void AddScheduleWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_routeCount > _stopControl.StopSchedule.Count)
            {
                _stopControl.ErrorLabel.Visible = true;
                _stopControl.ErrorLabel.Text = "Расписание не заполнено";
                _stopControl.ErrorLabel.ForeColor = Color.Red;
            }
        }
        
    }
}