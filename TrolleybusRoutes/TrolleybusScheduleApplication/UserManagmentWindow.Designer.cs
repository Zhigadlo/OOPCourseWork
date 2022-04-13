namespace TrolleybusScheduleApplication
{
    partial class UserManagmentWindow
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.EmptyPassword = new System.Windows.Forms.Label();
            this.EmptyLogin = new System.Windows.Forms.Label();
            this.LoginError = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordError = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmptySecondPassword = new System.Windows.Forms.Label();
            this.SecondPasswordError = new System.Windows.Forms.Label();
            this.NewPasswordError = new System.Windows.Forms.Label();
            this.SecondPasswordLabel = new System.Windows.Forms.Label();
            this.SecondPasswordBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(50, 12);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(211, 29);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Добавить пользователя";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(284, 12);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(216, 29);
            this.ChangeRoleButton.TabIndex = 1;
            this.ChangeRoleButton.Text = "Смена роли пользователя";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(519, 12);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(229, 29);
            this.ChangePasswordButton.TabIndex = 2;
            this.ChangePasswordButton.Text = "Смена пароля пользователя";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // EmptyPassword
            // 
            this.EmptyPassword.AutoSize = true;
            this.EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptyPassword.Location = new System.Drawing.Point(515, 226);
            this.EmptyPassword.Name = "EmptyPassword";
            this.EmptyPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptyPassword.TabIndex = 27;
            this.EmptyPassword.Text = "label2";
            this.EmptyPassword.Visible = false;
            // 
            // EmptyLogin
            // 
            this.EmptyLogin.AutoSize = true;
            this.EmptyLogin.ForeColor = System.Drawing.Color.Red;
            this.EmptyLogin.Location = new System.Drawing.Point(516, 145);
            this.EmptyLogin.Name = "EmptyLogin";
            this.EmptyLogin.Size = new System.Drawing.Size(50, 20);
            this.EmptyLogin.TabIndex = 26;
            this.EmptyLogin.Text = "label2";
            this.EmptyLogin.Visible = false;
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(306, 172);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(192, 20);
            this.LoginError.TabIndex = 25;
            this.LoginError.Text = "Неверный формат логина";
            this.LoginError.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(364, 192);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 28);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(367, 107);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(69, 28);
            this.LoginLabel.TabIndex = 23;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.Visible = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordBox.Location = new System.Drawing.Point(305, 223);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(195, 27);
            this.PasswordBox.TabIndex = 22;
            this.PasswordBox.Text = "Введите пароль";
            this.PasswordBox.Visible = false;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // LoginBox
            // 
            this.LoginBox.ForeColor = System.Drawing.Color.LightGray;
            this.LoginBox.Location = new System.Drawing.Point(305, 138);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(195, 27);
            this.LoginBox.TabIndex = 21;
            this.LoginBox.Text = "Введите логин";
            this.LoginBox.Visible = false;
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(305, 262);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(194, 20);
            this.PasswordError.TabIndex = 28;
            this.PasswordError.Text = "Неверный формат пароля";
            this.PasswordError.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(306, 61);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(65, 28);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "label1";
            this.TitleLabel.Visible = false;
            // 
            // EmptySecondPassword
            // 
            this.EmptySecondPassword.AutoSize = true;
            this.EmptySecondPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptySecondPassword.Location = new System.Drawing.Point(512, 321);
            this.EmptySecondPassword.Name = "EmptySecondPassword";
            this.EmptySecondPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptySecondPassword.TabIndex = 35;
            this.EmptySecondPassword.Text = "label2";
            this.EmptySecondPassword.Visible = false;
            // 
            // SecondPasswordError
            // 
            this.SecondPasswordError.AutoSize = true;
            this.SecondPasswordError.ForeColor = System.Drawing.Color.Red;
            this.SecondPasswordError.Location = new System.Drawing.Point(316, 348);
            this.SecondPasswordError.Name = "SecondPasswordError";
            this.SecondPasswordError.Size = new System.Drawing.Size(163, 20);
            this.SecondPasswordError.TabIndex = 34;
            this.SecondPasswordError.Text = "Пароли не совпадают";
            this.SecondPasswordError.Visible = false;
            // 
            // NewPasswordError
            // 
            this.NewPasswordError.AutoSize = true;
            this.NewPasswordError.ForeColor = System.Drawing.Color.Red;
            this.NewPasswordError.Location = new System.Drawing.Point(303, 410);
            this.NewPasswordError.Name = "NewPasswordError";
            this.NewPasswordError.Size = new System.Drawing.Size(198, 20);
            this.NewPasswordError.TabIndex = 33;
            this.NewPasswordError.Text = "Пароли должны совпадать";
            this.NewPasswordError.Visible = false;
            // 
            // SecondPasswordLabel
            // 
            this.SecondPasswordLabel.AutoSize = true;
            this.SecondPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordLabel.Location = new System.Drawing.Point(309, 287);
            this.SecondPasswordLabel.Name = "SecondPasswordLabel";
            this.SecondPasswordLabel.Size = new System.Drawing.Size(183, 28);
            this.SecondPasswordLabel.TabIndex = 32;
            this.SecondPasswordLabel.Text = "Повторите пароль";
            this.SecondPasswordLabel.Visible = false;
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.SecondPasswordBox.Location = new System.Drawing.Point(305, 318);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.Size = new System.Drawing.Size(195, 27);
            this.SecondPasswordBox.TabIndex = 31;
            this.SecondPasswordBox.Text = "Введите пароль еще раз";
            this.SecondPasswordBox.Visible = false;
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            this.SecondPasswordBox.TextChanged += new System.EventHandler(this.SecondPasswordBox_TextChanged);
            this.SecondPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondPasswordBox_KeyDown);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(329, 378);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(132, 29);
            this.RegistrationButton.TabIndex = 30;
            this.RegistrationButton.Text = "Добавить";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Visible = false;
            this.RegistrationButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 409);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 36;
            this.QuitButton.Text = "Назад";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // UserManagmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.EmptySecondPassword);
            this.Controls.Add(this.SecondPasswordError);
            this.Controls.Add(this.NewPasswordError);
            this.Controls.Add(this.SecondPasswordLabel);
            this.Controls.Add(this.SecondPasswordBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.EmptyPassword);
            this.Controls.Add(this.EmptyLogin);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.AddUserButton);
            this.Name = "UserManagmentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для управления пользователями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddUserButton;
        private Button ChangeRoleButton;
        private Button ChangePasswordButton;
        private Label EmptyPassword;
        private Label EmptyLogin;
        private Label LoginError;
        private Label PasswordLabel;
        private Label LoginLabel;
        private TextBox PasswordBox;
        private TextBox LoginBox;
        private Label PasswordError;
        private Label TitleLabel;
        private Label EmptySecondPassword;
        private Label SecondPasswordError;
        private Label NewPasswordError;
        private Label SecondPasswordLabel;
        private TextBox SecondPasswordBox;
        private Button RegistrationButton;
        private Button QuitButton;
    }
}