namespace TrolleybusScheduleApplication.Controls
{
    partial class ControlForUsers
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.PasswordDropButton = new System.Windows.Forms.Button();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(18, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 31);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Логин:";
            // 
            // PasswordDropButton
            // 
            this.PasswordDropButton.Location = new System.Drawing.Point(10, 65);
            this.PasswordDropButton.Name = "PasswordDropButton";
            this.PasswordDropButton.Size = new System.Drawing.Size(170, 29);
            this.PasswordDropButton.TabIndex = 1;
            this.PasswordDropButton.Text = "Сбросить пароль";
            this.PasswordDropButton.UseVisualStyleBackColor = true;
            this.PasswordDropButton.Click += new System.EventHandler(this.PasswordDropButton_Click);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(186, 65);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(155, 29);
            this.ChangeRoleButton.TabIndex = 2;
            this.ChangeRoleButton.Text = "Изменить роль";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(347, 65);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(185, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить пользователя";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(106, 19);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(71, 31);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(321, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 31);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Роль:";
            // 
            // UserRole
            // 
            this.UserRole.AutoSize = true;
            this.UserRole.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserRole.Location = new System.Drawing.Point(396, 19);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(58, 31);
            this.UserRole.TabIndex = 6;
            this.UserRole.Text = "Role";
            // 
            // ControlForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.UserRole);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.PasswordDropButton);
            this.Controls.Add(this.Label1);
            this.Name = "ControlForUsers";
            this.Size = new System.Drawing.Size(545, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label1;
        private Label Label2;
        public Label LoginLabel;
        public Label UserRole;
        public Button PasswordDropButton;
        public Button DeleteButton;
        public Button ChangeRoleButton;
    }
}
