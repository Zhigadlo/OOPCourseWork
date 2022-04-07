using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrolleybusScheduleApplication
{
    public partial class RegistrationWindow : Form
    {
        private StartWindow _startWindow;
        public RegistrationWindow(StartWindow startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
        }

        private bool IsRegistrationSuccessful(string login, string password1, string password2)
        {
            throw new NotImplementedException();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            _startWindow.Show();
            Close();
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
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
    }
}
