namespace TrolleybusScheduleApplication.Forms.GuestWindows
{
    partial class GuestWindow
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
            this.FindRoutesBetweenStopsButton = new System.Windows.Forms.Button();
            this.FirstStopBox = new System.Windows.Forms.ComboBox();
            this.LastStopBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxForNumbers
            // 
            this.BoxForNumbers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxForNumbers.FormattingEnabled = true;
            this.BoxForNumbers.Location = new System.Drawing.Point(96, 53);
            this.BoxForNumbers.Name = "BoxForNumbers";
            this.BoxForNumbers.Size = new System.Drawing.Size(74, 43);
            this.BoxForNumbers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор маршрута";
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButton.Location = new System.Drawing.Point(81, 102);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(104, 47);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.Location = new System.Drawing.Point(12, 687);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(132, 42);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Выход";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PanelForControls
            // 
            this.PanelForControls.AutoScroll = true;
            this.PanelForControls.Location = new System.Drawing.Point(12, 211);
            this.PanelForControls.Name = "PanelForControls";
            this.PanelForControls.Size = new System.Drawing.Size(975, 470);
            this.PanelForControls.TabIndex = 6;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(32, 159);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(400, 37);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "label2";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // ShowAllRoutesButton
            // 
            this.ShowAllRoutesButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAllRoutesButton.Location = new System.Drawing.Point(772, 152);
            this.ShowAllRoutesButton.Name = "ShowAllRoutesButton";
            this.ShowAllRoutesButton.Size = new System.Drawing.Size(196, 44);
            this.ShowAllRoutesButton.TabIndex = 8;
            this.ShowAllRoutesButton.Text = "Все маршруты";
            this.ShowAllRoutesButton.UseVisualStyleBackColor = true;
            this.ShowAllRoutesButton.Click += new System.EventHandler(this.ShowAllRoutesButton_Click);
            // 
            // FindRoutesBetweenStopsButton
            // 
            this.FindRoutesBetweenStopsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindRoutesBetweenStopsButton.Location = new System.Drawing.Point(529, 102);
            this.FindRoutesBetweenStopsButton.Name = "FindRoutesBetweenStopsButton";
            this.FindRoutesBetweenStopsButton.Size = new System.Drawing.Size(159, 47);
            this.FindRoutesBetweenStopsButton.TabIndex = 9;
            this.FindRoutesBetweenStopsButton.Text = "Найти";
            this.FindRoutesBetweenStopsButton.UseVisualStyleBackColor = true;
            this.FindRoutesBetweenStopsButton.Visible = false;
            this.FindRoutesBetweenStopsButton.Click += new System.EventHandler(this.FindRoutesBetweenStopsButton_Click);
            // 
            // FirstStopBox
            // 
            this.FirstStopBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstStopBox.FormattingEnabled = true;
            this.FirstStopBox.Location = new System.Drawing.Point(380, 53);
            this.FirstStopBox.Name = "FirstStopBox";
            this.FirstStopBox.Size = new System.Drawing.Size(234, 43);
            this.FirstStopBox.TabIndex = 10;
            this.FirstStopBox.Visible = false;
            // 
            // LastStopBox
            // 
            this.LastStopBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastStopBox.FormattingEnabled = true;
            this.LastStopBox.Location = new System.Drawing.Point(661, 53);
            this.LastStopBox.Name = "LastStopBox";
            this.LastStopBox.Size = new System.Drawing.Size(234, 43);
            this.LastStopBox.TabIndex = 11;
            this.LastStopBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(380, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск маршрутов между остановками";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(342, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "от";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(620, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "до";
            this.label4.Visible = false;
            // 
            // GuestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastStopBox);
            this.Controls.Add(this.FirstStopBox);
            this.Controls.Add(this.FindRoutesBetweenStopsButton);
            this.Controls.Add(this.ShowAllRoutesButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PanelForControls);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxForNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание троллейбусов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ComboBox BoxForNumbers;
        protected Label label1;
        protected Button FindButton;
        private Label TitleLabel;
        private Button ShowAllRoutesButton;
        public Button QuitButton;
        protected FlowLayoutPanel PanelForControls;
        protected ComboBox FirstStopBox;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected Button FindRoutesBetweenStopsButton;
        protected ComboBox LastStopBox;
    }
}