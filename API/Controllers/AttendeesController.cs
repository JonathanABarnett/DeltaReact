using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Attendees;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AttendeesController : BaseApiController
    {

        // /activities
        [HttpGet]
        public async Task<ActionResult<List<Attendee>>> GetAttendees()
        {
            return await Mediator.Send(new List.Query());
        }

        // /activities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Attendee>> GetAttendee(Guid id)
        {
            return Ok();
        }
    }
}