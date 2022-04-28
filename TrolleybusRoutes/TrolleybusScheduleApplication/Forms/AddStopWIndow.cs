using ORMLibrary;
using RouteSystem.Routes;

namespace TrolleybusScheduleApplication.Forms
{
    public partial class AddStopWindow : Form
    {
        protected MongoDBORM<Stop> _stopORM = new MongoDBORM<Stop>("RouteSystem", "Stops");
        protected StopsManageWindow _startWindow;
        public AddStopWindow(StopsManageWindow window)
        {
            InitializeComponent();
            _startWindow = window;
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                EmptyTextBox.Visible = true;
            }
            else
            {
                if (_stopORM.Contains("Name", TextBox.Text))
                {
                    TextBoxError.Visible = true;
                }
                else
                {
                    Stop newStop = new Stop(TextBox.Text);
                    _stopORM.Write(newStop);
                    _startWindow.AddNewControl(newStop);
                    MessageBox.Show("Вы добавили остановку " + newStop.Name);
                    Close();
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            EmptyTextBox.Visible = false;
            TextBoxError.Visible = false;
        }
    }
}
