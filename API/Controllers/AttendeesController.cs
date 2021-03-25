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
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttendee(Attendee attendee)
        {
            return Ok(await Mediator.Send(new Create.Command { Attendee = attendee }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditAttendee(Guid id, Attendee attendee)
        {
            attendee.Id = id;

            return Ok(await Mediator.Send(new Edit.Command { Attendee = attendee }));
        }
    }
}