using RouteSystem.Users;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class AddUserWindow : RegistrationWindow
    {
        public AddUserWindow(Form startWindow) : base(startWindow)
        {
            Text = "Добавление пользователя";
        }

        protected override void RegistrationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        protected override void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                EmptyLogin.Text = _emptyString;
                EmptyLogin.Visible = true;
            }

            if (PasswordBox.Text == "")
            {
                EmptyPassword.Text = _emptyString;
                EmptyPassword.Visible = true;
            }

            if (SecondPasswordBox.Text == "")
            {
                EmptySecondPassword.Text = _emptyString;
                EmptySecondPassword.Visible = true;
            }

            if (LoginBox.Text != "" && PasswordBox.Text != "" &&
                SecondPasswordBox.Text != "" && IsRegistrationSuccessful())
            {
                var newUser = new User(LoginBox.Text, PasswordBox.Text);
                newUser.Role = Roles.User;
                _userORM.Write(newUser);
                MessageBox.Show("Пользователь добавлен", "Успех");
                Close();
                _startWindow.Show();
            }
        }
    }
}
