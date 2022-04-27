using ORMLibrary;
using RouteSystem.Users;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class StartWindow : Form
    {
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users");
        public StartWindow()
        {
            InitializeComponent();
        }

        private void GhuestLinkLabel_Click(object sender, EventArgs e)
        {
            GhuestWindow ghuestWindow = new GhuestWindow(this);
            Hide();
            ghuestWindow.ShowDialog();
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow(this);
            Hide();
            registrationWindow.ShowDialog();
        }
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            PasswordError.Visible = false;
            PasswordLoginError.Visible = false;
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
            }

        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
            }
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
            PasswordLoginError.Visible = false;
            LoginError.Visible = false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "" && LoginBox.Text == "")
            {
                PasswordError.Visible = true;
                LoginError.Visible = true;
            }
            else if (PasswordBox.Text == "")
            {
                PasswordError.Visible = true;
            }
            else if (LoginBox.Text == "")
            {
                LoginError.Visible = true;
            }
            else
            {
                try
                {
                    User user = _userORM.Read("Login", LoginBox.Text);
                    if (user.Password == PasswordBox.Text)
                    {
                        Hide();
                        switch (user.Role)
                        {
                            case Roles.Admin:
                                AdminWindow adminWindow = new AdminWindow(this, user);
                                adminWindow.ShowDialog();
                                break;
                            case Roles.User:
                                UserWindow userWindow = new UserWindow(this);
                                userWindow.ShowDialog();
                                break;
                        }

                    }
                    else
                    {
                        PasswordLoginError.Visible = true;
                    }
                }
                catch
                {
                    PasswordLoginError.Visible = true;
                }
            }
        }
    }
}