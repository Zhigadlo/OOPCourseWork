namespace TrolleybusScheduleApplication.Forms
{
    partial class DeleteStopWindow
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
            this.StopsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StopsComboBox
            // 
            this.StopsComboBox.FormattingEnabled = true;
            this.StopsComboBox.Location = new System.Drawing.Point(155, 94);
            this.StopsComboBox.Name = "StopsComboBox";
            this.StopsComboBox.Size = new System.Drawing.Size(151, 28);
            this.StopsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите остановку";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(182, 148);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(155, 125);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(152, 20);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "Выберите остановку";
            this.ErrorLabel.Visible = false;
            // 
            // DeleteStopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 254);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopsComboBox);
            this.Name = "DeleteStopWindow";
            this.Text = "Удаление остановки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox StopsComboBox;
        private Label label1;
        private Button DeleteButton;
        private Label ErrorLabel;
    }
}