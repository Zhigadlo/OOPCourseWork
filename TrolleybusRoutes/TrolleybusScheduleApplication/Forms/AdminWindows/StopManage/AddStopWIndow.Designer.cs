namespace TrolleybusScheduleApplication.Forms.AdminWindows.StopManage
{
    partial class AddStopWindow
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
            this.TextBoxError = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.EmptyTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxError
            // 
            this.TextBoxError.AutoSize = true;
            this.TextBoxError.ForeColor = System.Drawing.Color.Red;
            this.TextBoxError.Location = new System.Drawing.Point(134, 104);
            this.TextBoxError.Name = "TextBoxError";
            this.TextBoxError.Size = new System.Drawing.Size(186, 20);
            this.TextBoxError.TabIndex = 25;
            this.TextBoxError.Text = "Такая остановка уже есть";
            this.TextBoxError.Visible = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(78, 43);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(341, 28);
            this.Label.TabIndex = 23;
            this.Label.Text = "Введите название новой остановки\r\n";
            // 
            // TextBox
            // 
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(128, 74);
            this.TextBox.Name = "TextBox";
            this.TextBox.PlaceholderText = "Введите название";
            this.TextBox.Size = new System.Drawing.Size(195, 27);
            this.TextBox.TabIndex = 21;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(166, 127);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(114, 29);
            this.ChangeRoleButton.TabIndex = 29;
            this.ChangeRoleButton.Text = "Добавить";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // EmptyTextBox
            // 
            this.EmptyTextBox.AutoSize = true;
            this.EmptyTextBox.ForeColor = System.Drawing.Color.Red;
            this.EmptyTextBox.Location = new System.Drawing.Point(329, 77);
            this.EmptyTextBox.Name = "EmptyTextBox";
            this.EmptyTextBox.Size = new System.Drawing.Size(148, 20);
            this.EmptyTextBox.TabIndex = 31;
            this.EmptyTextBox.Text = "Вы ничего не ввели";
            this.EmptyTextBox.Visible = false;
            // 
            // AddStopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 233);
            this.Controls.Add(this.EmptyTextBox);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.TextBoxError);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStopWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление остановки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label TextBoxError;
        protected Label Label;
        protected TextBox TextBox;
        protected Button ChangeRoleButton;
        protected Label EmptyTextBox;
    }
}