using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Attendees.Any()) return;

            var attendees = new List<Attendee>
            {
                new Attendee
                {
                    DateStartedAttending = DateTime.Now.AddMonths(-2),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@gmail.com",
                    IsMember = false,
                    Street = "123 Main St",
                    City = "Springfield",
                    StateAbbreviation = "IL",
                    ZipCode = 62704,
                    Notes = "Has been coming with grandma"
                },
                new Attendee
                {
                    DateStartedAttending = DateTime.Now.AddYears(-1),
                    FirstName = "Joe",
                    LastName = "Schmoe",
                    Email = "joe@gmail.com",
                    IsMember = true,
                    Street = "456 Main St",
                    City = "Springfield",
                    StateAbbreviation = "IL",
                    ZipCode = 62704,

                },
                new Attendee {
                    DateStartedAttending = DateTime.Now.AddDays(-15),
                    FirstName = "Jill",
                    LastName = "Pill",
                    Email = "jill@gmail.com",
                    IsMember = false,
                    Street = "789 Main St",
                    City = "Springfield",
                    StateAbbreviation = "IL",
                    ZipCode = 62705,
                    Notes = "Just moved to town"
                },
                new Attendee {
                    DateStartedAttending = DateTime.Now.AddYears(-5).AddMonths(-3),
                    FirstName = "Chuck",
                    LastName = "Duck",
                    Email = "chuck@gmail.com",
                    IsMember = true,
                    Street = "123 Not Main St",
                    City = "Springfield",
                    StateAbbreviation = "IL",
                    ZipCode = 62703,
                    Notes = "Is currently being treated for chicken pox"
                }

            };
            await context.Attendees.AddRangeAsync(attendees);
            await context.SaveChangesAsync();
        }
    }
}