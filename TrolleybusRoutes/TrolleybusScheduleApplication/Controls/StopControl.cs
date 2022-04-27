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
    }
}
