namespace TrolleybusScheduleApplication
{
    partial class UserWindow
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.RouteBox = new System.Windows.Forms.ListBox();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxForNumbers = new System.Windows.Forms.ComboBox();
            this.StopComboBox1 = new System.Windows.Forms.ComboBox();
            this.FindButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopComboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(18, 405);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(700, 21);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 10;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RouteBox
            // 
            this.RouteBox.FormattingEnabled = true;
            this.RouteBox.ItemHeight = 20;
            this.RouteBox.Location = new System.Drawing.Point(50, 55);
            this.RouteBox.Name = "RouteBox";
            this.RouteBox.Size = new System.Drawing.Size(292, 344);
            this.RouteBox.TabIndex = 9;
            this.RouteBox.Click += new System.EventHandler(this.RouteBox_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 20;
            this.ResultBox.Location = new System.Drawing.Point(452, 55);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(292, 344);
            this.ResultBox.TabIndex = 8;
            this.ResultBox.Visible = false;
            this.ResultBox.Click += new System.EventHandler(this.ResultBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбор маршрута";
            // 
            // BoxForNumbers
            // 
            this.BoxForNumbers.FormattingEnabled = true;
            this.BoxForNumbers.Location = new System.Drawing.Point(631, 21);
            this.BoxForNumbers.Name = "BoxForNumbers";
            this.BoxForNumbers.Size = new System.Drawing.Size(54, 28);
            this.BoxForNumbers.TabIndex = 6;
            // 
            // StopComboBox1
            // 
            this.StopComboBox1.FormattingEnabled = true;
            this.StopComboBox1.Location = new System.Drawing.Point(33, 20);
            this.StopComboBox1.Name = "StopComboBox1";
            this.StopComboBox1.Size = new System.Drawing.Size(151, 28);
            this.StopComboBox1.TabIndex = 12;
            // 
            // FindButton2
            // 
            this.FindButton2.Location = new System.Drawing.Point(367, 20);
            this.FindButton2.Name = "FindButton2";
            this.FindButton2.Size = new System.Drawing.Size(94, 29);
            this.FindButton2.TabIndex = 14;
            this.FindButton2.Text = "Найти";
            this.FindButton2.UseVisualStyleBackColor = true;
            this.FindButton2.Click += new System.EventHandler(this.FindButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "до";
            // 
            // StopComboBox2
            // 
            this.StopComboBox2.FormattingEnabled = true;
            this.StopComboBox2.Location = new System.Drawing.Point(210, 21);
            this.StopComboBox2.Name = "StopComboBox2";
            this.StopComboBox2.Size = new System.Drawing.Size(151, 28);
            this.StopComboBox2.TabIndex = 17;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopComboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindButton2);
            this.Controls.Add(this.StopComboBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.RouteBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxForNumbers);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button QuitButton;
        private Button FindButton;
        private ListBox RouteBox;
        private ListBox ResultBox;
        private Label label1;
        private ComboBox BoxForNumbers;
        private ComboBox StopComboBox1;
        private Button FindButton2;
        private Label label2;
        private Label label3;
        private ComboBox StopComboBox2;
    }
}