﻿namespace TrolleybusScheduleApplication.Controls
{
    partial class StopControl
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StopName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(386, 15);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(35, 35);
            this.ChangeButton.TabIndex = 3;
            this.ChangeButton.Text = "✎";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(427, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(35, 35);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "╳";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // StopName
            // 
            this.StopName.AutoSize = true;
            this.StopName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopName.Location = new System.Drawing.Point(20, 15);
            this.StopName.Name = "StopName";
            this.StopName.Size = new System.Drawing.Size(65, 28);
            this.StopName.TabIndex = 4;
            this.StopName.Text = "label1";
            // 
            // StopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.StopName);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "StopControl";
            this.Size = new System.Drawing.Size(476, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChangeButton;
        private Button DeleteButton;
        private Label StopName;
    }
}
