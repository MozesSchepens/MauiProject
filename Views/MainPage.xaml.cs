using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using MauiProject.Models;
using MauiProject.Services;
using System.Threading.Tasks;

namespace MauiProject
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
            LoadEvents();
        }

        private async void LoadEvents()
        {
            var events = await _databaseService.GetEventsAsync();
            foreach (var ev in events)
            {
                Events.Add(ev);
            }
        }

        private async void OnAddEventClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEventPage(_databaseService, Events));
        }
    }
}