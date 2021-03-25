using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Attendees
{
    public class Details
    {
        public class Query : IRequest<Attendee>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Attendee>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Attendee> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Attendees.FindAsync(request.Id);
            }
        }
    }
}