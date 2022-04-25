﻿namespace TrolleybusScheduleApplication.Forms
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
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.CheckScheduleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangeUserPasswordButton = new System.Windows.Forms.Button();
            this.DeleteStopButton = new System.Windows.Forms.Button();
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
            // AddRouteButton
            // 
            this.AddRouteButton.Location = new System.Drawing.Point(266, 249);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(257, 29);
            this.AddRouteButton.TabIndex = 1;
            this.AddRouteButton.Text = "Добавить маршрут в базу данных";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
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
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(266, 176);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(257, 29);
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.Text = "Добавление пользователя";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangeUserPasswordButton
            // 
            this.ChangeUserPasswordButton.Location = new System.Drawing.Point(266, 211);
            this.ChangeUserPasswordButton.Name = "ChangeUserPasswordButton";
            this.ChangeUserPasswordButton.Size = new System.Drawing.Size(257, 29);
            this.ChangeUserPasswordButton.TabIndex = 6;
            this.ChangeUserPasswordButton.Text = "Смена пароля пользователя";
            this.ChangeUserPasswordButton.UseVisualStyleBackColor = true;
            this.ChangeUserPasswordButton.Click += new System.EventHandler(this.ChangeUserPasswordButton_Click);
            // 
            // DeleteStopButton
            // 
            this.DeleteStopButton.Location = new System.Drawing.Point(266, 284);
            this.DeleteStopButton.Name = "DeleteStopButton";
            this.DeleteStopButton.Size = new System.Drawing.Size(257, 29);
            this.DeleteStopButton.TabIndex = 7;
            this.DeleteStopButton.Text = "Удалить остановку из базы ";
            this.DeleteStopButton.UseVisualStyleBackColor = true;
            this.DeleteStopButton.Click += new System.EventHandler(this.DeleteStopButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteStopButton);
            this.Controls.Add(this.ChangeUserPasswordButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckScheduleButton);
            this.Controls.Add(this.AddRouteButton);
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
        private Button AddRouteButton;
        private Button CheckScheduleButton;
        private Label label1;
        private Button QuitButton;
        private Button AddUserButton;
        private Button ChangeUserPasswordButton;
        private Button DeleteStopButton;
    }
}