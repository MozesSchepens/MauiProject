using System;

namespace MauiProject.Models
{
    public class Event
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public List<string> TodoList { get; set; } = new();
        public List<string> Shifts { get; set; } = new();
    }
}