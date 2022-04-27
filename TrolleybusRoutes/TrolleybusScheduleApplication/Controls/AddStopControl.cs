using RouteSystem.Routes;

namespace TrolleybusScheduleApplication.Controls
{
    public partial class AddStopControl : UserControl
    {
        public Action OnRemoveButtonClick;
        public Action OnAddScheduleButtonClick;
        public List<Time> StopSchedule = new List<Time>();
        public Stop Stop;
        public AddStopControl()
        {
            InitializeComponent();
        }

        private void DeleteControlButton_Click(object sender, EventArgs e)
        {
            OnRemoveButtonClick?.Invoke();
        }

        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            OnAddScheduleButtonClick?.Invoke();
        }

        private void StopComboBox_TextChanged(object sender, EventArgs e)
        {
            if (StopComboBox.Text != "")
                Stop = new Stop(StopComboBox.Text);

        }
    }
}
