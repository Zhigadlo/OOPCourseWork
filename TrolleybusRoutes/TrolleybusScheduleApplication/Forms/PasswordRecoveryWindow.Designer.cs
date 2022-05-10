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
            this.RecoveryButton.Location = new System.Drawing.Point(107, 218);
            this.RecoveryButton.Name = "RecoveryButton";
            this.RecoveryButton.Size = new System.Drawing.Size(135, 29);
            this.RecoveryButton.TabIndex = 0;
            this.RecoveryButton.Text = "Восстановить";
            this.RecoveryButton.UseVisualStyleBackColor = true;
            this.RecoveryButton.Click += new System.EventHandler(this.RecoveryButton_Click);
            // 
            // EmptySecondPassword
            // 
            this.EmptySecondPassword.AutoSize = true;
            this.EmptySecondPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptySecondPassword.Location = new System.Drawing.Point(291, 158);
            this.EmptySecondPassword.Name = "EmptySecondPassword";
            this.EmptySecondPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptySecondPassword.TabIndex = 29;
            this.EmptySecondPassword.Text = "label2";
            this.EmptySecondPassword.Visible = false;
            // 
            // EmptyPassword
            // 
            this.EmptyPassword.AutoSize = true;
            this.EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.EmptyPassword.Location = new System.Drawing.Point(293, 61);
            this.EmptyPassword.Name = "EmptyPassword";
            this.EmptyPassword.Size = new System.Drawing.Size(50, 20);
            this.EmptyPassword.TabIndex = 28;
            this.EmptyPassword.Text = "label2";
            this.EmptyPassword.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(84, 95);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(194, 20);
            this.PasswordError.TabIndex = 27;
            this.PasswordError.Text = "Неверный формат пароля";
            this.PasswordError.Visible = false;
            // 
            // SecondPasswordError
            // 
            this.SecondPasswordError.AutoSize = true;
            this.SecondPasswordError.ForeColor = System.Drawing.Color.Red;
            this.SecondPasswordError.Location = new System.Drawing.Point(95, 185);
            this.SecondPasswordError.Name = "SecondPasswordError";
            this.SecondPasswordError.Size = new System.Drawing.Size(163, 20);
            this.SecondPasswordError.TabIndex = 26;
            this.SecondPasswordError.Text = "Пароли не совпадают";
            this.SecondPasswordError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Повторите пароль";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.Black;
            this.SecondPasswordBox.Location = new System.Drawing.Point(84, 155);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.PlaceholderText = "Введите пароль еще раз";
            this.SecondPasswordBox.Size = new System.Drawing.Size(195, 27);
            this.SecondPasswordBox.TabIndex = 24;
            this.SecondPasswordBox.UseSystemPasswordChar = true;
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(84, 27);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(192, 28);
            this.PasswordLabel.TabIndex = 23;
            this.PasswordLabel.Text = "Новый пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.Location = new System.Drawing.Point(83, 58);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Введите пароль";
            this.PasswordBox.Size = new System.Drawing.Size(195, 27);
            this.PasswordBox.TabIndex = 22;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            // 
            // PasswordRecoveryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
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