﻿using RouteSystem.Users;
using RouteSystem.Reports;
using RouteSystem.Routes;
using ORMLibrary;
using TrolleybusScheduleApplication.Forms.AdminWindows.RouteManage;
using TrolleybusScheduleApplication.Forms.AdminWindows.Schedule;
using TrolleybusScheduleApplication.Forms.AdminWindows.StopManage;
using TrolleybusScheduleApplication.Forms.AdminWindows.UserManage;
using TrolleybusScheduleApplication;

namespace TrolleybusScheduleApplication.Forms.AdminWindows
{
    public partial class AdminWindow : Form
    {
        private Form _startWindow;
        private User _admin;
        private FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();
        private MongoDBORM<Route> _routeORM = new MongoDBORM<Route>("RouteSystem", "Routes", DbConnection.Instance.GetClient());
        public AdminWindow(Form startWindow, User admin)
        {
            _startWindow = startWindow;
            _admin = admin;
            InitializeComponent();
        }

        private void CheckScheduleButton_Click(object sender, EventArgs e)
        {
            AdminScheduleForm userWindow = new AdminScheduleForm(this);
            userWindow.QuitButton.Text = "Назад";
            userWindow.ShowDialog();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startWindow.Dispose();
        }

        private void RouteManageButton_Click(object sender, EventArgs e)
        {
            RouteManageWindow routeManageWindow = new RouteManageWindow();
            routeManageWindow.ShowDialog();
        }

        private void StopManageButton_Click(object sender, EventArgs e)
        {
            StopsManageWindow stopsManageWindow = new StopsManageWindow();
            stopsManageWindow.ShowDialog();
        }

        private void UserManagrButton_Click(object sender, EventArgs e)
        {
            UsersManageWindow usersManageWindow = new UsersManageWindow(_admin);
            usersManageWindow.ShowDialog();
        }

        private void XmlReportButton_Click(object sender, EventArgs e)
        {
            if(_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                RouteReport.CreateRoutesReport(_routeORM.ReadAll(), _folderBrowserDialog.SelectedPath);
                MessageBox.Show("Отчет сохранен", "Успех");
            }
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        
    }
}
