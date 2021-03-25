using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
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
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var attendee = await _context.Attendees.FindAsync(request.Attendee.Id);

                // (Map From, Map To)
                _mapper.Map(request.Attendee, attendee);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}