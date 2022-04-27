using ORMLibrary;
using RouteSystem.Users;
using System.Text.RegularExpressions;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class RegistrationWindow : Form
    {
        protected Form _startWindow;
        protected string _regexForLogin = @"^[a-zA-Z][a-zA-Z0-9]{5,12}$";
        protected string _regexForPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$";
        protected string _emptyString = "Поле пустое";
        private ToolTip _toolTip = new ToolTip();
        protected MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users");
        public RegistrationWindow(Form startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
            _toolTip.SetToolTip(LoginBox, "Логин содержит от 6 до 12 символов, начинается с буквы");
            _toolTip.SetToolTip(PasswordBox, "9-20 символов, одна обычная и заглавная буквы, спец. символ и цифра");
            _toolTip.SetToolTip(SecondPasswordBox, "Повторите пароль который вы написали выше");
        }

        protected bool IsRegistrationSuccessful()
        {
            if (Regex.IsMatch(LoginBox.Text, _regexForLogin))
            {
                if (_userORM.Contains("Login", LoginBox.Text))
                {
                    NewPasswordError.Text = "Пользователь с таким логином уже зарегестрирован";
                    NewPasswordError.Visible = true;
                }
                else
                {
                    if (Regex.IsMatch(PasswordBox.Text, _regexForPassword) && PasswordBox.Text == SecondPasswordBox.Text)
                    {
                        return true;
                    }
                    else if (!Regex.IsMatch(PasswordBox.Text, _regexForPassword))
                    {
                        PasswordError.Visible = true;
                    }
                    else
                    {
                        SecondPasswordError.Text = "Пароли должны совпадать";
                        SecondPasswordError.Visible = true;
                    }
                }
                return false;
            }
            else
            {
                LoginError.Visible = true;
                return false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _startWindow.Show();
            Close();
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
            EmptyLogin.Visible = false;
            LoginError.Visible = false;
            NewPasswordError.Visible = false;
        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }
        }
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            EmptyPassword.Visible = false;
            PasswordError.Visible = false;
            NewPasswordError.Visible = false;
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }
        }
        private void SecondPasswordBox_TextChanged(object sender, EventArgs e)
        {
            SecondPasswordBox.UseSystemPasswordChar = true;
        }
        private void SecondPasswordBox_Click(object sender, EventArgs e)
        {
            EmptySecondPassword.Visible = false;
            SecondPasswordError.Visible = false;
            NewPasswordError.Visible = false;
        }
        private void SecondPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }
        }

        protected virtual void RegistrationButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Вы зарегистрировались. Теперь вы можете войти в систему:)", "Успех");
                Close();
                _startWindow.Show();
            }
        }

        private void LoginBox_MouseMove(object sender, MouseEventArgs e)
        {
            _toolTip.Active = true;
        }

        protected virtual void RegistrationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startWindow.Close();
        }
    }
}