using TrolleybusScheduleApplication.Forms.UserWindows;

namespace TrolleybusScheduleApplication.Forms.AdminWindows.Schedule
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

        protected override void GuestWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        protected override void GuestWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
