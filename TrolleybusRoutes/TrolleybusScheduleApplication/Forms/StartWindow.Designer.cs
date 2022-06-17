namespace TrolleybusScheduleApplication.Forms
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.GhuestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordLoginError = new System.Windows.Forms.Label();
            this.LoginError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(192, 336);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(177, 47);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBox.Location = new System.Drawing.Point(174, 98);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "Введите логин";
            this.LoginBox.Size = new System.Drawing.Size(214, 41);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.Location = new System.Drawing.Point(174, 219);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Введите пароль";
            this.PasswordBox.Size = new System.Drawing.Size(214, 41);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(214, 49);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(116, 46);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(210, 170);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 46);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationButton.Location = new System.Drawing.Point(192, 389);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(177, 46);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // GhuestLinkLabel
            // 
            this.GhuestLinkLabel.AutoSize = true;
            this.GhuestLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GhuestLinkLabel.Location = new System.Drawing.Point(201, 438);
            this.GhuestLinkLabel.Name = "GhuestLinkLabel";
            this.GhuestLinkLabel.Size = new System.Drawing.Size(154, 28);
            this.GhuestLinkLabel.TabIndex = 6;
            this.GhuestLinkLabel.TabStop = true;
            this.GhuestLinkLabel.Text = "Войти как гость";
            this.GhuestLinkLabel.Click += new System.EventHandler(this.GhuestLinkLabel_Click);
            // 
            // PasswordLoginError
            // 
            this.PasswordLoginError.AutoSize = true;
            this.PasswordLoginError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLoginError.ForeColor = System.Drawing.Color.Red;
            this.PasswordLoginError.Location = new System.Drawing.Point(59, 298);
            this.PasswordLoginError.Name = "PasswordLoginError";
            this.PasswordLoginError.Size = new System.Drawing.Size(457, 35);
            this.PasswordLoginError.TabIndex = 7;
            this.PasswordLoginError.Text = "Неправльно введен логин или пароль";
            this.PasswordLoginError.Visible = false;
            this.PasswordLoginError.Click += new System.EventHandler(this.PasswordLoginError_Click);
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(201, 142);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(145, 28);
            this.LoginError.TabIndex = 8;
            this.LoginError.Text = "Введите логин";
            this.LoginError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(183, 263);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(197, 35);
            this.PasswordError.TabIndex = 9;
            this.PasswordError.Text = "Введите пароль";
            this.PasswordError.Visible = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(552, 541);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.PasswordLoginError);
            this.Controls.Add(this.GhuestLinkLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button RegistrationButton;
        private LinkLabel GhuestLinkLabel;
        private Label PasswordLoginError;
        private Label LoginError;
        private Label PasswordError;
    }
}