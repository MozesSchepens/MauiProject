using MauiProject.Models;
using MauiProject.Services;
using System.Collections.ObjectModel;

namespace MauiProject.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly DatabaseService _databaseService;
        public ObservableCollection<Event> Events { get; set; }

        public MainPage()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            Events = new ObservableCollection<Event>();
            BindingContext = this;

            if (UserService.CurrentUserRole == UserRole.User)
                AddButton.IsVisible = false;

            LoadEvents();
        }

        private async void LoadEvents()
        {
            Events.Clear();
            var events = await _databaseService.GetEventsAsync();
            foreach (var ev in events)
                Events.Add(ev);
        }

        private async void OnAddEventClicked(object sender, EventArgs e)
        {
            // Simulatie van toevoegen
            var newEvent = new Event
            {
                Title = "Nieuw Event",
                Date = DateTime.Now.AddDays(1),
                Location = "Locatie X",
                Description = "Beschrijving",
                TodoList = new() { "Voorbereiden" },
                Shifts = new() { "Shift 1" }
            };
            await _databaseService.AddEventAsync(newEvent);
            Events.Add(newEvent);
        }
    }
}