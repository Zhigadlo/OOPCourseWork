﻿using System;
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
    public partial class ChangeUserPasswordWindow : RegistrationWindow
    {
        public ChangeUserPasswordWindow(Form startWindow) : base(startWindow)
        {
            PasswordLabel.Text = "Новый пароль";
            Text = "Изменение пароля пользователя";
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
                SecondPasswordBox.Text != "" && IsPasswordUpdateSuccessful())
            {
                User user = _userORM.Read("Login", LoginBox.Text);
                int id = user.Id;
                user.Password = PasswordBox.Text;
                _userORM.Update(id, user);
                MessageBox.Show("Пароль изменен", "Успех");
                Close();
                _startWindow.Show();
            }
        }

        private bool IsPasswordUpdateSuccessful()
        {
            if(_userORM.Contains("Login", LoginBox.Text))
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
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
