namespace TrolleybusScheduleApplication
{
    partial class RegistrationWindow
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondPasswordBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(328, 261);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(132, 29);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Далее";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(223, 168);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(233, 124);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(52, 20);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordBox
            // 
            this.PasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordBox.Location = new System.Drawing.Point(301, 165);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(195, 27);
            this.PasswordBox.TabIndex = 8;
            this.PasswordBox.Text = "Введите пароль";
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // LoginBox
            // 
            this.LoginBox.ForeColor = System.Drawing.Color.LightGray;
            this.LoginBox.Location = new System.Drawing.Point(301, 121);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(195, 27);
            this.LoginBox.TabIndex = 7;
            this.LoginBox.Text = "Введите логин";
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_Click);
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Повторите пароль";
            // 
            // SecondPasswordBox
            // 
            this.SecondPasswordBox.ForeColor = System.Drawing.Color.LightGray;
            this.SecondPasswordBox.Location = new System.Drawing.Point(301, 210);
            this.SecondPasswordBox.Name = "SecondPasswordBox";
            this.SecondPasswordBox.Size = new System.Drawing.Size(195, 27);
            this.SecondPasswordBox.TabIndex = 12;
            this.SecondPasswordBox.Text = "Введите пароль еще раз";
            this.SecondPasswordBox.Click += new System.EventHandler(this.SecondPasswordBox_Click);
            this.SecondPasswordBox.TextChanged += new System.EventHandler(this.SecondPasswordBox_TextChanged);
            this.SecondPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondPasswordBox_KeyDown);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(41, 399);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPasswordBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegistrationButton;
        private Label PasswordLabel;
        private Label LoginLabel;
        private TextBox PasswordBox;
        private TextBox LoginBox;
        private Label label1;
        private TextBox SecondPasswordBox;
        private Button BackButton;
    }
}