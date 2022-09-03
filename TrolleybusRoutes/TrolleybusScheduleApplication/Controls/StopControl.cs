using RouteSystem.Routes;

namespace TrolleybusScheduleApplication.Controls
{
    public partial class StopControl : UserControl
    {
        public Action OnDeleteButtonClick;
        public Action OnChangeButtonClick;
        public Stop Stop { get; set; }
        public StopControl(Stop stop)
        {
            Stop = stop;
            InitializeComponent();
            StopName.Text = stop.Name;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OnChangeButtonClick?.Invoke();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick?.Invoke();
        }

        private void StopControl_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void StopControl_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void StopName_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void StopName_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void StopName_Click(object sender, EventArgs e)
        {

        }
    }
}
