using MauiProject.Models;

namespace MauiProject.Services
{
    public class DatabaseService
    {
        public async Task<List<Event>> GetEventsAsync()
        {
            await Task.Delay(100); // Simuleer vertraging
            return new List<Event>
            {
                new Event
                {
                    Title = "Nieuwjaarsreceptie",
                    Date = DateTime.Today,
                    Location = "Bedrijfshal",
                    Description = "Samenkomst met catering",
                    TodoList = new() { "Catering regelen", "Drank inkopen" },
                    Shifts = new() { "Opbouw 16u", "Afbraak 22u" }
                }
            };
        }

        public async Task AddEventAsync(Event newEvent)
        {
            await Task.Delay(100); // Simulatie
        }
    }
}