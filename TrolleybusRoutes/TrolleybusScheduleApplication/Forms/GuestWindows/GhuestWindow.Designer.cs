namespace TrolleybusScheduleApplication.Forms.GuestWindows
{
    partial class GhuestWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.BoxForNumbers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.PanelForControls = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShowAllRoutesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxForNumbers
            // 
            this.BoxForNumbers.FormattingEnabled = true;
            this.BoxForNumbers.Location = new System.Drawing.Point(98, 36);
            this.BoxForNumbers.Name = "BoxForNumbers";
            this.BoxForNumbers.Size = new System.Drawing.Size(54, 28);
            this.BoxForNumbers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор маршрута";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(78, 70);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(32, 500);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PanelForControls
            // 
            this.PanelForControls.Location = new System.Drawing.Point(32, 140);
            this.PanelForControls.Name = "PanelForControls";
            this.PanelForControls.Size = new System.Drawing.Size(577, 354);
            this.PanelForControls.TabIndex = 6;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(182, 100);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(250, 37);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "label2";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowAllRoutesButton
            // 
            this.ShowAllRoutesButton.Location = new System.Drawing.Point(438, 105);
            this.ShowAllRoutesButton.Name = "ShowAllRoutesButton";
            this.ShowAllRoutesButton.Size = new System.Drawing.Size(159, 29);
            this.ShowAllRoutesButton.TabIndex = 8;
            this.ShowAllRoutesButton.Text = "Все маршруты";
            this.ShowAllRoutesButton.UseVisualStyleBackColor = true;
            this.ShowAllRoutesButton.Click += new System.EventHandler(this.ShowAllRoutesButton_Click);
            // 
            // GhuestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.ShowAllRoutesButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PanelForControls);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxForNumbers);
            this.Name = "GhuestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание троллейбусов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GhuestWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ComboBox BoxForNumbers;
        protected Label label1;
        protected Button FindButton;
        protected Button QuitButton;
        private FlowLayoutPanel PanelForControls;
        private Label TitleLabel;
        private Button ShowAllRoutesButton;
    }
}