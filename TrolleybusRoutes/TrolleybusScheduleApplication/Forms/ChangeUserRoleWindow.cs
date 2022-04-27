using ORMLibrary;
using RouteSystem.Users;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class ChangeUserRoleWindow : Form
    {
        private User _admin;
        private MongoDBORM<User> _usersORM = new MongoDBORM<User>("RouteSystem", "Users");
        public ChangeUserRoleWindow(User user)
        {
            _admin = user;
            InitializeComponent();
            RoleComboBox.Items.Add("Пользователь");
            RoleComboBox.Items.Add("Администратор");
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" && RoleComboBox.Text == "")
            {
                EmptyLogin.Visible = true;
                EmptyRole.Visible = true;
            }
            else if (LoginBox.Text == "")
            {
                EmptyLogin.Visible = true;
            }
            else if (RoleComboBox.Text == "")
            {
                EmptyRole.Visible = true;
            }
            else
            {
                if (_usersORM.Contains("Login", LoginBox.Text) && _admin.Login != LoginBox.Text)
                {
                    User user = _usersORM.Read("Login", LoginBox.Text);

                    switch (RoleComboBox.Text)
                    {
                        case "Пользователь":
                            user.Role = Roles.User;
                            break;
                        case "Администратор":
                            user.Role = Roles.Admin;
                            break;
                        default:
                            RoleError.Visible = true;
                            break;
                    }
                    _usersORM.Update(user.Id, user);
                    MessageBox.Show("Вы поменяли роль пользователя " + user.Login);
                    Close();
                }
                else
                    LoginError.Visible = true;
            }
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            EmptyLogin.Visible = false;
            LoginError.Visible = false;
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyRole.Visible = false;
            RoleError.Visible = false;
        }
    }
}
