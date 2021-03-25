using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Attendees
{
    public class Create
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
                _context.Attendees.Add(request.Attendee);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}