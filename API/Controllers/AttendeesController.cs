using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class AttendeesController : BaseApiController
    {
        private readonly DataContext _context;
        public AttendeesController(DataContext context)
        {
            _context = context;
        }

        // /activities
        [HttpGet]
        public async Task<ActionResult<List<Attendee>>> GetAttendees()
        {
            return await _context.Attendees.ToListAsync();
        }

        // /activities/{id}
        [HttpGet("{id}")] 
        public async Task<ActionResult<Attendee>> GetAttendee(Guid id) {
            return await _context.Attendees.FindAsync(id);
        }
    }
}