using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PathfindersClubApp.Models
{
    public class Calendar
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }      
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
