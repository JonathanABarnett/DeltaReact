using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Attendees
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Attendee Attendee { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var attendee = await _context.Attendees.FindAsync(request.Attendee.Id);

                attendee.City = request.Attendee.City ?? attendee.City;

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}