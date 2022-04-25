using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrolleybusScheduleApplication.Controls
{
    public partial class AddStopControl : UserControl
    {
        public Action OnAddButtonClick;
        public Action OnRemoveButtonClick;
        public AddStopControl()
        {
            InitializeComponent();
        }

        private void AddControlButton_Click(object sender, EventArgs e)
        {
            OnAddButtonClick?.Invoke();
        }

        private void DeleteControlButton_Click(object sender, EventArgs e)
        {
            OnRemoveButtonClick?.Invoke();
        }
    }
}
