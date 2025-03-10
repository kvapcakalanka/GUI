using System;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace TravelPlannerDesktop
{
    public partial class TripPlannerPage : Page
    {
        private string connectionString = "Data Source=Data\\data1.db;Version=3;";


        public TripPlannerPage()
        {
            InitializeComponent();
            LoadTrips(); 
        }

        // CREATE: Add a new trip
        private void AddTrip_Click(object sender, RoutedEventArgs e)
        {
            string destination = DestinationTextBox.Text;
            DateTime? startDate = StartDatePicker.SelectedDate;
            DateTime? endDate = EndDatePicker.SelectedDate;

            if (string.IsNullOrWhiteSpace(destination) || startDate == null || endDate == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Trips (Destination, StartDate, EndDate) VALUES (@Destination, @StartDate, @EndDate)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Destination", destination);
                command.Parameters.AddWithValue("@StartDate", startDate.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@EndDate", endDate.Value.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();

                MessageBox.Show("Trip added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            LoadTrips(); // Refresh trip list
            ClearFields();
        }

        // READ: Load and display trips
        private void LoadTrips()
        {
            TripsListBox.Items.Clear(); // Clear the list

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Trips";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string trip = $"ID: {reader["TripID"]}, Destination: {reader["Destination"]}, " +
                                  $"Start: {reader["StartDate"]}, End: {reader["EndDate"]}";
                    TripsListBox.Items.Add(trip);
                }
            }
        }

        // UPDATE: Update a selected trip
        private void UpdateTrip_Click(object sender, RoutedEventArgs e)
        {
            if (TripsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a trip to update.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string selectedTrip = TripsListBox.SelectedItem.ToString();
            int tripID = int.Parse(selectedTrip.Split(':')[1].Split(',')[0].Trim()); 
            string destination = DestinationTextBox.Text;
            DateTime? startDate = StartDatePicker.SelectedDate;
            DateTime? endDate = EndDatePicker.SelectedDate;

            if (string.IsNullOrWhiteSpace(destination) || startDate == null || endDate == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Trips SET Destination = @Destination, StartDate = @StartDate, EndDate = @EndDate WHERE TripID = @TripID";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Destination", destination);
                command.Parameters.AddWithValue("@StartDate", startDate.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@EndDate", endDate.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@TripID", tripID);
                command.ExecuteNonQuery();

                MessageBox.Show("Trip updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            LoadTrips(); // Refresh trip list
            ClearFields();
        }

        // DELETE: Remove a selected trip
        private void DeleteTrip_Click(object sender, RoutedEventArgs e)
        {
            if (TripsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a trip to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string selectedTrip = TripsListBox.SelectedItem.ToString();
            int tripID = int.Parse(selectedTrip.Split(':')[1].Split(',')[0].Trim());

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Trips WHERE TripID = @TripID";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@TripID", tripID);
                command.ExecuteNonQuery();

                MessageBox.Show("Trip deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            LoadTrips(); // Refresh trip list
            ClearFields();
        }

        private void ClearFields()
        {
            DestinationTextBox.Clear();
            StartDatePicker.SelectedDate = null;
            EndDatePicker.SelectedDate = null;
        }
    }
}
