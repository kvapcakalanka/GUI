using System.Windows;
using System.Windows.Controls;

namespace TravelPlannerDesktop
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void GetStarted_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void FeatureButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature is not available yet. Stay tuned for updates!");
        }
    }
}
