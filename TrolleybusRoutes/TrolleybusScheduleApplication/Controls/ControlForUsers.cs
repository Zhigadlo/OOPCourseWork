using RouteSystem.Users;

namespace TrolleybusScheduleApplication.Controls
{
    public partial class ControlForUsers : UserControl
    {
        public User User;
        public Action OnPasswordDropClick;
        public Action OnChangeRoleClick;
        public Action OnDeleteButtonClick;
        public ControlForUsers(User user)
        {
            User = user;
            InitializeComponent();
            LoginLabel.Text = user.Login;
            UserRole.Text = user.Role.ToString();
        }

        private void PasswordDropButton_Click(object sender, EventArgs e)
        {
            OnPasswordDropClick?.Invoke();
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            OnChangeRoleClick?.Invoke();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClick?.Invoke();
        }

        private void ControlForUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
