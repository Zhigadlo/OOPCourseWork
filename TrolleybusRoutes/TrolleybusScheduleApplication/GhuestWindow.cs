using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteSystem;
using ORMLibrary;

namespace TrolleybusScheduleApplication
{
    public partial class GhuestWindow : Form
    {
        private StartWindow _startWindow;
        public GhuestWindow(StartWindow startWindow)
        {
            _startWindow = startWindow;
            InitializeComponent();
        }


    }
}
