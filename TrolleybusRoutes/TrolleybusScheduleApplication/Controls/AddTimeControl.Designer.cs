namespace TrolleybusScheduleApplication.Controls
{
    partial class AddTimeControl
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
            this.HourBox = new System.Windows.Forms.TextBox();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(12, 16);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(53, 27);
            this.HourBox.TabIndex = 0;
            // 
            // MinuteBox
            // 
            this.MinuteBox.Location = new System.Drawing.Point(85, 16);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(53, 27);
            this.MinuteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // AddTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Name = "AddTimeControl";
            this.Size = new System.Drawing.Size(150, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        public TextBox HourBox;
        public TextBox MinuteBox;
    }
}
