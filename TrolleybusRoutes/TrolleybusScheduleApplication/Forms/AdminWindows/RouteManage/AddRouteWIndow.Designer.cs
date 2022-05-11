namespace TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage
{
    partial class AddRouteWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelForControls = new System.Windows.Forms.FlowLayoutPanel();
            this.AddControlButton = new System.Windows.Forms.Button();
            this.RouteNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RouteCountBox = new System.Windows.Forms.TextBox();
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление маршрута";
            // 
            // PanelForControls
            // 
            this.PanelForControls.AutoScroll = true;
            this.PanelForControls.Location = new System.Drawing.Point(12, 79);
            this.PanelForControls.Name = "PanelForControls";
            this.PanelForControls.Size = new System.Drawing.Size(789, 331);
            this.PanelForControls.TabIndex = 1;
            // 
            // AddControlButton
            // 
            this.AddControlButton.Location = new System.Drawing.Point(20, 44);
            this.AddControlButton.Name = "AddControlButton";
            this.AddControlButton.Size = new System.Drawing.Size(177, 29);
            this.AddControlButton.TabIndex = 2;
            this.AddControlButton.Text = "Добавить остановку";
            this.AddControlButton.UseVisualStyleBackColor = true;
            this.AddControlButton.Click += new System.EventHandler(this.AddControlButton_Click);
            // 
            // RouteNumberBox
            // 
            this.RouteNumberBox.Location = new System.Drawing.Point(392, 46);
            this.RouteNumberBox.Name = "RouteNumberBox";
            this.RouteNumberBox.Size = new System.Drawing.Size(48, 27);
            this.RouteNumberBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер маршрута:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество поездок:";
            // 
            // RouteCountBox
            // 
            this.RouteCountBox.Location = new System.Drawing.Point(649, 46);
            this.RouteCountBox.Name = "RouteCountBox";
            this.RouteCountBox.Size = new System.Drawing.Size(48, 27);
            this.RouteCountBox.TabIndex = 5;
            this.RouteCountBox.TextChanged += new System.EventHandler(this.RouteCountBox_TextChanged);
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Location = new System.Drawing.Point(317, 416);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(159, 29);
            this.AddRouteButton.TabIndex = 7;
            this.AddRouteButton.Text = "Добавить маршрут";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 416);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "Назад";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AddRouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AddRouteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RouteCountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RouteNumberBox);
            this.Controls.Add(this.AddControlButton);
            this.Controls.Add(this.PanelForControls);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRouteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление маршрута";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button QuitButton;
        protected Button AddRouteButton;
        protected FlowLayoutPanel PanelForControls;
        protected TextBox RouteNumberBox;
        protected TextBox RouteCountBox;
        protected Button AddControlButton;
    }
}