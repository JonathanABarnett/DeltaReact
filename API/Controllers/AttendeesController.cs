using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Attendees;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class AttendeesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public AttendeesController(IMediator mediator)
        {
            _mediator = mediator;

        }

        // /activities
        [HttpGet]
        public async Task<ActionResult<List<Attendee>>> GetAttendees()
        {
            return await _mediator.Send(new List.Query());
        }

        // /activities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Attendee>> GetAttendee(Guid id)
        {
            return Ok();
        }
    }
}