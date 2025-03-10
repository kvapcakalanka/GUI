using System.Windows;
using System.Windows.Controls;

namespace TravelPlannerDesktop
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "User" && password == "1234") 
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.SetLoggedIn(true);

                NavigationService.Navigate(new HomePage());
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
