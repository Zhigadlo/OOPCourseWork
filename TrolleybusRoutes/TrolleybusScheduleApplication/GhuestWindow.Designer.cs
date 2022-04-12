namespace TrolleybusScheduleApplication
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
            this.StopBox = new System.Windows.Forms.ListBox();
            this.RouteBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxForNumbers
            // 
            this.BoxForNumbers.FormattingEnabled = true;
            this.BoxForNumbers.Location = new System.Drawing.Point(184, 25);
            this.BoxForNumbers.Name = "BoxForNumbers";
            this.BoxForNumbers.Size = new System.Drawing.Size(54, 28);
            this.BoxForNumbers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор маршрута";
            // 
            // StopBox
            // 
            this.StopBox.FormattingEnabled = true;
            this.StopBox.ItemHeight = 20;
            this.StopBox.Location = new System.Drawing.Point(457, 59);
            this.StopBox.Name = "StopBox";
            this.StopBox.Size = new System.Drawing.Size(292, 344);
            this.StopBox.TabIndex = 2;
            this.StopBox.Visible = false;
            this.StopBox.Click += new System.EventHandler(this.StopBox_Click);
            // 
            // RouteBox
            // 
            this.RouteBox.FormattingEnabled = true;
            this.RouteBox.ItemHeight = 20;
            this.RouteBox.Location = new System.Drawing.Point(55, 59);
            this.RouteBox.Name = "RouteBox";
            this.RouteBox.Size = new System.Drawing.Size(292, 344);
            this.RouteBox.TabIndex = 3;
            this.RouteBox.Click += new System.EventHandler(this.RouteBox_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(253, 25);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(23, 409);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // GhuestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.RouteBox);
            this.Controls.Add(this.StopBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxForNumbers);
            this.Name = "GhuestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание троллейбусов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ComboBox BoxForNumbers;
        protected Label label1;
        protected ListBox StopBox;
        protected ListBox RouteBox;
        protected Button FindButton;
        protected Button QuitButton;
    }
}