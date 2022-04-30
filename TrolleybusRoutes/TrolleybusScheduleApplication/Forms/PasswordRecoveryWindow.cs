using RouteSystem.Users;
using ORMLibrary;
using System.Text.RegularExpressions;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class PasswordRecoveryWindow : Form
    {
        private string _emptyString = "Поле пустое";
        private User _userForRecovery;
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users");
        private Form _startWindow;
        public PasswordRecoveryWindow(Form startWindow, User user)
        {
            _startWindow = startWindow;
            _userForRecovery = user;
            InitializeComponent();
        }

        private void RecoveryButton_Click(object sender, EventArgs e)
        {
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

            if (PasswordBox.Text != "" &&
                SecondPasswordBox.Text != "" && IsPasswordValid())
            {
                _userForRecovery.Password = PasswordBox.Text;
                _userORM.Update(_userForRecovery.Id, _userForRecovery);
                MessageBox.Show("Пароль восстановлен. Теперь вы можете войти в систему:)", "Успех");
                Close();
                _startWindow.Show();
            }
        }

        private bool IsPasswordValid()
        {
            if (Regex.IsMatch(PasswordBox.Text, Validation.RegexForPassword) && PasswordBox.Text == SecondPasswordBox.Text)
            {
                return true;
            }
            else if (!Regex.IsMatch(PasswordBox.Text, Validation.RegexForPassword))
            {
                PasswordError.Visible = true;
            }
            else
            {
                SecondPasswordError.Text = "Пароли должны совпадать";
                SecondPasswordError.Visible = true;
            }
            return false;
        }
    }
}
