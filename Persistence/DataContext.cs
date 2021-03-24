using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // Use the plural name of the domain class
        public DbSet<Attendee> Attendees { get; set; }
    }
}