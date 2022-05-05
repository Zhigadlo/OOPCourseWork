using ORMLibrary;
using RouteSystem.Users;
using System.Text.RegularExpressions;

namespace TrolleybusScheduleApplication.Forms.AdminWindows.UserManage
{
    public partial class AddUserForm : Form
    {
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users", DbConnection.Instance.GetClient());
        private UsersManageWindow _startWindow;
        public AddUserForm(UsersManageWindow startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                EmptyLogin.Text = "Поле пустое";
                EmptyLogin.Visible = true;
            }

            if (LoginBox.Text != "" && IsLoginValid())
            {
                var newUser = new User(LoginBox.Text, null);
                newUser.Role = Roles.User;
                _userORM.Write(newUser);
                MessageBox.Show("Вы добавилти пользователя. Перед входом в систему ему надо будет придумать пароль", "Успех");
                Close();
                _startWindow.Show();
            }
        }

        private bool IsLoginValid()
        {
            if (Regex.IsMatch(LoginBox.Text, Validation.RegexForLogin))
            {
                if (_userORM.Contains("Login", LoginBox.Text))
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегестрирован", "Ошибка");
                }
                else
                {
                    return true;
                }
                return false;
            }
            else
            {
                LoginError.Visible = true;
                return false;
            }
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {
            LoginError.Visible = false;
        }
    }
}
