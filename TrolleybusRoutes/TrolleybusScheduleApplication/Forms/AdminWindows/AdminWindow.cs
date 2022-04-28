using RouteSystem.Users;
using TrolleybusScheduleApplication.Forms.AdminWindows.Schedule;
using TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage;
using TrolleybusScheduleApplication.Forms.AdminWindows.StopManage;

namespace TrolleybusScheduleApplication.Forms.AdminWindows
{
    public partial class AdminWindow : Form
    {
        private Form _startWindow;
        private User _user;
        public AdminWindow(Form startWindow, User user)
        {
            _startWindow = startWindow;
            _user = user;
            InitializeComponent();
        }

        private void CheckScheduleButton_Click(object sender, EventArgs e)
        {
            AdminScheduleForm userWindow = new AdminScheduleForm(this);
            userWindow.QuitButton.Text = "Назад";
            userWindow.ShowDialog();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void AdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startWindow.Close();
        }

        private void RouteManageButton_Click(object sender, EventArgs e)
        {
            RouteManageWindow routeManageWindow = new RouteManageWindow();
            routeManageWindow.ShowDialog();
        }

        private void StopManageButton_Click(object sender, EventArgs e)
        {
            StopsManageWindow stopsManageWindow = new StopsManageWindow();
            stopsManageWindow.ShowDialog();
        }
    }
}
