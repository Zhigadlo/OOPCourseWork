namespace TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage
{
    partial class AddScheduleWindow
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
            this.PanelForTime = new System.Windows.Forms.FlowLayoutPanel();
            this.AddScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelForTime
            // 
            this.PanelForTime.AutoScroll = true;
            this.PanelForTime.Location = new System.Drawing.Point(12, 12);
            this.PanelForTime.Name = "PanelForTime";
            this.PanelForTime.Size = new System.Drawing.Size(250, 255);
            this.PanelForTime.TabIndex = 0;
            // 
            // AddScheduleButton
            // 
            this.AddScheduleButton.Location = new System.Drawing.Point(84, 276);
            this.AddScheduleButton.Name = "AddScheduleButton";
            this.AddScheduleButton.Size = new System.Drawing.Size(94, 29);
            this.AddScheduleButton.TabIndex = 1;
            this.AddScheduleButton.Text = "Добавить";
            this.AddScheduleButton.UseVisualStyleBackColor = true;
            this.AddScheduleButton.Click += new System.EventHandler(this.AddScheduleButton_Click);
            // 
            // AddScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(273, 317);
            this.Controls.Add(this.AddScheduleButton);
            this.Controls.Add(this.PanelForTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScheduleWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление расписания";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddScheduleWindow_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel PanelForTime;
        private Button AddScheduleButton;
    }
}