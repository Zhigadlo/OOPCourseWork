using ORMLibrary;
using RouteSystem.Users;
using TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms.AdminWindows.UserManage
{
    public partial class UsersManageWindow : RouteManageWindow
    {
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users");
        public List<User> UserList = new List<User>();
        private User _mainUser;
        public UsersManageWindow(User user) : base()
        {
            Text = "Управление пользователями";
            label1.Text = "Пользователи";
            AddRouteButton.Text = "Добавить пользователя";
            _mainUser = user;
            UserList.Remove(_mainUser);
            ControlForUsers controlForDelete = null;
            foreach (ControlForUsers control in PanelForControls.Controls)
            {
                if (control.User.Login == _mainUser.Login)
                {
                    controlForDelete = control;
                }

                if (control.User.Role == Roles.RootAdmin || 
                    control.User.Role == Roles.Admin && _mainUser.Role == Roles.Admin)
                {
                    control.PasswordDropButton.Enabled = false;
                    control.DeleteButton.Enabled = false;
                    control.ChangeRoleButton.Enabled = false; 
                }
            }

            PanelForControls.Controls.Remove(controlForDelete);
        }

        protected override void WindowInitialize()
        {
            UserList = _userORM.ReadAll();
            foreach (User user in UserList)
            {
                ControlForUsers userControl = new ControlForUsers(user);
                userControl.OnChangeRoleClick += () =>
                {
                    ChangeRole(userControl);
                };
                userControl.OnDeleteButtonClick += () =>
                {
                    DeleteUserControl(userControl);
                };
                userControl.OnPasswordDropClick += () =>
                {
                    PasswordDrop(userControl);
                };

                if (user.Password == null)
                    userControl.PasswordDropButton.Enabled = false;

                PanelForControls.Controls.Add(userControl);
            }
        }

        private void DeleteUserControl(ControlForUsers userControl)
        {
            if (MessageBox.Show("Вы точно хотите удалить пользователя " + userControl.User.Login + "?",
                        "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PanelForControls.Controls.Remove(userControl);
                _userORM.Delete(userControl.User.Id);
                MessageBox.Show("Пользователь " + userControl.User.Login + " был удален", "Успех");
            }
        }
        private void PasswordDrop(ControlForUsers userControl)
        {
            userControl.User.Password = null;
            _userORM.Update(userControl.User.Id, userControl.User);
            userControl.PasswordDropButton.Enabled = false;
            MessageBox.Show("Пароль пользователя" + userControl.User.Login + " сброшен", "Успех");
        }
        private void ChangeRole(ControlForUsers userControl)
        {
            userControl.UserRole.Visible = false;
            userControl.ChangeRoleButton.Enabled = false;
            ComboBox comboBox = new ComboBox()
            {
                Location = userControl.UserRole.Location,
                Name = "ComboBox",
                Size = new Size(120, userControl.UserRole.Size.Height),
                Font = userControl.UserRole.Font,
                ForeColor = userControl.UserRole.ForeColor,
                Text = userControl.UserRole.Text,
            };
            comboBox.Items.Add(Roles.User);
            comboBox.Items.Add(Roles.Admin);
            
            userControl.Controls.Add(comboBox);

            comboBox.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (int)Keys.Enter)
                {
                    if (comboBox.Text == "")
                    {
                        MessageBox.Show("Вы ничего не ввели", "Ошибка");
                    }
                    else if (_userORM.Contains("Login", userControl.LoginLabel.Text)
                            && userControl.LoginLabel.Text == comboBox.Text)
                    {
                        userControl.UserRole.Text = comboBox.Text;
                        userControl.UserRole.Visible = true;
                        comboBox.Dispose();
                    }
                    else
                    {
                        userControl.UserRole.Text = comboBox.Text;
                        userControl.UserRole.Visible = true;
                        userControl.Controls.Remove(comboBox);
                        switch (comboBox.SelectedItem)
                        {
                            case Roles.User:
                                userControl.UserRole.Text = "User";
                                userControl.User.Role = Roles.User;
                                break;
                            case Roles.Admin:
                                userControl.UserRole.Text = "Admin";
                                userControl.User.Role = Roles.Admin;
                                break;
                        }
                        UpdateRoleInDB(userControl.User.Id, userControl.User);
                        comboBox.Dispose();
                    }
                    userControl.Controls.Remove(comboBox);
                }
                userControl.ChangeRoleButton.Enabled = true;
            };
        }
        private void UpdateRoleInDB(int id, User user)
        {
            _userORM.Update(id, user);
        }

        protected override void AddRouteButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
