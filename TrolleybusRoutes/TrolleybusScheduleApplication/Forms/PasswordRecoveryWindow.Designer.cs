namespace TrolleybusScheduleApplication.Forms
{
    partial class PasswordRecoveryWindow
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
            this.RecoveryButton = new System.Windows.Forms.Button();
            this.EmptySecondPassword = new System.Windows.Forms.Label();
            this.EmptyPassword = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.SecondPasswordError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondPasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RecoveryButton
            // 
            this.RecoveryButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecoveryButton.Location = new System.Drawing.Point(200, 300);
            this.RecoveryButton.Name = "RecoveryButton";
            this.RecoveryButton.Size = new System.Drawing.Size(185, 51);
            this.RecoveryButton.TabIndex = 0;
            this.RecoveryButton.Text = "Восстановить";
            this.RecoveryButton.UseVisualStyleBackColor = true;
            this.RecoveryButton.Click += new System.EventHandler(this.RecoveryButton_Click);
            // 
            // EmptySecondPassword
            // 
            this.EmptySecondPassword.AutoSize = true;
            this.EmptySecondPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmptySecondPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptySecondPassword.Location = new System.Drawing.Point(451, 224);
            this.EmptySecondPassword.Name = "EmptySecondPassword";
            this.EmptySecondPassword.Size = new System.Drawing.Size(65, 28);
            this.EmptySecondPassword.TabIndex = 29;
            this.EmptySecondPassword.Text = "label2";
            this.EmptySecondPassword.Visible = false;
            // 
            // EmptyPassword
            // 
            this.EmptyPassword.AutoSize = true;
            this.EmptyPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptyPassword.Location = new System.Drawing.Point(451, 65);
            this.EmptyPassword.Name = "EmptyPassword";
            this.EmptyPassword.Size = new System.Drawing.Size(65, 28);
            this.EmptyPassword.TabIndex = 28;
            this.EmptyPassword.Text = "label2";
            this.EmptyPassword.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(168, 128);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(254, 28);
            this.PasswordError.TabIndex = 27;
            this.PasswordError.Text = "Неверный формат пароля";
            this.PasswordError.Visible = false;
            this.PasswordError.Click += new System.EventHandler(this.PasswordError_Click);
            // 
            // SecondPasswordError
            // 
            this.SecondPasswordError.AutoSize = true;
            this.SecondPasswordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordError.ForeColor = System.Drawing.Color.Red;
            this.SecondPasswordError.Location = new System.Drawing.Point(190, 260);
            this.SecondPasswordError.Name = "SecondPasswordError";
            this.SecondPasswordError.Size = new System.Drawing.Size(214, 28);
            this.SecondPasswordError.TabIndex = 26;
            this.SecondPasswordError.Text = "Пароли не совпадают";
            this.SecondPasswordError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "Повторите пароль";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.Black;
            this.SecondPasswordBox.Location = new System.Drawing.Point(143, 216);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.PlaceholderText = "Введите пароль еще раз";
            this.SecondPasswordBox.Size = new System.Drawing.Size(302, 41);
            this.SecondPasswordBox.TabIndex = 24;
            this.SecondPasswordBox.UseSystemPasswordChar = true;
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(156, 16);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(276, 56);
            this.PasswordLabel.TabIndex = 23;
            this.PasswordLabel.Text = "Новый пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.Location = new System.Drawing.Point(143, 75);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Введите пароль";
            this.PasswordBox.Size = new System.Drawing.Size(302, 41);
            this.PasswordBox.TabIndex = 22;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            // 
            // PasswordRecoveryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 363);
            this.Controls.Add(this.EmptySecondPassword);
            this.Controls.Add(this.EmptyPassword);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.SecondPasswordError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.RecoveryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordRecoveryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RecoveryButton;
        protected Label EmptySecondPassword;
        protected Label EmptyPassword;
        protected Label PasswordError;
        protected Label SecondPasswordError;
        protected Label label1;
        protected TextBox SecondPasswordBox;
        protected Label PasswordLabel;
        protected TextBox PasswordBox;
    }
}