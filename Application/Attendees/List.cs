using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Attendees
{
    public class List
    {
        public class Query : IRequest<List<Attendee>> { }

        public class Handler : IRequestHandler<Query, List<Attendee>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Attendee>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Attendees.ToListAsync();
            }
        }
    }
}