using System;

namespace BoxStars.Shared.ViewModels
{
    public class PersonViewModel
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
