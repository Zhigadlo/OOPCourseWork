﻿namespace TrolleybusScheduleApplication.Forms
{
    public partial class AdminScheduleForm : UserWindow
    {
        public AdminScheduleForm(Form startWindow) : base(startWindow)
        {

        }
        protected override void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void UserWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
