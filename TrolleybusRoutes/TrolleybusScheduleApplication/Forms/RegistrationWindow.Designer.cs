﻿namespace TrolleybusScheduleApplication.Forms
{
    partial class RegistrationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondPasswordBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewPasswordError = new System.Windows.Forms.Label();
            this.SecondPasswordError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.LoginError = new System.Windows.Forms.Label();
            this.EmptyLogin = new System.Windows.Forms.Label();
            this.EmptyPassword = new System.Windows.Forms.Label();
            this.EmptySecondPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationButton.Location = new System.Drawing.Point(209, 449);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(132, 49);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Далее";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(182, 166);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(192, 46);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(209, 36);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(116, 46);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.Location = new System.Drawing.Point(122, 224);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Введите пароль";
            this.PasswordBox.Size = new System.Drawing.Size(302, 41);
            this.PasswordBox.TabIndex = 8;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBox.Location = new System.Drawing.Point(122, 94);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "Введите логин";
            this.LoginBox.Size = new System.Drawing.Size(302, 41);
            this.LoginBox.TabIndex = 7;
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Повторите пароль";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.Black;
            this.SecondPasswordBox.Location = new System.Drawing.Point(122, 374);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.PlaceholderText = "Введите пароль еще раз";
            this.SecondPasswordBox.Size = new System.Drawing.Size(307, 41);
            this.SecondPasswordBox.TabIndex = 12;
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            this.SecondPasswordBox.TextChanged += new System.EventHandler(this.SecondPasswordBox_TextChanged);
            this.SecondPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondPasswordBox_KeyDown);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(21, 552);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 38);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewPasswordError
            // 
            this.NewPasswordError.AutoSize = true;
            this.NewPasswordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordError.ForeColor = System.Drawing.Color.Red;
            this.NewPasswordError.Location = new System.Drawing.Point(143, 510);
            this.NewPasswordError.Name = "NewPasswordError";
            this.NewPasswordError.Size = new System.Drawing.Size(261, 28);
            this.NewPasswordError.TabIndex = 15;
            this.NewPasswordError.Text = "Пароли должны совпадать";
            this.NewPasswordError.Visible = false;
            // 
            // SecondPasswordError
            // 
            this.SecondPasswordError.AutoSize = true;
            this.SecondPasswordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordError.ForeColor = System.Drawing.Color.Red;
            this.SecondPasswordError.Location = new System.Drawing.Point(169, 418);
            this.SecondPasswordError.Name = "SecondPasswordError";
            this.SecondPasswordError.Size = new System.Drawing.Size(214, 28);
            this.SecondPasswordError.TabIndex = 16;
            this.SecondPasswordError.Text = "Пароли не совпадают";
            this.SecondPasswordError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(131, 268);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(254, 28);
            this.PasswordError.TabIndex = 17;
            this.PasswordError.Text = "Неверный формат пароля";
            this.PasswordError.Visible = false;
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(131, 138);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(252, 28);
            this.LoginError.TabIndex = 18;
            this.LoginError.Text = "Неверный формат логина";
            this.LoginError.Visible = false;
            // 
            // EmptyLogin
            // 
            this.EmptyLogin.AutoSize = true;
            this.EmptyLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmptyLogin.ForeColor = System.Drawing.Color.Red;
            this.EmptyLogin.Location = new System.Drawing.Point(426, 102);
            this.EmptyLogin.Name = "EmptyLogin";
            this.EmptyLogin.Size = new System.Drawing.Size(65, 28);
            this.EmptyLogin.TabIndex = 19;
            this.EmptyLogin.Text = "label2";
            this.EmptyLogin.Visible = false;
            // 
            // EmptyPassword
            // 
            this.EmptyPassword.AutoSize = true;
            this.EmptyPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptyPassword.Location = new System.Drawing.Point(426, 232);
            this.EmptyPassword.Name = "EmptyPassword";
            this.EmptyPassword.Size = new System.Drawing.Size(65, 28);
            this.EmptyPassword.TabIndex = 20;
            this.EmptyPassword.Text = "label2";
            this.EmptyPassword.Visible = false;
            // 
            // EmptySecondPassword
            // 
            this.EmptySecondPassword.AutoSize = true;
            this.EmptySecondPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmptySecondPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptySecondPassword.Location = new System.Drawing.Point(430, 382);
            this.EmptySecondPassword.Name = "EmptySecondPassword";
            this.EmptySecondPassword.Size = new System.Drawing.Size(65, 28);
            this.EmptySecondPassword.TabIndex = 21;
            this.EmptySecondPassword.Text = "label2";
            this.EmptySecondPassword.Visible = false;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 602);
            this.Controls.Add(this.EmptySecondPassword);
            this.Controls.Add(this.EmptyPassword);
            this.Controls.Add(this.EmptyLogin);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.SecondPasswordError);
            this.Controls.Add(this.NewPasswordError);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPasswordBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LoginLabel;
        private Button BackButton;
        private Label NewPasswordError;
        protected TextBox PasswordBox;
        protected TextBox LoginBox;
        protected TextBox SecondPasswordBox;
        protected Label EmptyLogin;
        protected Label EmptyPassword;
        protected Label EmptySecondPassword;
        protected Button RegistrationButton;
        protected Label PasswordLabel;
        protected Label label1;
        protected Label SecondPasswordError;
        protected Label PasswordError;
        protected Label LoginError;
    }
}