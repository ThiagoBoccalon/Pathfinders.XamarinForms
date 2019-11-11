using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PathfindersClubApp.Models;
using SQLite;

namespace PathfindersClubApp.Data
{    
    public class CalenderDataBase
    {
        readonly SQLiteAsyncConnection _database;

        public CalenderDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Calendar>().Wait();
        }

        public Task<List<Calendar>> GetCalendarAsync()
        {
            return _database.Table<Calendar>().ToListAsync();
        }

        public Task<Calendar> GetCalendarAsync(int id)
        {
            return _database.Table<Calendar>()
                .Where(item => item.ID == id)
                .FirstOrDefaultAsync();
        }
    }
}
