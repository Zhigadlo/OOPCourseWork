using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrolleybusScheduleApplication.Controls;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class AddRouteWindow : Form
    {
        public AddRouteWindow()
        {
            InitializeComponent();
            AddStopControl();

           
        }


        private void AddStopControl()
        {
            AddStopControl stopControl = new AddStopControl();
            PanelForControls.Controls.Add(stopControl);
            stopControl.OnAddButtonClick += () =>
            {
                AddStopControl();
            };
            stopControl.OnRemoveButtonClick += () =>
            {
                PanelForControls.Controls.Remove(stopControl);
            };
        }
    }
}
