namespace TrolleybusScheduleApplication
{
    public partial class StartWindow : Form
    {
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
            Close();
        }
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == "������� ������")
                PasswordBox.Text = "";
            if (LoginBox.Text == "")
                LoginBox.Text = "������� �����";
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text != "" && PasswordBox.Text != "������� ������")
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
                PasswordBox.Text = "������� ������";
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
                LoginBox.Text = "������� �����";
            }
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "������� �����")
                LoginBox.Text = "";

            if (PasswordBox.Text == "")
                PasswordBox.Text = "������� ������";
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if(LoginBox.Text != "" && LoginBox.Text != "������� �����")
            {
                LoginBox.ForeColor = Color.Black;
            }
            else
            {
                LoginBox.ForeColor = Color.LightGray;
            }
        }

        
    }
}