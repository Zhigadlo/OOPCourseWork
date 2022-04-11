using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMLibrary;
using RouteSystem.Users;

namespace TrolleybusScheduleApplication
{
    public partial class RegistrationWindow : Form
    {
        private StartWindow _startWindow;
        private string _emptyString = "Поле пустое";
        private MongoDBORM<User> _userORM = new MongoDBORM<User>("RouteSystem", "Users");
        public RegistrationWindow(StartWindow startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
        }

        private bool IsRegistrationSuccessful()
        {
            string regexForLogin = @"^[a-zA-Z][a-zA-Z0-9]{5,12}$";
            string regexForPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
            if (Regex.IsMatch(LoginBox.Text, regexForLogin))
            {
                if (_userORM.Find("Login", LoginBox.Text))
                {
                    NewPasswordError.Text = "Пользователь с таким логином уже зарегестрирован";
                    NewPasswordError.Visible = true;
                }
                else
                {
                    if (Regex.IsMatch(PasswordBox.Text, regexForPassword) && PasswordBox.Text == SecondPasswordBox.Text)
                    {
                        return true;
                    }
                    else if (!Regex.IsMatch(PasswordBox.Text, regexForPassword))
                    {
                        PasswordError.Text = "Пример пароля: Abcde12345_, AbCaaaA443&";
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
                LoginError.Text = "Логин содержит от 6 до 12 символов, начинается с буквы";
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

            if (LoginBox.Text == "Введите логин")
                LoginBox.Text = "";

            if (PasswordBox.Text == "")
                PasswordBox.Text = "Введите пароль";

            if (SecondPasswordBox.Text == "")
                SecondPasswordBox.Text = "Введите пароль еще раз";
        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }

            if (e.KeyCode == Keys.Enter && LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
            }
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginBox.Text != "" && LoginBox.Text != "Введите логин")
            {
                LoginBox.ForeColor = Color.Black;
            }
            else
            {
                LoginBox.ForeColor = Color.LightGray;
            }
        }
        private void PasswordBox_Click(object sender, EventArgs e)
        {
            EmptyPassword.Visible = false;
            PasswordError.Visible = false;
            NewPasswordError.Visible = false;

            if (PasswordBox.Text == "Введите пароль")
                PasswordBox.Text = "";

            if (LoginBox.Text == "")
                LoginBox.Text = "Введите логин";

            if (SecondPasswordBox.Text == "")
                SecondPasswordBox.Text = "Введите пароль еще раз";
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text != "" && PasswordBox.Text != "Введите пароль")
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
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }

            if (e.KeyCode == Keys.Enter && PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
            }
        }
        private void SecondPasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (SecondPasswordBox.Text != "" && SecondPasswordBox.Text != "Введите пароль еще раз")
            {
                SecondPasswordBox.UseSystemPasswordChar = true;
                SecondPasswordBox.ForeColor = Color.Black;
            }
            else
            {
                SecondPasswordBox.UseSystemPasswordChar = false;
                SecondPasswordBox.ForeColor = Color.LightGray;
            }
        }
        private void SecondPasswordBox_Click(object sender, EventArgs e)
        {
            EmptySecondPassword.Visible = false;
            SecondPasswordError.Visible = false;
            NewPasswordError.Visible = false;

            if (SecondPasswordBox.Text == "Введите пароль еще раз")
                SecondPasswordBox.Text = "";

            if (PasswordBox.Text == "")
                PasswordBox.Text = "Введите пароль";

            if (LoginBox.Text == "")
                LoginBox.Text = "Введите логин";
        }
        private void SecondPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrationButton.Focus();
            }

            if (e.KeyCode == Keys.Enter && SecondPasswordBox.Text == "")
            {
                SecondPasswordBox.Text = "Введите пароль еще раз";
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || LoginBox.Text == "Введите логин")
            {
                EmptyLogin.Text = _emptyString;
                EmptyLogin.Visible = true;
            }

            if (PasswordBox.Text == "" || PasswordBox.Text == "Введите пароль")
            {
                EmptyPassword.Text = _emptyString;
                EmptyPassword.Visible = true;
            }

            if (SecondPasswordBox.Text == "" || SecondPasswordBox.Text == "Введите пароль еще раз")
            {
                EmptySecondPassword.Text = _emptyString;
                EmptySecondPassword.Visible = true;
            }

            if (LoginBox.Text != "" && LoginBox.Text != "Введите логин" &&
                PasswordBox.Text != "" && PasswordBox.Text != "Введите пароль" &&
                SecondPasswordBox.Text != "" && SecondPasswordBox.Text != "Введите пароль еще раз" &&
                IsRegistrationSuccessful())
            {
                
                _userORM.Write(new User(LoginBox.Text, PasswordBox.Text));
                MessageBox.Show("Вы зарегистрировались.", "Успех");
                Close();
                _startWindow.Show();
                
            }
        }
    }
}
