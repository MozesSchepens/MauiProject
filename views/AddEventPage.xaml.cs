using Microsoft.Maui.Controls;
using MauiProject.Models;
using MauiProject.Services;
using System.Collections.ObjectModel;

namespace MauiProject.Views
{
    public partial class AddEventPage : ContentPage
    {
        private readonly DatabaseService _databaseService;
        private readonly ObservableCollection<Event> _events;

        // Default constructor (nodig voor de XAML-compiler)
        public AddEventPage()
        {
            InitializeComponent();
        }

        // Constructor met parameters
        public AddEventPage(DatabaseService databaseService, ObservableCollection<Event> events)
        {
            InitializeComponent();
            _databaseService = databaseService;
            _events = events;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var newEvent = new Event
            {
                Title = NameEntry.Text,
                Date = DatePicker.Date,
                Location = LocationEntry.Text,
                Description = DescriptionEditor.Text
            };

            await _databaseService.AddEventAsync(newEvent);
            _events.Add(newEvent);
            await Navigation.PopAsync();
        }
    }
}
