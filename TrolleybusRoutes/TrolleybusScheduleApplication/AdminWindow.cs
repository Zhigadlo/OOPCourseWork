using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrolleybusScheduleApplication
{
    public partial class AdminWindow : Form
    {
        private Form _startWindow;
        public AdminWindow(Form startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
        }

        private void CheckScheduleButton_Click(object sender, EventArgs e)
        {
            UserWindow userWindow = new UserWindow(this);
            Hide();
            userWindow.ShowDialog();
            Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _startWindow.Show();
                Close();
            }
        }

        private void ChangeUserInfoButton_Click(object sender, EventArgs e)
        {
            UserManagmentWindow userManagmentWindow = new UserManagmentWindow(this);
            Hide();
            userManagmentWindow.ShowDialog();
            Show();
        }
    }
}
