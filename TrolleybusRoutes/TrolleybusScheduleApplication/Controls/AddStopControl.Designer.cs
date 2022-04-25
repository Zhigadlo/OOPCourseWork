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
            this.AddControlButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteControlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddControlButton
            // 
            this.AddControlButton.Location = new System.Drawing.Point(22, 18);
            this.AddControlButton.Name = "AddControlButton";
            this.AddControlButton.Size = new System.Drawing.Size(34, 29);
            this.AddControlButton.TabIndex = 0;
            this.AddControlButton.Text = "+";
            this.AddControlButton.UseVisualStyleBackColor = true;
            this.AddControlButton.Click += new System.EventHandler(this.AddControlButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнить расписание";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteControlButton
            // 
            this.DeleteControlButton.Location = new System.Drawing.Point(62, 17);
            this.DeleteControlButton.Name = "DeleteControlButton";
            this.DeleteControlButton.Size = new System.Drawing.Size(38, 30);
            this.DeleteControlButton.TabIndex = 3;
            this.DeleteControlButton.Text = "-";
            this.DeleteControlButton.UseVisualStyleBackColor = true;
            this.DeleteControlButton.Click += new System.EventHandler(this.DeleteControlButton_Click);
            // 
            // AddStopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteControlButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddControlButton);
            this.Name = "AddStopControl";
            this.Size = new System.Drawing.Size(501, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddControlButton;
        private ComboBox comboBox1;
        private Button button1;
        private Button DeleteControlButton;
    }
}
