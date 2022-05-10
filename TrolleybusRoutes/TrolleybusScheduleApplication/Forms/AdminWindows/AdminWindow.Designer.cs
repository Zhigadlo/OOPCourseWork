namespace TrolleybusScheduleApplication.Forms.AdminWindows
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
            this.CheckScheduleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.RouteManageButton = new System.Windows.Forms.Button();
            this.UserManagrButton = new System.Windows.Forms.Button();
            this.StopManageButton = new System.Windows.Forms.Button();
            this.XmlReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckScheduleButton
            // 
            this.CheckScheduleButton.Location = new System.Drawing.Point(104, 57);
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
            this.label1.Location = new System.Drawing.Point(198, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Меню";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 258);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // RouteManageButton
            // 
            this.RouteManageButton.Location = new System.Drawing.Point(104, 92);
            this.RouteManageButton.Name = "RouteManageButton";
            this.RouteManageButton.Size = new System.Drawing.Size(257, 29);
            this.RouteManageButton.TabIndex = 8;
            this.RouteManageButton.Text = "Управление маршрутами";
            this.RouteManageButton.UseVisualStyleBackColor = true;
            this.RouteManageButton.Click += new System.EventHandler(this.RouteManageButton_Click);
            // 
            // UserManagrButton
            // 
            this.UserManagrButton.Location = new System.Drawing.Point(104, 162);
            this.UserManagrButton.Name = "UserManagrButton";
            this.UserManagrButton.Size = new System.Drawing.Size(257, 29);
            this.UserManagrButton.TabIndex = 9;
            this.UserManagrButton.Text = "Управление пользователями";
            this.UserManagrButton.UseVisualStyleBackColor = true;
            this.UserManagrButton.Click += new System.EventHandler(this.UserManagrButton_Click);
            // 
            // StopManageButton
            // 
            this.StopManageButton.Location = new System.Drawing.Point(104, 127);
            this.StopManageButton.Name = "StopManageButton";
            this.StopManageButton.Size = new System.Drawing.Size(257, 29);
            this.StopManageButton.TabIndex = 10;
            this.StopManageButton.Text = "Управление остановками";
            this.StopManageButton.UseVisualStyleBackColor = true;
            this.StopManageButton.Click += new System.EventHandler(this.StopManageButton_Click);
            // 
            // XmlReportButton
            // 
            this.XmlReportButton.Location = new System.Drawing.Point(104, 197);
            this.XmlReportButton.Name = "XmlReportButton";
            this.XmlReportButton.Size = new System.Drawing.Size(257, 29);
            this.XmlReportButton.TabIndex = 11;
            this.XmlReportButton.Text = "Отчет по маршрутам в xml";
            this.XmlReportButton.UseVisualStyleBackColor = true;
            this.XmlReportButton.Click += new System.EventHandler(this.XmlReportButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 299);
            this.Controls.Add(this.XmlReportButton);
            this.Controls.Add(this.StopManageButton);
            this.Controls.Add(this.UserManagrButton);
            this.Controls.Add(this.RouteManageButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckScheduleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CheckScheduleButton;
        private Label label1;
        private Button QuitButton;
        private Button RouteManageButton;
        private Button UserManagrButton;
        private Button StopManageButton;
        private Button XmlReportButton;
    }
}