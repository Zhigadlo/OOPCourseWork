using RouteSystem.Routes;

namespace TrolleybusScheduleApplication.Controls
{
    public partial class RouteControl : UserControl
    {
        public Route Route;
        public Action OnChangeButtonClick;
        public Action OnDeleteButtonClick;
        public RouteControl(Route route)
        {
            Route = route;
            InitializeComponent();
            label1.Text = route.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OnChangeButtonClick?.Invoke();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick?.Invoke();
        }

        private void RouteControl_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void RouteControl_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
