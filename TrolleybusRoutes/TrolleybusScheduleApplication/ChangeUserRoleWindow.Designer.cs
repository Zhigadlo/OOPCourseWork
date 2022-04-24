namespace TrolleybusScheduleApplication
{
    partial class ChangeUserRoleWindow
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
            this.LoginError = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.RoleError = new System.Windows.Forms.Label();
            this.EmptyLogin = new System.Windows.Forms.Label();
            this.EmptyRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(140, 98);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(287, 20);
            this.LoginError.TabIndex = 25;
            this.LoginError.Text = "Такого пользователя нет в базе данных";
            this.LoginError.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(205, 118);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(119, 28);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Новая роль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(169, 33);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(200, 28);
            this.LoginLabel.TabIndex = 23;
            this.LoginLabel.Text = "Логин пользователя";
            // 
            // LoginBox
            // 
            this.LoginBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBox.Location = new System.Drawing.Point(167, 64);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "Введите логин";
            this.LoginBox.Size = new System.Drawing.Size(195, 27);
            this.LoginBox.TabIndex = 21;
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(167, 149);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(195, 28);
            this.RoleComboBox.TabIndex = 28;
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(193, 209);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(131, 29);
            this.ChangeRoleButton.TabIndex = 29;
            this.ChangeRoleButton.Text = "Сменить роль";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // RoleError
            // 
            this.RoleError.AutoSize = true;
            this.RoleError.ForeColor = System.Drawing.Color.Red;
            this.RoleError.Location = new System.Drawing.Point(205, 186);
            this.RoleError.Name = "RoleError";
            this.RoleError.Size = new System.Drawing.Size(116, 20);
            this.RoleError.TabIndex = 30;
            this.RoleError.Text = "Такой роли нет";
            this.RoleError.Visible = false;
            // 
            // EmptyLogin
            // 
            this.EmptyLogin.AutoSize = true;
            this.EmptyLogin.ForeColor = System.Drawing.Color.Red;
            this.EmptyLogin.Location = new System.Drawing.Point(368, 67);
            this.EmptyLogin.Name = "EmptyLogin";
            this.EmptyLogin.Size = new System.Drawing.Size(150, 20);
            this.EmptyLogin.TabIndex = 31;
            this.EmptyLogin.Text = "Вы не ввели пароль";
            this.EmptyLogin.Visible = false;
            // 
            // EmptyRole
            // 
            this.EmptyRole.AutoSize = true;
            this.EmptyRole.ForeColor = System.Drawing.Color.Red;
            this.EmptyRole.Location = new System.Drawing.Point(368, 152);
            this.EmptyRole.Name = "EmptyRole";
            this.EmptyRole.Size = new System.Drawing.Size(154, 20);
            this.EmptyRole.TabIndex = 32;
            this.EmptyRole.Text = "Вы не выбрали роль";
            this.EmptyRole.Visible = false;
            // 
            // ChangeUserRoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(546, 295);
            this.Controls.Add(this.EmptyRole);
            this.Controls.Add(this.EmptyLogin);
            this.Controls.Add(this.RoleError);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginBox);
            this.Name = "ChangeUserRoleWindow";
            this.Text = "Изменение роли ползователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LoginError;
        private Label PasswordLabel;
        private Label LoginLabel;
        private TextBox LoginBox;
        private ComboBox RoleComboBox;
        private Button ChangeRoleButton;
        private Label RoleError;
        private Label EmptyLogin;
        private Label EmptyRole;
    }
}