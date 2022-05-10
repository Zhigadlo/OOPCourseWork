namespace TrolleybusScheduleApplication.Forms.AdminWindows.UserManage
{
    partial class AddUserForm
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
            this.EmptyLogin = new System.Windows.Forms.Label();
            this.LoginError = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmptyLogin
            // 
            this.EmptyLogin.AutoSize = true;
            this.EmptyLogin.ForeColor = System.Drawing.Color.Red;
            this.EmptyLogin.Location = new System.Drawing.Point(288, 49);
            this.EmptyLogin.Name = "EmptyLogin";
            this.EmptyLogin.Size = new System.Drawing.Size(50, 20);
            this.EmptyLogin.TabIndex = 23;
            this.EmptyLogin.Text = "label2";
            this.EmptyLogin.Visible = false;
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(78, 76);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(192, 20);
            this.LoginError.TabIndex = 22;
            this.LoginError.Text = "Неверный формат логина";
            this.LoginError.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(50, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(272, 28);
            this.LoginLabel.TabIndex = 21;
            this.LoginLabel.Text = "Логин нового пользователя";
            // 
            // LoginBox
            // 
            this.LoginBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBox.Location = new System.Drawing.Point(77, 42);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "Введите логин";
            this.LoginBox.Size = new System.Drawing.Size(195, 27);
            this.LoginBox.TabIndex = 20;
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(123, 101);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(94, 29);
            this.AddUserButton.TabIndex = 24;
            this.AddUserButton.Text = "Добавить";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 142);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.EmptyLogin);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label EmptyLogin;
        protected Label LoginError;
        private Label LoginLabel;
        protected TextBox LoginBox;
        private Button AddUserButton;
    }
}