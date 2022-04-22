using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrolleybusScheduleApplication
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
