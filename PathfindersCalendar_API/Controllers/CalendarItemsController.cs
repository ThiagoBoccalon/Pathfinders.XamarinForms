using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PathfindersCalendar_API.Models;

namespace PathfindersCalendar_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarItemsController : ControllerBase
    {
        private readonly CalendarContext _context;

        public CalendarItemsController(CalendarContext context)
        {
            _context = context;
        }

        // GET: api/CalendarItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarItems>>> GetCalendarItems()
        {
            return await _context.CalendarItems.ToListAsync();
        }

        // GET: api/CalendarItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarItems>> GetCalendarItem(long id)
        {
            var calendarItem = await _context.CalendarItems.FindAsync(id);

            if (calendarItem == null)
            {
                return NotFound();
            }

            return calendarItem;
        }

        // PUT: api/CalendarItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarItem(long id, CalendarItems calendarItem)
        {
            if (id != calendarItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(calendarItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CalendarItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CalendarItems>> PostCalendarItem(CalendarItems calendarItem)
        {
            _context.CalendarItems.Add(calendarItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCalendarItem", new { id = calendarItem.Id }, calendarItem);
            return CreatedAtAction(nameof(GetCalendarItem), new { id = calendarItem.Id }, calendarItem);
        }

        // DELETE: api/CalendarItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalendarItems>> DeleteCalendarItem(long id)
        {
            var calendarItem = await _context.CalendarItems.FindAsync(id);
            if (calendarItem == null)
            {
                return NotFound();
            }

            _context.CalendarItems.Remove(calendarItem);
            await _context.SaveChangesAsync();

            return calendarItem;
        }

        private bool CalendarItemExists(long id)
        {
            return _context.CalendarItems.Any(e => e.Id == id);
        }
    }
}
