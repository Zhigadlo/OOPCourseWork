namespace TrolleybusScheduleApplication
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
            this.RegistrationButton.Location = new System.Drawing.Point(328, 328);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(132, 29);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Далее";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(362, 140);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 28);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(365, 55);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(69, 28);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordBox
            // 
            this.PasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordBox.Location = new System.Drawing.Point(303, 171);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(195, 27);
            this.PasswordBox.TabIndex = 8;
            this.PasswordBox.Text = "Введите пароль";
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // LoginBox
            // 
            this.LoginBox.ForeColor = System.Drawing.Color.LightGray;
            this.LoginBox.Location = new System.Drawing.Point(303, 86);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(195, 27);
            this.LoginBox.TabIndex = 7;
            this.LoginBox.Text = "Введите логин";
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Повторите пароль";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.SecondPasswordBox.Location = new System.Drawing.Point(304, 268);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.Size = new System.Drawing.Size(195, 27);
            this.SecondPasswordBox.TabIndex = 12;
            this.SecondPasswordBox.Text = "Введите пароль еще раз";
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            this.SecondPasswordBox.TextChanged += new System.EventHandler(this.SecondPasswordBox_TextChanged);
            this.SecondPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondPasswordBox_KeyDown);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 409);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewPasswordError
            // 
            this.NewPasswordError.AutoSize = true;
            this.NewPasswordError.ForeColor = System.Drawing.Color.Red;
            this.NewPasswordError.Location = new System.Drawing.Point(302, 360);
            this.NewPasswordError.Name = "NewPasswordError";
            this.NewPasswordError.Size = new System.Drawing.Size(198, 20);
            this.NewPasswordError.TabIndex = 15;
            this.NewPasswordError.Text = "Пароли должны совпадать";
            this.NewPasswordError.Visible = false;
            // 
            // SecondPasswordError
            // 
            this.SecondPasswordError.AutoSize = true;
            this.SecondPasswordError.ForeColor = System.Drawing.Color.Red;
            this.SecondPasswordError.Location = new System.Drawing.Point(315, 298);
            this.SecondPasswordError.Name = "SecondPasswordError";
            this.SecondPasswordError.Size = new System.Drawing.Size(163, 20);
            this.SecondPasswordError.TabIndex = 16;
            this.SecondPasswordError.Text = "Пароли не совпадают";
            this.SecondPasswordError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(304, 208);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(194, 20);
            this.PasswordError.TabIndex = 17;
            this.PasswordError.Text = "Неверный формат пароля";
            this.PasswordError.Visible = false;
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(304, 120);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(192, 20);
            this.LoginError.TabIndex = 18;
            this.LoginError.Text = "Неверный формат логина";
            this.LoginError.Visible = false;
            // 
            // EmptyLogin
            // 
            this.EmptyLogin.AutoSize = true;
            this.EmptyLogin.ForeColor = System.Drawing.Color.Red;
            this.EmptyLogin.Location = new System.Drawing.Point(514, 93);
            this.EmptyLogin.Name = "EmptyLogin";
            this.EmptyLogin.Size = new System.Drawing.Size(50, 20);
            this.EmptyLogin.TabIndex = 19;
            this.EmptyLogin.Text = "label2";
            this.EmptyLogin.Visible = false;
            // 
            // EmptyPassword
            // 
            this.EmptyPassword.AutoSize = true;
            this.EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptyPassword.Location = new System.Drawing.Point(513, 174);
            this.EmptyPassword.Name = "EmptyPassword";
            this.EmptyPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptyPassword.TabIndex = 20;
            this.EmptyPassword.Text = "label2";
            this.EmptyPassword.Visible = false;
            // 
            // EmptySecondPassword
            // 
            this.EmptySecondPassword.AutoSize = true;
            this.EmptySecondPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptySecondPassword.Location = new System.Drawing.Point(511, 271);
            this.EmptySecondPassword.Name = "EmptySecondPassword";
            this.EmptySecondPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptySecondPassword.TabIndex = 21;
            this.EmptySecondPassword.Text = "label2";
            this.EmptySecondPassword.Visible = false;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegistrationButton;
        private Label PasswordLabel;
        private Label LoginLabel;
        private TextBox PasswordBox;
        private TextBox LoginBox;
        private Label label1;
        private TextBox SecondPasswordBox;
        private Button BackButton;
        private Label NewPasswordError;
        private Label SecondPasswordError;
        private Label PasswordError;
        private Label LoginError;
        private Label EmptyLogin;
        private Label EmptyPassword;
        private Label EmptySecondPassword;
    }
}