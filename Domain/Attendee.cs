using System;

namespace Domain
{
    public class Attendee
    {
        public Guid Id { get; set; }
        public DateTime DateStartedAttending { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateAbbreviation { get; set; }
        public int ZipCode { get; set; }
        public string Notes { get; set; }



    }
}