namespace TrolleybusScheduleApplication.Controls
{
    partial class AddStopControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StopComboBox = new System.Windows.Forms.ComboBox();
            this.AddScheduleButton = new System.Windows.Forms.Button();
            this.DeleteControlButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StopComboBox
            // 
            this.StopComboBox.FormattingEnabled = true;
            this.StopComboBox.Location = new System.Drawing.Point(72, 20);
            this.StopComboBox.Name = "StopComboBox";
            this.StopComboBox.Size = new System.Drawing.Size(151, 28);
            this.StopComboBox.TabIndex = 1;
            this.StopComboBox.TextChanged += new System.EventHandler(this.StopComboBox_TextChanged);
            // 
            // AddScheduleButton
            // 
            this.AddScheduleButton.Location = new System.Drawing.Point(240, 19);
            this.AddScheduleButton.Name = "AddScheduleButton";
            this.AddScheduleButton.Size = new System.Drawing.Size(184, 29);
            this.AddScheduleButton.TabIndex = 2;
            this.AddScheduleButton.Text = "Заполнить расписание";
            this.AddScheduleButton.UseVisualStyleBackColor = true;
            this.AddScheduleButton.Click += new System.EventHandler(this.AddScheduleButton_Click);
            // 
            // DeleteControlButton
            // 
            this.DeleteControlButton.Location = new System.Drawing.Point(15, 19);
            this.DeleteControlButton.Name = "DeleteControlButton";
            this.DeleteControlButton.Size = new System.Drawing.Size(38, 30);
            this.DeleteControlButton.TabIndex = 3;
            this.DeleteControlButton.Text = "-";
            this.DeleteControlButton.UseVisualStyleBackColor = true;
            this.DeleteControlButton.Click += new System.EventHandler(this.DeleteControlButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(455, 23);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "label1";
            this.ErrorLabel.Visible = false;
            // 
            // AddStopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DeleteControlButton);
            this.Controls.Add(this.AddScheduleButton);
            this.Controls.Add(this.StopComboBox);
            this.Name = "AddStopControl";
            this.Size = new System.Drawing.Size(689, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button DeleteControlButton;
        public ComboBox StopComboBox;
        public Button AddScheduleButton;
        public Label ErrorLabel;
    }
}
