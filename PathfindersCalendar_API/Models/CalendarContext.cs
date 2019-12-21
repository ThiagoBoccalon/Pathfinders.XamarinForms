using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfindersCalendar_API.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions<CalendarContext> options) 
            : base(options)
        {
        }

        public DbSet<CalendarItems> CalendarItems { get; set; }
    }
}
