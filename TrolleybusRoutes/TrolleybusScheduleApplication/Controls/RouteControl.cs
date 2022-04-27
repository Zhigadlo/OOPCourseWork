using RouteSystem.Routes;
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
    public partial class RouteControl : UserControl
    {
        public Route Route;
        public Action OnChangeButtonClick;
        public Action OnDeleteButtonClick;
        public RouteControl(Route route)
        {
            Route = route;
            InitializeComponent();
            label1.Text = route.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OnChangeButtonClick?.Invoke();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick?.Invoke();
        }
    }
}
