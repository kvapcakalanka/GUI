using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TravelPlannerDesktop
{
    public partial class BookingsPage : Page
    {
        private ObservableCollection<Booking> Bookings;

        public BookingsPage()
        {
            InitializeComponent();
            Bookings = new ObservableCollection<Booking>();
            BookingDataGrid.ItemsSource = Bookings;
        }

        // Add a new booking to the collection
        private void AddBooking_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DestinationTextBox.Text) ||
                !StartDatePicker.SelectedDate.HasValue ||
                !EndDatePicker.SelectedDate.HasValue ||
                string.IsNullOrWhiteSpace(GuestsTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Add booking details to the ObservableCollection
            Bookings.Add(new Booking
            {
                Destination = DestinationTextBox.Text,
                StartDate = StartDatePicker.SelectedDate.Value.ToString("d"),
                EndDate = EndDatePicker.SelectedDate.Value.ToString("d"),
                Guests = GuestsTextBox.Text
            });

            // Clear the form inputs after successful addition
            ClearForm();
        }

        // Update an existing booking
        private void UpdateBooking_Click(object sender, RoutedEventArgs e)
        {
            if (BookingDataGrid.SelectedItem is Booking selectedBooking)
            {
                selectedBooking.Destination = DestinationTextBox.Text;
                selectedBooking.StartDate = StartDatePicker.SelectedDate?.ToString("d") ?? selectedBooking.StartDate;
                selectedBooking.EndDate = EndDatePicker.SelectedDate?.ToString("d") ?? selectedBooking.EndDate;
                selectedBooking.Guests = GuestsTextBox.Text;

                BookingDataGrid.Items.Refresh();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a booking to update.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Delete a booking from the collection
        private void DeleteBooking_Click(object sender, RoutedEventArgs e)
        {
            if (BookingDataGrid.SelectedItem is Booking selectedBooking)
            {
                Bookings.Remove(selectedBooking);
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearForm()
        {
            DestinationTextBox.Clear();
            StartDatePicker.SelectedDate = null;
            EndDatePicker.SelectedDate = null;
            GuestsTextBox.Clear();
        }
    }

    public class Booking
    {
        public string Destination { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Guests { get; set; }
    }
}
