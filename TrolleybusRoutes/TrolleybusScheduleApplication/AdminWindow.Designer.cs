namespace TrolleybusScheduleApplication
{
    partial class AdminWindow
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
            this.ChangeUserInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckScheduleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeUserInfoButton
            // 
            this.ChangeUserInfoButton.Location = new System.Drawing.Point(266, 141);
            this.ChangeUserInfoButton.Name = "ChangeUserInfoButton";
            this.ChangeUserInfoButton.Size = new System.Drawing.Size(257, 29);
            this.ChangeUserInfoButton.TabIndex = 0;
            this.ChangeUserInfoButton.Text = "Смена роли пользователя";
            this.ChangeUserInfoButton.UseVisualStyleBackColor = true;
            this.ChangeUserInfoButton.Click += new System.EventHandler(this.ChangeUserInfoButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить маршрут в базу данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CheckScheduleButton
            // 
            this.CheckScheduleButton.Location = new System.Drawing.Point(266, 106);
            this.CheckScheduleButton.Name = "CheckScheduleButton";
            this.CheckScheduleButton.Size = new System.Drawing.Size(257, 29);
            this.CheckScheduleButton.TabIndex = 2;
            this.CheckScheduleButton.Text = "Посмотреть расписание";
            this.CheckScheduleButton.UseVisualStyleBackColor = true;
            this.CheckScheduleButton.Click += new System.EventHandler(this.CheckScheduleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Меню";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 409);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавление пользователя";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Смена пароля пользователя";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Удалить остановку из базы ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckScheduleButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeUserInfoButton);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChangeUserInfoButton;
        private Button button1;
        private Button CheckScheduleButton;
        private Label label1;
        private Button QuitButton;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}