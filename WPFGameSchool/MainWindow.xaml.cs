using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFGameSchool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (pass.Password != "" && user.Text != "")
            {
                List<UserDataManager> allUsers = UserDataManager.LoadAllUserData();
                string enteredUsername = user.Text;
                string enteredPassword = pass.Password;

                if (allUsers.Any(u => u.Username == enteredUsername && u.Password == enteredPassword))
                {
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            {
                RegisterWindow registerWindow = new RegisterWindow();
                registerWindow.Show();
                this.Hide();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string username = user.Text;
            string password = pass.Password;
            UserDataManager userData = new UserDataManager(username, password);
            UserDataManager.SaveUserData(userData);
            RefreshUserListBox();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            List<UserDataManager> allUsers = UserDataManager.LoadAllUserData();
            userListBox.Items.Clear();
            foreach (UserDataManager user in allUsers)
            {
                userListBox.Items.Add(user);
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(UserDataManager.CsvFileName, "");
            userListBox.Items.Clear();
        }
        private void RefreshUserListBox()
        {
            List<UserDataManager> allUsers = UserDataManager.LoadAllUserData();
            userListBox.Items.Clear();
            foreach (UserDataManager user in allUsers)
            {
                userListBox.Items.Add(user);
            }
        }
        private void userListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (userListBox.SelectedItem != null)
            {
                UserDataManager selectedUser = (UserDataManager)userListBox.SelectedItem;
                user.Text = selectedUser.Username;
                pass.Password = selectedUser.Password;
            }
        }
    }
}
