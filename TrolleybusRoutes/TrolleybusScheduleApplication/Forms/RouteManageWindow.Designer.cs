namespace TrolleybusScheduleApplication.Forms
{
    partial class RouteManageWindow
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
            this.RoutePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.PanelOfRoutes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // RoutePanel
            // 
            this.RoutePanel.AutoScroll = true;
            this.RoutePanel.AutoSize = true;
            this.RoutePanel.Location = new System.Drawing.Point(12, 40);
            this.RoutePanel.Name = "RoutePanel";
            this.RoutePanel.Size = new System.Drawing.Size(0, 0);
            this.RoutePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Маршруты";
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Location = new System.Drawing.Point(192, 409);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(213, 29);
            this.AddRouteButton.TabIndex = 2;
            this.AddRouteButton.Text = "Добавить маршрут";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 409);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Назад";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PanelOfRoutes
            // 
            this.PanelOfRoutes.AutoScroll = true;
            this.PanelOfRoutes.Location = new System.Drawing.Point(12, 50);
            this.PanelOfRoutes.Name = "PanelOfRoutes";
            this.PanelOfRoutes.Size = new System.Drawing.Size(587, 340);
            this.PanelOfRoutes.TabIndex = 4;
            // 
            // RouteManageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.PanelOfRoutes);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AddRouteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoutePanel);
            this.Name = "RouteManageWindow";
            this.Text = "Управление маршрутами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel RoutePanel;
        private Label label1;
        private Button AddRouteButton;
        private Button QuitButton;
        public FlowLayoutPanel PanelOfRoutes;
    }
}