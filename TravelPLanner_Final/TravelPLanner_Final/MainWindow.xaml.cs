using System.Windows;

namespace TravelPlannerDesktop
{
    public partial class MainWindow : Window
    {
        private bool isUserLoggedIn = false; 

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage()); // Load the Home Page initially
        }

       
        public void SetLoggedIn(bool isLoggedIn)
        {
            isUserLoggedIn = isLoggedIn;

            if (isLoggedIn)
            {
                MessageBox.Show("Welcome! You are now logged in.");
            }
            else
            {
                MessageBox.Show("You have been logged out.");
                MainFrame.Navigate(new LoginPage()); // Redirect to login page on logout
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void TripPlanner_Click(object sender, RoutedEventArgs e)
        {
            if (!isUserLoggedIn)
            {
                MessageBox.Show("Please log in to access the Trip Planner.");
                return;
            }
            MainFrame.Navigate(new TripPlannerPage());
        }

        private void Bookings_Click(object sender, RoutedEventArgs e)
        {
            if (!isUserLoggedIn)
            {
                MessageBox.Show("Please log in to access Bookings.");
                return;
            }
            MainFrame.Navigate(new BookingsPage());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            SetLoggedIn(false);
        }
    }
}
