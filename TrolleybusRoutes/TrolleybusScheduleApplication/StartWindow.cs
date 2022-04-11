using RouteSystem.Users;
using ORMLibrary;

namespace TrolleybusScheduleApplication
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
            Close();
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

            if (PasswordBox.Text == "¬ведите пароль")
                PasswordBox.Text = "";
            if (LoginBox.Text == "")
                LoginBox.Text = "¬ведите логин";
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text != "" && PasswordBox.Text != "¬ведите пароль")
            {
                PasswordBox.UseSystemPasswordChar = true;
                PasswordBox.ForeColor = Color.Black;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = false;
                PasswordBox.ForeColor = Color.LightGray;
            }
        }
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
            }

            if (e.KeyCode == Keys.Enter && PasswordBox.Text == "")
            {
                PasswordBox.Text = "¬ведите пароль";
            }
        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
            }

            if (e.KeyCode == Keys.Enter && LoginBox.Text == "")
            {
                LoginBox.Text = "¬ведите логин";
            }
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
            PasswordLoginError.Visible = false;
            LoginError.Visible = false;

            if (LoginBox.Text == "¬ведите логин")
                LoginBox.Text = "";

            if (PasswordBox.Text == "")
                PasswordBox.Text = "¬ведите пароль";
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if(LoginBox.Text != "" && LoginBox.Text != "¬ведите логин")
            {
                LoginBox.ForeColor = Color.Black;
            }
            else
            {
                LoginBox.ForeColor = Color.LightGray;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if((PasswordBox.Text == "" || PasswordBox.Text == "¬ведите пароль") &&(LoginBox.Text == "" || LoginBox.Text == "¬ведите логин"))
            {
                PasswordError.Visible = true;
                LoginError.Visible = true;
            }
            else if (PasswordBox.Text == "" || PasswordBox.Text == "¬ведите пароль")
            {
                PasswordError.Visible = true;
            }
            else if (LoginBox.Text == "" || LoginBox.Text == "¬ведите логин")
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
                        switch (user.Role)
                        {
                            case Roles.Admin:
                                AdminWindow adminWindow = new AdminWindow();
                                Hide();
                                adminWindow.ShowDialog();
                                Close();
                                break;
                            case Roles.User:
                                UserWindow userWindow = new UserWindow();
                                Hide();
                                userWindow.ShowDialog();
                                Close();
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