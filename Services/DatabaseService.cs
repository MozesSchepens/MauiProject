using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using MauiProject.Models;
using System.IO;

namespace MauiProject.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Mauievent.db");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Event>().Wait();
        }

        public Task<List<Event>> GetEventsAsync()
        {
            return _database.Table<Event>().ToListAsync();
        }

        public Task<int> SaveEventAsync(Event ev)
        {
            return _database.InsertAsync(ev);
        }
    }
}
